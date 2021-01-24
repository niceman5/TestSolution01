﻿//console.log("구독자 수 관리 앱");

// 삼중 슬래시 참조, 삼중 슬래시 지시문
/// <reference path="ChangeType.ts" />
/// <reference path="HtmlResponse.ts" />
/// <reference path="SubscriberCounter.ts" />
/// <reference path="HtmlWriter.ts" />
/// <reference path="BlogCounter.ts" />
/// <reference path="YoutubeCounter.ts" />
/// <reference path="CounterType.ts" />
/// <reference path="CounterList.ts" />
/// <reference path="_Constants.ts" />
/// <reference path="_Models.ts" />

import { ChangeType } from './ChangeType';
//import { HtmlResponse } from "./HtmlResponse";
import { SubscriberCounter } from "./SubscriberCounter";
import { HtmlWriter } from "./HtmlWriter";
import { BlogCounter } from "./BlogCounter";
import { YoutubeCounter } from "./YoutubeCounter";
//import { CounterType } from "./CounterType";
import { CounterList } from "./CounterList";
//import { Constants } from "./_Constants";
//import { ICounterBase, ICounterInfo, ICounterSettings, IIncrementDecrementUpdate } from "./_Models";

//[!] 실행
class Root {
    private title: string = "Youtube";
    subscriberCounter: SubscriberCounter;
    youtubeCounter: YoutubeCounter;
    blogCounter: BlogCounter; 
    constructor(private writer: HtmlWriter) {
        this.youtubeCounter = new YoutubeCounter({
            id: 1,
            title: '유튜브 카운터',
            count: 10000
        });
        this.blogCounter = new BlogCounter({
            id: 2,
            title: '블로그 카운터',
            count: 20000,
            postCount: 5
        });
        this.subscriberCounter = this.youtubeCounter;
    }

    // fetch() 함수와 async/await를 사용하려면 lib: "ES2015", "DOM" 추가 필요
    async initializeCountsAsync() {
        const response = await fetch("/counters.json");
        const counters = await response.json();

        this.youtubeCounter = new YoutubeCounter({ ...counters.youtubeCounter });
        this.blogCounter = new BlogCounter({ ...counters.blogCounter });
        this.subscriberCounter = this.youtubeCounter;

        let html: string = "";
        const counterList = new CounterList();
        counterList.add(this.youtubeCounter);
        counterList.add(this.blogCounter);
        counterList.getAll().forEach((cl, idx) => {
            html += `${cl.id} - ${cl.title}<br />`;
        });

        this.writer.write(html); 
    }

    togglePage(page?: string) {
        switch (page) {
            case 'Youtube':
                this.subscriberCounter = this.youtubeCounter;
                break;
            case 'Blog':
                this.subscriberCounter = this.blogCounter;
                break;
        }
        this.renderCounter(this.subscriberCounter);
    }

    renderCounter(counter: SubscriberCounter) {
        // 구조 파괴(분해) 할당
        const { startYear, siteUrl } = counter.getCounterInfo();

        const html = `
<h2>${counter.title} 구독자 카운트</h2>
<span>채널 이름: </span> ${counter.title}<br /> 
<span>구독자 수: </span> ${counter.count}<hr /> 
${startYear}년: ${siteUrl}
<hr /> 
변경 값: <input type="text" id="txtAmount" value="0"> 
<button onclick="window.root.changeCounter(+1)">증가</button>
<button onclick="window.root.changeCounter(-1)">감소</button>
<button onclick="window.root.changeCounter(0)">수정</button>
`;
        this.writer.write(html); 
    }

    changeCounter(changeType: ChangeType) {
        let txtAmount: HTMLInputElement | null = document.querySelector("#txtAmount");
        let amount = 0;
        if (txtAmount !== null) {
            amount = +txtAmount.value;
        }
        let err;
        try {
            if (changeType == ChangeType.Increment) {
                this.subscriberCounter.increment(amount);
            }
            else if (changeType == ChangeType.Decrement) {
                this.subscriberCounter.decrement(amount);
            }
            else {
                this.subscriberCounter.update(amount);
            }
        } catch (e) {
            err = e; 
        }
        this.renderCounter(this.subscriberCounter);
        if (err) {
            this.writer.writeLog(err.message); 
        }
    }
}

let divHtml: HTMLDivElement | null = document.querySelector("#divHtml");
const writer: HtmlWriter = new HtmlWriter(divHtml);
const root = new Root(writer); // 자바스크립트 코드 실행
root.initializeCountsAsync(); // Web API로부터 JSON 데이터 받아 출력
(<any>window).root = root; 

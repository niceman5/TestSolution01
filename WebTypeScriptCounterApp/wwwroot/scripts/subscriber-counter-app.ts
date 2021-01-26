// console.log("구독자 수 관리 앱");

// 삼중 슬래쉬 참조, 삼중 슬래쉬 지시문
/// <reference path="ChangeType.ts">
/// <reference path="CounterType.ts">
/// <reference path="CounterList.ts">
/// <reference path="HtmlResponse.ts">
/// <reference path="SubscriberCounter.ts">
/// <reference path="HtmlWriter.ts">
/// <reference path="BlogCounter.ts">
/// <reference path="YoutubeCounter.ts">



//[!] 실행
class Root {
    private title: string = "YouTube";
    subscriberCounter: SubscriberCounter;

    constructor( private writer : HtmlWriter) {
        this.subscriberCounter = new SubscriberCounter(this.title);
        this.renderCounter();
    }

    renderCounter() {
        const html = `
<h2> ${this.title}구독자 카운트</h2>
<span>채널 이름 : </span> ${this.subscriberCounter.title} <br />
<span>구독자 수 : </span> ${this.subscriberCounter.count} <hr />
변경값 : <input type="text" id="txtAmount" value="0">
<button onclick="window.root.chageCounter(+1)" >증가</button>
<button onclick="window.root.chageCounter(-1)">감소</button>
<button onclick="window.root.chageCounter(0)">수정</button>
`
        // HtmlResponse.write(html);        정적메서드 대신 인스턴스메서드 사용하게 변경
        writer.write(html);
    } 
    
    chageCounter(changeType: ChangeType) {
        //console.log("call chageCounter");

        let txtAmount: HTMLInputElement | null = document.querySelector("#txtAmount");
        let amount = 0;

        if (txtAmount !== null) {
            amount = +txtAmount.value;      //+기호.....숫자형으로 
        }

        if (changeType === ChangeType.Increment) {
            this.subscriberCounter.increment(amount);
        }
        else if (changeType === ChangeType.Decrement) {
            this.subscriberCounter.decrement(amount);
        }
        else {
            this.subscriberCounter.update(amount);
        }
        this.renderCounter();
    }
}

// HtmlResponse.divHtml = document.querySelector("#divHtml");
let divHtml: HTMLDivElement | null = document.querySelector("#divHtml");

const writer: HtmlWriter = new HtmlWriter(divHtml); 
const root = new Root(writer);    //javascript코드 실행

(<any>window).root = root;
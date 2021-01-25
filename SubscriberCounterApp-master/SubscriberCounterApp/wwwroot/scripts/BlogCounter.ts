﻿/// <reference path="CounterType.ts" />
/// <reference path="SubscriberCounter.ts" />
/// <reference path="_Constants.ts" />
/// <reference path="_Models.ts" />
import { CounterType } from "./CounterType";
import { SubscriberCounter } from './SubscriberCounter';
import { Constants } from "./_Constants";
import { ICounterSettings, ICounterInfo, ICounterBase, IIncrementDecrementUpdate } from "./_Models";

export class BlogCounter extends SubscriberCounter {
    private _startYear: number;
    private _siteUrl: string;
    counterType: CounterType = CounterType.Blog;
    postCount?: number = 0; 
    constructor(counterSettings: ICounterSettings) {
        super(counterSettings); // 부모의 생성자에 매개 변수 전달
        this.postCount = counterSettings.postCount;
        this._startYear = Constants.Blog.START_YEAR;
        this._siteUrl = Constants.Blog.SITE_URL;
    }
    getCounterInfo(): ICounterInfo<number, string> {
        return {
            startYear: this._startYear,
            siteUrl: this._siteUrl
        };
    }
    // 다시 정의(Override)
    //increment(cnt: number) {
    //    if (this.postCount > 0) {
    //        this._count += (cnt * this.postCount); // 학습 목적상 포스트 수만큼 곱해서 증가
    //    }
    //    else {
    //        this._count += cnt;
    //    }
    //}
    increment(cnt: number) {
        if (this.postCount !== undefined && this.postCount > 0) {
            super.increment(cnt * this.postCount); // 부모 메서드로 전달
        }
        else {
            super.increment(cnt); 
        }
    }
}

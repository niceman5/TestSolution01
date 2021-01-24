﻿/// <reference path="CounterType.ts" />
/// <reference path="SubscriberCounter.ts" />
/// <reference path="_Constants.ts" />
/// <reference path="_Models.ts" />
import { CounterType } from './CounterType';
import { SubscriberCounter } from "./SubscriberCounter";
import { Constants } from "./_Constants";
import { ICounterSettings, ICounterInfo } from "./_Models";

export class YoutubeCounter extends SubscriberCounter {
    private _startYear: number;
    private _siteUrl: string;
    counterType: CounterType = CounterType.Youtube;
    constructor(counterSettings: ICounterSettings) {
        super(counterSettings); // 부모의 생성자에 매개 변수 전달
        this._startYear = Constants.Youtube.START_YEAR;
        this._siteUrl = Constants.Youtube.SITE_URL;
    }
    getCounterInfo(): ICounterInfo<number, string> {
        return {
            startYear: this._startYear,
            siteUrl: this._siteUrl
        };
    }
}

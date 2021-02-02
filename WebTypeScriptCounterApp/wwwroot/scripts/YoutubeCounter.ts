/// <reference path="CounterType.ts">
/// <reference path="SubscriberCounter.ts">
/// <reference path="_Constants.ts" />

class YoutubeCounter extends SubscriberCounter {
    private _startYear: number;
    private _siteUrl: string;

    counterType: CounterType = CounterType.Youtube;

    constructor(counterSetting: any) {
        //부모의 생성자에 넘긴다. 
        super(counterSetting);
        this._startYear = Constants.Youyube.START_YEAR;
        this._siteUrl = Constants.Youyube.SITE_URL;
    }

    getCounterInfo() {
        return {
            startYear: this._startYear,
            siteUrl: this._siteUrl
        };
    }
}
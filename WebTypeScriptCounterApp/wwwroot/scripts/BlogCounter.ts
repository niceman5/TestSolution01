/// <reference path="CounterType.ts">
/// <reference path="SubscriberCounter.ts">
/// <reference path="_Constants.ts" />

class BlogCounter extends SubscriberCounter {
    private _startYear: number;
    private _siteUrl: string;

    counterType: CounterType = CounterType.Blog;

    postCount: number = 0;
    constructor(counterSetting: any) {
        //이건 필수......SubscriberCounter에는 생성자가 있음
        //자식 클래스에서는 부모의 생성자를 호출해줘야 함.
        super(counterSetting);      //부모의 생성자에 매개 변수 전달
        this.postCount = counterSetting.postCount;

        this._startYear = Constants.Blog.START_YEAR;
        this._siteUrl = Constants.Blog.SITE_URL;
    }

    getCounterInfo() {
        return {
            startYear: this._startYear,
            siteUrl: this._siteUrl
        };
    }

    //메서드 재정의 override
    //increment(cnt: number) {
    //    if (this.postCount > 0) {
    //        this._count += (cnt * this.postCount);       //학습목적상 포스트수만큼 증가하게
    //    }
    //    else {
    //        this._count += cnt;
    //    }
    //}

    increment(cnt: number) {
        if (this.postCount > 0) {
            super.increment(cnt * this.postCount); //부모 메서드 호출            
        }
        else {
            super.increment(cnt);
        }
    }
}
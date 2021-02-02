"use strict";
/// <reference path="CounterType.ts">
/// <reference path="SubscriberCounter.ts">
/// <reference path="_Constants.ts" />
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var BlogCounter = /** @class */ (function (_super) {
    __extends(BlogCounter, _super);
    function BlogCounter(counterSetting) {
        var _this = 
        //이건 필수......SubscriberCounter에는 생성자가 있음
        //자식 클래스에서는 부모의 생성자를 호출해줘야 함.
        _super.call(this, counterSetting) || this;
        _this.counterType = CounterType.Blog;
        _this.postCount = 0;
        _this.postCount = counterSetting.postCount;
        _this._startYear = Constants.Blog.START_YEAR;
        _this._siteUrl = Constants.Blog.SITE_URL;
        return _this;
    }
    BlogCounter.prototype.getCounterInfo = function () {
        return {
            startYear: this._startYear,
            siteUrl: this._siteUrl
        };
    };
    //메서드 재정의 override
    //increment(cnt: number) {
    //    if (this.postCount > 0) {
    //        this._count += (cnt * this.postCount);       //학습목적상 포스트수만큼 증가하게
    //    }
    //    else {
    //        this._count += cnt;
    //    }
    //}
    BlogCounter.prototype.increment = function (cnt) {
        if (this.postCount > 0) {
            _super.prototype.increment.call(this, cnt * this.postCount); //부모 메서드 호출            
        }
        else {
            _super.prototype.increment.call(this, cnt);
        }
    };
    return BlogCounter;
}(SubscriberCounter));

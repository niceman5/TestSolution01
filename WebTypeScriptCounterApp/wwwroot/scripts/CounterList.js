"use strict";
/// <reference path="SubscriberCounter.ts">
var CounterList = /** @class */ (function () {
    function CounterList() {
        this._counterList = [];
    }
    CounterList.prototype.add = function (counter) {
        this._counterList.push(counter);
    };
    // counterlist배열 전체를 리턴.
    CounterList.prototype.getAll = function () {
        return this._counterList;
    };
    return CounterList;
}());

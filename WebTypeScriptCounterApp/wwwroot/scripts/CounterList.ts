/// <reference path="SubscriberCounter.ts">

class CounterList {
    private _counterList: SubscriberCounter[] = [];

    add(counter: SubscriberCounter) {
        this._counterList.push(counter);
    }

    // counterlist배열 전체를 리턴.
    getAll() :SubscriberCounter[] {
        return this._counterList;
    }
}
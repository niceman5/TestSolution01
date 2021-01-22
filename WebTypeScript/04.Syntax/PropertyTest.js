//property만들고 사용하기 
var PropertyTestDemo;
(function (PropertyTestDemo) {
    var Developer = /** @class */ (function () {
        function Developer() {
        }
        Object.defineProperty(Developer.prototype, "user_name", {
            get: function () {
                return this._user_name;
            },
            set: function (value) {
                this._user_name = value;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(Developer.prototype, "age", {
            get: function () {
                return this._age;
            },
            set: function (value) {
                if (value > 0 && value < 90) {
                    this._age = value;
                }
                else {
                    throw "나이 값이 잘못 되었습니다.";
                }
            },
            enumerable: false,
            configurable: true
        });
        return Developer;
    }());
    //인스턴스 생성
    var dev = new Developer();
    //속성에 값 설정(set)
    dev.name = "홍길동";
    dev.user_name = "user홍길동";
    //속성값 조회(get)
    console.log(dev.name);
    console.log(dev.user_name);
    dev.age = 50;
    console.log(dev.age);
    //dev.age = -1;
    //console.log(dev.age);
    //익명형식사용
    //id와 name의 속성을 갖틑 익명형식을 만들어 duck개체에 할당
    var duck = { id: 1, name: "오리1" };
    console.log(duck.id + "-" + duck.name);
    //다른 익명형식을 대입하는데 앞서 선언한 모양과 속성이 동일해야 함
    // duck = { id: "1", name: "오리2" };     오류남
    duck = { id: 2, name: "오리2" };
    console.log(duck.id + "-" + duck.name);
    //name속성 제외하고 할당해도 오류
    //duck = { id: 3};
    //속성을 추가해서 할당해도 오류
    //duck = { id: 2, name: "오리2", email:"aaaa" };
    //처음 개체가 만들어지면 그 형식과 동일한 모양으로만 다시 할당됨.
})(PropertyTestDemo || (PropertyTestDemo = {}));
//# sourceMappingURL=PropertyTest.js.map
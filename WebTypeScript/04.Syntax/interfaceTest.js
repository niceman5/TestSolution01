/*
 * 속성들(옵셔널 포함) 정의 가능
 * 메서드(함수)정의
 * 인덱서 정의
 * 다른 인터페이스로 확장
 * 기존 javascript의 class를 typescript로 옮길때 interface키워드를 붙이면 됨
 * 개발시 ts파일에만 존재함. -> 컴파일된 js파일에는 interface키워드가 없음.
 * */
var interfaceDemo;
(function (interfaceDemo) {
    function add(friend) {
        var name = friend.name;
        var color = friend.color;
        var age = friend.age;
        console.log("name=" + name + " color=" + color + " age=" + age);
    }
    add({ name: "가나다" });
    add({ name: "가나다", color: "red" });
    add({ name: "가나다", color: "red", age: 22 });
    //함수의 매개변수 타입
    function printLable(labelledobj) {
        console.log(labelledobj.label);
    }
    var myobj = { size: 10, label: "Size 10" };
    printLable(myobj);
    //클래스 선언 및 인터페이스 상속. 인터페이스는 implements사용
    var Car = /** @class */ (function () {
        function Car() {
            //go(): void {
            //    console.log('인터페이스에 정의된 모든 멤버를 반드시 구현해야 한다.');
            //}
            //람다식으로 표현 가능함.
            this.go = function () { return console.log('인터페이스에 정의된 모든 멤버를 반드시 구현해야 한다.'); };
        }
        return Car;
    }());
    var car = new Car();
    car.go();
    var x;
    x = 1234;
    x = "가나다";
    x = true;
    var y; //union 타입....데이터 형을 지정.
    y = 1234;
    y = "!2343";
    // y = true; 오류남,.
})(interfaceDemo || (interfaceDemo = {}));
//# sourceMappingURL=interfaceTest.js.map
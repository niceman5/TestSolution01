var ParamsDemo;
(function (ParamsDemo) {
    // 동적 파라메터....
    // ... 는 rest parameter라고 함....가변길이 매개변수라고 함.
    // 형식 ...변수명:데이터형[]
    function sumAll() {
        var numbers = [];
        for (var _i = 0; _i < arguments.length; _i++) {
            numbers[_i] = arguments[_i];
        }
        var sum = 0;
        for (var _a = 0, numbers_1 = numbers; _a < numbers_1.length; _a++) {
            var num_1 = numbers_1[_a];
            sum += num_1;
        }
        return sum;
    }
    console.log(sumAll(3, 5));
    console.log(sumAll(3, 5, 7));
    console.log(sumAll(3, 5, 7, 9));
    console.log(sumAll(1000));
    // 매서드의 매개 변수에 콜백 펑션 사용하기
    // C# 델리케이트
    // 콜백 함수(delegate)는 동일한 메서드 시그니처를 갖는 메서드의 참조를 담을 수 있는 그릇
    // go변수에 익명함수를 담는다.
    //var go = function () {  이것도 됨
    var go = function () {
        console.log("직진");
    };
    //var back = function () {  //이것도 됨
    var back = function () {
        console.log("후진");
    };
    // 매개 변수로 함수를 받아서 실행 : 매개 변수로 전달된 메서드 대신 호출 
    //function runnerCall( runner : any ) {
    function runnerCall(runner) {
        runner();
    }
    //함수의 매개 변수로 함수 자체를 전달.
    runnerCall(go);
    runnerCall(back);
})(ParamsDemo || (ParamsDemo = {}));
//# sourceMappingURL=ParamsTest.js.map
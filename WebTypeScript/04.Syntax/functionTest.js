/*
 * 함수선언
 * function() 함수이름{
 * }
 *
 * 함수를 실행
 * 함수이름();
 * 함수이름(매개변수);
 * 결과값 = 함수이름(매개변수);
 * */
var FunctionDemo1;
(function (FunctionDemo1) {
    function show() {
        console.log("Hello World!!!");
    }
    show();
})(FunctionDemo1 || (FunctionDemo1 = {}));
//ts에서 optional parameter
// rect { h: number; w ?: number;}
// h파라메터는 필수지만 w는 optional임.
var myFunc = function (a) {
    return a * a;
};
console.log(myFunc(5));
//아래와 같이 표시가능 Arrow function
var myFunc2 = function (a) { return a * a; };
console.log(myFunc2(5));
var FunctionDemo2;
(function (FunctionDemo2) {
    function calculateSum(x, y, z) {
        var restNumner = [];
        for (var _i = 3; _i < arguments.length; _i++) {
            restNumner[_i - 3] = arguments[_i];
        }
        var sum = x + y;
        for (var i = 0; i < restNumner.length; i++) {
            sum += restNumner[i];
        }
        return sum;
    }
    var calc = calculateSum;
    var calcSum = function (x, y) { return x + y; };
    console.log('calcSum=' + calcSum(5, 4));
    console.log('calc=' + calc(5, 4));
    console.log('calculateSum=' + calculateSum(5, 4, 9, 8, 7, 6));
    function printName(name, age) {
        if (age === void 0) { age = 20; }
        var email = [];
        for (var _i = 2; _i < arguments.length; _i++) {
            email[_i - 2] = arguments[_i];
        }
        return "name: " + name + ", age:" + age + ", emails:" + email.join(', ') + " ";
    }
    var r = printName("Red", 22, "aa@aa.com", "bb@aa.com", "cc@aa.com");
    console.log(r);
})(FunctionDemo2 || (FunctionDemo2 = {}));
var AnonymousFunction;
(function (AnonymousFunction) {
    //익명함수
    //functin다음에 함수이름이 오지 않고 매개변수가 바로 온다.
    //익명함수는 다른 함수의 매개변수로 전달할수 있다.
    //익명함수를 변수에 할당해서 사용할수 있다.
    var sumTwoNumber = function (f, s) {
        return f + s;
    };
    //익명함수사용
    var result = sumTwoNumber(3, 5);
    console.log(result);
})(AnonymousFunction || (AnonymousFunction = {}));
var ArrowFunction;
(function (ArrowFunction) {
    var f1 = function (message) {
        console.log(message);
    };
    //람다식 arrow함수.
    var f2 = function (message) {
        console.log(message);
    };
    //한줄이면
    var f3 = function (message) { return console.log(message); };
    f1("arrow function");
    f2("Lamda Expression");
    f3("Lamda Expression2");
})(ArrowFunction || (ArrowFunction = {}));
//# sourceMappingURL=functionTest.js.map
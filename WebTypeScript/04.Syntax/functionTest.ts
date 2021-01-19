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

namespace FunctionDemo1 {
    function show() {
        console.log("Hello World!!!");
    }
    show();
}

//ts에서 optional parameter
// rect { h: number; w ?: number;}
// h파라메터는 필수지만 w는 optional임.

var myFunc = function (a: number) {
    return a * a;
}
console.log(myFunc(5));

//아래와 같이 표시가능 Arrow function
var myFunc2 = (a: number) => a * a;
console.log(myFunc2(5));

namespace FunctionDemo2 {
    function calculateSum(x: number, y: number, z?: number, ...restNumner: number[]) : number {
        var sum = x + y;
        for (var i = 0; i < restNumner.length; i++) {
            sum += restNumner[i];
        }
        return sum;
    }

    var calc: (x: number, y: number) => number = calculateSum;
    var calcSum = (x, y) => x + y;

    console.log('calcSum=' + calcSum(5, 4));
    console.log('calc=' + calc(5, 4));
    console.log('calculateSum=' + calculateSum(5, 4, 9, 8, 7, 6));

    function printName(name: string, age: number = 20, ...email: string[]): string {
        return `name: ${name}, age:${age}, emails:${email.join(', ')} `;
    }
    var r = printName("Red", 22, "aa@aa.com", "bb@aa.com", "cc@aa.com");
    console.log(r);
}


namespace AnonymousFunction {
    //익명함수
    //functin다음에 함수이름이 오지 않고 매개변수가 바로 온다.
    //익명함수는 다른 함수의 매개변수로 전달할수 있다.
    //익명함수를 변수에 할당해서 사용할수 있다.
    const sumTwoNumber = function (f, s) {
        return f + s;
    }
    //익명함수사용
    let result = sumTwoNumber(3, 5);
    console.log(result);
}


namespace ArrowFunction {
    let f1 = function (message) {
        console.log(message);
    }

    //람다식 arrow함수.
    let f2 = (message) => {
        console.log(message);
    }
    //한줄이면
    let f3 = (message) => console.log(message);
    f1("arrow function");
    f2("Lamda Expression");
    f3("Lamda Expression2");
}

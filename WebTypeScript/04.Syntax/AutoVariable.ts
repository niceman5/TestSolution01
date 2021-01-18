
// numericSeparator 
// 긴 숫자 표시시 가운데 "," 대신 _를 사용한다. _는 아무 의미가 없음
let num = 1_000_000;

//실제 출력에는 1000000이 출력됨....
console.log(num);

let binary = 0b1111;    //15임 2진법
let hex = 0xFF;         // 255 16진법
let octal = 0o77;       // 63 8진법

console.log(binary);
console.log(hex);
console.log(octal);


var i = 10;
var j: any;     //j에는 모든 값이 들어올수 있음.
var k: number;  //k에는 number만 들어올수 있음
//k = "aaa";    //인텔리센스에서 오류 체크함.

var b: boolean = true;      //선언과 동시에 초기화 까지....
b = false;
// b = 1234;

var str: string = "감사합니다.";


// 배열형 선언. 문자열 선언
var arr: string[] = ["a", "b", "c"];
// 숫자형 배열 선언 
var arr2: number[] = [1, 2, 3, 4, 5];




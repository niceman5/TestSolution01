// 타입 어설션
// 인텔리센스의 도움을 받을수 있음
let what = "문자열";
console.log(what.length);


// 인텔리센스의 도움을 받을수 없음.
let aaa;
aaa = "간나다";
//aaa.

//아래처럼 형식변환하면 인텔리센스 적용됨.
let bbb;
bbb = "나나나1222";
console.log((<string>bbb).length);
console.log((bbb as string).length);

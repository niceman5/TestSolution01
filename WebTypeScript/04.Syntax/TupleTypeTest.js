/*
 * typescript의 튜플타입
 * */
//let hello: MultiString = ["Hello"];           //오류남 형체크
//let hello: MultiString = ["Hello", 1222];     //오류남 형체크
var hello = ["Hello", "World"];
var pi = ["PI", 3.141592];
console.log(pi);
console.log(pi[0]);
console.log(pi[1]);
var pi2 = ["PI", 3.141592, 100];
console.log(pi2);
// 분해 (Desconstructing) :튜플 분해 구조파괴할당 혹은 구조분해할당이라고 함.
var tech = {
    id: 1234,
    title: "TypeScript"
};
//[1]기본 개체 분해 방법
//var id = tech.id;
//var title = tech.title;
// [2]한번에 처리....
// var { id, title } = tech;
// [2]-1 이름에 맞게 들어간다.
var title = tech.title, id = tech.id;
console.log(id + " : " + title);
//# sourceMappingURL=TupleTypeTest.js.map
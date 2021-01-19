var colors = ["red", "green", "black"];
// javascript방식
// in구문은 index값을 가져온다.
for (var index in colors) {
    console.log(index);
    console.log(colors[index]);
}
// typescript
// of구문은  값을 가져온다.
for (var _i = 0, colors_1 = colors; _i < colors_1.length; _i++) {
    var color = colors_1[_i];
    console.log(color);
}
//let과 var차이 
//var number1 = 3;
//let number2 = 3;
function printNumber(num) {
    for (var i = 0; i < num; i++) {
        console.log(i);
    }
    // for블럭에서 선언했는데 여기서 사용가능
    console.log('최종 :' + i);
}
function printNumber2(num) {
    for (var i_1 = 0; i_1 < num; i_1++) {
        console.log(i_1);
    }
    // i를 여기서 사용못한다고 에러남....실행시 에러남. c#과 동일하게....
    console.log('최종 :' + i);
}
printNumber(3);
printNumber2(3);
//# sourceMappingURL=Controls.js.map
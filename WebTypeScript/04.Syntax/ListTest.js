var ListDemo;
(function (ListDemo) {
    var colors = ["red", "blue", "green"];
    console.log(colors[0]);
    console.log(colors[1]);
    console.log(colors[2]);
    console.log("\uC694\uC18C\uC218 : " + colors.length);
    for (var i = 0; i < colors.length; i++) {
        console.log(colors[i]);
    }
    console.log(colors);
    //javascript배열은 동적으로 push메서드로 요소 추가 가능
    var cart = [];
    console.log(cart.push("책")); //push는 배열에 추가하고 난 배열의 길이를 리턴함.
    console.log(cart.push("강의"));
    console.log(cart.push("컴"));
    console.log(cart);
    var array1 = new Array(); //[]빈 배열 만듬
    var array2 = new Array(3); // array2의 lengrh는 3인 배열임
    var array3 = new Array(1, 2, 3); // [1,2,3]
    console.log(array1);
    console.log(array2);
    console.log(array3);
    var arr = [3, 2, 1, 4, 5];
    var sortarr = arr.sort(); //정렬 오름차순
    console.log(arr);
    console.log(sortarr);
    for (var _i = 0, sortarr_1 = sortarr; _i < sortarr_1.length; _i++) {
        var item = sortarr_1[_i];
        console.log(item);
    }
    var numbers = [1, 2, 3, 2];
    numbers.reverse(); //현재거 역순으로 처리....sort하고 reverse하면 내림차순임.
    console.log(numbers);
    var new_numbers = numbers.slice(0);
    console.log(new_numbers);
    console.log(numbers.slice(1));
    console.log(numbers.slice(2)); //두개뛰거 나머지
    console.log(numbers.slice(-2)); //뒤에서 두개
    console.log(numbers);
    console.log(numbers.slice(0, 2));
    console.log(numbers.slice(1, 2));
})(ListDemo || (ListDemo = {}));
//# sourceMappingURL=ListTest.js.map
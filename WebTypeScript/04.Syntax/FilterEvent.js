var FilterEventDemo;
(function (FilterEventDemo) {
    var numbers = [1, 2, 3, 4, 5, 6];
    var result = numbers.filter(function (n) { return n % 2 === 0; }); //짝수만 고른다.
    console.log(result);
})(FilterEventDemo || (FilterEventDemo = {}));
//# sourceMappingURL=FilterEvent.js.map
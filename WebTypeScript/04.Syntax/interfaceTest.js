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
    // add({ color: "blue" });  에러남 필수항목이 없어서
})(interfaceDemo || (interfaceDemo = {}));
//# sourceMappingURL=interfaceTest.js.map
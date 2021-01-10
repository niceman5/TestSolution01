var Greeter = /** @class */ (function () {
    function Greeter(message) {
        this.greeting = message;
    }
    Greeter.prototype.greet = function () {
        return "안녕 " + this.greeting;
    };
    return Greeter;
}());
var a = new Greeter("가나다");
console.log(a.greet());
//# sourceMappingURL=00_Greet.js.map
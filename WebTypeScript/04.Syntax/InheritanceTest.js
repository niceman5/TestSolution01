var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
//상속 : 부모클래스의 기능을 자식 클래스가 물려받아 사용 
var InheritanceDemo;
(function (InheritanceDemo) {
    var Parent = /** @class */ (function () {
        function Parent() {
            this.parent_age = 20;
            this.toString = function () {
                return "개발자";
            };
        }
        Parent.prototype.hi = function () {
            console.log("안녕하세요!");
        };
        return Parent;
    }());
    // class Child {        //일반
    var Child = /** @class */ (function (_super) {
        __extends(Child, _super);
        function Child() {
            var _this = _super !== null && _super.apply(this, arguments) || this;
            _this.toString = function () { return "\uC6F9 \uAC1C\uBC1C\uC790"; };
            return _this;
        }
        Child.prototype.hllo = function () {
            console.log("반갑습니다.");
        };
        return Child;
    }(Parent));
    var child = new Child();
    child.hllo(); // 자식 클래스의 member만 가능
    child.hi(); //상속후에는 둘다 사용 가능
    console.log(child.parent_age);
    var p = new Parent();
    console.log(p);
    console.log("" + p); //개발자를 찍어줌.....
    var w = new Child();
    console.log("" + w); //개발자를 찍어줌.....
})(InheritanceDemo || (InheritanceDemo = {}));
//# sourceMappingURL=InheritanceTest.js.map
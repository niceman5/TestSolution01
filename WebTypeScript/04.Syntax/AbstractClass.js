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
// 추상 클래스
var Shape = /** @class */ (function () {
    function Shape() {
    }
    return Shape;
}());
//원 클래스
var Circle = /** @class */ (function (_super) {
    __extends(Circle, _super);
    function Circle(radius) {
        var _this = _super.call(this) || this;
        _this.radius = radius;
        return _this;
    }
    Circle.prototype.getArea = function () {
        return Math.PI * Math.pow(this.radius, 2);
    };
    return Circle;
}(Shape));
var Rectangle = /** @class */ (function (_super) {
    __extends(Rectangle, _super);
    function Rectangle(w, h) {
        var _this = _super.call(this) || this;
        _this.w = w;
        _this.h = h;
        return _this;
    }
    Rectangle.prototype.getArea = function () {
        return this.w * this.h;
    };
    return Rectangle;
}(Shape));
var circle = new Circle(10);
console.log(circle.getArea());
var rectangle = new Rectangle(10, 10);
console.log(rectangle.getArea());
//# sourceMappingURL=AbstractClass.js.map
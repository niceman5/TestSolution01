/*
 * 클래스는 컨테이너 역할
 *  -속성들 구현
 *  -생성자
 *  -메서드
 * 인스턴스가능
 * 다른 클래스로 상속 가능
 *  - super()로 base클래스 접속
 * 액세스 접근 한정자 : private , public
 * static멤버 생성가능
 * getter와 setter구현 가능
 *
 * */
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
var ClassTestDemo;
(function (ClassTestDemo) {
    //class원형
    var Animal = /** @class */ (function () {
        function Animal(name) {
            this.name = name;
        }
        ;
        Animal.prototype.move = function (meters) {
            console.log(this.name + " move " + meters + " m.");
        };
        return Animal;
    }());
    var Snake = /** @class */ (function (_super) {
        __extends(Snake, _super);
        function Snake(name) {
            return _super.call(this, name) || this;
        }
        Snake.prototype.move = function () {
            console.log("조용하게 이동.....");
            _super.prototype.move.call(this, 5);
        };
        return Snake;
    }(Animal));
    var Horse = /** @class */ (function (_super) {
        __extends(Horse, _super);
        function Horse(name) {
            return _super.call(this, name) || this;
        }
        Horse.prototype.move = function () {
            console.log("뛰어서 이동.......");
            _super.prototype.move.call(this, 45);
        };
        return Horse;
    }(Animal));
    var sam = new Snake("방울뱀 방울이");
    var tom = new Horse("조랑말 말말이");
    sam.move();
    tom.move(30);
})(ClassTestDemo || (ClassTestDemo = {}));
//# sourceMappingURL=ClassTest.js.map
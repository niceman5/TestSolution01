var ConstructorPrivate;
(function (ConstructorPrivate) {
    var nameCard = /** @class */ (function () {
        // 생성자에서 값을 받아서 자동으로  private name필드 생성
        // 별도 선언안해도 사용가능해짐...
        function nameCard(name) {
            this.name = name;
            // Empty
        }
        //출력
        nameCard.prototype.display = function () {
            return "\uC774\uB984 : " + this.name;
        };
        return nameCard;
    }());
    //const t = new nameCard();     생성자가 없음
    var t = new nameCard('빌게이츠');
    console.log(t.display());
})(ConstructorPrivate || (ConstructorPrivate = {}));
var ConstructorPublic;
(function (ConstructorPublic) {
    var nameCard = /** @class */ (function () {
        //속성은 public
        function nameCard(name) {
            this.name = name;
            // Empty
        }
        //출력
        nameCard.prototype.display = function () {
            return "\uC774\uB984 : " + this.name;
        };
        return nameCard;
    }());
    //const t = new nameCard();     생성자가 없음
    var t = new nameCard('홍길동');
    console.log(t.name);
    t.name = "임꺽정"; // name속성을 변경함.
    console.log(t.display());
})(ConstructorPublic || (ConstructorPublic = {}));
//# sourceMappingURL=ConstructorPrivate.js.map
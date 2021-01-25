var LocalAndGlobal;
(function (LocalAndGlobal) {
    var VariableScope = /** @class */ (function () {
        function VariableScope() {
            this.globalVariable = "[2]전역변수"; //필드 또는 멤버 변수
        }
        VariableScope.prototype.render = function () {
            //[1] 지역변수
            var localVariable = "[1]지역 변수"; //render에서만 유효함. 속성
            console.log(localVariable);
            //2-1
            console.log(this.globalVariable);
            //2-2
            this.test();
        };
        VariableScope.prototype.test = function () {
            console.log(this.globalVariable);
        };
        return VariableScope;
    }());
    var t = new VariableScope();
    t.render();
    var Say = /** @class */ (function () {
        function Say() {
            //1 필드(멤버변수)
            this.message = "안녕하세요1!"; //필드 이니셜라이져
        }
        //2 메서드
        Say.prototype.hi = function () {
            this.message = "반갑습니다.";
            console.log(this.message);
        };
        return Say;
    }());
    var say = new Say();
    // say.message  private속성이라 접근이 안됨.
    say.hi(); //public이라 외부에서 접근 가능함.
})(LocalAndGlobal || (LocalAndGlobal = {}));
//# sourceMappingURL=LocalAndGlobal.js.map
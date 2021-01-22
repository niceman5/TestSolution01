var GreeterDemo = /** @class */ (function () {
    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    // 생성자
    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    function GreeterDemo(element) {
        this.element = element;
        this.element.innerHTML += "The Time is : ";
        this.span = document.createElement("span");
        this.element.appendChild(this.span);
        this.span.innerText = new Date().toUTCString();
        this.timerToken = 0;
    }
    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    // 메서드
    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    GreeterDemo.prototype.start = function () {
        var _this = this;
        this.timerToken = setInterval(function () { return _this.span.innerText = new Date().toUTCString(); }, 500);
    };
    GreeterDemo.prototype.end = function () {
        clearTimeout(this.timerToken);
    };
    return GreeterDemo;
}());
// load시 실행시키는 코드...람다 함수
window.onload = function () {
    var el = document.getElementById("content");
    var greeterDemo = new GreeterDemo(el);
    greeterDemo.start();
    var btn = document.getElementById("btn");
    var count = 0;
    //이벤트 이름과 익명 메서드를 매개 변수로 지정.
    btn.addEventListener("click", function () {
        console.log("clicked " + count++);
    });
};
//# sourceMappingURL=app.js.map
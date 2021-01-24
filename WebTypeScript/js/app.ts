
class GreeterDemo {
    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    // 필드
    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    element: HTMLElement;
    span: HTMLElement;
    timerToken: any;

    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    // 생성자
    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    constructor(element: HTMLElement) {
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
    start() {
        this.timerToken = setInterval(
            () => this.span.innerText = new Date().toUTCString(), 500);
    }

    end() {
        clearTimeout(this.timerToken);
    }
}

// load시 실행시키는 코드...람다 함수
window.onload = () => {
    let el = <HTMLElement>document.getElementById("content");

    const greeterDemo = new GreeterDemo(el);
    greeterDemo.start();


    var btn = document.getElementById("btn");
    let count: number = 0;
    //이벤트 이름과 익명 메서드를 매개 변수로 지정.
    btn.addEventListener("click", function () {
        console.log("clicked " + count++);
    });
}
class Greeter {
    greeting: string;
    constructor(message: string) {
        this.greeting = message;
    }

    greet() {
        return "안녕 " + this.greeting;
    }
}

var a = new Greeter("가나다");
console.log(a.greet());

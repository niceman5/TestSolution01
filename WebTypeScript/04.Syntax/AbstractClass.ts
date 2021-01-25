
// 추상 클래스
abstract class Shape {
    abstract getArea(): number;
}

//원 클래스
class Circle extends Shape {

    constructor(public radius: number) {
        super();
    }

    getArea(): number {
        return Math.PI * this.radius ** 2
    }
}

class Rectangle extends Shape {
    constructor(public w: number, public h: number) {
        super();
    }

    getArea(): number {
        return this.w * this.h;
    }

}

var circle = new Circle(10);
console.log(circle.getArea())

var rectangle = new Rectangle(10, 10);
console.log(rectangle.getArea())
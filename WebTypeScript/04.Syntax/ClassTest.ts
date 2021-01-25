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

namespace ClassTestDemo {
    //class원형
    class Animal {
        constructor(public name: string) { };
        move(meters: number) {
            console.log(this.name + " move " + meters + " m.");
        }
    }

    class Snake extends Animal {
        constructor(name: string) {
            super(name);
        }
        move() {
            console.log("조용하게 이동.....");
            super.move(5);
        }
    }

    class Horse extends Animal {
        constructor(name: string) {
            super(name);
        }

        move() {
            console.log("뛰어서 이동.......");
            super.move(45);
        }
    }

    var sam = new Snake("방울뱀 방울이"); 
    var tom: Animal = new Horse("조랑말 말말이");
    sam.move();
    tom.move(30);
}

module ConstructorPrivate {
    class nameCard {

        // 생성자에서 값을 받아서 자동으로  private name필드 생성
        // 별도 선언안해도 사용가능해짐...
        constructor(private name: string) {
            // Empty
        }
        //출력
        display() {
            return `이름 : ${this.name}`;
        }
    }

    //const t = new nameCard();     생성자가 없음
    const t = new nameCard('빌게이츠');    
    console.log(t.display());
}



module ConstructorPublic {
    class nameCard {
        //속성은 public
        constructor(public name: string) {
            // Empty
        }

        //출력
        display() {
            return `이름 : ${this.name}`;
        }
    }

    //const t = new nameCard();     생성자가 없음
    const t = new nameCard('홍길동');
    console.log(t.name);
    t.name = "임꺽정";             // name속성을 변경함.
    console.log(t.display());
}
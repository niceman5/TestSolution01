//상속 : 부모클래스의 기능을 자식 클래스가 물려받아 사용 
module InheritanceDemo {
    class Parent {
        public parent_age: number = 20;
        hi() {
            console.log("안녕하세요!");
        }

        public toString = ():string => {
            return "개발자";
        }
    }

    // class Child {        //일반
    class Child extends Parent {        //부모를 상속받는다.
        hllo() {
            console.log("반갑습니다.");
        }

        public toString = (): string => `웹 개발자`;        
    }

    let child = new Child();
    child.hllo();   // 자식 클래스의 member만 가능
    child.hi();     //상속후에는 둘다 사용 가능
    console.log(child.parent_age);

    let p = new Parent();
    console.log(p);
    console.log(`${p}`);        //개발자를 찍어줌.....


    let w = new Child();
    console.log(`${w}`);        //개발자를 찍어줌.....
}
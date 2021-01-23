/*
 * 속성들(옵셔널 포함) 정의 가능
 * 메서드(함수)정의
 * 인덱서 정의
 * 다른 인터페이스로 확장
 * 기존 javascript의 class를 typescript로 옮길때 interface키워드를 붙이면 됨
 * 개발시 ts파일에만 존재함. -> 컴파일된 js파일에는 interface키워드가 없음.
 * */

namespace interfaceDemo {

    // typescript의 장점...묶어서 관리 가능...
    interface Friend {
        name: string,
        color?: string,     //null가능 형식 ? nullable
        age?:number
    }


    function add(friend: Friend) {
        let name = friend.name;
        let color = friend.color;
        let age = friend.age;

        console.log(`name=${name} color=${color} age=${age}`);
    }


    add({ name: "가나다" });
    add({ name: "가나다", color: "red" });
    add({ name: "가나다", color: "red", age: 22 });

    // add({ color: "blue" });  에러남 필수항목이 없어서

    interface ILabelledValue {
        label: string;
    }
    //함수의 매개변수 타입
    function printLable(labelledobj: ILabelledValue) {
        console.log(labelledobj.label);    
    }

    var myobj = { size: 10, label: "Size 10" };
    printLable(myobj);


    interface Person {
        firstName: string;
        lastName: string;
        age?: Number;           //option값 nullable
    }
    // Driver는 총 7개의 member를 가진다.
    // interface는 특정한 class에게 강제 규칙을 강요한다.
    // 묶어서 관리하는 새로은 타입을 만듬.
    // 즉 엔터티 타입을 만들어 주는 역할과 규칙을 주는 역할을 모두 가진다.

    /*
    interface Driver extends Person {
        yearExperience: number;
        vehicles: Vehicle[];
        addVehicle(vehicle: Vehicle): void;
        removeVehicle(vehicle: Vehicle): Vehicle;
    }
    */


    //인터페이스는 클래스에 포함될 수 있는 속성 또는 메서드에 대한 표준 규약을 제공한다.

    //인터페이스 선언
    interface ICar {
        go(): void;     //함수 시그니처만 제공 ICar를 상속받는 모든 클래스는 go라는 함수를 제공해야 한다.
    }
    //클래스 선언 및 인터페이스 상속. 인터페이스는 implements사용
    class Car implements ICar {
        //go(): void {
        //    console.log('인터페이스에 정의된 모든 멤버를 반드시 구현해야 한다.');
        //}
        //람다식으로 표현 가능함.
        go = (): void => console.log('인터페이스에 정의된 모든 멤버를 반드시 구현해야 한다.');

    }

    let car = new Car();
    car.go();

    var x: any;
    x = 1234;
    x = "가나다";
    x = true;

    let y: string | number;         //union 타입....데이터 형을 지정.
    y = 1234;
    y = "!2343";
    // y = true; 오류남,.

}


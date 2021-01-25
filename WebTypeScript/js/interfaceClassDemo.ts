
// entity형 정의
interface IContact {
    name: string;
    age: number;
    addr?: string;      //nullable : 옵션
};

var theContact = { name: "홍길동", age: 21, addr: "서울" };
var theContact2 = { name: "임꺽정", age: 30, addr: "부산" };
var theContact3 = { name: "가나다", age: 40, addr: "목포" };

function printContact(contact: IContact): string {

    if (contact.addr) {
        //return contact.name + ", " + contact.age + "(" + contact.addr + ")";
        return `이름:${contact.name}, 나이: ${contact.age}, 주소:${contact.addr}`;
    }
    else {
        return contact.name + ", " + contact.age;
    }
    
}

var contactResult = printContact(theContact);

// console.log(contackResult);
document.write(contactResult);

// 함수형 정의
// IContact형을 전달받아 string을 리턴하는 함수정의
interface IPrintContact {
    (contact: IContact): string;
};

var contactPrinter: IPrintContact;
contactPrinter = function (contact: IContact): string {
    return `이름:${contact.name}, 나이: ${contact.age}`;
}


// 배열형 정의
interface IContactArray {
    [index: number]: IContact;
};

var contactArray: IContactArray;
contactArray = [theContact, theContact2, theContact3];
document.write("<br/>" + printContact(contactArray[1]));


//클래스를 사용하여 묶어서 관리

interface IPrintCurrentContact {
    print(): string;
}
// 인터페이스를 구현한 클래스 선언
class Contact implements IContact, IPrintCurrentContact {    
    name: string;
    age: number;   

    print(): string {
        return `이름:${this.name}, 나이: ${this.age}`;
    }    
    //생성자...
    constructor(name: string, age: number) {
        this.name = name;
        this.age = age;
    }
}

var contactTest = new Contact("한라산", 150);
//contactTest.name = "백두산";
//contactTest.age = 100;
document.write("<br/>" + contactTest.print());

// Contact class를 상속
class ContactWithAddr extends Contact {
    addr: string;

    constructor(name: string, age: number, addr: string) {
        super(name, age);       //부모의 초기화에 넘긴다.
        this.addr = addr;
    }

    print(): string {
        return `이름:${this.name}, 나이: ${this.age}, 주소:${this.addr}`;
    }
}

var cwa = new ContactWithAddr("북한산", 45, "세종시");
document.write("<br/>" + cwa.print());



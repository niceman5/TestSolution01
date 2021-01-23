var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
;
var theContact = { name: "홍길동", age: 21, addr: "서울" };
var theContact2 = { name: "임꺽정", age: 30, addr: "부산" };
var theContact3 = { name: "가나다", age: 40, addr: "목포" };
function printContact(contact) {
    if (contact.addr) {
        //return contact.name + ", " + contact.age + "(" + contact.addr + ")";
        return "\uC774\uB984:" + contact.name + ", \uB098\uC774: " + contact.age + ", \uC8FC\uC18C:" + contact.addr;
    }
    else {
        return contact.name + ", " + contact.age;
    }
}
var contactResult = printContact(theContact);
// console.log(contackResult);
document.write(contactResult);
;
var contactPrinter;
contactPrinter = function (contact) {
    return "\uC774\uB984:" + contact.name + ", \uB098\uC774: " + contact.age;
};
;
var contactArray;
contactArray = [theContact, theContact2, theContact3];
document.write("<br/>" + printContact(contactArray[1]));
// 인터페이스를 구현한 클래스 선언
var Contact = /** @class */ (function () {
    //생성자...
    function Contact(name, age) {
        this.name = name;
        this.age = age;
    }
    Contact.prototype.print = function () {
        return "\uC774\uB984:" + this.name + ", \uB098\uC774: " + this.age;
    };
    return Contact;
}());
var contactTest = new Contact("한라산", 150);
//contactTest.name = "백두산";
//contactTest.age = 100;
document.write("<br/>" + contactTest.print());
// Contact class를 상속
var ContactWithAddr = /** @class */ (function (_super) {
    __extends(ContactWithAddr, _super);
    function ContactWithAddr(name, age, addr) {
        var _this = _super.call(this, name, age) || this;
        _this.addr = addr;
        return _this;
    }
    ContactWithAddr.prototype.print = function () {
        return "\uC774\uB984:" + this.name + ", \uB098\uC774: " + this.age + ", \uC8FC\uC18C:" + this.addr;
    };
    return ContactWithAddr;
}(Contact));
var cwa = new ContactWithAddr("북한산", 45, "세종시");
document.write("<br/>" + cwa.print());
//# sourceMappingURL=interfaceClassDemo.js.map
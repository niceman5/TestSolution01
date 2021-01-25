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
// 클래스 선언
var BankAccount = /** @class */ (function () {
    //생성자. 클래스내의 필드 초기화
    // constructor() { this.balance = 100; }
    function BankAccount(init) {
        this.balance = 0; //필드 선언
        this.balance = init;
    }
    // 함수, 메서드.
    BankAccount.prototype.deposit = function (credit) {
        this.balance += credit;
        return this.balance;
    };
    return BankAccount;
}());
// 클래스 사용
var bank = new BankAccount(1000);
bank.deposit(100);
bank.deposit(200);
var r = bank.deposit(300);
console.log(r);
var CheckBankAccount = /** @class */ (function (_super) {
    __extends(CheckBankAccount, _super);
    function CheckBankAccount(balance) {
        return _super.call(this, balance) || this;
    }
    CheckBankAccount.prototype.withCheck = function (debit) {
        this.balance -= debit;
        return this.balance;
    };
    return CheckBankAccount;
}(BankAccount));
var check = new CheckBankAccount(2000);
var r2 = check.withCheck(500);
console.log(r2);
//# sourceMappingURL=ClassBankAccount.js.map
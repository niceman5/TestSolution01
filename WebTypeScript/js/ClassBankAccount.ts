// 클래스 선언
class BankAccount {
    balance: number = 0;            //필드 선언

    //생성자. 클래스내의 필드 초기화
    // constructor() { this.balance = 100; }
    constructor(init: number) {
        this.balance = init;
    }

    // 함수, 메서드.
    deposit(credit: number) {
        this.balance += credit;

        return this.balance;
    }
}

// 클래스 사용
var bank = new BankAccount(1000);
bank.deposit(100);
bank.deposit(200);
var r = bank.deposit(300);
console.log(r);

class CheckBankAccount extends BankAccount {
    constructor(balance: number) {
        super(balance);
    }
    withCheck(debit: number) {
        this.balance -= debit;
        return this.balance;
    }
}

var check = new CheckBankAccount(2000);
var r2 = check.withCheck(500);
console.log(r2);



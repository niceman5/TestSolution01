var GenericsDemo;
(function (GenericsDemo) {
    /*
     * 재사용성
     * 제너릭 클래스 제너릭 함수
     * 타입 체킹 및 제약조건 부여
     * */
    var Account = /** @class */ (function () {
        function Account() {
        }
        return Account;
    }());
    var a1 = new Account();
    a1.tag = "안녕하세요";
    console.log(a1.tag);
    var a2 = new Account();
    a2.tag = 2222;
    console.log(a2.tag);
    var a3 = new Account();
    a3.tag = true;
    console.log(a3.tag);
    //Array클래스의 제네릭버젼은 Array<T>형태로 표현
    //클래스<T>형태로 제네릭 클래스 만들기
    var Cup = /** @class */ (function () {
        function Cup() {
        }
        return Cup;
    }());
    //형식 매개변수 T에 string전달하여 문자열 저장하는 속성 생성
    var text = new Cup();
    //text.Content = 1234;    //안됨
    text.Content = "aaaaa";
    var int = new Cup();
    //int.Content = "111";        //에러
    int.Content = 2222;
    console.log(text.Content + " " + int.Content);
})(GenericsDemo || (GenericsDemo = {}));
//# sourceMappingURL=Generics.js.map
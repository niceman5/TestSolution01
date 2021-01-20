var StringKeyword;
(function (StringKeyword) {
    var name = "가나다";
    var age = 21;
    console.log("반가워요.." + name + "(" + age + ")입니다.");
    // ``안의 내용을 그대로 저정한다.
    var multiLines = "\n    \uC548\uB155\uD558\uC138\uC694.\n    \uBC18\uAC11\uC2B5\uB2C8\uB2E4.\n";
    console.log(multiLines);
    console.log("안녕\n반가워"); //한줄띄우기
    console.log("안녕\t반가워"); //tab 띄우기
    console.log(" '낼' \'만나요.\' ");
    console.log(" \"낼\"  \"만나요.\" "); // "출력
    console.log(" \\낼\\  \\만나요.\\ "); // /출력
    // string interpolation 문자열 보간법 (중요함)
    var message = "Hello";
    console.log(message + " " + age); //문자열 보간에 사용된 변수는 모두 문자열로 처리됨
    console.log(message + " " + age * 2); //숫자변수에 *2결과를 문자열로 출력함.
    console.log("3 > 5 : " + (3 > 5)); // 3 > 5 : false 출력됨
    console.log("ES " + 6); //숫자도 바로 출력할수 있음.
    var mesg;
    mesg = "\n\uAC00\uB098\uB2E4\uB77C\n\uB9C8\uBC14\uC0AC\uC544\n\uC790\uCC28\uCE74\uD0C0\n";
    console.log(mesg);
    var dateNow = new Date(); //Date Class생성자    
    console.log(dateNow);
    var num2 = "1234";
    console.log(typeof (num2));
    console.log(typeof (+num2)); //+기호를 붙이면 숫자모양의 문자를 숫자형식으로 변경한다.
    console.log(num2 + num2); //문자열 연결이 됨
    console.log(+num2 + +num2); //숫자로 변환해서 더한결과 출력
    console.log(Number(num2)); //숫자로 변경
    var s = "12.2555";
    var n1 = parseInt(s); //숫자로 변경
    var n2 = parseFloat(s); //숫자로 변경
    console.log(" n1 => " + n1 + " : " + typeof n1);
    console.log(" n2 => " + n2 + " : " + typeof n2);
    console.log(" n1 => " + ++n1 + " : " + typeof n1); //증감연산자 지원함.
    /*==연산자는 동등 연산자로, 피연산자가 서로 다른 타입이면 타입을 강제로 변환하여 비교한다.
    하지만 형 변환이 어떻게 되는지 하나하나 외워서 사용하는 것은 복잡하기만 할 뿐이다.

    0 == ''     //true
    0 == '0'     //true
    1 == true     //true
    false == '0'    //true
    null == undefined    //true
    false == null    //false
    false == undefined    //false

    하지만 ===연산자는 일치 연산자로, 두 피연산자를 더 정확하게 비교한다.
    0 === ''     //false
    0 === false    //false
    1 === true     //false
    NaN === NaN     //false
    null === undefined     //false

    따라서 특별한 경우가 아니라면, ==보다는 ===를 쓰는 것을 권장한다.
    */
    var x = 10;
    if (x === 10) {
        console.log("x\uB294 " + x + "\uC785\uB2C8\uB2E4.");
    }
    if (x !== 20) {
        console.log("x\uB294 20\uC774 \uC544\uB2D9\uB2C8\uB2E4.");
    }
    var me = "hello world!";
    console.log(me.toUpperCase());
    console.log(me.toLowerCase());
    console.log(me.replace("hello", "안녕하세요").replace("world", "세계"));
    var orign = "안녕하세요. 안녕하세요.";
    var result = orign.replace("안녕", "Hi"); //하나만 변경됨
    console.log(result);
    result = orign.replace(/안녕/, "Hi"); //하나만 변경됨
    console.log(result);
    result = orign.replace(/안녕/g, "Hi"); //모두 변경됨
    console.log(result);
    result = orign.replace(/안녕/img, "Hi"); //대소문자 구분없이 모두 변경됨
    console.log(result);
    var s1 = new String("Hello."); //string class의 인스턴스 생성
    var s2 = "안녕하세요."; //string 키워드
    console.log(s1 + " " + s2);
    console.log(s1.length + "," + s2.length);
})(StringKeyword || (StringKeyword = {}));
//# sourceMappingURL=StringKeyword.js.map
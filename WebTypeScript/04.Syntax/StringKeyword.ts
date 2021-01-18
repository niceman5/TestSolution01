namespace StringKeyword {
    const name: string = "가나다";
    var age: number = 21;

    console.log("반가워요.." + name + "(" + age + ")입니다.");

    // ``안의 내용을 그대로 저정한다.
    var multiLines = `
    안녕하세요.
    반갑습니다.
`;

    console.log(multiLines);
    console.log("안녕\n반가워");     //한줄띄우기
    console.log("안녕\t반가워");     //tab 띄우기
    console.log(" '낼' \'만나요.\' ");          
    console.log(" \"낼\"  \"만나요.\" ");       // "출력
    console.log(" \\낼\\  \\만나요.\\ ");       // /출력

    // string interpolation 문자열 보간법 (중요함)
    var message = "Hello";
    console.log(`${message} ${age}`);   //문자열 보간에 사용된 변수는 모두 문자열로 처리됨
    console.log(`${message} ${age*2}`); //숫자변수에 *2결과를 문자열로 출력함.
    console.log(`3 > 5 : ${3 > 5}`);    // 3 > 5 : false 출력됨
    console.log(`ES ${6}`);             //숫자도 바로 출력할수 있음.

    var mesg: string;
    mesg = `
가나다라
마바사아
자차카타
`;
    console.log(mesg);

    const dateNow = new Date();     //Date Class생성자    
    console.log(dateNow);

    let num2 = "1234";
    console.log(typeof (num2));
    console.log(typeof (+num2));    //+기호를 붙이면 숫자모양의 문자를 숫자형식으로 변경한다.
    console.log(num2 + num2);       //문자열 연결이 됨
    console.log(+num2 + +num2);     //숫자로 변환해서 더한결과 출력

    console.log(Number(num2));      //숫자로 변경

    var s: string = "12.2555";
    var n1: number = parseInt(s);       //숫자로 변경
    var n2: number = parseFloat(s);     //숫자로 변경
    console.log(` n1 => ${n1} : ${typeof n1}`);
    console.log(` n2 => ${n2} : ${typeof n2}`);

    console.log(` n1 => ${++n1} : ${typeof n1}`);       //증감연산자 지원함.

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
    var x: number = 10;
    if (x === 10) {
        console.log(`x는 ${x}입니다.`);
    }   

    if (x !== 20) {
        console.log(`x는 20이 아닙니다.`);
    }   
}
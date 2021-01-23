namespace GenericsDemo {
    /*
     * 재사용성
     * 제너릭 클래스 제너릭 함수
     * 타입 체킹 및 제약조건 부여
     * */
    class Account<T>
    {
        tag:T
    }

    let a1 = new Account<string>();
    a1.tag = "안녕하세요";
    console.log(a1.tag);

    let a2 = new Account<number>();
    a2.tag = 2222;
    console.log(a2.tag);

    let a3 = new Account<boolean>();
    a3.tag = true;
    console.log(a3.tag);

    //Array클래스의 제네릭버젼은 Array<T>형태로 표현



    //클래스<T>형태로 제네릭 클래스 만들기
    class Cup<T> {
        public Content!: T;
    }

    //형식 매개변수 T에 string전달하여 문자열 저장하는 속성 생성
    let text = new Cup<string>();
    //text.Content = 1234;    //안됨
    text.Content = "aaaaa";

    let int = new Cup<number>();
    //int.Content = "111";        //에러
    int.Content = 2222;

    console.log(`${text.Content} ${int.Content}`)
    
}
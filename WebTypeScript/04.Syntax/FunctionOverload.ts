
// 함수(메서드) 오버로드( overload ) :다중정의/여러번 정의/중복
module FunctionOverloadDemo {

    //함수 시그니쳐 선언부
    function multi(name: string): void;
    function multi(age: number): void;

    //함수 내용 구현부분
    function multi(sender: (string | number)): void {
        switch (typeof sender) {
            case "string":
                console.log(`이름 : ${sender}`);
                break;
            case "number":
                console.log(`나이 : ${sender}`);
                break;
        }
    }

    multi("홍길동");
    multi(21);
}
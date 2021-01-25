// 함수(메서드) 오버로드( overload ) :다중정의/여러번 정의/중복
var FunctionOverloadDemo;
(function (FunctionOverloadDemo) {
    //함수 내용 구현부분
    function multi(sender) {
        switch (typeof sender) {
            case "string":
                console.log("\uC774\uB984 : " + sender);
                break;
            case "number":
                console.log("\uB098\uC774 : " + sender);
                break;
        }
    }
    multi("홍길동");
    multi(21);
})(FunctionOverloadDemo || (FunctionOverloadDemo = {}));
//# sourceMappingURL=FunctionOverload.js.map
var LiteralType;
(function (LiteralType) {
    var language;
    //오류남 리터럴로 지정된 값만 들어올수 있음.
    //language = "AA";
    language = "TypeScript";
    console.log(language);
    // Ctrl - space하면 입력할수있는 값이 보임.
    var languages;
    languages = "C#";
    console.log(languages);
    //version에 입력될수 있는 값을 지정한다.
    var version;
    version = 6;
    var twoTypes;
    twoTypes = "공용 구조체 형식";
    console.log(twoTypes);
    twoTypes = 1;
    console.log(twoTypes);
    //let ts: TechType = "Javascript";      등록안됨
    var ts = "TypeScript"; //ts변수는 TechType형이다.
    //let pt: PrimitiveType = new Date();   //에러발생
})(LiteralType || (LiteralType = {}));
//# sourceMappingURL=LiteralType.js.map
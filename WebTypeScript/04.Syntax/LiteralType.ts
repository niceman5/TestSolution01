namespace LiteralType {
    let language: "TypeScript"; 

    //오류남 리터럴로 지정된 값만 들어올수 있음.
    
    //language = "AA";
    language = "TypeScript";
    console.log(language);


    // Ctrl - space하면 입력할수있는 값이 보임.
    let languages: "TypeScript" | "C#";
    languages = "C#"

    console.log(languages);

    //version에 입력될수 있는 값을 지정한다.
    let version: 4 | 8 | 6;
    version = 6;

    let twoTypes: string | number;
    twoTypes = "공용 구조체 형식";
    console.log(twoTypes);

    twoTypes = 1;
    console.log(twoTypes);

    //twoTypes = true;      //이건 에러남

    //리터럴정의 선언. 해당 선언으로 변수정의에 사용함 -> 형식별칭    
    type TechType = "TypeScript" | "C#" | ".CORE";

    //let ts: TechType = "Javascript";      등록안됨
    let ts: TechType = "TypeScript";        //ts변수는 TechType형이다.


    type PrimitiveType = string | number | boolean;
    //let pt: PrimitiveType = new Date();   //에러발생

}
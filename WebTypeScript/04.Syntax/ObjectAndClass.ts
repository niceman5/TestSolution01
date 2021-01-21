namespace ObjectAndClassDemo {

    // 개체와 클래스 비교
    //1 object :개체 리터럴
    const todo1 = { id:undefined, title: undefined, isDone:undefined };
    console.log(`${todo1}`);        //[object Object]
    console.log(`${todo1.id} - ${todo1.title} - ${todo1.isDone}`);

    //2클래스선언 및 클래스의 인스턴스 생성
    //2-1클래스 선언
    export class TodoClass {
        id;
        title;
        isDone;
    }
    //2-2클래스 인스턴스 생성 : 설계도인 클래스로 부터 개체 하나 생성
    const todo2 = new TodoClass();
    console.log(`${todo2.id} - ${todo2.title} - ${todo2.isDone}`);
}2
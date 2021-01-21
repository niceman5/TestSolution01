namespace interfaceDemo {

    // typescript의 장점...묶어서 관리 가능...
    interface Friend {
        name: string,
        color?: string,     //null가능 형식 ? nullable
        age?:number
    }


    function add(friend: Friend) {
        let name = friend.name;
        let color = friend.color;
        let age = friend.age;

        console.log(`name=${name} color=${color} age=${age}`);
    }


    add({ name: "가나다" });
    add({ name: "가나다", color: "red" });
    add({ name: "가나다", color: "red", age: 22 });

    // add({ color: "blue" });  에러남 필수항목이 없어서

}


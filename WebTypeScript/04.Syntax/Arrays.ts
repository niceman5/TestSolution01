var nums = new Array(1, 2, 3, 5, 4);

for (let num of nums) {
    console.log(num);
}


//현재 같은 레벨의 ts파일들간 변수가 같은 변수명 사용하는지 체크하고 있음
//이걸 피하려면 별도 namespace로 묶어야 함
//문자열은 그 자체로 문자 배열로 사용할수 있음.

var aaaa: string = "TSC";
console.log(aaaa[0]);
console.log(aaaa[1]);
console.log(aaaa[2]);


namespace ArrayString {
    var aaaa: string = "ABC";
    console.log(aaaa[0]);
    console.log(aaaa[1]);
    console.log(aaaa[2]);

    //string에서 직접 접근 가능
    console.log("KIM"[0]);
    console.log("KIM"[1]);
    console.log("KIM"[2]);

    console.log(typeof "KIM");
    console.log(typeof "KIM"[0]);

    //이런 할당방식을 구조파과 할당.구조 분해 할당이라고 함. ts만 됨....
    var arr = [11, 22, 33, 44];
    var [d, e, f,g, h] = arr;
    console.log(d);
    console.log(e);
    console.log(f);
    console.log(g);
    console.log(h);     //undefined

    var [aa, bb, cc] = ["aaa", 999, true];
    console.log(aa);
    console.log(bb);
    console.log(cc);

    function ff() {
        let index = 0;
        for (var i = 0; i < 10; i++) {
            //let으로 선언시 위의 index와 다른 변수임....블럭내 로컬 변수가 됨. let 사용 추천.
            let index = "aaa";
            index += "def";
        }
    }

    console.log("indexer테스트");
    let cars = ["AAA", "BBB", "CCC"];

    //index값만 가져올때...
    for (let key in cars) {
        console.log(`${key} - ${cars[key]}`);
    }
    //배열에서 값을 가져올때
    for (let value of cars) {
        console.log(`${value}`);
    }
}

console.log(aaaa);
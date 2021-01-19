var nums = new Array(1, 2, 3, 5, 4);
for (var _i = 0, nums_1 = nums; _i < nums_1.length; _i++) {
    var num_1 = nums_1[_i];
    console.log(num_1);
}
//현재 같은 레벨의 ts파일들간 변수가 같은 변수명 사용하는지 체크하고 있음
//이걸 피하려면 별도 namespace로 묶어야 함
//문자열은 그 자체로 문자 배열로 사용할수 있음.
var aaaa = "TSC";
console.log(aaaa[0]);
console.log(aaaa[1]);
console.log(aaaa[2]);
var ArrayString;
(function (ArrayString) {
    var aaaa = "ABC";
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
    var d = arr[0], e = arr[1], f = arr[2], g = arr[3], h = arr[4];
    console.log(d);
    console.log(e);
    console.log(f);
    console.log(g);
    console.log(h); //undefined
    var _a = ["aaa", 999, true], aa = _a[0], bb = _a[1], cc = _a[2];
    console.log(aa);
    console.log(bb);
    console.log(cc);
    function ff() {
        var index = 0;
        for (var i = 0; i < 10; i++) {
            //let으로 선언시 위의 index와 다른 변수임....블럭내 로컬 변수가 됨. let 사용 추천.
            var index_1 = "aaa";
            index_1 += "def";
        }
    }
})(ArrayString || (ArrayString = {}));
console.log(aaaa);
//# sourceMappingURL=Arrays.js.map
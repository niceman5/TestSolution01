// 멤버변수 및 메서드를 묶어서 관리.

namespace Devlec {
    var _name = "데브렉";

    //export가 있어야 외부에서 접근 가능.
    export var _url = "http://www.aaa.com"
    export function GetKoreaName() {
        return _name;
    }
}

namespace DevlecDemo {
    export var url: string;
    export var name: string;
}
console.log(Devlec.GetKoreaName());
console.log(Devlec._url);

DevlecDemo.url = "poe.com";
DevlecDemo.name = "1111";

console.log(DevlecDemo.url);
console.log(DevlecDemo.name);
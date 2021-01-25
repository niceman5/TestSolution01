// 멤버변수 및 메서드를 묶어서 관리.
var Devlec;
(function (Devlec) {
    var _name = "데브렉";
    //export가 있어야 외부에서 접근 가능.
    Devlec._url = "http://www.aaa.com";
    function GetKoreaName() {
        return _name;
    }
    Devlec.GetKoreaName = GetKoreaName;
})(Devlec || (Devlec = {}));
var DevlecDemo;
(function (DevlecDemo) {
})(DevlecDemo || (DevlecDemo = {}));
console.log(Devlec.GetKoreaName());
console.log(Devlec._url);
DevlecDemo.url = "poe.com";
DevlecDemo.name = "1111";
console.log(DevlecDemo.url);
console.log(DevlecDemo.name);
//# sourceMappingURL=NamespaceTest.js.map
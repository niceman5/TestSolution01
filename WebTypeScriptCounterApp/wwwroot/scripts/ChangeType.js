"use strict";
// 같은 프로젝트내 typescript를 인식하고 사용한다.
var ChangeType;
(function (ChangeType) {
    ChangeType[ChangeType["Increment"] = 1] = "Increment";
    ChangeType[ChangeType["Update"] = 0] = "Update";
    ChangeType[ChangeType["Decrement"] = -1] = "Decrement";
})(ChangeType || (ChangeType = {}));
;

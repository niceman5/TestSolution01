"use strict";
//[1]HTML 페이지의 특정 div tag에 HTML출력
/*export*/ var HtmlWriter = /** @class */ (function () {
    function HtmlWriter(divHtml) {
        this.divHtml = divHtml;
        if (this.divHtml !== null) {
            this.divHtml.innerHTML = "<h2>구독자 카운터 앱</h2>";
        }
    }
    HtmlWriter.prototype.write = function (html) {
        if (this.divHtml !== null) {
            this.divHtml.innerHTML = html;
        }
    };
    return HtmlWriter;
}());

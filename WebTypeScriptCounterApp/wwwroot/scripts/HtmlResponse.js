"use strict";
//[1]HTML 페이지의 특정 div tag에 HTML출력
/*export*/ var HtmlResponse = /** @class */ (function () {
    function HtmlResponse() {
        //Empty
    }
    HtmlResponse.write = function (html) {
        if (HtmlResponse) {
        }
        if (HtmlResponse.divHtml !== null) {
            HtmlResponse.divHtml.innerHTML = html;
        }
    };
    return HtmlResponse;
}());

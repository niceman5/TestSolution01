
//[1]HTML 페이지의 특정 div tag에 HTML출력
/*export*/ class HtmlResponse {
    private constructor() {     //생성자를 통해 생성할 필요가 없어 private로 함.
        //Empty
    }
    static divHtml: HTMLDivElement |  null;
    static write(html: string) {
        if (HtmlResponse ) {

        }
        if (HtmlResponse.divHtml !== null) {
            HtmlResponse.divHtml.innerHTML = html;
        }
    }
}
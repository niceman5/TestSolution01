namespace LocalAndGlobal {
    class VariableScope {
        globalVariable: string = "[2]전역변수";     //필드 또는 멤버 변수

        render(): void {
            //[1] 지역변수
            let localVariable: string = "[1]지역 변수";     //render에서만 유효함. 속성
            console.log(localVariable);
            //2-1
            console.log(this.globalVariable);
            //2-2
            this.test();
        }

        test(): void {
            console.log(this.globalVariable);
            
        }
    }

    const t = new VariableScope();
    t.render();

    class Say {
        //1 필드(멤버변수)
        private message: string = "안녕하세요1!";    //필드 이니셜라이져

        //2 메서드
        public hi(): void {
            this.message = "반갑습니다.";
            console.log(this.message);
        }

    }

    const say = new Say();
    // say.message  private속성이라 접근이 안됨.
    say.hi();       //public이라 외부에서 접근 가능함.

}
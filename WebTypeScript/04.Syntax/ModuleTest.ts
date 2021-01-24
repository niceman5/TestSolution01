/*
 * 변수, 인터페이스, 클래스등을 묶어서 캪슐화
 *  - C#/java의 namespace/package와 같은 개념
 *      - System.Data, System.IO등
 *  - 서브시스템으로 코드를 조직화
 *  - module키워드로 생성
 * Internal모둘과 External모듈로 구분됨
 *  - export키워드로 모듈내에 선언된 멤버를 모듈 밖에서도 public하게 사용 가능하도록 설정
 * 하나의 모듈을 서로 다른 파일로 분리 가능
 * 컴파일후 하나로 통합 가능
 * 외부 라이브러리 사용 가능 
 * 하나의 스코프로 묶음 가능
 * 
 * 
 * 
 * 
 * module Drivers {
 *  export class BasePerson implements Person{}
 *  export class CarDriver extends BasePerson {}
 * }
 * 
 * // 사용예
 * var someDriver = new Driver.CarDriver(...) {}
 * 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidation;
using FluentValidation.Results;

namespace ConsoleFluentValidation
{
    /*
     * FluentValidation 테스트
     * 각종 제한 조건을 쉽게 체크할수 있음
     * 
     * https://docs.fluentvalidation.net/en/latest/index.html
     * 
     * DataAnotation보다 복잡한 체크조건 설정 가능하다.
     * 
     * */
    class Program
    {
        static void Main(string[] args)
        {
            //기본 FluentValidation  
            //BasicTest01 b1 = new BasicTest01();
            //b1.Run();
            CasCadeTest01 c1 = new CasCadeTest01();
            c1.Run();
        }
    }
}

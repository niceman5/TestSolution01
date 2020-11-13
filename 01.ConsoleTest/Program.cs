using System;
using Npgg;
using System.Configuration;
using System.Security.Cryptography;
using System.Threading;

namespace _01.ConsoleTest
{
    class Program
    {

        static void Main(string[] args)
        {
            ////칼라 콘솔 출력
            //var ctt = new ConsoleTableTest();
            //ctt.ConsoleTablePrint();

            //// App.config설정
            //var at = new AppTest();
            //at.AppSetPrint();

            // thread사용
            var tt = new ThreadTest();
            tt.ThreadPrint();

            //var dt = new _04DapperTest();
            //dt.Execute();
        }
    }
}

using System;
using Npgg;
using System.Configuration;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;

namespace _01.ConsoleTest
{
    class Program
    {
        private static async Task count()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                await Task.Delay(1000);
            }
        }

        static void Main(string[] args)
        {
            ////칼라 콘솔 출력
            //var ctt = new ConsoleTableTest();
            //ctt.ConsoleTablePrint();

            //// App.config설정
            //var at = new AppTest();
            //at.AppSetPrint();

            // thread사용
            //var tt = new ThreadTest();
            //tt.ThreadPrint();

            //var dt = new _04DapperTest();
            //dt.Execute();


            //var aa = new _05asyncawait01();

            //var a = count();
            //var b = count();
            //var c = count();
            //Task.WaitAll(a, b, c);

            //var t = new _06LinqTest01();
            //t.Run();

            var t = new _06LinqTest02();
            t.Run();
        }
    }
}

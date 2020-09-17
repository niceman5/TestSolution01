using System;
using System.Threading;

namespace ConsoleEventHandler
{
    class Program
    {
        public event EventHandler Event1;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Program program = new Program();
            // 이벤트를 등록시켜줌....해당 이벤트 실행시 실행된 메서드 연결
            program.Event1 += EventHandler1;

            Thread.Sleep(5000);
            program.EventStart();
        }

        private static void EventHandler1(object sender, EventArgs e)
        {
            Console.WriteLine("이벤트 핸들러가 동작됨.......");
        }

        private void EventStart()
        {
            Console.WriteLine("이벤트를 발생시킵니다.");
            // 이벤트를 강제 발생
            Event1(this, EventArgs.Empty);
        }
    }
}

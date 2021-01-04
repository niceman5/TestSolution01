using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _01.ConsoleTest
{
    class _99일반테스트_책내용
    {
        public void Q100Page()
        {
            /// ++ 기호만 옮겨서 결과가 4가 나오게 
            int a = 0;
            for (; ; )
            {
                //if (a > 3 && a++ < 5) 
                //    Console.WriteLine(a);
                //if (a > 9)
                //    break;
                if (a > 3 && a < 5)
                    Console.WriteLine(a);
                if (a++ > 9)
                    break;

            }
        }
        public void Q99Page() 
        {
            //1초마다 match가 출력되게 
            for(; ;)
            {
                //var next = DateTime.Now.AddSeconds(1);
                //for (; ; )
                //{                    
                //    if (next == DateTime.Now)
                //    {
                //        Console.WriteLine("match!");
                //        continue;
                //    }
                //}
                var next = DateTime.Now.AddSeconds(1);
                for (; ; )
                {                    
                    if (next <= DateTime.Now)
                    {
                        Console.WriteLine("match!");
                        continue;
                    }
                }
            }
        }
    }
}

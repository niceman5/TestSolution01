using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace _01.ConsoleTest
{
    class PerfCheck
    {
        public void Run()
        {
            TestString();
            TestStringBuilder();
        }

        private void TestString()
        {
            Stopwatch sw = new Stopwatch();

            sw.Start(); 
            string s = string.Empty;

            for (int i = 0; i < 10000 ; i++)
            {
                s += i.ToString();
            }

            sw.Stop();
            var elapsed = sw.ElapsedMilliseconds;
            Console.WriteLine(s.Length);
            Console.WriteLine(MethodBase.GetCurrentMethod().Name + ":" + elapsed);
        }

        private void TestStringBuilder()
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 10000; i++)
            {
                sb.Append(i.ToString());
            }

            sw.Stop();
            var elapsed = sw.ElapsedMilliseconds;
            Console.WriteLine(sb.ToString().Length);
            Console.WriteLine(MethodBase.GetCurrentMethod().Name + ":" + elapsed);
        }
    }
}

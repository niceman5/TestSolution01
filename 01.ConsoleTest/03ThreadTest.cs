using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace _01.ConsoleTest
{
    class ThreadTest
    {
        public Thread worker = null;

        public void ThreadPrint()
        {
            try
            {
                ThreadStart start = new ThreadStart(Working);
                worker = new Thread(start);
                worker.Start();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Working()
        {
            while (true)
            {
                string path = "C:\\Logs\\sample.txt";

                using (StreamWriter w = new StreamWriter(path, true))
                {
                    w.WriteLine($"window service is call on {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss tt")}");
                }
                Thread.Sleep(1000 * 5);     //5초간
            }
        }

    }
}

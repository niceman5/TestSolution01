using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using Serilog;

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
            string path = "C:\\Logs\\sample.txt";
            Log.Logger = new LoggerConfiguration()
                              .MinimumLevel.Debug()
                              .WriteTo.Console()
                              .WriteTo.File(path + "\\log-{Date}.log",
                                  outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                              .CreateLogger();

            while (true)            
            {

                Log.Information("Log Write");
                
                Thread.Sleep(1000 * 5);     //5초간
            }
        }

    }
}

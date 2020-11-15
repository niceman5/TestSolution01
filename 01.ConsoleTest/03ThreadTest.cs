using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using Serilog;

namespace _01.ConsoleTest
{
    class sampleClass
    {
        public int pk { get; set; }
        public string id { get; set; }
    }


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
            string path = "C:\\Logs\\LogSample";
            Log.Logger = new LoggerConfiguration()
                              .MinimumLevel.Debug()
                              .WriteTo.Console()
                              .WriteTo.File(path + "\\test.log",
                                  rollingInterval:RollingInterval.Day,          //test20201120.log 날짜 형식으로 로그 남김  파일명사이에 일자를 넣음
                                  retainedFileCountLimit:30,                    // 로그 파일 갯수 기본 31개 null 옵션 가능
                                  outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                              .CreateLogger();


            for (int i = 0; i < 50; i++)
            {
                Log.Information("Log Write Log Count : {i}", i);
            }

            // Json 형식으로도 로그 가능. class의 내용을 다 찍어줌.
            sampleClass dataModel = new sampleClass() { pk = 1, id = "wolfre" };
            var testValue = 35;
            Log.Information("Schema {@A} in {@B}", dataModel, testValue);
            


            //while (true)            
            //{
            //    Log.Information("Log Write");                
            //    Thread.Sleep(1000 * 5);     //5초간
            //}
        }

    }
}

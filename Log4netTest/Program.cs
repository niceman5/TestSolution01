using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerilogtTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Warning()
                .WriteTo.Console()
                .WriteTo.File("log.txt",
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                .CreateLogger();

            Log.Debug("Debug 오류 수정위해 기록");            
            Log.Information("Information Hello. Serilog!!!");
            Log.Warning("Warning 경고");
            Log.Error("Error 에러입니다. 에러 기록");
            Log.Fatal("Fatal 치명적");

            Program.test01();

            Log.CloseAndFlush();

            //Console.ReadLine();
            
        }

        public static void test01()
        {
            Console.WriteLine("Aaa");
            Log.Error("AAAAAA");
        }
    }
}

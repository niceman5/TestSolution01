using System;
using System.IO;
using System.Text;

namespace Util
{   

    public static class Logger
    {
        public enum LOG_TYPE 
        {
            ALERT,
            SYSTEM,
            WARNING
        }

        // 여러군데서 접근하기 때문에 내용이 깨지지 않게 하려면 필요함
        private static object locker = new object();

        public const string LOG_DIR = @"logs\";
        public const string LOG_EXIT = ".log";


        /// <summary>
        /// 로그를 기록할 폴더가 존재하는지 확인하고 없으면 생성한다.
        /// </summary>
        private static void CheckDirExists()
        {
            if (!Directory.Exists(LOG_DIR))
            {
                Directory.CreateDirectory(LOG_DIR);
            }
        }

        // 인라인함수로 구현가능 
        // private static string LogStamp() => $"[{DateTime.Now.ToString("HH:mm:ss")}]";
        private static string LogStamp()
        {
            return $"[{DateTime.Now.ToString("yyyy-MM-dd")} {DateTime.Now.ToString("HH:mm:ss.fff")}]";
        }

        private static string FileStamp() => $"{DateTime.Now.ToString("yyyy-MM-dd")}{LOG_EXIT}";



        public static void Log(string logStr, LOG_TYPE type = LOG_TYPE.ALERT)
        {
            // [HH:MM:SS.fff] (ALERT:SYSTEM:WARNING) 시간 템플릿/구분을 찍고 로그를 찍는다.
            // 파일명 yyyy-MM-dd.log
            
            CheckDirExists();

            lock (locker)
            {
                using (var writer = new StreamWriter($"{LOG_DIR}{FileStamp()}", true, Encoding.UTF8))
                {
                    writer.WriteLine($"{LogStamp()} {type.ToString()} : {logStr}");                    
                }
            }

        }

    }
}

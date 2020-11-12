using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace _01.ConsoleTest
{
    class AppTest
    {
        public void AppSetPrint() 
        {
            var ThreadTime = Convert.ToInt32(ConfigurationSettings.AppSettings["ThreadTime"]);
            var ServerIP = ConfigurationSettings.AppSettings["ServerIP"];
            var ServerPort = ConfigurationSettings.AppSettings["ServerPort"];

            var appSettings = ConfigurationSettings.AppSettings;

            Console.WriteLine($"appSettings count = {appSettings.Count}");
            foreach (var key in appSettings.AllKeys)
            {
                Console.WriteLine($"key : [{key}] value : [{appSettings[key]}]");
            }

            Console.WriteLine(ThreadTime);
            Console.WriteLine(ServerIP);
            Console.WriteLine(ServerPort);
        }
    }
}

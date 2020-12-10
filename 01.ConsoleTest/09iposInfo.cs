using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace _01.ConsoleTest
{
    /// <summary>
    /// IP와 OS정보 Test
    /// </summary>
    class _09iposInfo
    {
        public void Run() 
        {
            string localIp = "";

            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());            
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIp = ip.ToString();
                }
            }
            Console.WriteLine(localIp);

            OperatingSystem os = Environment.OSVersion;
            /*
             * 
             * 
            Win32NT
            6.2.9200.0
            Microsoft Windows NT 6.2.9200.0
            Microsoft Windows NT 6.2.9200.0
            3.1.9
            김태훈
            DESKTOP-N3RMADT
            */
            Console.WriteLine(os.Platform);            
            Console.WriteLine(os.Version);
            Console.WriteLine(os.VersionString);
            Console.WriteLine(os.ToString());
            Console.WriteLine(Environment.Version.ToString());
            Console.WriteLine(Environment.UserName);
            Console.WriteLine(Environment.UserDomainName);

        }
    }
}

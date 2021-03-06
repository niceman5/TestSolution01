﻿using System;
using System.ComponentModel;
using System.IO;
using System.ServiceProcess;
using System.Threading;

namespace _02.WinServiceTest
{
    [RunInstaller(true)]
    public partial class Service1 : ServiceBase
    {

        public Thread worker = null;

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                ThreadStart start = new ThreadStart(Working);
                worker = new Thread(start);
                worker.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                
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

        protected override void OnStop()
        {
            try
            {
                if ((worker != null) & worker.IsAlive)
                {
                    worker.Abort();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

        }
    }
}

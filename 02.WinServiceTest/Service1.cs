using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Util;

namespace _02.WinServiceTest
{
    public partial class Service1 : ServiceBase
    {
        private System.Timers.Timer timer;
        private const string dirPath = @"C:\00.Dev\Log\";
        private const string filePath = dirPath + "win_log.txt";


        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
            Logger.Log("Service OnStart!!!");

            timer = new System.Timers.Timer(2000);
            timer.Elapsed += TimerAction;
            timer.Start();
        }   

        private void TimerAction(object sender, ElapsedEventArgs e)
        {
            Logger.Log("Log기록");
        }

        protected override void OnStop()
        {
            Logger.Log("Service OnStop!!!");
        }        
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33LayoutTest
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Table Layout써서 구분
            // Application.Run(new Form1());

            // 여라가지 Layout처리
            // Application.Run(new Form2());

            //Layout간 이벤트처리까지...
            Application.Run(new Form3());
        }
    }
}

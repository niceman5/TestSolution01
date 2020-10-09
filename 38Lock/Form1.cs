using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _38Lock
{
    public partial class Form1 : Form
    {
        Thread _T1;
        Thread _T2;

        object RoomLock = new object();

        int _iRoom1Count = 1;
        int _iRoom2Count = 1;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnRoom1_Click(object sender, EventArgs e)
        {
            lstRoom1.Items.Add(String.Format("Room 1 : {0} 예약", _iRoom1Count));

            //_T1 = new Thread( Run);
            //_T1.Start();

            //Thread에 파라메터를 넘길때 사용한다.
            _T1 = new Thread(new ParameterizedThreadStart(Run));
            _T1.Start(_iRoom1Count);

            _iRoom1Count++;
        }

        private void Run(object obj)
        {
            lock (RoomLock)
            {
                invokeFunction(lblLockStatus, string.Format("Room 1 : Player {0} 사용중", obj));                

                for (int i = 1; i <= 3; i++)
                {
                    // ui가 잠기지 않고 필요할때만 점유하게 한다.
                    if (InvokeRequired)
                    {
                        Invoke(new Action(delegate ()
                        {
                            lstResult.Items.Add( string.Format("Room 1 : Player {0} 진행 중 ....... {1}", obj, i) );
                            Refresh();      //UI갱신
                        }));
                    }
                    Thread.Sleep(1000);
                }

                invokeFunction(lblLockStatus, string.Format("Room 1 : Player {0} 사용완료", obj));
                Thread.Sleep(1000);
            }            
        }

        private void invokeFunction(Label obj, string str)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(delegate ()
                {
                    obj.Text = str;

                }));
            }
        }

        private void btnRoom2_Click(object sender, EventArgs e)
        {
            lstRoom2.Items.Add(String.Format("Room 2 : {0} 예약", _iRoom2Count));

            //_T2 = new Thread(Run2);
            //_T2.Start();

            _T2 = new Thread(new ParameterizedThreadStart(Run2));
            _T2.Start(_iRoom2Count);

            _iRoom2Count++;
        }


        private void Run2(object obj)
        {
            lock (RoomLock)
            {
                invokeFunction(lblLockStatus, string.Format("Room 2 : Player {0} 사용중", obj));

                for (int i = 1; i <= 3; i++)
                {
                    // ui가 잠기지 않고 필요할때만 점유하게 한다.
                    if (InvokeRequired)
                    {
                        Invoke(new Action(delegate ()
                        {
                            lstResult.Items.Add(string.Format("Room 2 : Player {0} 진행 중 ....... {1}", obj, i));
                            Refresh();      //UI갱신
                        }));
                    }
                    Thread.Sleep(1000);
                }

                invokeFunction(lblLockStatus, string.Format("Room 2 : Player {0} 사용완료", obj));
                Thread.Sleep(1000);
            }
        }
    }
}

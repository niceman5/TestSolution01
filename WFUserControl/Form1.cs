using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFUserControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "폼 타이틀";
            
            // Assembly의 정보를 가져온다.
            Version version = Assembly.GetEntryAssembly().GetName().Version;

            this.Text += " " + version.ToString();

            // 폼로드시 유저컨트롤이 올라간 판넬의 모든 컨트롤을 찾아서 그중에 사용자 컨트롤일경우 처리
            // 사용자 컨트롤의 이벤트와 OInfo_eventdelSender메서드를 연결한다. 델리게이트 이용해서
            // 사용자 컨트롤에서 이벤트를 받아 처리 하는 방식임.....중요함.
            foreach (var oControl in pMain.Controls)
            {
                if (oControl is UCInfo)
                {
                    UCInfo oInfo = oControl as UCInfo;
                    oInfo.eventdelSender += OInfo_eventdelSender;
                }
            }
        }

        private int OInfo_eventdelSender(object sender, string strText)
        {
            UCInfo oInfo = sender as UCInfo;

            lboxList.Items.Add(string.Format("{0}) {1}", oInfo.UserNo, strText));
            return 0;
        }
    }
}

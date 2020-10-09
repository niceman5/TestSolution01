using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33LayoutTest
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // ucCMenu.eColorSender += UcCMenu_eColorSender;

            ucCMenu.eActionColor += UcCMenu_eActionColor;

            ucPanelTop.eLableDoubleClikcHandler += UcPanelTop_eLableDoubleClikcHandler;
            ucPanelCenter1.eLableDoubleClikcHandler += UcPanelTop_eLableDoubleClikcHandler;
            ucPanelCenter2.eLableDoubleClikcHandler += UcPanelTop_eLableDoubleClikcHandler;
            ucPanelRight.eLableDoubleClikcHandler += UcPanelTop_eLableDoubleClikcHandler;
        }

        private void UcPanelTop_eLableDoubleClikcHandler(object sender, EventArgs e)
        {
            string strResult = ucCMenu.fButtonColorChange((ucPanel)sender);

            lstLog.Items.Add(strResult);
        }

        private void UcCMenu_eActionColor(object arg1, Color arg2)
        {
            Button obtn = arg1 as Button;

            string strPanelName = string.Empty;

            switch (obtn.Name)
            {
                case "btn1":
                    ucPanelTop.BackColor = arg2;
                    strPanelName = "Panel Top";
                    break;
                case "btn2":
                    ucPanelCenter1.BackColor = arg2;
                    strPanelName = "Panel Center1";
                    break;
                case "btn3":
                    ucPanelCenter2.BackColor = arg2;
                    strPanelName = "Panel Center2";
                    break;
                case "btn4":
                    ucPanelRight.BackColor = arg2;
                    strPanelName = "Panel Right";
                    break;
                default:
                    break;
            }

            string strResult = string.Format("선택:{0}, {1}의 색상을 {2}로 변경합니다.", obtn.Name, strPanelName, arg2.ToString());
            lstLog.Items.Add(strResult);
        }

        //private void UcCMenu_eColorSender(object oSender, Color color)
        //{            
        //}
    }
}

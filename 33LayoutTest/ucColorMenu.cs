using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;

namespace _33LayoutTest
{
    public partial class ucColorMenu : UserControl
    {
        // 1)Delegate Event선언
        public delegate void delColorSender(object oSender, Color color);
        public event delColorSender eColorSender;

        // 2)기본 EventHandler
        public event EventHandler oColorEventHandler;

        // 3)제네릭형태 delegate 사용
        public event Action<object, Color> eActionColor;


        public ucColorMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 판넬 클릭시 칼라선택창을 띄우고 커러 선택하게 한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pColor_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dialogResult = cDialogColor.ShowDialog();
            
            if(dialogResult == DialogResult.OK)
            {
                pColor.BackColor = cDialogColor.Color;
            }
        }

        private void ucColorMenu_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 5 ; i++)
            {
                // 버튼을 생성해서 추가
                Button obtn = new Button();
                obtn.Name = "btn" + i.ToString();
                obtn.Text = string.Format("P{0} 색상 변경", i);
                obtn.BackColor = Color.Gray;
                obtn.Margin = new Padding(10, 20, 0, 0);
                obtn.Size = new Size(100, 30);
                obtn.Click += Obtn_Click;

                flMenu.Controls.Add(obtn);
            }
        }

        private void Obtn_Click(object sender, EventArgs e)
        {
            // eColorSender(sender, pColor.BackColor);  //1번
            // oColorEventHandler(sender, e);           //2번
            eActionColor(sender, pColor.BackColor);     //3번
        }

        public string fButtonColorChange(ucPanel oPanel)
        {
            string strBtnName = string.Empty;
            string strResult = string.Empty;

            switch (oPanel.Name)
            {
                case "ucPanelTop":
                    strBtnName = "btn1";
                    break;
                case "ucPanelCenter1":
                    strBtnName = "btn2";
                    break;
                case "ucPanelCenter2":
                    strBtnName = "btn3";
                    break;
                case "ucPanelRight":
                    strBtnName = "btn4";
                    break;

                default:
                    break;
            }

            strResult = fBtnSearch(strBtnName, oPanel.BackColor, oPanel.Name);
            
            return strResult;
        }

        private string fBtnSearch(string strButtonName, Color color, string strPanelName)
        {
            string strResult = string.Empty;

            foreach (var item in flMenu.Controls)
            {
                if (item is Button)
                {
                    Button obtn = item as Button;

                    if ( obtn.Name.Equals(strButtonName))
                    {
                        obtn.BackColor = color;
                        strResult = string.Format("{0} Panel DoubleClick, {1}의 색상을 {2}로 변경함. ", strPanelName, strButtonName, color.ToString());
                        return strResult;
                    }
                }
            }

            return "";
        }


    }
}
 
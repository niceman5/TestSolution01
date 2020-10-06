using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFUserControl
{
    public partial class UCInfo : UserControl
    {
        // 이벤트를 사용할수 있게 하기 위해 델리게이트선언...
        public delegate int delEvent(object sender, string strText);    // delegate 선언
        public event delEvent eventdelSender;   // delegate event선언


        /// <summary>
        /// 사용자 정의 Property
        /// </summary>
        [Category("UserProperty"), Description("Image")]
        public Image UserFace
        {
            get{ return this.pboxFace.BackgroundImage;}
            set{this.pboxFace.BackgroundImage = value;}
        }

        [Category("UserProperty"), Description("No")]
        public string UserNo
        {
            get { return this.lblNo.Text; }
            set { this.lblNo.Text = value; }
        }

        [Category("UserProperty"), Description("현상범의 이름")]
        public string UserName
        {
            get { return this.lblName.Text; }
            set { this.lblName.Text = value; }
        }

        [Category("UserProperty"), Description("현상금")]
        public string UserGold
        {
            get { return this.lblGold.Text; }
            set { this.lblGold.Text = value; }
        }


        public UCInfo()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            // 모든 버튼에서 이걸 실행됨
            Button obtn = sender as Button;

            string strText = string.Empty;

            switch (obtn.Name)
            {
                case "btnReg":
                    this.BackColor = Color.Red;
                    strText = string.Format("{0}은 금액{1} 으로 수배중입니다.", lblName.Text, lblGold.Text);
                    break;
                case "btnIdel":
                    this.BackColor = Color.Yellow;
                    strText = string.Format("{0}은 수배중지 입니다.", lblName.Text);
                    break;
                case "btnCatch":
                    this.BackColor = Color.BlueViolet;
                    strText = string.Format("{0}은 잡혔습니다.", lblName.Text);
                    break;
                default:
                    break;
            }

            if (eventdelSender != null)
            {
                // 이벤트를 연결해준다. 이벤트를 넘겨준다. 발생시킨다
                eventdelSender(this, strText);
            }            

        }
    }
}

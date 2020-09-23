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

namespace WFDelegate1
{
    public partial class frmPizza : Form
    {
        public delegate int delPizzaComplete(string strResult, int iTime);
        public event delPizzaComplete eventdelPizzaComplete;    //delegate event선언
        //public event EventHandler

        public frmPizza()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // 현재 열린 폼 닫기...
            this.Close();
        }


        public void fPizzaCheck(Dictionary<string, int> dpOrder)
        {
            int iTotlaTime = 0;
            foreach (KeyValuePair<string, int> oOrder in dpOrder)
            {
                int iNowTime = 0;
                string strType = string.Empty;
                int iTime = 0;
                int iCount = oOrder.Value;

                switch (oOrder.Key)
                {
                    // 도우
                    case "오리지널":
                        iNowTime = 3000;
                        strType = "도우";                        
                        break;
                    case "씬":
                        iNowTime = 3500;
                        strType = "도우";
                        break;

                    // 엣지
                    case "리치골드":
                        iNowTime = 500;
                        strType = "엣지";
                        break;
                    case "치즈크러스트":
                        iNowTime = 400;
                        strType = "엣지";
                        break;

                    // 토핑
                    case "소세지":
                        iNowTime = 34;
                        strType = "토핑";
                        break;
                    case "감자":
                        iNowTime = 28;
                        strType = "토핑";
                        break;
                    case "치즈":
                        iNowTime = 40;
                        strType = "토핑";
                        break;
                         
                    default:
                        break;
                }

                iTime = iNowTime * iCount;
                iTotlaTime += iTime;
                lboxMake.Items.Add(string.Format("{0}) {1} : {2}초 ({3}초, {4}개)", strType, oOrder.Key, iTime, iNowTime, iCount));
             
                this.Refresh();         //화면 refresh  부하 많이 먹어서 안씀
                Thread.Sleep(1000);
            }

            int iRec = eventdelPizzaComplete("Pizza가 완성되었습니다.", iTotlaTime);
            lboxMake.Items.Add("-----------------");

            if (iRec == 0)
            {
                lboxMake.Items.Add("주문 완료 확인!!!");
            }
            else
            {
                lboxMake.Items.Add("제작시간 초과로 고객 반품!!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFDelegate1
{
    public partial class Form1 : Form
    {

        public delegate int delFuncDow_Edge(int i);
        public delegate int delFuncTopping(string strOrder, int iEa);

        public delegate T delFunc<T>(T i);
        public delegate object delFunc(object i);       //var object





        int _iTotlaPrice = 0;




        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            delFuncDow_Edge delDow = new delFuncDow_Edge(fDow);
            delFuncDow_Edge delEdge = new delFuncDow_Edge(fEdge);
            delFuncTopping delTopping = null;




            int iOrder = 0;
            int iEdgeOrder = 0;

            if (rdoDow1.Checked)
            {
                iOrder = 1;
            }
            else if (rdoDow2.Checked)
            {
                iOrder = 2;
            }
            // _iTotlaPrice = delDow(iOrder);


            if (rdoEdge1.Checked)
            {
                iEdgeOrder = 1;
            }
            else if (rdoEdge2.Checked)
            {
                iEdgeOrder = 2;
            }
            // _iTotlaPrice = delEdge(iEdgeOrder);

            //callback사용하는 방식으로...
            fCallBackDelegate(iOrder, delDow);
            fCallBackDelegate(iEdgeOrder, delEdge);

            if (chkTopping1.Checked)
            {
                // delTopping = new delFuncTopping(fTooping1);
                delTopping += fTooping1;
            }
            if (chkTopping2.Checked)
            {
                delTopping += fTooping2;
            }
            if (chkTopping3.Checked)
            {
                delTopping += fTooping3;
            }


            // 델리게이트 체인으로 함수들을 한번에 호출한다.
            delTopping("토핑", (int)numEa.Value);

            listBoxOrderAdd("--------------------------------------------------");
            listBoxOrderAdd(string.Format("전체 주문 가격은 {0} 원 입니다.", _iTotlaPrice));
        }

        #region
        /// <summary>
        /// 0:선택안함 1:오리지널  2:씬
        /// </summary>
        /// <param name="iorder"></param>
        /// <returns></returns>
        private int fDow(int iOrder)
        {
            string strOrder = string.Empty;
            int iPrice = 0;

            if (iOrder == 1)
            {
                iPrice = 10000;
                strOrder = string.Format("도우는 오리지널을 선택 하셨습니다. ({0})원", iPrice, ToString());
            }
            else if (iOrder == 2)
            {
                iPrice = 11000;
                strOrder = string.Format("도우는 씬을 선택 하셨습니다. ({0})원", iPrice, ToString());
            }
            else
            {
                strOrder = "도우를 선택하지 않았습니다.";
            }
            //lstOrder.Items.Add(strOrder);
            listBoxOrderAdd(strOrder);

            return _iTotlaPrice += iPrice;
        }

        /// <summary>
        /// 0:선택안함 1:리치골드  2:치즈크러스터
        /// </summary>
        /// <param name="iorder"></param>
        /// <returns></returns>
        private int fEdge(int iOrder)
        {
            string strOrder = string.Empty;
            int iPrice = 0;

            if (iOrder == 1)
            {
                iPrice = 1000;
                strOrder = string.Format("엣지는 리치골드를 선택 하셨습니다. ({0})원", iPrice, ToString());
            }
            else if (iOrder == 2)
            {
                iPrice = 2000;
                strOrder = string.Format("엣지는 치크크러스터를 선택 하셨습니다. ({0})원", iPrice, ToString());
            }
            else
            {
                strOrder = "엣지를 선택하지 않았습니다.";
            }
            //lstOrder.Items.Add(strOrder);
            listBoxOrderAdd(strOrder);

            return _iTotlaPrice += iPrice;
        }

        public int fCallBackDelegate(int i, delFuncDow_Edge dFunc)
        {
            return dFunc(i);
        }

        private int fTooping1(string Order , int iEa)
        {
            string strOrder = string.Empty;

            int iPrice = iEa * 500;

            strOrder = string.Format("소세지 {0} {1}개를 선택 하였습니다. : ({2}원 (1개 500원)", Order, iEa, iPrice);
            listBoxOrderAdd(strOrder);

            return _iTotlaPrice += iPrice;
        }

        private int fTooping2(string Order, int iEa)
        {
            string strOrder = string.Empty;

            int iPrice = iEa * 200;

            strOrder = string.Format("감자 {0} {1}개를 선택 하였습니다. : ({2}원 (1개 200원)", Order, iEa, iPrice);
            listBoxOrderAdd(strOrder);

            return _iTotlaPrice += iPrice;
        }

        private int fTooping3(string Order, int iEa)
        {
            string strOrder = string.Empty;

            int iPrice = iEa * 300;

            strOrder = string.Format("치즈 {0} {1}개를 선택 하였습니다. : ({2}원 (1개 300원)", Order, iEa, iPrice);
            listBoxOrderAdd(strOrder);

            return _iTotlaPrice += iPrice;
        }

        private void listBoxOrderAdd(string strOrder)
        {
            lstOrder.Items.Add(strOrder);
        }

        #endregion
    }
}

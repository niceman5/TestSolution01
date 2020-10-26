using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42.ListTest
{
    public partial class Form1 : Form
    {
        //List<string>    
        //List<int>

        // 메모리 설정 new List<object>(10) -> 안잡아도 상관없음
        List<object> oList = new List<object>();
            
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataAdd();
        }
        private void txtData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataAdd();
            }            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (numPosition.Value == -1)
            {
                oList.Remove(txtData.Text);
            }
            else
            {
                oList.RemoveAt( (int)numPosition.Value ); 
            }
            lstList.DataSource = oList.ToList<object>();
            lboxNoCreate();
            oList_DataDetail();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            List<object> ListChnage = new List<object>();
            ListChnage = oList.ConvertAll<object>(s => s.ToString().Replace(txtChangeOld.Text, txtChangeNew.Text) );

            lstChangeList.DataSource = ListChnage.ToList();

            oChnageList_DataDetail(ListChnage);
        }

        private void lboxNoCreate()
        {
            // list 생성하며서 해당 길이만큼 0으로 초기화 하는 코드. 실제 list를 등록시킨다. 
            List<int> iList = (Enumerable.Repeat(0, oList.Count).ToList<int>());

            // 줄번호........
            for (int i = 0; i < iList.Count; i++)
            {
                iList[i] = i + 1;
            }

            lstNo.DataSource = iList.ToList(); 
        }

        private void oList_DataDetail()
        {
            txtList.Text = null;

            int iListCount = oList.Count;
            int iListCapacity = oList.Capacity;
            
            //List의 값을 문자열로 해당 분리자로 연결해서 리턴한다.
            string strListData = string.Join(", ", oList);


            //StringBuilder sb = new StringBuilder();
            //sb.Append("icount : " +  iListCount.ToString() + "\\n\\r");

            //string st = string.Format("icount : {0} ", iListCount);

            string strListDetail = $@"
Capacity : {iListCapacity}

Count : {iListCount}

Data : {strListData}
";

            txtList.Text = strListDetail;
        }


        private void DataAdd()
        {
            if (numPosition.Value == -1)
            {
                oList.Add(txtData.Text);
            }
            else
            {
                oList.Insert((int)numPosition.Value, txtData.Text);
            }

            // foreach대신에 한번에 datasource에 list에 object를 설정.....아님 하나씩 넣는 프로세스 개발해야 함
            lstList.DataSource = oList.ToList<object>();
            lboxNoCreate();
            oList_DataDetail();

            txtData.Text = "";
        }

        private void oChnageList_DataDetail( List<object> oChnageList)
        {
            txtChnageList.Text = null;

            int iListCount = oList.Count;
            int iListCapacity = oList.Capacity;

            //List의 값을 문자열로 해당 분리자로 연결해서 리턴한다.
            string strListData = string.Join(", ", oList);


            //StringBuilder sb = new StringBuilder();
            //sb.Append("icount : " +  iListCount.ToString() + "\\n\\r");

            //string st = string.Format("icount : {0} ", iListCount);

            string strListDetail = $@"
Capacity : {iListCapacity}

Count : {iListCount}

Data : {strListData}
";

            txtChnageList.Text = strListDetail;
        }
    }
}

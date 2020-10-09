using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _36LinkedListSortedList
{
    public partial class Form1 : Form
    {
        SortedList<DateTime, string> slSchedule = new SortedList<DateTime, string>();
        Dictionary<DateTime, string> dSchedule = new Dictionary<DateTime, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            /*
            // LinkedList 사용법
            LinkedList<string> llList = new LinkedList<string>();

            // 리스트에 차례대로 추가함
            for (int i = 0; i < 10; i++)
            {
                llList.AddLast(i.ToString());
            }

            //중간에 삽입하기 위해서는 원하는 위치를 찾아야 함. "5"에 해당하는 노드위치가 들어감
            var findNode = llList.Find("5");
            llList.AddAfter(findNode, "New Value");
            */

            // 다중선택이 됨으로 시작일자를 구한다.
            DateTime dsDate = mcSchedule.SelectionStart;

            if (!slSchedule.ContainsKey(dsDate) )
            {
                slSchedule.Add(dsDate, txtSchedule.Text);

                //선택된 날짜를 진하게...다시 그리기 까지..
                mcSchedule.AddBoldedDate(dsDate);
                mcSchedule.UpdateBoldedDates();
            }

            lstSchedule.Items.Clear();

            foreach (KeyValuePair<DateTime, string> oitem in slSchedule)
            {
                lstSchedule.Items.Add(string.Format("{0} : {1}", oitem.Key.ToString("yyyy-MM-dd"), oitem.Value));
            }            

        }

        private void mcSchedule_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime dsDate = mcSchedule.SelectionStart;

            if (slSchedule.ContainsKey(dsDate))
            {
                txtSchedule.Text = slSchedule[dsDate];
            }
            else
            {
                txtSchedule.Text = "";
            }
        }
    }
}

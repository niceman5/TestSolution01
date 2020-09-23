using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTable01
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();     //학급들에 대한 정보를 가지고 있을 데이터 set

        public Form1()
        {
            InitializeComponent();
        }

                
        private void btnAppend_Click(object sender, EventArgs e)
        {
            bool bExistsTable = false;

            if (ds.Tables.Contains(cboClass.Text))
            {
                bExistsTable = true;
            }

            DataTable dt = null;


            if (!bExistsTable)
            {
                dt = new DataTable(cboClass.Text);
                DataColumn colName = new DataColumn("NAME", typeof(string));
                DataColumn colSex = new DataColumn("SEX", typeof(string));
                DataColumn colRef = new DataColumn("REF", typeof(string));

                dt.Columns.Add(colName);
                dt.Columns.Add(colSex);
                dt.Columns.Add(colRef);
            }
            else
            {
                dt = ds.Tables[cboClass.Text];
            }


            // row추가....
            DataRow row = dt.NewRow();
            row["NAME"] = txtName.Text;
            row["SEX"] = (rdoSexMan.Checked == true) ? "남자" : "여자";
            row["REF"] = txtRef.Text;

            //생성된 Row를 Table에 추가            

            //if (bExistsTalbe)
            //{
            //    ds.Tables.Remove(cboClass.Text);
            //    ds.Tables.Add(dt);
            //}

            if (bExistsTable)
            {
                ds.Tables[cboClass.Text].Rows.Add(row);
            }
            else
            {
                dt.Rows.Add(row);
                ds.Tables.Add(dt);
            }


            // 이벤트를 직접 호출 
            ViewRefresh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                foreach (DataRow row in ds.Tables[cboClass.Text].Rows)
                {
                    if (row["NAME"].Equals(txtName.Text))
                    {
                        row["SEX"] = (rdoSexMan.Checked == true) ? "남자" : "여자";
                        row["REF"] = txtRef.Text;

                    }
                }

                ViewRefresh();
            }
        }

        private void btnViewDataDelete_Click(object sender, EventArgs e)
        {
            // 여러개 선택 가능함
            int iSelRow = dgViewInfo.SelectedRows[0].Index;

            // 지운다.
            ds.Tables[cboClass.Text].Rows.RemoveAt(iSelRow);

            ViewRefresh();
        }

        private void cboViewClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewRefresh();
        }

        private void ViewRefresh()
        {
            dgViewInfo.DataSource = ds.Tables[cboViewClass.Text];

            foreach (DataGridViewRow oRow in dgViewInfo.Rows)
            {
                oRow.HeaderCell.Value = oRow.Index.ToString();
            }
            dgViewInfo.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }


    }
}

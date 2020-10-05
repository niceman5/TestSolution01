using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFException01
{
    public partial class Form1 : Form
    {
        Dictionary<string, Color> dColor = new Dictionary<string, Color>();
        Color oSelectColor = new Color();


        public Form1()
        {
            InitializeComponent();
        }

        private void pColor_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dRet = colorDialog1.ShowDialog();

            if (dRet == DialogResult.OK)
            {
                pColor.BackColor = colorDialog1.Color;
            }

            lblColor.Text = pColor.BackColor.ToString();
        }

        private void tbarAlpha_Scroll(object sender, EventArgs e)
        {
            pColor.BackColor = Color.FromArgb(tbarAlpha.Value, pColor.BackColor);
            lblColor.Text = pColor.BackColor.ToString();
        }

        private void btnColorSave_Click(object sender, EventArgs e)
        {
            try
            {
                Color oColor = pColor.BackColor;
                dColor.Add(oColor.ToString(), oColor);

                ListBoxRefres();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void ListBoxRefres()
        {
            try
            {
                lstColor.Items.Clear();

                foreach (string pKey in dColor.Keys)
                {
                    lstColor.Items.Add(pKey);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnColorDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstColor.SelectedItem != null && dColor.ContainsKey(lstColor.SelectedItem.ToString()))
                {
                    dColor.Remove(lstColor.SelectedItem.ToString());
                    ListBoxRefres();
                }
                else
                {
                    MessageBox.Show("삭제할 item이 없거나 키가 없습니다.");
                }

                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void lstColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //선택값 변경시...
            oSelectColor = dColor[(lstColor.SelectedItem.ToString()];
            pColor.BackColor = oSelectColor;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

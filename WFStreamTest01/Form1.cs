using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFStreamTest01
{
    public partial class Form1 : Form
    {
        CXMLControl _xml = new CXMLControl();
        Dictionary<string, string> _data = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfigSave_Click(object sender, EventArgs e)
        {
            string strText = this.tboxData.Text;
            bool bCheck = this.cboxData.Checked;
            int iNum = (int)this.numData.Value;

            StringBuilder sb = new StringBuilder();
            sb.Append(strText + Environment.NewLine);
            sb.Append(bCheck.ToString() + Environment.NewLine);
            sb.Append(iNum.ToString() + Environment.NewLine);

            tboxConfigData.Text = sb.ToString();

            // 일단 데이터 저장시 dict를 초기화 한다.
            _data.Clear();
            _data.Add(CXMLControl._TEXT_DATA, strText);
            _data.Add(CXMLControl._CBOX_DATA, bCheck.ToString());
            _data.Add(CXMLControl._NUMBER_DATA, iNum.ToString());
        }

        private void btnConfigRead_Click(object sender, EventArgs e)
        {
            string[] strConfig = tboxConfigData.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            tboxData.Text = strConfig[0];
            cboxData.Checked = bool.Parse(strConfig[1]);
            numData.Value = Int32.Parse(strConfig[2]);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string strFilePath = "";
            StringBuilder sb = new StringBuilder();

            OFDialog.InitialDirectory = Application.StartupPath;        //프로그램 실행 파일 위치.
            OFDialog.FileName = "*.txt";        // file save dialog에서 파일명
            OFDialog.Filter = "text files (*.txt)|*.txt|All Files(*.*)|*.*";    //파일 형식            

            if (OFDialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = OFDialog.FileName;
                using (StreamReader sr = new StreamReader(strFilePath, Encoding.UTF8, true))
                {
                    //파일 끝인지 확인.....
                    while (sr.EndOfStream == false)
                    {
                        sb.Append(sr.ReadLine() + Environment.NewLine);
                    }
                }
                tboxConfigData.Text = sb.ToString();


                // sb.Append( File.ReadAllText(strFilePath) );

                _data.Clear();
                _data = _xml.Xml_Reader(strFilePath);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strFilePath = "";

            SFDialog.InitialDirectory = Application.StartupPath;        //프로그램 실행 파일 위치.
            //SFDialog.FileName = "*.txt";        // file save dialog에서 파일명
            //SFDialog.Filter = "text files (*.txt)|*.txt|All Files(*.*)|*.*";    //파일 형식

            SFDialog.FileName = "*.xml";        // file save dialog에서 파일명
            SFDialog.Filter = "xml files (*.xml)|*.xml|All Files(*.*)|*.*";    //파일 형식

            if (SFDialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = SFDialog.FileName;

                //using (StreamWriter sw = new StreamWriter(strFilePath))
                //{
                //    sw.WriteLine(tboxConfigData.Text);
                //}


                // File.WriteAllText(strFilePath, tboxConfigData.Text);
                // string[] s = File.ReadAllLines(strFilePath);

                _xml.Xml_Writer(strFilePath, _data);
            }
        }
    }
}

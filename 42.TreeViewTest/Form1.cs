using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42.TreeViewTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Log(Log_Level.Info, "프로그램 시작합니다.");

            txtSource.Text = @"C:\00.Dev\VSTestProject\TestSolution01\42.TreeViewTest";
        }

        // TreeView 폴더 기준으로 노드 경로 가져온다/
        private void btnTreeLoad_Click(object sender, EventArgs e)
        {
            // 먼저 treeview를 초기화 하고 load한다
            tvLocation.Nodes.Clear();

            TreeViewLoadByPath(tvLocation, txtSource.Text);
        }

        private void TreeViewLoadByPath(TreeView tv, string path)
        {

            if (string.IsNullOrEmpty(txtSource.Text))
            {
                return;
            }

            DirectoryInfo rootDirInfo = new DirectoryInfo(path);

            // TreeNode tn = CreateDirNode(rootDirInfo);       //계층구조를 가지고 있는 노드를 만들어서 넣어 줘야 한다.
            // tv.Nodes.Add(tn);
            // 재귀호출 한다
            tv.Nodes.Add(CreateDirNode(rootDirInfo));            
        }

        private TreeNode CreateDirNode(DirectoryInfo dirInfo)
        {
            TreeNode dirNode = new TreeNode(dirInfo.Name);


            //directory정보
            foreach (var dir in dirInfo.GetDirectories())
            {
                dirNode.Nodes.Add(CreateDirNode(dir));
            }

            // file정보
            //foreach (var filename in dirInfo.GetFiles())
            //{
            //    dirNode.Nodes.Add(new TreeNode(filename.Name));
            //}

            return dirNode;
        }
        // 펼치기
        private void btnExtend_Click(object sender, EventArgs e)
        {
            // tvLocation.ExpandAll(); 다 펼치기

            if (tvLocation.SelectedNode != null)
            {
                // 선택한 노드 아래 펼치기
                tvLocation.SelectedNode.ExpandAll();
            }
        }

        // 접기
        private void btnCallapse_Click(object sender, EventArgs e)
        {
            // 다 접기
            tvLocation.CollapseAll();
        }

        private void tvLocation_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string strSelectPath = tvLocation.SelectedNode.FullPath;

            if (lstCommand.Items.Contains(strSelectPath))
            {
                MessageBox.Show("이미 등록된 데이터 입니다.");
                return;
            }

            lstCommand.Items.Add(strSelectPath);
        }

        // 삭제
        private void lstCommand_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstCommand.SelectedIndex != -1)
            {
                lstCommand.Items.RemoveAt(lstCommand.SelectedIndex);
            }            
        }

        // 폴더를 보여줌
        private void lstCommand_MouseClick(object sender, MouseEventArgs e)
        {
            // 파일경로 만들기...            
            string dirPath = SourcePath();

            if (dirPath == null)
            {
                return;
            }


            StringBuilder sb = new StringBuilder();

            if (Directory.Exists(dirPath))
            {
                DirectoryInfo di = new DirectoryInfo(dirPath);

                foreach (var directoty in di.GetDirectories())
                {
                    sb.Append($"[Folder] {directoty}" + Environment.NewLine);
                }

                // file정보
                foreach (var file in di.GetFiles())
                {
                    sb.Append($"    {file.Name}" + Environment.NewLine);
                }

                txtFile.Text = sb.ToString();
            }


        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string sourcePath = SourcePath();      //Source Folder Full Path 
            string destinationPath = $@"{txtDestination.Text}\{DateTime.Now:yyyyMMdd_hhmmss}";

            FileSystem.CopyDirectory(sourcePath, destinationPath, UIOption.AllDialogs);
        }

        private string SourcePath()
        {
            if (string.IsNullOrEmpty(txtSource.Text))
            {
                Log(Log_Level.Warning, "Source 경로가 입력되어 있지 않습니다." );
                return null;
            }


            // 파일경로 만들기...
            string root_path = txtSource.Text;       //root경로
            string last_path = Path.GetDirectoryName(root_path);
            string str_path = lstCommand.SelectedItem.ToString();
            string dirPath = $@"{last_path}\{str_path}";

            return dirPath;
        }

        // log 표기
        enum Log_Level
        {
            Info,           // 알림
            Warning,        // 경고
            Error           // 오류
        }

        private void Log( Log_Level eLevel, string logDesc)
        {
            DateTime dTime = DateTime.Now;

            // lstLog.Items.Add(dTime + eLevel.ToString() +" " +logDesc);

            // 2020-11-01 18:33:22.123 [info] 프로그램을 시작합니다.
            string Loginfo = $"{dTime:yyyy-MM-dd HH:mm:ss.fff} [{eLevel.ToString()}] {logDesc}";

            //lstLog.Items.Add(Loginfo);
            lstLog.Items.Insert(0, Loginfo);        //로그가 맨위부터 쌓임
        }
    }
}

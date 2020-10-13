using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebCrawling01
{
    public partial class Form1 : Form
    {
        // 복사해서 쓴다...공통 코드
        private ChromeDriverService _driverService = null;
        private ChromeOptions _options = null;
        private ChromeDriver _driver = null;
        //


        public Form1()
        {
            InitializeComponent();

            // 복사해서 쓴다...공통 코드
            _driverService = ChromeDriverService.CreateDefaultService();
            _driverService.HideCommandPromptWindow = true;

            _options = new ChromeOptions();
            _options.AddArgument("disable-gpu");
            //
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string pw = txtPW.Text;


            _driver = new ChromeDriver(_driverService, _options);
            _driver.Navigate().GoToUrl("www.daum.net");         // www.naver.com 웹싸이트 접속
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }
    }
}

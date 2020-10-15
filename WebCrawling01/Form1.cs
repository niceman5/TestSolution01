using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebCrawling01
{
    public partial class Form1 : Form
    {
        // 복사해서 쓴다...공통 코드
        // 크롬드라이버를 열기위한 설정들
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
            _driver.Navigate().GoToUrl("https://www.daum.net");         // www.naver.com 웹싸이트 접속
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // mouse 우클릭 copy - copy xpath 
            var element = _driver.FindElementByXPath("//*[@id='inner_login']/a[1]");        //로그인 버튼
            element.Click();

            // 페이지가 전환되는 동안 대기
            Thread.Sleep(3000);

            element = _driver.FindElementByXPath("//*[@id='id']");          // id입력
            element.SendKeys(id);

            element = _driver.FindElementByXPath("//*[@id='inputPwd']");    // pw입력
            element.SendKeys(pw);

            element = _driver.FindElementByXPath("//*[@id='loginBtn']");    // click
            element.Click();
        }


        List<string> lstSrc = null;       // image url
        int i = 0;                                      // 현재 배열 위치
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strUrl = "https://www.google.com/search?q=" + txtSearch.Text + "&source=lnms&tbm=isch";

            _driver = new ChromeDriver(_driverService, _options);            
            _driver.Navigate().GoToUrl(strUrl);         
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            _driver.ExecuteScript("window.scrollBy(0,10000)");      // 창을 띄우고 스크롤 진행(아래 스크롤 한거)

            lstSrc = new List<string>();

            foreach (IWebElement item in _driver.FindElementsByClassName("rg_i"))
            {
                if (item.GetAttribute("src") != null)
                {
                    lstSrc.Add(item.GetAttribute("src"));
                }
            }

            lblTotal.Text = string.Format("/ {0}", lstSrc.Count);

            this.Invoke(new Action(delegate ()
            {
                foreach (string strsrc in lstSrc)
                {
                    i++;
                    GetMapImage(lstSrc[i]);
                    txtGo.Text = i.ToString();
                    Refresh();
                    Thread.Sleep(50);
                }
            }));
        }

        private void GetMapImage(string base64String)
        {
            try
            {
                var base64Data = Regex.Match(base64String, @"data:image/(?<type>.*?),(?<data>.*)").Groups["data"].Value;
                var binData = Convert.FromBase64String(base64Data);

                using (var stream = new MemoryStream(binData))
                {
                    if (stream.Length == 0)
                    {
                        picMain.Load(base64String);
                        txtGo.Text = i.ToString();                        
                    }
                    else
                    {
                        var image = Image.FromStream(stream);
                        picMain.Image = image;
                    }
                    txtUrl.Text = base64String;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            // thread겹치지 말라고 
            this.Invoke(new Action(delegate ()
            {
                i--;

                GetMapImage(lstSrc[i]);
                txtGo.Text = i.ToString();
            }));
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            // thread겹치지 말라고 
            this.Invoke(new Action(delegate ()
            {
                Int32.TryParse(txtGo.Text, out i);
                GetMapImage(lstSrc[i]);
                txtGo.Text = i.ToString();
            }));
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // thread겹치지 말라고 
            this.Invoke(new Action(delegate ()
            {
                i++;
                GetMapImage(lstSrc[i]);
                txtGo.Text = i.ToString();
            }));
        }
    }
}

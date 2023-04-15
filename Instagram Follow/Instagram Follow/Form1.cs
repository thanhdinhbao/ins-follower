using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
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

namespace Instagram_Follow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            ChromeOptions ops = new ChromeOptions();
            ops.AddArguments("--disable-notifications");

            var driver = new ChromeDriver(driverService, ops);
            driver.Url = "https://app.mrinsta.com/login";
            driver.Navigate();
            //user
            string user = cbxUser.Text;
            var el1 = driver.FindElementByName("instagram_id");
            foreach (char u in user)
            {
                el1.SendKeys(u.ToString());
                Thread.Sleep(300);

            }
            //pass
            string pass = "";
            var el2 = driver.FindElementByName("password");
            el2.SendKeys(pass + OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(3000);
            driver.Url = "https://app.mrinsta.com/free-followers";
            driver.Navigate();
            Thread.Sleep(3000);
            try
            {
                for (int i = 0; i < 15; i++)
                {
                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    string title = (string)js.ExecuteScript("document.getElementsByClassName('btn btn-success')[0].click()");
                    Thread.Sleep(10000);
                }
            }
            catch(Exception)
            {

            }
            Thread.Sleep(1000);
            driver.FindElementByClassName("btn btn-outline-primary").Click();
            Thread.Sleep(10000);
            //ktra website
            string testURL = "https://www.mrinsta.com/free-followers-success/";
            string currentURL = driver.Url;
            if(currentURL == testURL)
            {
                MessageBox.Show("Thành công", "Instagram Auto Follower");
                driver.Close();
                driver.Quit();
            }
            else
            {
                MessageBox.Show("Thất bại, vui lòng thử lại!", "Instagram Auto Follower");
                driver.Close();
                driver.Quit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            ChromeOptions ops = new ChromeOptions();
            ops.AddArguments("--disable-notifications");

            var driver = new ChromeDriver(driverService, ops);
            driver.Url = "https://app.turbomedia.io/login";
            driver.Navigate();
            //user
            string user = cbxUser.Text;
            var el1 = driver.FindElementByName("instagram_id");
            foreach (char u in user)
            {
                el1.SendKeys(u.ToString());
                Thread.Sleep(300);

            }
            //pass
            string pass = "DBthanh26092004";
            var el2 = driver.FindElementByName("password");
            el2.SendKeys(pass + OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(3000);
            driver.Url = "https://app.turbomedia.io/free-followers";
            driver.Navigate();
            Thread.Sleep(3000);
            try
            {
                for (int i = 0; i < 15; i++)
                {
                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    string title = (string)js.ExecuteScript("document.getElementsByClassName('btn btn-success')[0].click()");
                    Thread.Sleep(10000);
                }
            }
            catch (Exception)
            {

            }
            Thread.Sleep(1000);
            driver.FindElementByCssSelector("#content > div > div > div > div > div.follow-profiles-list > div > form > button").Click();
            Thread.Sleep(10000);
            //ktra website
            string testURL = "https://www.turbomedia.io/free-followers-success/";
            string currentURL = driver.Url;
            if (currentURL == testURL)
            {
                MessageBox.Show("Thành công", "Instagram Auto Follower");
                driver.Close();
                driver.Quit();
            }
            else
            {
                MessageBox.Show("Thất bại, vui lòng thử lại!", "Instagram Auto Follower");
                driver.Close();
                driver.Quit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if(txtURL.Text == "".Trim())
            {
                MessageBox.Show("Chưa nhập URL Post!", "Instagram Auto Follower");
            }
            else
            {
                var driverService = ChromeDriverService.CreateDefaultService();
                driverService.HideCommandPromptWindow = true;
                ChromeOptions ops = new ChromeOptions();
                ops.AddArguments("--disable-notifications");

                var driver = new ChromeDriver(driverService, ops);
                driver.Url = "https://app.mrinsta.com/login";
                driver.Navigate();
                //user
                string user = cbxUser.Text;
                var el1 = driver.FindElementByName("instagram_id");
                foreach (char u in user)
                {
                    el1.SendKeys(u.ToString());
                    Thread.Sleep(300);

                }
                //pass
                string pass = "DBthanh26092004";
                var el2 = driver.FindElementByName("password");
                el2.SendKeys(pass + OpenQA.Selenium.Keys.Enter);
                Thread.Sleep(3000);
                driver.Url = "https://app.mrinsta.com/";
                driver.Navigate();
                Thread.Sleep(3000);
                driver.FindElementByName("url").SendKeys(txtURL.Text.Trim() + OpenQA.Selenium.Keys.Enter);
                Thread.Sleep(125000);
                string testURL = "https://mrinsta.com/free-likes-success/";
                string currentURL = driver.Url;
                if (currentURL == testURL)
                {
                    MessageBox.Show("Thành công", "Instagram Auto Follower");
                    driver.Close();
                    driver.Quit();
                }
                else
                {
                    MessageBox.Show("Thất bại, vui lòng thử lại!", "Instagram Auto Follower");
                    driver.Close();
                    driver.Quit();
                }
            }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtURL.Text == "".Trim())
            {
                MessageBox.Show("Chưa nhập URL Post!", "Instagram Auto Follower");
            }
            else
            {
                var driverService = ChromeDriverService.CreateDefaultService();
                driverService.HideCommandPromptWindow = true;
                ChromeOptions ops = new ChromeOptions();
                ops.AddArguments("--disable-notifications");
                var driver = new ChromeDriver(driverService, ops);
                driver.Url = "https://app.turbomedia.io/login";
                driver.Navigate();
                //user
                string user = cbxUser.Text;
                var el1 = driver.FindElementByName("instagram_id");
                foreach (char u in user)
                {
                    el1.SendKeys(u.ToString());
                    Thread.Sleep(300);

                }
                //pass
                string pass = "DBthanh26092004";
                var el2 = driver.FindElementByName("password");
                el2.SendKeys(pass + OpenQA.Selenium.Keys.Enter);
                Thread.Sleep(3000);
                driver.Url = "https://app.turbomedia.io/";
                driver.Navigate();
                Thread.Sleep(5000);
                var element = driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[2]/div[3]/div/div[3]/div/div/div/form/div[3]/a"));
                Actions actions = new Actions(driver);
                actions.MoveToElement(element);
                actions.Perform();
                element.Click();
                driver.FindElement(By.CssSelector("#content > div > div > div > div.dashboard-profile.w-100 > div.instagram-plans-list > div > div:nth-child(3) > div > div > div > form > div.form-group.submit-box > button"));
                driver.FindElementByName("url").SendKeys(txtURL.Text.Trim() + OpenQA.Selenium.Keys.Enter);
                Thread.Sleep(125000);
                string testURL = "https://turbomedia.io/free-likes-success/";
                string currentURL = driver.Url;
                if (currentURL == testURL)
                {
                    MessageBox.Show("Thành công", "Instagram Auto Follower");
                    driver.Close();
                    driver.Quit();
                }
                else
                {
                    MessageBox.Show("Thất bại, vui lòng thử lại!", "Instagram Auto Follower");
                    driver.Close();
                    driver.Quit();
                }

            }
        }
    }
}

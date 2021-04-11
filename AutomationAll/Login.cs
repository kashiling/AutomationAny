using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using System.Linq;

namespace AutomationAll
{
    public class Login
    {

        [Test]
        public void CheckPomogranateRate()
        {
            IWebDriver driver = new ChromeDriver();
            var url = ConfigurationSettings.AppSettings["URL"];
            driver.Url = url;
            // Implicit Wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            driver.Manage().Window.Maximize();
            var title = driver.Title;
            Assert.AreEqual("कृषि उत्पन्न बाजार समिती, पुणे", title);
            IWebElement DateLink = driver.FindElement(By.XPath("//*[@id='form1']/table/tbody/tr[4]/td/ul[2]/li[2]/a"));
            DateLink.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            IWebElement GetPomoogranteRowNumbe = driver.FindElement(By.XPath("//*[@id='form1']/table[4]/tbody/tr[100]/td[1]/strong"));
            System.Threading.Thread.Sleep(2000);
            var rownumber = GetPomoogranteRowNumbe.Text;
            Assert.AreEqual("4114", rownumber);
          
            // explicit wait


            //fluent wait


            driver.Quit();
        }


        [Test]
        public void DownloadFruitsRates()
        {

            IWebDriver driver = new ChromeDriver();
            var url = ConfigurationSettings.AppSettings["URL"];
            driver.Url = url;
            // Implicit Wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            driver.Manage().Window.Maximize();
            var title = driver.Title;
            Assert.AreEqual("???? ??????? ????? ?????, ????", title);



        }


    }


}

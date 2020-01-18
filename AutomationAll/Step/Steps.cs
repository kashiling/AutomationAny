using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using TechTalk.SpecFlow;

namespace AutomationAll
{
    [Binding]
    public class Steps
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"Open Google test")]
        public void GivenOpenGoogleTest()
        {
           // IWebDriver driver = new ChromeDriver();
            var url = ConfigurationSettings.AppSettings["URL"];
            driver.Url = url;
            // Implicit Wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            driver.Manage().Window.Maximize();
        }

        [Given(@"Close Browser")]
        public void GivenCloseBrowser()
        {
           driver.Quit();
        }



    }
}

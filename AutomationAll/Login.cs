using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;

namespace AutomationAll
{
    public class Login
    {

        [Test]
        public void check()
        {
            Console.WriteLine("Hi");
            IWebDriver driver = new ChromeDriver();
            var url = ConfigurationSettings.AppSettings["URL"];
            driver.Url = url;
            driver.Quit();
        }
    }
}

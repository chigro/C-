using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TemplateTestProject.BrowserlaunchTest
{
    [TestClass]
   public class LaunchBrowser
    {
        [TestMethod, TestCategory("SELENUIM TEST")]
        public void BrowserLaunch()
        {
            var baseUrl = "https://www.beslist.nl";

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(baseUrl);
            //driver.Close();
            Thread.Sleep(5000);
            driver.Quit();
        }

        [TestMethod, TestCategory("CONFIG")]
        public void Sample()
        {
            Console.WriteLine(ConfigurationManager.AppSettings.Get("Browser"));
           
        }
        [TestMethod, TestCategory("SECURITY")]

        public void Name()
        {
            Console.WriteLine(ConfigurationManager.AppSettings.Get("UserName"));
        }

            }
}          

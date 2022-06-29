using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Demosite.Utilities
{
    [Binding]
    public class BaseClass
    {
        public static IWebDriver driver;
        [BeforeScenario]
        public static void LaunchBrowser()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demosite.executeautomation.com/Login.html");
        }

        [AfterScenario]
        public static void CleanUp()
        {
            driver.Quit();
        }
    }
}
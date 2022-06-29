using Demosite.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demosite.CommonMethodObject
{
    public class LoginObject
    {
        public void VarifyHome()
        {
            IWebElement home;
            bool display = true;
            home = BaseClass.driver.FindElement(By.XPath("//span[.='Login']"));
            display = home.Displayed;
        }

        public void EnterName()
        {
            IWebElement username = BaseClass.driver.FindElement(By.XPath("//input[@name='UserName']"));
            username.SendKeys("Admin");
        }

        public void EnterPass()
        {
            IWebElement password = BaseClass.driver.FindElement(By.XPath("//input[@name='Password']"));
            password.SendKeys("Admin12");
        }

        public void LoginButton()
        {
            IWebElement loginbtn = BaseClass.driver.FindElement(By.XPath("//input[@name='Login']"));
            loginbtn.Click();
        }

        public void Demosite()
        {
            IWebElement Demo;
            bool display = true;
            Demo = BaseClass.driver.FindElement(By.XPath("//p[. = 'This is a demo website, which act as a mock site for trying out different automation tools']"));
            display = Demo.Displayed;
        }
    }
}
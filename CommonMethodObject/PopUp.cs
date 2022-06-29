using Demosite.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demosite.CommonMethodObject
{
    public class PopUp
    {
       

        public void Verify()
        {
            IWebElement Popup;
            bool display = true;
            Popup = BaseClass.driver.FindElement(By.XPath("//p[.='This is just a demo popup']"));
            display = Popup.Displayed;
           
        }

        public void clickHtml()
        {
            IWebElement html = BaseClass.driver.FindElement(By.LinkText("HtmlPopup"));
            html.Click();
        }
    }
}

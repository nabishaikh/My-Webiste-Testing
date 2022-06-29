using Demosite.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demosite.CommonMethodObject
{
    public class UserFormObject
    {
        
        public void VerifyForm()
        {
            IWebElement Form;
            bool display = true;
            Form = BaseClass.driver.FindElement(By.XPath("//p[.='This is a demo website, which act as a mock site for trying out different automation tools']"));
            display = Form.Displayed;
        }

        public void SelectTitle()
        {
            SelectElement title = new SelectElement(BaseClass.driver.FindElement(By.XPath("(//*[@id='TitleId']")));
            title.SelectByIndex(1);

        }

        public void EnterInitial()
        {
            IWebElement initial = BaseClass.driver.FindElement(By.XPath("//input[@name='Initial']"));
            initial.SendKeys("Shaikh");
        }

        public void EnterFirstName()
        {
            IWebElement FirstName = BaseClass.driver.FindElement(By.XPath("//input[@name='FirstName']"));
            FirstName.SendKeys("Nabi");
        }

        public void EnterMiddleName()
        {
            IWebElement MiddleName = BaseClass.driver.FindElement(By.XPath("//input[@name='MiddleName']"));
            MiddleName.SendKeys("Samsul");

        }

        public void SelectGender()
        {
            IWebElement gender = BaseClass.driver.FindElement(By.XPath("//input[@name='Male'"));
            gender.Click();
        }

        public void SelectLanguages()
        {
            IWebElement Languages = BaseClass.driver.FindElement(By.XPath("//input[@name='Hindi'"));
            Languages.Click();
        }

        public void SaveData()
        {
            IWebElement save = BaseClass.driver.FindElement(By.XPath("//input[@name='Save'"));
            save.Click();
        }

        public void GenerateBtn()
        {
            IWebElement generate = BaseClass.driver.FindElement(By.XPath("//input[@name='generate'"));
            generate.Click();
        }
         public void Alert()
        {
            IAlert alert = BaseClass.driver.SwitchTo().Alert();
            alert.Accept();
                
        }




    }
}
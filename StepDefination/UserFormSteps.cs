using Demosite.CommonMethodObject;
using System;
using TechTalk.SpecFlow;

namespace Demosite.StepDefination
{
    [Binding]
    public class UserFormSteps
    {
        UserFormObject UserObj = new UserFormObject();

        [Given(@"user is on form page")]
        public void GivenUserIsOnFormPage()
        {
            UserObj.VerifyForm();
        }
        
        [When(@"user select title")]
        public void WhenUserSelectTitle()
        {
            UserObj.SelectTitle();
        }
        
        [When(@"user enter Initial")]
        public void WhenUserEnterInitial()
        {
            UserObj.EnterInitial();
        }
        
        [When(@"user enter FirstName")]
        public void WhenUserEnterFirstName()
        {
            UserObj.EnterFirstName();
        }
        
        [When(@"user enter MiddleName")]
        public void WhenUserEnterMiddleName()
        {
             UserObj.EnterMiddleName();
        }
        
        [When(@"user select gender")]
        public void WhenUserSelectGender()
        {
            UserObj.SelectGender();
        }
        
        [When(@"user select languages")]
        public void WhenUserSelectLanguages()
        {
            UserObj.SelectLanguages();
        }
        
        [When(@"user save the details")]
        public void WhenUserSaveTheDetails()
        {
            UserObj.SaveData();
        }
        
        
        
        [When(@"user generate Aleart message")]
        public void WhenUserGenerateAleartMessage()
        {
            UserObj.Alert();
        }
        
        [Then(@"user able to do successfully")]
        public void ThenUserAbleToDoSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
    }

}

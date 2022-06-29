using Demosite.CommonMethodObject;
using System;
using TechTalk.SpecFlow;

namespace Demosite.StepDefination
{
    [Binding]
    public class LoginSteps
    {

        LoginObject loginObj = new LoginObject();

        [Given(@"user is on home page")]
        public void GivenUserIsOnHomePage()
        {
            loginObj.VarifyHome();

        }

        [When(@"user enter username")]
        public void WhenUserEnterUsername()
        {
            loginObj.EnterName();
        }

        [When(@"user enter password")]
        public void WhenUserEnterPassword()
        {
            loginObj.EnterPass();
        }

        [When(@"user click on login button")]
        public void WhenUserClickOnLoginButton()
        {
            loginObj.LoginButton();
        }

        [Then(@"user should able to see Demo site")]
        public void ThenUserShouldAbleToSeeDemoSite()
        {
            loginObj.Demosite();
        }
    }
}

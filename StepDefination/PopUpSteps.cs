using Demosite.CommonMethodObject;
using System;
using TechTalk.SpecFlow;

namespace Demosite.StepDefination
{
    [Binding]
    public class PopUpSteps
    {
        PopUp objpop = new PopUp();

        [Given(@"User on demosite")]
        public void GivenUserOnDemosite()
        {
           
        }
        
        [Given(@"user click on html site")]
        public void GivenUserClickOnHtmlSite()
        {
            objpop.clickHtml();
        }
        
        [Then(@"user able to see PopUp")]
        public void ThenUserAbleToSeePopUp()
        {
            objpop.Verify();
        }
    }
}

using Automation.Helpers;
using Automation.PageObjects;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using Xunit;

namespace Automation.Steps.ExitIntentSteps
{
    [Binding]
    public class ExitIntentSteps : Hooks
    {
        ExitIntentPage EIObj = new ExitIntentPage(_driver);
        ActionHelper helper = new ActionHelper();

        [Given(@"I enter to the exit intent page")]
        public void GivenIEnterToTheExitIntentPage()
        {
            _driver.Navigate().GoToUrl("https://ss-testing-automated-exercise.herokuapp.com/exit_intent");
        }
        
        [When(@"the mouse is out of the viewport")]
        public void WhenTheMouseIsOutOfTheViewport()
        {
            helper.mouseMoveOutOfViewport();
            Thread.Sleep(2000);
        }
        
        [Then(@"the modal should appear on the browser")]
        public void ThenTheModalShouldAppearOnTheBrowser()
        {
            Boolean modal = _driver.SwitchTo().ActiveElement().Displayed;
            Assert.True(modal);
        }
    }
}

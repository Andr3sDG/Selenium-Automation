using Automation.Helpers;
using Automation.PageObjects;
using OpenQA.Selenium.Interactions;
using System;
using TechTalk.SpecFlow;
using Xunit;


namespace Automation.Steps
{
    [Binding]
    public sealed class ContextMenuSteps : Hooks
    {
        ContextMenuPage CMObj = new ContextMenuPage(_driver);
        ActionHelper helper = new ActionHelper();
        Actions actions = new Actions(_driver);

        //01
        [Given(@"I enter to the context menu page")]
        public void GivenIEnterToTheContextMenuPage()
        {
            _driver.Navigate().GoToUrl("https://ss-testing-automated-exercise.herokuapp.com/context_menu");
        }

        //01
        [When(@"I right click inside of the box")]
        public void WhenIRightClickInsideOfTheBox()
        {
            actions.ContextClick(CMObj.hotSpot).Build().Perform();
        }

        //02
        [When(@"click on the accept button")]
        public void WhenClickOnTheAcceptButton()
        {
            _driver.SwitchTo().Alert().Accept();
        }

        //01
        [Then(@"the alert message should appear with the following message ""(.*)""")]
        public void ThenTheAlertMessageShouldAppearWithTheFollowingMessage(string message)
        {
            String actualMessage = _driver.SwitchTo().Alert().Text;
            Assert.Equal(message, actualMessage);
        }

        //02
        [Then(@"the alert message should disappear")]
        public void ThenTheAlertMessageShouldDisappear()
        {
            Assert.False(helper.isAlertVisible(_driver));
        }

    }
}

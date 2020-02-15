using Automation.Helpers;
using Automation.PageObjects;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using Xunit;

namespace Automation.Steps.FloatingMenuSteps
{
    [Binding]
    public class FloatingMenuSteps : Hooks
    {
        FloatingMenuPage FMObj = new FloatingMenuPage(_driver);
        ActionHelper helper = new ActionHelper();

        [Given(@"I enter to the floating menu page")]
        public void GivenIEnterToTheFloatingMenuPage()
        {
            _driver.Navigate().GoToUrl("https://ss-testing-automated-exercise.herokuapp.com/floating_menu#contact");
        }
        
        [When(@"I scroll to the bottom")]
        public void WhenIScrollToTheBottom()
        {
            helper.scrollToBottom(_driver);
        }
        
        [Then(@"I should see the menu on top of the page")]
        public void ThenIShouldSeeTheMenuOnTopOfThePage()
        {
            Assert.True(FMObj.floatingMenu.Displayed);
        }
    }
}

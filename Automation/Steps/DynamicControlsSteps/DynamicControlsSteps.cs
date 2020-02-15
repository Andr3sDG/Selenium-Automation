using Automation.Helpers;
using Automation.PageObjects;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace Automation.Steps.DynamicControlsSteps
{
    [Binding]
    public class DynamicControlsSteps : Hooks
    {
        DynamicControlsPage DCObj = new DynamicControlsPage(_driver);
        ActionHelper helper = new ActionHelper();

        //01 - 02
        [Given(@"I enter to the dynamic controls page")]
        public void GivenIEnterToTheDynamicControlsPage()
        {
            _driver.Navigate().GoToUrl("https://ss-testing-automated-exercise.herokuapp.com/dynamic_controls");
        }
        
        //01
        [When(@"I click on the remove button")]
        public void WhenIClickOnTheRemoveButton()
        {
            DCObj.btnRemove.Click();
        }

        //02
        [When(@"I click on the enable button")]
        public void WhenIClickOnTheEnableButton()
        {
            DCObj.btnSwitch.Click();
        }

        //01
        [Then(@"the checkbox should disappear")]
        public void ThenTheCheckboxShouldDisappear()
        {
            Assert.True(helper.isCheckBoxPresent(_driver, DCObj.blahCheck));
        }

        //02
        [Then(@"the input should be enabled")]
        public void ThenTheInputShouldBeEnabled()
        {
            Assert.True(helper.isInputEnabled(_driver, DCObj.blahInput));
        }

    }
}

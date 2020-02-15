using Automation.PageObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using Xunit;

namespace Automation.Steps.MultipleWindowsSteps
{
    [Binding]
    public class MultipleWindowsSteps : Hooks
    {
        MultipleWindowsPage MWObj = new MultipleWindowsPage(_driver);

        [Given(@"I enter to the first page")]
        public void GivenIEnterToTheFirstPage()
        {
            _driver.Navigate().GoToUrl("https://ss-testing-automated-exercise.herokuapp.com/windows");
        }
        
        [When(@"I click on the link to open other tab")]
        public void WhenIClickOnTheLinkToOpenOtherTab()
        {
            MWObj.openPage.Click();
        }
        
        [Then(@"I should stay on the other tab")]
        public void ThenIShouldStayOnTheOtherTab()
        {
            String newWindow = _driver.SwitchTo().Window(_driver.WindowHandles[1]).Url;
            Assert.Matches("https://ss-testing-automated-exercise.herokuapp.com/windows/new", newWindow);
        }
    }
}

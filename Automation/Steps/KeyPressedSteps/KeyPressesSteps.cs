using Automation.PageObjects;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace Automation.Steps.KeyPressedSteps
{
    [Binding]
    public class KeyPressesSteps : Hooks
    {
        KeyPressesPage KPObj = new KeyPressesPage(_driver);

        //01 - 02
        [Given(@"I enter to the key pressed page")]
        public void GivenIEnterToTheKeyPressedPage()
        {
            _driver.Navigate().GoToUrl("https://ss-testing-automated-exercise.herokuapp.com/key_presses");
        }
        
        //01 - 02
        [When(@"I press the esc key")]
        public void WhenIPressTheEscKey()
        {
            KPObj.target.SendKeys(Keys.Escape);
        }

        //02
        [When(@"I press the back-space key")]
        public void WhenIPressTheBack_SpaceKey()
        {
            KPObj.target.SendKeys(Keys.Backspace);
        }

        //01 - 02
        [Then(@"should be printed the next message ""(.*)""")]
        public void ThenShouldBePrintedTheNextMessage(string expectedMessage)
        {
            Assert.Matches(expectedMessage, KPObj.result.Text);
        }
    }
}

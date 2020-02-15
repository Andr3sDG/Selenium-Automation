using Automation.Helpers;
using Automation.PageObjects;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace Automation.Steps.JavaScriptAlertSteps
{
    [Binding]
    public class JavaScriptAlertSteps : Hooks
    {
        JavaScriptAlertPage JSObj = new JavaScriptAlertPage(_driver);
        ActionHelper helper = new ActionHelper();
        String sendText;

        //01
        [Given(@"I enter to the JS Alert page")]
        public void GivenIEnterToTheJSAlertPage()
        {
            _driver.Navigate().GoToUrl("https://ss-testing-automated-exercise.herokuapp.com/javascript_alerts");
        }
        
        //01
        [Given(@"I click on the basic alert")]
        public void GivenIClickOnTheBasicAlert()
        {
            JSObj.JSAlert.Click();
        }

        //02
        [Given(@"I click on the prompt alert")]
        public void GivenIClickOnThePromptAlert()
        {
            JSObj.JSPrompt.Click();
        }

        //02
        [When(@"I write ""(.*)"" and accept")]
        public void WhenIWrite(string text)
        {
            sendText = text;
            helper.enterTextToThePromptAlert(_driver, sendText);
        }

        //01
        [When(@"I click ok")]
        public void WhenIClickOk()
        {
            helper.acceptTheJSAlert(_driver);
        }

        //01
        [Then(@"should appear the following message ""(.*)""")]
        public void ThenShouldAppearTheFollowingMessage(string expectedMessage)
        {
            Assert.Matches(expectedMessage, JSObj.result.Text);
        }

        //02
        [Then(@"should appear the message ""(.*)""")]
        public void ThenShouldAppearTheMessage(string message)
        {
            String x = JSObj.result.Text;
            String expectedMessage = message + " " + sendText;
            Assert.Matches(expectedMessage, JSObj.result.Text);
        }

    }
}

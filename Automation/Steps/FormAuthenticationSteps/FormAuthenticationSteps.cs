using Automation.Helpers;
using Automation.PageObjects;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using Xunit;

namespace Automation.Steps.FormAuthenticationSteps
{
    [Binding]
    public class FormAuthenticationSteps : Hooks
    {
        FormAuthenticationPage FAObj = new FormAuthenticationPage(_driver);
        ActionHelper helper = new ActionHelper();

        //01
        [Given(@"I enter to the login page")]
        public void GivenIEnterToTheLoginPage()
        {
            _driver.Navigate().GoToUrl("https://ss-testing-automated-exercise.herokuapp.com/login");
        }

        //01 - 03 - 04
        [Given(@"I enter my username = ""(.*)"" and password = ""(.*)""")]
        public void GivenIEnterMyUsernameAndPassword(string username, string password)
        {
            helper.enterCredentials(FAObj.usernameInput, username, FAObj.passwordInput, password);
            Thread.Sleep(2000);
        }

        //01 - 03 - 04
        [When(@"I press login")]
        public void WhenIPressLogin()
        {
            FAObj.loginForm.Submit();
        }

        //02
        [When(@"I press logout")]
        public void WhenIPressLogout()
        {
            FAObj.logoutButton.Click();
        }

        //01
        [Then(@"I should see the secure area")]
        public void ThenIShouldSeeTheSecureArea()
        {
            Assert.Matches("https://ss-testing-automated-exercise.herokuapp.com/secure", _driver.Url);
        }

        //02
        [Then(@"I should see the login page again")]
        public void ThenIShouldSeeTheLoginPageAgain()
        {
            Assert.Matches("https://ss-testing-automated-exercise.herokuapp.com/login", _driver.Url);
        }

        //03 - 04
        [Then(@"I should see the following message ""(.*)""")]
        public void ThenIShouldSeeTheFollowingMessage(string expectedMessage)
        {
            Assert.Matches(expectedMessage, FAObj.flashMessage.Text);
        }

    }
}

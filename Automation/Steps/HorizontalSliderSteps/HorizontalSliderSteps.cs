using Automation.Helpers;
using Automation.PageObjects;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using Xunit;

namespace Automation.Steps.HorizontalSliderSteps
{
    [Binding]
    public class HorizontalSliderSteps : Hooks
    {
        HorizontalSliderPage HSObj = new HorizontalSliderPage(_driver);
        ActionHelper helper = new ActionHelper();
        Actions builder = new Actions(_driver);

        [Given(@"I enter to the horizontal slider page")]
        public void GivenIEnterToTheHorizontalSliderPage()
        {
            _driver.Navigate().GoToUrl("https://ss-testing-automated-exercise.herokuapp.com/horizontal_slider");
        }

        [When(@"I drag the slider to the value (.*)")]
        public void WhenIDragTheSliderToTheValue(double value)
        {
            helper.moveTheSliderTo(HSObj.slider, value);
            Thread.Sleep(5000);
        }

        [Then(@"the value should be (.*)")]
        public void ThenTheValueShouldBe(double expectedValue)
        {
            double actualValue = double.Parse(HSObj.value.Text);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}

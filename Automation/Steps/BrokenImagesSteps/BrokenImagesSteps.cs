using Automation.Helpers;
using Automation.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace Automation.Steps.BrokenImagesSteps
{
    [Binding]
    public class BrokenImagesSteps : Hooks
    {
        BrokenImagesPage BIObj = new BrokenImagesPage(_driver);
        ActionHelper helper = new ActionHelper();
        List<IWebElement> images;
        int imgs;

        [When(@"I enter to the broken images page")]
        public void WhenIEnterToTheBrokenImagesPage()
        {
            _driver.Navigate().GoToUrl("https://ss-testing-automated-exercise.herokuapp.com/broken_images");
        }
        
        [When(@"check the images")]
        public void WhenCheckTheImages()
        {
            images.Add(BIObj.iFirst);
            images.Add(BIObj.iSecond);
            images.Add(BIObj.iThird);
        }
        
        [Then(@"I should have (.*) broken images")]
        public void ThenIShouldHaveBrokenImages(int expected)
        {
            
        }

        [Then(@"I should have (.*) available image")]
        public void ThenIShouldHaveAvailableImage(int expected)
        {
            
        }

    }
}

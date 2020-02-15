using Automation.Helpers;
using Automation.PageObjects;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using Xunit;

namespace Automation.Steps.DynamicContentSteps
{
    [Binding]
    public class DynamicContentSteps : Hooks
    {
        String[] imgs = { "https://ss-testing-automated-exercise.herokuapp.com/img/avatars/Original-Facebook-Geek-Profile-Avatar-1.jpg",
                           "https://ss-testing-automated-exercise.herokuapp.com/img/avatars/Original-Facebook-Geek-Profile-Avatar-2.jpg",
                           "https://ss-testing-automated-exercise.herokuapp.com/img/avatars/Original-Facebook-Geek-Profile-Avatar-3.jpg",
                           "https://ss-testing-automated-exercise.herokuapp.com/img/avatars/Original-Facebook-Geek-Profile-Avatar-5.jpg",
                           "https://ss-testing-automated-exercise.herokuapp.com/img/avatars/Original-Facebook-Geek-Profile-Avatar-6.jpg"
                         };
        /*String[] imgs2 = { "https://ss-testing-automated-exercise.herokuapp.com/img/avatars/Original-Facebook-Geek-Profile-Avatar-2.jpg",
                           "https://ss-testing-automated-exercise.herokuapp.com/img/avatars/Original-Facebook-Geek-Profile-Avatar-3.jpg",
                           "https://ss-testing-automated-exercise.herokuapp.com/img/avatars/Original-Facebook-Geek-Profile-Avatar-5.jpg",
                           "https://ss-testing-automated-exercise.herokuapp.com/img/avatars/Original-Facebook-Geek-Profile-Avatar-6.jpg",
                           "https://ss-testing-automated-exercise.herokuapp.com/img/avatars/Original-Facebook-Geek-Profile-Avatar-7.jpg"
                         };
        */
        DynamicContentPage DCObj = new DynamicContentPage(_driver);
        ActionHelper helper = new ActionHelper();
        List<String> expectedImages = new List<String>();
        List<String> images = new List<String>();

        [Given(@"I enter to the dynamic page")]
        public void GivenIEnterToTheDynamicPage()
        {
            _driver.Navigate().GoToUrl("https://ss-testing-automated-exercise.herokuapp.com/dynamic_content");
        }
        
        [When(@"I have all the images that can be loaded")]
        public void WhenIHaveAllTheImagesThatCanBeLoaded()
        {
            images = helper.getAllImages(_driver, DCObj.image1, DCObj.image2, DCObj.image3, images);
            images.Sort();
        }

        [Then(@"I must have stored five images")]
        public void ThenIMustHaveStoredFiveImages()
        {
            expectedImages.AddRange(imgs);
            Assert.Equal(expectedImages, images);
        }

    }
}

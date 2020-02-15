using Automation.Helpers;
using Automation.PageObjects;
using TechTalk.SpecFlow;
using Xunit;

namespace Automation.Steps.DisappearingElementsSteps
{
    [Binding]
    public class DisappearingElementsSteps : Hooks
    {
        DisappearingElementsPage DEObj = new DisappearingElementsPage(_driver);
        ActionHelper helper = new ActionHelper();
        bool isNotPresent;

        //01 - 02
        [Given(@"I enter to the disappearing elements page")]
        public void GivenIEnterToTheDisappearingElementsPage()
        {
            _driver.Navigate().GoToUrl("https://ss-testing-automated-exercise.herokuapp.com/disappearing_elements");
        }
        
        //01
        [When(@"the page load all the buttons")]
        public void WhenThePageLoadAllTheButtons()
        {
            helper.isGalleryPresent(_driver);
        }
        
        //02
        [When(@"the page doesn't load all the buttons")]
        public void WhenThePageDoesnTLoadAllTheButtons()
        {
            isNotPresent = helper.isGalleryNotPresent(_driver);
        }
        
        //01
        [Then(@"the gallery button should be present")]
        public void ThenTheGalleryButtonShouldBePresent()
        {
            Assert.True(DEObj.galleryButton.Displayed);
        }
        
        //02
        [Then(@"the gallery button shouldn't be present")]
        public void ThenTheGalleryButtonShouldnTBePresent()
        {
            Assert.False(isNotPresent);
        }
    }
}

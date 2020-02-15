using Automation.PageObjects;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;
using System.Threading;
using System.Threading.Tasks;
using System;
using Automation.Helpers;
using Xunit;

namespace Automation.Steps.DragAndDropSteps
{
    [Binding]
    public class DragAndDropSteps : Hooks
    {
        DragAndDropPage DDObj = new DragAndDropPage(_driver);
        ActionHelper helper = new ActionHelper();

        //01 - 02
        [Given(@"I enter to the drag and drop page")]
        public void GivenIEnterToTheDragAndDropPage()
        {
            _driver.Navigate().GoToUrl("https://ss-testing-automated-exercise.herokuapp.com/drag_and_drop");
        }

        //01
        [When(@"I change the position of the box A to B")]
        public void WhenIChangeThePositionOfTheBoxAToB()
        {
            helper.dragAndDrop(_driver, DDObj.columnA, DDObj.columnB);
        }
        
        //02
        [When(@"I change the position of the box B to A")]
        public void WhenIChangeThePositionOfTheBoxBToA()
        {
            helper.dragAndDrop(_driver, DDObj.columnB, DDObj.columnA);
        }


        //01
        [Then(@"the box ""(.*)"" must be on the position of the box B")]
        public void ThenTheBoxMustBeOnThePositionOfTheBoxB(string boxA)
        {
            String actualValue = DDObj.columnB.Text;
            Assert.Matches(boxA, actualValue);
        }

        //02
        [Then(@"the box ""(.*)"" must be on the position of the box A")]
        public void ThenTheBoxMustBeOnThePositionOfTheBoxA(string boxB)
        {
            String actualValue = DDObj.columnA.Text;
            Assert.Matches(boxB, actualValue);
        }

    }
}

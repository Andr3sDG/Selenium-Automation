using Automation.Helpers;
using Automation.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;
using Xunit;

namespace Automation.Steps.AddRemoveElementsSteps
{
    [Binding]
    public class AddRemoveElmentsSteps : Hooks
    {
        AddRemoveElementsPage ARObj = new AddRemoveElementsPage(_driver);
        ActionHelper helper = new ActionHelper();
        IList<IWebElement> childs;

        //01 - 02
        [Given(@"I enter to the dinamic buttons page")]
        public void GivenIEnterToTheDinamicButtonsPage()
        {
            _driver.Navigate().GoToUrl("https://ss-testing-automated-exercise.herokuapp.com/add_remove_elements/");
        }

        //01 - 02
        [When(@"I click (.*) times")]
        public void WhenIClickTimes(int times)
        {
            childs = helper.createChilds(childs, ARObj.add, ARObj.delete, ARObj.parent, times);
        }

        //02
        [When(@"delete every added elements")]
        public void WhenDeleteTheAddedElements()
        {
            int elements = childs.Count;
            helper.deleteChilds(elements, ARObj.delete, ARObj.parent);
        }

        //01
        [Then(@"I should have (.*) elements")]
        public void ThenIShouldHaveElements(int expectedElements)
        {
            Assert.Equal(expectedElements, childs.Count);
        }

        //02
        [Then(@"I shouldn´t have elements")]
        public void ThenIShouldHaveElements()
        {
            Assert.False(helper.isPresent(_driver, ARObj.delete));
        }
    }
}

using Automation.Helpers;
using Automation.PageObjects;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using Xunit;

namespace Automation.Steps.FileUploadSteps
{
    [Binding]
    public class FileUploadSteps : Hooks
    {
        UploadFilePage UFObj = new UploadFilePage(_driver);
        ActionHelper helper = new ActionHelper();
        String path;

        [Given(@"I create a file with ""(.*)"" as text")]
        public void GivenICreateAFileWithAsText(string text) => path = helper.createFile(text);

        [Given(@"I enter to the upload file component")]
        public void GivenIEnterToTheUploadFileComponent()
        {
            _driver.Navigate().GoToUrl("https://ss-testing-automated-exercise.herokuapp.com/upload");
        }
        
        [When(@"I upload the file")]
        public void WhenIUploadTheFile()
        {
            UFObj.uploadFileButton.SendKeys(path);
            UFObj.submitFileButton.Click();
        }
        
        [Then(@"the file should be uploaded correctly")]
        public void ThenTheFileShouldBeUploadedCorrectly()
        {
            Assert.True(UFObj.uploadedFiles.Displayed);
        }
    }
}

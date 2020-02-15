using Automation.Helpers;
using Automation.PageObjects;
using Syroot.Windows.IO;
using System;
using System.IO;
using System.Threading;
using TechTalk.SpecFlow;
using Xunit;

namespace Automation.Steps.FileDownloadSteps
{
    [Binding]
    public class FileDownloadSteps : Hooks
    {
        FileDownloadPage FDObj = new PageObjects.FileDownloadPage(_driver);
        ActionHelper helper = new ActionHelper();

        [Given(@"I enter to the file download page")]
        public void GivenIEnterToTheFileDownloadPage()
        {
            _driver.Navigate().GoToUrl("https://ss-testing-automated-exercise.herokuapp.com/download");
        }
        
        [When(@"I click in the hiperlink")]
        public void WhenIClickInTheHiperlink()
        {
            FDObj.link.Click();
            Thread.Sleep(3000);
        }
        
        [Then(@"the file should be downloaded")]
        public void ThenTheFileShouldBeDownloaded()
        {
            String path = KnownFolders.Downloads.DefaultPath + @"\some-file.txt";
            Assert.True(File.Exists(path));
        }
    }
}

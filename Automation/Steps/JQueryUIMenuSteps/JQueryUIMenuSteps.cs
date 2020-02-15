using Automation.Helpers;
using Automation.PageObjects;
using OpenQA.Selenium.Interactions;
using Syroot.Windows.IO;
using System;
using System.IO;
using TechTalk.SpecFlow;
using Xunit;

namespace Automation.Steps.JQueryUIMenuSteps
{
    [Binding]
    public class JQueryUIMenuSteps : Hooks
    {
        JQueryUIPage JQObj = new JQueryUIPage(_driver);
        ActionHelper helper = new ActionHelper();

        [Given(@"I enter to the JQuery Menu")]
        public void GivenIEnterToTheJQueryMenu()
        {
            _driver.Navigate().GoToUrl("https://ss-testing-automated-exercise.herokuapp.com/jqueryui/menu#");
        }
        
        [When(@"I select the file to download and click")]
        public void WhenISelectTheFileToDownloadAndClick()
        {
            helper.downloadFileFromJQueryMenu(_driver, JQObj.enabled, JQObj.downloads, JQObj.excel);
        }
        
        [Then(@"I should have the xls file on my pc")]
        public void ThenIShouldHaveTheXlsFileOnMyPc()
        {
            String path = KnownFolders.Downloads.DefaultPath + @"\menu.xls";
            Assert.True(File.Exists(path));
        }
    }
}

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.PageObjects
{
    class UploadFilePage
    {
        private IWebDriver _driver;

        public UploadFilePage (IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Id, Using = "file-upload")]
        public IWebElement uploadFileButton;

        [FindsBy(How = How.Id, Using = "file-submit")]
        public IWebElement submitFileButton;

        [FindsBy(How = How.Id, Using = "uploaded-files")]
        public IWebElement uploadedFiles;

    }
}

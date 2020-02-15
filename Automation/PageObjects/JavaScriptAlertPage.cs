using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.PageObjects
{
    class JavaScriptAlertPage
    {

        private IWebDriver _driver;

        public JavaScriptAlertPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#content > div > ul > li:nth-child(1) > button")]
        public IWebElement JSAlert;

        [FindsBy(How = How.CssSelector, Using = "#content > div > ul > li:nth-child(3) > button")]
        public IWebElement JSPrompt;

        [FindsBy(How = How.Id, Using = "result")]
        public IWebElement result;

    }
}

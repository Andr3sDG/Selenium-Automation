using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.PageObjects
{
    class JQueryUIPage
    {

        private IWebDriver _driver;

        public JQueryUIPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#ui-id-3 > a")]
        public IWebElement enabled;

        [FindsBy(How = How.CssSelector, Using = "#ui-id-4 > a")]
        public IWebElement downloads;

        [FindsBy(How = How.CssSelector, Using = "#ui-id-7 > a")]
        public IWebElement excel;

    }
}

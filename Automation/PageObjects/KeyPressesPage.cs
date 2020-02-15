using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.PageObjects
{
    class KeyPressesPage
    {

        private IWebDriver _driver;

        public KeyPressesPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Id, Using = "target")]
        public IWebElement target;

        [FindsBy(How = How.Id, Using = "result")]
        public IWebElement result;

    }
}

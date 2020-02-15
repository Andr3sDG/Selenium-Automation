using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.PageObjects
{
    class BrokenImagesPage
    {

        private IWebDriver _driver;

        public BrokenImagesPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#content > div > img:nth-child(2)")]
        public IWebElement iFirst;

        [FindsBy(How = How.CssSelector, Using = "#content > div > img:nth-child(3)")]
        public IWebElement iSecond;

        [FindsBy(How = How.CssSelector, Using = "#content > div > img:nth-child(4)")]
        public IWebElement iThird;
    }
}

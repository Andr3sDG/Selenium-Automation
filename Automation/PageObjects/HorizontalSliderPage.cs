using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.PageObjects
{
    class HorizontalSliderPage
    {

        private IWebDriver _driver;

        public HorizontalSliderPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/input")]
        public IWebElement slider;

        [FindsBy(How = How.Id, Using = "range")]
        public IWebElement value;
    }
}

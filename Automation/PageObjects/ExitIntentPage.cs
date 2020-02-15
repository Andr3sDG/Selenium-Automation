using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automation.PageObjects
{
    class ExitIntentPage
    {
        private IWebDriver _driver;

        public ExitIntentPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/h3")]
        public IWebElement h3;

    }
}

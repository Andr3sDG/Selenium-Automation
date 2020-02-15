using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automation.PageObjects
{
    class DynamicContentPage
    {

        private IWebDriver _driver;

        public DynamicContentPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/div/div[1]/div[1]/img")]
        public IWebElement image1;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/div/div[2]/div[1]/img")]
        public IWebElement image2;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/div/div[3]/div[1]/img")]
        public IWebElement image3;

    }
}

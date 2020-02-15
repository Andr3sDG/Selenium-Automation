using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automation.PageObjects
{
    class DisappearingElementsPage
    {

        private IWebDriver _driver;

        public DisappearingElementsPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/ul/li[5]/a")]
        public IWebElement galleryButton;

    }
}

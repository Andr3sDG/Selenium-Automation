using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automation.PageObjects
{
    class AddRemoveElementsPage
    {

        private IWebDriver _driver;

        public AddRemoveElementsPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#content > div > button")]
        public IWebElement add;

        [FindsBy(How = How.Id, Using = "elements")]
        public IWebElement parent;

        [FindsBy(How = How.ClassName, Using = "added-manually")]
        public IWebElement delete;

    }
}

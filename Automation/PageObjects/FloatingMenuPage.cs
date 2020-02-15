using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automation.PageObjects
{
    class FloatingMenuPage
    {

        private IWebDriver _driver;

        public FloatingMenuPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Id, Using = "menu")]
        public IWebElement floatingMenu;

    }
}

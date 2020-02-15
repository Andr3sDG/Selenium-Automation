using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automation.PageObjects
{
    public class ContextMenuPage
    {

        private IWebDriver _driver;

        public ContextMenuPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Id, Using = "hot-spot")]
        public IWebElement hotSpot;

    }
}

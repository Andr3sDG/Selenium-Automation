using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automation.PageObjects
{
    class DragAndDropPage
    {

        private IWebDriver _driver;

        public DragAndDropPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Id, Using = "column-a")]
        public IWebElement columnA;

        [FindsBy(How = How.Id, Using = "column-b")]
        public IWebElement columnB;

    }
}

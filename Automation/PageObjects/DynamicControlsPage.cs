using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automation.PageObjects
{
    class DynamicControlsPage
    {

        private IWebDriver _driver;

        public DynamicControlsPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/form[1]/div/input")]
        public IWebElement blahCheck;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/form[1]/button")]
        public IWebElement btnRemove;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/form[2]/input")]
        public IWebElement blahInput;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/form[2]/button")]
        public IWebElement btnSwitch;
    }
}

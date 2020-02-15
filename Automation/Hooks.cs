using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Automation
{
    [Binding]
    public class Hooks
    {
        public static IWebDriver _driver;

        [Before]
        public static void BeforeScenario()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("disable-popup-blocking", "true");
            options.AddArgument("no-sandbox");
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
        }

        [After]
        public static void AfterScenario()
        {
            _driver.Quit();
        }
    }
}

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.PageObjects
{
    class FormAuthenticationPage
    {

        private IWebDriver _driver;

        public FormAuthenticationPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement usernameInput;

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement passwordInput;

        [FindsBy(How = How.Id, Using = "login")]
        public IWebElement loginForm;

        [FindsBy(How = How.ClassName, Using = "radius")]
        public IWebElement logoutButton;

        [FindsBy(How = How.Id, Using = "flash")]
        public IWebElement flashMessage;

    }
}

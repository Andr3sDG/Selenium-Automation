using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Awesome;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Support.UI;
using AutoIt;
using System.IO;
using Syroot.Windows.IO;
using OpenQA.Selenium.Interactions;
using System.Collections;
using System.Net.Http;

namespace Automation.Helpers
{
    class ActionHelper
    {

        public IList<IWebElement> createChilds(IList<IWebElement> childs, IWebElement add, IWebElement delete, IWebElement parent, int times)
        {
            if(times != 0)
            {
                add.Click();
                createChilds(childs, add, delete, parent, times - 1);
            }
            childs = parent.FindElements(By.ClassName(delete.GetAttribute("className")));
            return childs;
        }

        public void deleteChilds(int elements, IWebElement delete, IWebElement parent)
        {
            if (elements != 0)
            {
                delete.Click();
                deleteChilds(elements - 1, delete, parent);
            }
        }

        public Boolean isPresent(IWebDriver driver, IWebElement element)
        {
            try
            {
                driver.FindElement(By.ClassName(element.GetAttribute("className")));
                return true;
            }catch (NoSuchElementException Ex)
            {
                return false;
            }
        }

        public void imageBroken(IWebDriver driver, List<IWebElement> images)
        {
            //HttpClient client = new HttpClient();
            //HttpResponseMessage response = await client.GetAsync(driver.Url);
            //foreach  (IWebElement image in images)
            //{
            //    int code = 
            //}
            //return 3;
        }

        public Boolean isAlertVisible(IWebDriver driver)
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException Ex)
            {
                return false;
            }
        }

        public void isGalleryPresent(IWebDriver driver)
        {
            try
            {
                driver.FindElement(By.XPath("/html/body/div[2]/div/div/ul/li[5]/a"));
            }
            catch (NoSuchElementException Ex)
            {
                driver.Navigate().Refresh();
                isGalleryPresent(driver);
            }
        }

        public Boolean isGalleryNotPresent(IWebDriver driver)
        {
            try
            {
                driver.FindElement(By.XPath("/html/body/div[2]/div/div/ul/li[5]/a"));
                driver.Navigate().Refresh();
                isGalleryNotPresent(driver);
            }
            catch (NoSuchElementException Ex)
            {

            }
            return false;
        }

        public void dragAndDrop(IWebDriver driver, IWebElement col1, IWebElement col2)
        {
            col1.DragTo(col2, driver);
            resetDragAndDrop();
        }

        public void resetDragAndDrop()
        {
            ConstructorInfo constructor = typeof(DragAndDropExtension).GetConstructor(BindingFlags.Static | BindingFlags.NonPublic, null, new Type[0], null);
            constructor.Invoke(null, null);
        }

        public List<String> getAllImages(IWebDriver driver, IWebElement img1, IWebElement img2, IWebElement img3, List<String> images)
        {
            List<String> dupes = new List<String>();
            while(images.Count < 5)
            {
                dupes.Add(img1.GetAttribute("src"));
                dupes.Add(img2.GetAttribute("src"));
                dupes.Add(img3.GetAttribute("src"));
                images = dupes.Distinct().ToList();
                if(images.Count == 5)
                {
                    break;
                }
                else
                {
                    driver.Navigate().Refresh();
                }
            }
            return images;
        }

        public Boolean isCheckBoxPresent(IWebDriver driver, IWebElement element)
        {
            try
            {
                new WebDriverWait(driver, new TimeSpan(0, 0, 5))
                    .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.XPath("/html/body/div[2]/div/div[1]/form[1]/div/input")));
                return true;
            }
            catch (TimeoutException)
            {
                return false;
            }
        }

        public Boolean isInputEnabled(IWebDriver driver, IWebElement element)
        {
            try
            {
                new WebDriverWait(driver, new TimeSpan(0, 0, 5))
                    .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[2]/div/div[1]/form[2]/input")));
                return true;
            }
            catch (TimeoutException)
            {
                return false;
            }
        }

        public void mouseMoveOutOfViewport()
        {
            AutoItX.MouseMove(0, 0);
        }

        public String createFile(String text)
        {
            String filePath = KnownFolders.Desktop.DefaultPath + @"\test.txt";
            try
            {
                if (!File.Exists(filePath))
                {
                    using (StreamWriter sw = File.CreateText(filePath))
                    {
                        sw.WriteLine(text);
                    }
                }
                return filePath;
            }
            catch (Exception ex)
            {
                return filePath;
            }
        }

        public void scrollToBottom(IWebDriver driver)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
        }

        public void enterCredentials(IWebElement username, String user, IWebElement password, String pass)
        {
            username.SendKeys(user);
            password.SendKeys(pass);
        }

        public void moveTheSliderTo(IWebElement slider, double reach)
        {
            reach *= 2;
            for(int i = 0; i < reach; i++)
            {
                slider.SendKeys(Keys.ArrowRight);
            }
        }

        public void downloadFileFromJQueryMenu(IWebDriver driver, IWebElement enbld, IWebElement down, IWebElement xls)
        {
            Actions builder = new Actions(driver);
            builder.MoveToElement(enbld).Perform();
            builder.MoveToElement(down).Perform();
            builder.MoveToElement(xls).Click().Perform();
        }

        public void acceptTheJSAlert(IWebDriver driver)
        {
            driver.SwitchTo().Alert().Accept();
        }

        public void enterTextToThePromptAlert(IWebDriver driver, String text)
        {
            driver.SwitchTo().Alert().SendKeys(text);
            driver.SwitchTo().Alert().Accept();
        }

    }
}

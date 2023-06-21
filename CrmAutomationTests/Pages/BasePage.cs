using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmAutomationTests.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver _driver;
        protected WebDriverWait _wait;
        protected double _timeout =  10;
        private 

        protected BasePage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(_timeout));

        }

        public void WaitForElement(int seconds)
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
        }

        public IWebElement FindElementByText(string text)
        {
            return _driver.FindElement(By.XPath($"//*[contains(., '{text}')]"));
        }

        public IWebElement TryFindElement(IWebElement element)
        {
            try
            {
                return element;
            }
            catch (StaleElementReferenceException ex)
            {
                return element;
            }
        }

        public void AcceptAlert()
        {
            IAlert alert = _driver.SwitchTo().Alert();
            alert.Accept();
        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmAutomationTests.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver _driver;
        protected WebDriverWait _wait;
        protected double _timeout;
        private 

        protected BasePage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(_timeout));
        }
    }
}

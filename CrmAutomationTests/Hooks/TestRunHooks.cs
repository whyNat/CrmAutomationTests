using CrmAutomationTests.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CrmAutomationTests.Hooks
{
    [Binding]
    public class TestRunHooks
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public TestRunHooks()
        {
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            var webDriver = new WebDriversConfig();
            _driver = webDriver.GetDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Quit();
        }
    }
}

using Allure.Commons;
using BoDi;
using CrmAutomationTests.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private readonly IObjectContainer _container;
        public static AllureLifecycle allure = AllureLifecycle.Instance;

        public TestRunHooks(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            allure.CleanupResultDirectory();
            var webDriver = new WebDriversConfig();
            _driver = webDriver.GetDriver();
            _container.RegisterInstanceAs(_driver);
            _driver.Manage().Window.Maximize();
        }

        [BeforeStep]
        public void BeforeStep()
        {
            new WebDriverWait(_driver, new TimeSpan(0, 0, 0, 10, 0)).Until(
            d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver = _container.Resolve<IWebDriver>();

            if (_driver != null)
            {
                _driver.Quit();
                _driver.Dispose();
            }
        }
    }
}

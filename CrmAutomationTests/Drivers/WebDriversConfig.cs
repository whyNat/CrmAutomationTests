using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CrmAutomationTests.Drivers
{
    [Binding]
    public class WebDriversConfig
    {
        readonly IWebDriver driver = new FirefoxDriver();

        public IWebDriver GetDriver() { return driver; }
    }
}

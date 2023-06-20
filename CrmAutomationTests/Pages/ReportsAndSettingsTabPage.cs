using CrmAutomationTests.Utilities.Constants.Selectors;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmAutomationTests.Pages
{
    public class ReportsAndSettingsTabPage : BasePage
    {
        private IWebElement ReportsAndSettingsTab => _driver.FindElement(By.CssSelector(ReportsAndSettingsTabSelectors.ReportsAndSettingsTab));

        private IWebElement ReportSideButton => _driver.FindElement(By.CssSelector(ReportsAndSettingsTabSelectors.ReportSideButton));

        private IWebElement SearchField => _driver.FindElement(By.CssSelector(ReportsAndSettingsTabSelectors.SearchField));

        private IWebElement ReportLink => _driver.FindElement(By.CssSelector(ReportsAndSettingsTabSelectors.ReportLink));

        private IWebElement RunReportButton => _driver.FindElement(By.CssSelector(ReportsAndSettingsTabSelectors.RunReportButton));

        private List<IWebElement> ReportItemsList => _driver.FindElements(By.CssSelector(ReportsAndSettingsTabSelectors.ReportItemsList)).ToList();

        public ReportsAndSettingsTabPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement GetReportsAndSettingsTab()
        {
            WaitForElement(10);
            return ReportsAndSettingsTab;
        }

        public IWebElement GetReportSideButton()
        {
            WaitForElement(15);
            return ReportSideButton;
        }

        public IWebElement GetSearchField()
        {
            return SearchField;
        }

        public void GetReportLink()
        {
            TryFindElement(ReportLink);
            ReportLink.Click();
            WaitForElement(15);
        }

        public void GetRunReportButton()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(RunReportButton));
            TryFindElement(RunReportButton);
            RunReportButton.Click();
        }

        public List<IWebElement> GetReportItemsList()
        {
            return ReportItemsList;
        }
    }
}

using CrmAutomationTests.Utilities.Constants.Selectors;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CrmAutomationTests.Pages
{
    public class ReportsAndSettingsTabPage : BasePage
    {
        private IWebElement ReportsAndSettingsTab => _driver.FindElement(By.CssSelector(ReportsAndSettingsTabSelectors.ReportsAndSettingsTab));

        private IWebElement SearchField => _driver.FindElement(By.CssSelector(ReportsAndSettingsTabSelectors.SearchField));

        private IWebElement ReportLink => _driver.FindElement(By.CssSelector(ReportsAndSettingsTabSelectors.ReportLink));

        private List<IWebElement> ReportLinks => _driver.FindElements(By.CssSelector(ReportsAndSettingsTabSelectors.ReportLink)).ToList();

        private IWebElement RunReportButton => _driver.FindElement(By.CssSelector(ReportsAndSettingsTabSelectors.RunReportButton));

        private List<IWebElement> ReportItemsList => _driver.FindElements(By.CssSelector(ReportsAndSettingsTabSelectors.ReportItemsList)).ToList();

        private List<IWebElement> Checkboxes => _driver.FindElements(By.CssSelector(ReportsAndSettingsTabSelectors.Checkboxes)).ToList();

        private IWebElement ActionsButton => _driver.FindElement(By.CssSelector(ReportsAndSettingsTabSelectors.ActionsButton));

        private IWebElement DeleteButton => _driver.FindElement(By.CssSelector(ReportsAndSettingsTabSelectors.DeleteButton));

        public ReportsAndSettingsTabPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement GetReportsAndSettingsTab()
        {
            WaitForElement(10);
            return ReportsAndSettingsTab;
        }

        public void SearchForReportByName(string name)
        {
            SearchField.SendKeys(name);
            SearchField.SendKeys(Keys.Enter);
            SearchField.SendKeys(Keys.Return);
            WaitForElement(20);
        }

        public void GetReportLink(string reportName)
        {
            WaitForElement(30);
            ReportLink.Click();
        }

        public List<IWebElement> GetReportItemsList()
        {
            return ReportItemsList;
        }

        public void GetRunReportButton()
        {
            Actions action = new Actions(_driver);
            action.MoveToElement(RunReportButton).Click().Perform();
        }

        public List<IWebElement> GetReportLinks()
        {
            return ReportLinks;
        }

        public List<IWebElement> GetCheckboxes()
        {
            return Checkboxes;
        }

        public IWebElement GetActionsButton()
        {
            return ActionsButton;
        }

        public IWebElement GetDeleteButton()
        {
            return DeleteButton;
        }

        public List<IWebElement> SelectChosenItems(int numberOfItems)
        {
            var chosenItems = new List<IWebElement>();
            for (int i = 1; i <= numberOfItems; i++)
            {
                WaitForElement(30);
                Actions action = new Actions(_driver);
                action.MoveToElement(Checkboxes[i]).Click().Perform();
                //Checkboxes[i].Click();
                chosenItems.Add(GetCheckboxes()[i]);
            }
            return chosenItems;
        }
    }
}

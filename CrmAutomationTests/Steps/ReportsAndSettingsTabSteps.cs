using CrmAutomationTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace CrmAutomationTests.Steps
{
    [Binding]
    public class ReportsAndSettingsTabSteps
    {
        private readonly ReportsAndSettingsTabPage _reportsAndSettingsPage;
        private List<IWebElement> _chosenItems;

        public ReportsAndSettingsTabSteps(ReportsAndSettingsTabPage reportsAndSettingsPage)
        {
            _reportsAndSettingsPage = reportsAndSettingsPage;
        }

        [When(@"user clicks on Reports & Settings tab")]
        public void WhenUserClicksOnReportsSettingsTab()
        {
            _reportsAndSettingsPage.GetReportsAndSettingsTab().Click();
        }

        [When(@"user searches for (.*) report")]
        public void WhenUserSearchesForProjectProfitabilityReport(string reportName)
        {
            _reportsAndSettingsPage.SearchForReportByName(reportName);
            //_reportsAndSettingsPage.GetSearchField().SendKeys(Keys.Tab);
            _reportsAndSettingsPage.GetReportLink(reportName);
        }

        [When(@"user clicks Run Report button")]
        public void WhenUserClicksRunReportButton()
        {
            _reportsAndSettingsPage.GetRunReportButton();
        }

        [Then(@"list of report items is visible")]
        public void ThenListOfReportItemsAreVisible()
        {
            Assert.IsTrue(_reportsAndSettingsPage.GetReportItemsList().Count() > 0, "Expected list of report items to be displayed");
        }

        [When(@"user selects first (.*) items in the table")]
        public void WhenUserSelectsItemsInTheTable(int numberOfItems)
        {
            _chosenItems = _reportsAndSettingsPage.SelectChosenItems(numberOfItems);
        }

        [When(@"user deletes chosen items")]
        public void WhenUserDeletesChosenItems()
        {
            _reportsAndSettingsPage.GetActionsButton().Click();
            _reportsAndSettingsPage.GetDeleteButton().Click();
        }

        [Then(@"selected items are no longer in the table")]
        public void ThenSelectedItemsAreNoLongerInTheTable()
        {
            Assert.IsFalse(_reportsAndSettingsPage.GetReportLinks().Contains(_chosenItems[0]));
            Assert.IsFalse(_reportsAndSettingsPage.GetReportLinks().Contains(_chosenItems[1]));
            Assert.IsFalse(_reportsAndSettingsPage.GetReportLinks().Contains(_chosenItems[2]));

        }
    }
}


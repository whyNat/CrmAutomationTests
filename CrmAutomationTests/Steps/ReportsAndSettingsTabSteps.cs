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
            _reportsAndSettingsPage.GetSearchField().SendKeys(reportName);
            _reportsAndSettingsPage.GetSearchField().SendKeys(Keys.Enter);
            _reportsAndSettingsPage.GetReportLink();
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
    }
}


using CrmAutomationTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;
using TechTalk.SpecFlow;

namespace CrmAutomationTests.Steps
{
    [Binding]
    public class SalesAndMarketingTabSteps
    {
        private readonly LoginPage _loginPage;
        private readonly SalesAndMarketingTabPage _salesAndMarketingPage;

        public SalesAndMarketingTabSteps(LoginPage loginPage, SalesAndMarketingTabPage salesAndMarketingPage)
        {
            _loginPage = loginPage;
            _salesAndMarketingPage = salesAndMarketingPage;
        }

        [Given(@"(.*) user logged in to the CRM entering password (.*)")]
        public void GivenUserLoggedInToTheCRMEnteringPassword(string userName, string password)
        {
            _loginPage.EnterCredentialsAndLogin(userName, password);
        }

        [When(@"user clicks on Sales & Marketing tab")]
        public void WhenUserClicksOnSalesMarketingTab()
        {
            _salesAndMarketingPage.GetSalesAndMarketingTab().Click();
        }

        [When(@"user clicks (.*) menu item")]
        public void WhenUserClicksContactsMenuItem(string menuItemName)
        {
            _salesAndMarketingPage.ClickChosenSubMenuItem(menuItemName);
        }

        [When(@"user creates new contact by enterning (.*), (.*), (.*), (.*), (.*) and saving the form")]
        public void WhenUserCreatesNewContactByEnterningKatrinaLechowiczCEOCustomersSuppliersAndSavingTheForm(string firstName, string lastName, string role, string firstCategory, string secCategory)
        {
            //_salesAndMarketingPage.ClickCreateContactItem();
            _salesAndMarketingPage.GetCreateButton().Click();
            _salesAndMarketingPage.GetFirstName().SendKeys(firstName);
            _salesAndMarketingPage.GetLastName().SendKeys(lastName);
            _salesAndMarketingPage.GetCategoryDropdown();
            _salesAndMarketingPage.GetCategoryInput(firstCategory).Click();
            _salesAndMarketingPage.GetCategoryDropdown();
            _salesAndMarketingPage.GetCategoryInput(secCategory).Click();
            _salesAndMarketingPage.GetRoleDropdown().Click();
            _salesAndMarketingPage.ChoseRole(role).Click();
            _salesAndMarketingPage.GetSaveButton().Click();
        }

        [Then(@"created contact data matches entered values: (.*), (.*), (.*), (.*), (.*)")]
        public void ThenCreatedContactDataMatchesEnteredValues(string expectedFirstName, string expectedLastName, string expectedRole, string expectedFirstCategory, string expectedSecCategory)
        {
            _salesAndMarketingPage.GetSavedContact().Click();
            var savedFirstAndLastName = _salesAndMarketingPage.GetSavedFirstNameLastName().Text.Trim();
            var savedCategories = _salesAndMarketingPage.GetSavedCategories().Text.Substring(10);
            var savedRole = _salesAndMarketingPage.GetSavedRole().Text;
            Assert.AreEqual(expectedFirstName + " " + expectedLastName, savedFirstAndLastName);
            Assert.AreEqual(expectedFirstCategory + ", " + expectedSecCategory, savedCategories);
            Assert.AreEqual(expectedRole, savedRole);

        }
    }
}

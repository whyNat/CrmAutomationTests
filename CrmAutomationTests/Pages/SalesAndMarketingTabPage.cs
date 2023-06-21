using CrmAutomationTests.Utilities.Constants.Selectors;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V112.Network;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TechTalk.SpecFlow;

namespace CrmAutomationTests.Pages
{
    [Binding]
    public class SalesAndMarketingTabPage : BasePage
    {
        private IWebElement SalesAndMarketingTab => _driver.FindElement(By.CssSelector(SalesAndMarketingTabSelectors.SalesAndMarketingTab));
        private List<IWebElement> MenuTabSubElements => _driver.FindElements(By.CssSelector(SalesAndMarketingTabSelectors.MenuTabSubElements)).ToList();

        private IWebElement MainTitle => _driver.FindElement(By.CssSelector(SalesAndMarketingTabSelectors.MainTitle));

        private List<IWebElement> ContactsSidebarSection => _driver.FindElements(By.CssSelector(SalesAndMarketingTabSelectors.ContactsSidebarSection)).ToList();

        private IWebElement CreateButton => _driver.FindElement(By.CssSelector(SalesAndMarketingTabSelectors.CreateButton));

        private IWebElement FirstName => _driver.FindElement(By.CssSelector(SalesAndMarketingTabSelectors.FirstNameInput));

        private IWebElement LastName => _driver.FindElement(By.CssSelector(SalesAndMarketingTabSelectors.LastNameInput));

        private IWebElement CategoryDropdown => _driver.FindElement(By.CssSelector(SalesAndMarketingTabSelectors.CategoryDropdown));

        private List<IWebElement> CategoryInputs => _driver.FindElements(By.CssSelector(SalesAndMarketingTabSelectors.CategoryInputs)).ToList();

        private IWebElement RoleDropdown => _driver.FindElement(By.CssSelector(SalesAndMarketingTabSelectors.RoleDropdown));

        private List<IWebElement> RoleOptions => _driver.FindElements(By.CssSelector(SalesAndMarketingTabSelectors.RoleOption)).ToList();

        private IWebElement SaveButton => _driver.FindElement(By.CssSelector(SalesAndMarketingTabSelectors.SaveButton));

        private IWebElement SavedFirstNameLastName => _driver.FindElement(By.CssSelector(SalesAndMarketingTabSelectors.SavedFirstNameLastName));

        private IWebElement SavedCategories => _driver.FindElement(By.CssSelector(SalesAndMarketingTabSelectors.SavedCategories));

        private IWebElement SavedRole => _driver.FindElement(By.CssSelector(SalesAndMarketingTabSelectors.SavedRole));

        private IWebElement SavedContact => _driver.FindElement(By.CssSelector(SalesAndMarketingTabSelectors.SavedContact));

        public SalesAndMarketingTabPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement GetSalesAndMarketingTab()
        {
            WaitForElement(10);
            return SalesAndMarketingTab;
        }

        public List<IWebElement> GetMenuTabSubElements()
        {
            return MenuTabSubElements;
        }

        public void ClickChosenSubMenuItem(string menuItemName)
        {
            var menuItems = GetMenuTabSubElements();
            foreach (var item in menuItems)
            {
                var linkName = item.GetAttribute("href");
                if (linkName.Contains(menuItemName))
                {
                    item.Click();
                }
            }
        }

        public List<IWebElement> GetContactsSidebarSection()
        {
            return ContactsSidebarSection;
        }

        public IWebElement GetFirstName()
        {
            _wait.Until(ExpectedConditions.UrlToBe("https://demo.1crmcloud.com/index.php?module=Contacts&action=EditView&record=&list_layout_name=Browse"));
            return FirstName;
        }

        public IWebElement GetLastName()
        {
            return LastName;
        }

        public IWebElement GetCreateButton()
        {
            _wait.Until(ExpectedConditions.UrlToBe("https://demo.1crmcloud.com/index.php?module=Contacts&action=index"));
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            _wait.Until(ExpectedConditions.ElementToBeClickable(CreateButton));
            return CreateButton;
        }

        public void GetCategoryDropdown()
        {
            Actions action = new Actions(_driver);
            action.MoveToElement(CategoryDropdown).Click().Perform();
        }

        public IWebElement GetCategoryInput(string inputName)
        {
            foreach (var item in CategoryInputs)
            {
                if (item.GetAttribute("innerText") == inputName)
                {
                    Actions actions = new Actions(_driver);
                    actions.MoveToElement(item);
                    actions.Perform();
                    return item;
                }
            }
            return null;
        }

        public IWebElement GetRoleDropdown()
        {
            return RoleDropdown;
        }

        public List<IWebElement> GetRoleOption()
        {
            return RoleOptions;
        }

        public IWebElement ChoseRole(string roleName)
        {
            foreach (var option in GetRoleOption())
            {
                if (option.Text.Contains(roleName))
                {
                    return option;
                }
            }
            return null;
        }

        public IWebElement GetSaveButton()
        {
            return SaveButton;
        }

        public IWebElement GetSavedFirstNameLastName()
        {
            return SavedFirstNameLastName;
        }

        public IWebElement GetSavedCategories()
        {
            return SavedCategories;
        }

        public IWebElement GetSavedRole()
        {
            return SavedRole;
        }

        public IWebElement GetSavedContact()
        {
            WaitForElement(15);
            return SavedContact;
        }
    }
}

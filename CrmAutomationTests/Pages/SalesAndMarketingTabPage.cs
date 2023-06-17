using CrmAutomationTests.Utilities.Constants.Selectors;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V112.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CrmAutomationTests.Pages
{
    [Binding]
    public class SalesAndMarketingTabPage : BasePage
    {
        private IWebElement SalesAndMarketingTab => _driver.FindElement(By.CssSelector(SalesAndMarketingTabSelectors.SalesAndMarketingTab));
        private List<IWebElement> MenuTabSubElements => _driver.FindElements(By.CssSelector(SalesAndMarketingTabSelectors.MenuTabSubElements)).ToList();

        private IWebElement CreateButton => _driver.FindElement(By.CssSelector(SalesAndMarketingTabSelectors.CreateButton));

        private IWebElement FirstName => _driver.FindElement(By.CssSelector(SalesAndMarketingTabSelectors.FirstNameInput));

        private IWebElement LastName => _driver.FindElement(By.CssSelector(SalesAndMarketingTabSelectors.LastNameInput));

        private IWebElement CategoryDropdown => _driver.FindElement(By.CssSelector(SalesAndMarketingTabSelectors.CategoryDropdown));

        private IWebElement CategoryInput => _driver.FindElement(By.CssSelector(SalesAndMarketingTabSelectors.CategoryInput));

        private IWebElement CategoryAddItemField => _driver.FindElement(By.CssSelector(SalesAndMarketingTabSelectors.CategoryAddItemField));

        private IWebElement RoleDropdown => _driver.FindElement(By.CssSelector(SalesAndMarketingTabSelectors.RoleDropdown));

        private List<IWebElement> RoleOptions => _driver.FindElements(By.CssSelector(SalesAndMarketingTabSelectors.RoleOption)).ToList();

        private IWebElement SaveButton => _driver.FindElement(By.CssSelector(SalesAndMarketingTabSelectors.SaveButton));

        public SalesAndMarketingTabPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement GetSalesAndMarketingTab()
        {
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
                if (item.Text.Contains(menuItemName))
                {
                    item.Click();
                }
            }
        }

        public IWebElement GetFirstName()
        {
            return FirstName;
        }

        public IWebElement GetLastName()
        {
            return LastName;
        }

        public IWebElement GetCreateButton()
        {
            return CreateButton;
        }

        public IWebElement GetCategoryDropdown()
        {
            return CategoryDropdown;
        }

        public IWebElement GetCategoryInput()
        {
            return CategoryInput;
        }

        public IWebElement GetCategoryAddItemField()
        {
            return CategoryAddItemField;
        }

        public IWebElement GetRoleDropdown()
        {
            return RoleDropdown;
        }

        public List<IWebElement> GetRoleOption()
        {
            return RoleOptions;
        }

        public void ChoseRole(string roleName)
        {
            foreach (var option in GetRoleOption())
            {
                if (option.Text.Contains(roleName))
                {
                    option.Click();
                }
            }
            
        }

        public IWebElement GetSaveButton()
        {
            return SaveButton;
        }
    }
}

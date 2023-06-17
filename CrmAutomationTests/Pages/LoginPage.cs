using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CrmAutomationTests.Pages
{
    [Binding]
    public class LoginPage : BasePage
    {
        private IWebElement UserNameField => _driver.FindElement(By.Id("login_user"));

        private IWebElement PasswordField => _driver.FindElement(By.Id("login_pass"));

        private IWebElement LoginButton => _driver.FindElement(By.CssSelector(".uii-arrow-right"));

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public void EnterCredentialsAndLogin(string username, string password)
        {
            _driver.Navigate().GoToUrl("https://demo.1crmcloud.com");
            UserNameField.Clear();
            UserNameField.SendKeys(username);
            PasswordField.Clear();
            PasswordField.SendKeys(password);
            LoginButton.Click();
        }
    }
}

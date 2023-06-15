using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmAutomationTests.Pages
{
    public class LoginPage : BasePage
    {
        public IWebElement UserNameField => _driver.FindElement(By.Id("login_user"));

        public IWebElement PasswordField => _driver.FindElement(By.Id("login_pass"));

        public IWebElement LoginButton => _driver.FindElement(By.CssSelector(".uii-arrow-right"));

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public void EnterCredentialsAndLogin(string username, string password)
        {
            UserNameField.Clear();
            UserNameField.SendKeys(username);
            PasswordField.Clear();
            PasswordField.SendKeys(password);
            LoginButton.Click();
        }
    }
}

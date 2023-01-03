
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V106.Page;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace CucumberTest.Pages
{
    internal class LogInPage : AbstractPage
    {
        public IWebElement lnkLogin;
        public IWebElement txtUserName;
        public IWebElement txtPassword;

        public LogInPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        private void Init() {
            lnkLogin = WaitToFindElement(By.XPath("//button"));
            txtUserName = WaitToFindElement(By.XPath("//input[@name='username']"));
            txtPassword = WaitToFindElement(By.XPath("//input[@name='password']"));
        }
      
        public void Login(string userName, string password)
        {
            Init();
            txtPassword.SendKeys(password);
            txtUserName.SendKeys(userName);
            ClickLoginButton();
        }
        private void ClickLoginButton() => lnkLogin.Click();
    }
}

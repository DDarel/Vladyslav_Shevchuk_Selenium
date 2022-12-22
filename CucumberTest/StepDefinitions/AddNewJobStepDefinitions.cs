using OpenQA.Selenium;
using CucumberTest.Pages;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Edge;
using System.Xml.Linq;
using OpenQA.Selenium.Chrome;

namespace CucumberTest.StepDefinitions
{
    [Binding]
    public sealed class AddNewJobStepDefinitions
    {
        IWebDriver webDriver = new ChromeDriver();


        [Given(@"User logged in with data")]
        public void GivenUserLoggedInWithData(Table table)
        {
            webDriver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
            LogInPage logInPage = new LogInPage(webDriver);
            dynamic data = table.CreateDynamicInstance();
            logInPage.Login((string)data.UserName, (string)data.Password);
        }

        [When(@"User click on Admin")]
        public void WhenUserClickOnAdmin()
        {
            MainPage mainPage = new MainPage(webDriver);
            mainPage.GoToAdmin();
        }

        [When(@"User click on Job Titles")]
        public void WhenUserClickOnJobTitles()
        {
            MainPage mainPage = new MainPage(webDriver);
            mainPage.GoToJobTitles();
        }

        [When(@"User click on Add")]
        public void WhenUserClickOnAdd()
        {
            MainPage mainPage = new MainPage(webDriver);
            mainPage.GoToAdd();
        }

        [When(@"User insert data")]
        public void WhenUserInsertData(Table table)
        {
            MainPage mainPage = new MainPage(webDriver);
            dynamic data = table.CreateDynamicInstance();
            mainPage.InsertAddData((string)data.JobTitle, (string)data.JobDescription, (string)data.Note);
        }

        [When(@"User click on Save")]
        public void WhenUserClickOnSave()
        {
            MainPage mainPage = new MainPage(webDriver);
            mainPage.ClickSave();
        }

        [Then(@"User delete Student")]
        public void ThenUserDeleteStudent()
        {
            MainPage mainPage = new MainPage(webDriver);
            mainPage.DeleteStudent();
        }

        [Then(@"User click Yes, Delete")]
        public void ThenUserClickYesDelete()
        {
            MainPage mainPage = new MainPage(webDriver);
            mainPage.ClickYes();
        }

    }
}

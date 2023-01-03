using OpenQA.Selenium;
using CucumberTest.Pages;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium.Chrome;

namespace CucumberTest.StepDefinitions
{
    [Binding]
    public sealed class AddNewJobStepDefinitions
    {
        IWebDriver webDriver = new ChromeDriver();
        
        [Given(@"I have logged into application")]
        public void GivenIHaveLoggedIntoApplication(Table table)
        {
            webDriver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
            LogInPage logInPage = new LogInPage(webDriver);
            dynamic data = table.CreateDynamicInstance();
            logInPage.Login((string)data.UserName, (string)data.Password);
        }

        [When(@"I add new job title")]
        public void WhenIAddNewJobTitle(Table table)
        {
            MainPage mainPage = new MainPage(webDriver);
            mainPage.GoToAdmin();
            mainPage.GoToJobTitles();
            mainPage.GoToAdd();
            dynamic data = table.CreateDynamicInstance();
            mainPage.InsertAddData((string)data.JobTitle, (string)data.JobDescription, (string)data.Note);
            mainPage.ClickSave();
        }

        [Then(@"Job title is added")]
        public void ThenJobTitleIsAdded()
        {
            MainPage mainPage = new MainPage(webDriver);
            mainPage.CheckJobIsAdded();
        }

        [When(@"I remove job title")]
        public void WhenIRemoveJobTitle()
        {
            MainPage mainPage = new MainPage(webDriver);
            mainPage.DeleteStudent();
            mainPage.ClickYes();
        }

        [Then(@"job title is removed")]
        public void ThenJobTitleIsRemoved()
        {
            MainPage mainPage = new MainPage(webDriver);
            if (!mainPage.CheckJobIsDeleted()) {
                throw new Exception("Job was not deleted");
            }
        }
    }
}

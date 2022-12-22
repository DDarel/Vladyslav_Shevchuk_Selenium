using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V106.CacheStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CucumberTest.Pages
{
    internal class MainPage
    {
        private IWebDriver webDriver { get; }

        public MainPage(IWebDriver webDriver1)
        {
            webDriver = webDriver1;
        }

        private IWebElement lnkAdmin;
        public void GoToAdmin() {
            Thread.Sleep(1500);
            lnkAdmin = webDriver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[1]/a/span"));
            lnkAdmin.Click();
        }

        private IWebElement lnkJob;
        private IWebElement lnkJobTitles;
        public void GoToJobTitles() {
            Thread.Sleep(1000);
            lnkJob = webDriver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/header/div[2]/nav/ul/li[2]/span"));
            lnkJob.Click();
            lnkJobTitles = webDriver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/header/div[2]/nav/ul/li[2]/ul/li[1]/a"));
            lnkJobTitles.Click();
        }

        private IWebElement lnkAddJob;
        public void GoToAdd() {
            Thread.Sleep(1000);
            lnkAddJob = webDriver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/div[1]/div/button"));
            lnkAddJob.Click();
        }

        private IWebElement lnkJobTitle;
        private IWebElement lnkJobDescription;
        private IWebElement lnkNote;
        
        public void InsertAddData(string jobTitle, string jobDescription, string note) {
            Thread.Sleep(1000);
            lnkJobTitle = webDriver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[2]/input"));
            lnkJobDescription = webDriver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[2]/div/div[2]/textarea"));
            lnkNote = webDriver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[4]/div/div[2]/textarea"));
            lnkJobTitle.SendKeys(jobTitle);
            lnkJobDescription.SendKeys(jobDescription);
            lnkNote.SendKeys(note);
        }

        private IWebElement lnkSave;
        public void ClickSave() {
            lnkSave = webDriver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[5]/button[2]"));
            lnkSave.Click();
        }

        private IWebElement lnkDelete;
        public void DeleteStudent() {
            Thread.Sleep(4000);
            webDriver.Navigate().Refresh();
            Thread.Sleep(4000);
            //lnkDelete = webDriver.FindElement(By.XPath("//div[@class='data' and .='Student']/../../../..//i[@class='oxd-icon bi-trash']/.."));
            lnkDelete = webDriver.FindElement(By.XPath($"//div[@role='row']/div[@role='cell']/div[text()='Student']/../../div/div/button/i[@class='oxd-icon bi-trash']"));
            lnkDelete.Click();
        }

        private IWebElement lnkYes;
        public void ClickYes() {
            lnkYes =  webDriver.FindElement(By.XPath("//*[@id=\"app\"]/div[3]/div/div/div/div[3]/button[2]"));
            lnkYes.Click();
        }

    }
}

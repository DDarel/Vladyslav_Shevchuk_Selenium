using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V106.CacheStorage;
using OpenQA.Selenium.DevTools.V106.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CucumberTest.Pages
{
    internal class MainPage : AbstractPage
    {
        public MainPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        private IWebElement lnkAdmin;
        public void GoToAdmin() {
            lnkAdmin = WaitToFindElement(By.XPath("//a[@href='/web/index.php/admin/viewAdminModule']"));
            lnkAdmin.Click();
        }

        private IWebElement lnkJob;
        private IWebElement lnkJobTitles;
        public void GoToJobTitles() {
            lnkJob = WaitToFindElement(By.XPath("//span[text()='Job ']"));
            lnkJob.Click();
            lnkJobTitles = WaitToFindElement(By.XPath("//a[text()='Job Titles']"));
            lnkJobTitles.Click();
        }

        private IWebElement lnkAddJob;
        public void GoToAdd() {
            lnkAddJob = WaitToFindElement(By.XPath("//button[text()=' Add ']"));
            lnkAddJob.Click();
        }

        private IWebElement lnkJobTitle;
        private IWebElement lnkJobDescription;
        private IWebElement lnkNote;
        
        public void InsertAddData(string jobTitle, string jobDescription, string note) {
            lnkJobTitle = WaitToFindElement(By.XPath("//form[@class='oxd-form']/div/div/div/input[@class='oxd-input oxd-input--active']"));
            lnkJobDescription = WaitToFindElement(By.XPath("//textarea[@placeholder='Type description here']"));
            lnkNote = WaitToFindElement(By.XPath("//textarea[@placeholder='Add note']"));
            
            lnkJobTitle.SendKeys(jobTitle);
            lnkJobDescription.SendKeys(jobDescription);
            lnkNote.SendKeys(note);
        }

        private IWebElement lnkSave;
        public void ClickSave() {
            lnkSave = WaitToFindElement(By.XPath("//button[text()=' Save ']"));
            lnkSave.Click();
        }

        private IWebElement lnkDelete;
        public void DeleteStudent() {
            lnkDelete = WaitToFindElement(By.XPath($"//div[@role='row']/div[@role='cell']/div[text()='Student']/../../div/div/button/i[@class='oxd-icon bi-trash']"));
            lnkDelete.Click();
        }

        private IWebElement lnkYes;

        public void ClickYes() {
            lnkYes = WaitToFindElement(By.XPath("//button[text()=' Yes, Delete ']"));
            lnkYes.Click();
        }

        public void CheckJobIsAdded() {
            try
            {
                IWebElement test = WaitToFindElement(By.XPath("//div[text()='Student']"));
            }
            catch {
                throw new Exception("Job was not added");
            }
        }

        public bool CheckJobIsDeleted() {
            try
            {
                IWebElement test = WaitToFindElement(By.XPath("//div[text()='Student']"));
                return false;
            }
            catch
            {
                return true;
            }
        }


    }
}

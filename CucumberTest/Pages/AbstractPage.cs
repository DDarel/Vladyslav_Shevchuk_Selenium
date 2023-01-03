using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CucumberTest.Pages
{
    class AbstractPage
    {
        protected IWebDriver webDriver { get; }
        public AbstractPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
        protected IWebElement WaitToFindElement(By element) {
            for (int i = 0; i < 10; i++)
                try
                {
                    IWebElement _element = webDriver.FindElement(element);
                    return _element;
                }
                catch
                {
                    Thread.Sleep(1000);
                }
            throw new Exception($"The page wasn't loaded");
        }
    }
}

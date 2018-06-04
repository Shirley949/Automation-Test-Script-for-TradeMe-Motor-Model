using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace ClassLibrary1
{
    public class Homepage
    {
        static string Url = "http://www.trademe.co.nz";
        
        [FindsBy(How = How.Id, Using = "SearchTabs1_MotorsAnchor")]
        private IWebElement motorsLink;

        public void SelectMotors()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("SearchTabs1_MotorsAnchor")));
            motorsLink.Click();

            //IWebElement linkText = Browser.Driver.FindElement(By.Id("SearchTabs1_MotorsAnchor"));
            //motorsLink.Click();
        }

        public void Goto()
        {
            Browser.Goto(Url);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace ClassLibrary1
{
    public class MotorPage
    {
        [FindsBy(How = How.LinkText, Using = "Cars for sale")]
        private IWebElement carsale;

        public void selectCarForSale()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Cars for sale")));

            carsale.Click();
        }

    }
}

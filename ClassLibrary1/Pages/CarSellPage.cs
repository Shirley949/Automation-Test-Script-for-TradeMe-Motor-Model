using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace ClassLibrary1
{
    public class CarSellPage
    {

        [FindsBy(How = How.LinkText, Using = "BMW")]
        private IWebElement bmwLink;

        public void SelectCar()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("BMW")));

            bmwLink.Click();
        }
    }
}





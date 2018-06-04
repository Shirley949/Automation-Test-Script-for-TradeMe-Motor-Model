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
    public static class Pages
    {
       public static Homepage Homepage
        {
            get
            {
                var homePage = new Homepage();
                PageFactory.InitElements(Browser.DriverContext, homePage);
                return homePage;
            }
        }

       public static MotorPage MotorPage
        {
            get
            {
                var motorPage = new MotorPage();
                PageFactory.InitElements(Browser.DriverContext, motorPage);
                return motorPage;
            }
        }

        public static CarSellPage CarSellPage
        {
            get
            {
                var carSellPage = new CarSellPage();
                PageFactory.InitElements(Browser.DriverContext, carSellPage);
                return carSellPage;
            }
           
        }

    }
}

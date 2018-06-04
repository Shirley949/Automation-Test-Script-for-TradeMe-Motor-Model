using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace ClassLibrary1
{
    public static class Browser
    {
        static IWebDriver webDriver = new FirefoxDriver();
        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static IWebDriver Driver
        {
            get { return webDriver; }
        }

        public static ISearchContext DriverContext
        {
            get { return webDriver; }
        }

        public static void Goto(string url)
        {
            webDriver.Url = url;
        }

        public static void Close()
        {
            webDriver.Quit();
        }
    }
}

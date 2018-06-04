using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using NUnit.Framework;
using ClassLibrary1;


namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Pages.Homepage.Goto();
            Pages.Homepage.SelectMotors();
            Pages.MotorPage.selectCarForSale();
            Pages.CarSellPage.SelectCar();
        }

        [TearDown]
        public void CleanUp()
        {
            Browser.Close();
        }
    }
}

using System;
using System.Threading;
using NUnit.Framework;
using ClassLibrary1;
using TechTalk.SpecFlow;

namespace ClassLibrary1.Steps
{
    [Binding]
    public class MotorSteps
    {
        [Given(@"I am in the homepage")]
        public void GoToHomepage()
        {
            Pages.Homepage.Goto();
        }

        [Given(@"I select the Motors")]
        public void SelectMotors()
        {
            Pages.Homepage.SelectMotors();
        }

        [Given(@"I select the Cars for sale")]
        public void SelectCarForSale()
        {
            Pages.MotorPage.selectCarForSale();
        }

        [Given(@"I select the model of the car")]
        public void SelectCar()
        {
            Pages.CarSellPage.SelectCar();
        }

        [Then(@"I close the browser")]
        public void CleanUp()
        {
            Browser.Close();
        }
    }
}

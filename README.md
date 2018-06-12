# Automation-Test-Script-for-TradeMe-Motor-Model
Automation test scripts which simulated the users select different brands and models of cars for motors model with Page Object Model framework, BDD using Specflow, Gherkin and Selenium Webdrive with C#

Method used:

[FindsBy(How = How.Id, Using = "SearchTabs1_MotorsAnchor")]

Waiting element:

WebDriverWait wait = new WebDriverWait(Browser.Driver, new TimeSpan(0, 0, 5));
wait.Until(ExpectedConditions.ElementIsVisible(By.Id("SearchTabs1_MotorsAnchor")));

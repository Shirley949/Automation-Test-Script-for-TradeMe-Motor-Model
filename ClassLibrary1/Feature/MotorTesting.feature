Feature: MotorTesting
	The users are able to click the motors in homepage
	And navigate to select the model of the cars

@mytag
Scenario: Motorpage selection
	Given I am in the homepage
	And I select the Motors
	And I select the Cars for sale
	And I select the model of the car
	Then I close the browser
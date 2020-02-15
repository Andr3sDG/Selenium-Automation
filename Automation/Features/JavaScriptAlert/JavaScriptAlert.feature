Feature: JavaScriptAlert
	In order to test the different JS Alerts
	As a normal user
	I want to see the alert and the message when is closed

@mytag
Scenario: 01 - Click on the JS Alert and validate the message
	Given I enter to the JS Alert page
	And I click on the basic alert
	When I click ok
	Then should appear the following message "You successfuly clicked an alert"

Scenario: 02 - Click on the JS Prompt and validate the message
	Given I enter to the JS Alert page
	And I click on the prompt alert
	When I write "testing" and accept
	Then should appear the message "You entered:"
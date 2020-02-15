Feature: ContextMenu
	In order to see the alert messages are working
	As a normal user
	I want to see the alert message appear when right click

@mytag
Scenario: 01 - Validate the alert message is visible
	Given I enter to the context menu page
	When I right click inside of the box
	Then the alert message should appear with the following message "You selected a context menu"

Scenario: 02 - Validate the alert is closed by click on the accept button
	Given I enter to the context menu page
	When I right click inside of the box
		And click on the accept button
	Then the alert message should disappear

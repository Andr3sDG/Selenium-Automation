Feature: DynamicControls
	In order to validate the dynamic controls of the page works
	As a normal user
	I want to use the controls and see the dynamic content

@mytag
Scenario: 01 - Remove the checkbox by clicking on the remove button
	Given I enter to the dynamic controls page
	When I click on the remove button
	Then the checkbox should disappear

Scenario: 02 - Enable the input by clicking on the enable button
	Given I enter to the dynamic controls page
	When I click on the enable button
	Then the input should be enabled

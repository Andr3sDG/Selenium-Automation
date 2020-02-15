Feature: DisappearingElements
	In order to see the gallery button disappear o appear
	As a normal user
	I want to see the button disappear and appear on the page

@mytag
Scenario: 01 - Refresh until the gallery button is present and validate
	Given I enter to the disappearing elements page
	When the page load all the buttons
	Then the gallery button should be present

Scenario: 02 - Refresh until the gallery button is not present and validate
	Given I enter to the disappearing elements page
	When the page doesn't load all the buttons
	Then the gallery button shouldn't be present

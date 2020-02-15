Feature: MultipleWindows
	In order to manage multiple windows
	As a normal user
	I want to be able to open multiple windows

@mytag
Scenario: Click on the page and validate text from another tab
	Given I enter to the first page
	When I click on the link to open other tab
	Then I should stay on the other tab

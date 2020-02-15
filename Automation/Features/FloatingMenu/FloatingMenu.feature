Feature: FloatingMenu
	In order to check the floating menu doesn´t dissapear
	As a normal user
	I want to see the menu in all the page position

@mytag
Scenario: Scroll to the bottom and validate the menu is displayed
	Given I enter to the floating menu page
	When I scroll to the bottom
	Then I should see the menu on top of the page

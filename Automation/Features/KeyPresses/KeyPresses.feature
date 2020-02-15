Feature: KeyPresses
	In order to catch the latest pressed key
	As a normal user
	I want to see the the latest key that was pressed

@mytag
Scenario: 01 - Validate the esc key pressed
	Given I enter to the key pressed page
	When I press the esc key
	Then should be printed the next message "You entered: ESCAPE"

Scenario: 02 - Validate the back-space key pressed
	Given I enter to the key pressed page
	When I press the back-space key
	Then should be printed the next message "You entered: BACK_SPACE"
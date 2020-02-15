Feature: ExitIntent
	In order to validate the modal when the mouse is out of the window
	As a normal user
	I want to see the modal appear when the mouse is out

@mytag
Scenario: Modal is displayed when the mouse is out of the window
	Given I enter to the exit intent page
	When the mouse is out of the viewport
	Then the modal should appear on the browser

Feature: HorizontalSlider
	In order to test the horizontal slider
	As a normal user
	I want to be able to move the slider

@mytag
Scenario: Move the slider to the 3.5 value
	Given I enter to the horizontal slider page
	When I drag the slider to the value 3.5
	Then the value should be 3.5

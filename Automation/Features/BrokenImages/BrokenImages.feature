Feature: BrokenImages
	In order to test the images are ok
	As a normal user
	I want to see the broken images

@mytag
Scenario: 01 - Get all the broken images
	When I enter to the broken images page
	And check the images
	Then I should have 2 broken images

Scenario: 02 - Get all the ok images
	When I enter to the broken images page
	And check the images
	Then I should have 1 available image
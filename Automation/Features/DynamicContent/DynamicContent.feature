Feature: DynamicContent
	In order to validate all the images of the page
	As a normal user
	I want to see all the images that are loaded on the page

@mytag
Scenario: 01 - Validate the dynamic content of the page
	Given I enter to the dynamic page
	When I have all the images that can be loaded
	Then I must have stored five images

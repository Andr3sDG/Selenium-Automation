Feature: JQueryUIMenu
	In order to download files from JQuery Menu
	As a normal user
	I want to be able to download the files

@mytag
Scenario: Download a xls file from the JQuery Menu
	Given I enter to the JQuery Menu
	When I select the file to download and click
	Then I should have the xls file on my pc

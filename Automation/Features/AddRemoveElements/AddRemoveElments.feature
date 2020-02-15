Feature: AddRemoveElments
	In order to test dinamic buttons
	As a normal user
	I want to be create remove buttons by clicking on the add button

@mytag
Scenario: 01 - Add 20 buttons to the page
	Given I enter to the dinamic buttons page
	When I click 20 times
	Then I should have 20 elements

Scenario: 02 - Remove element by element
	Given I enter to the dinamic buttons page
	When I click 20 times
	And delete every added elements
	Then I shouldn´t have elements

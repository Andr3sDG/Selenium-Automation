Feature: DragAndDrop
	In order to test drag and drop functionality
	As a normal user
	I want to be able to change the position of the boxes

@mytag
Scenario: 01 - Put the box A on the box B and validate
	Given I enter to the drag and drop page
	When I change the position of the box A to B
	Then the box "A" must be on the position of the box B

Scenario: 02 - Put the box B on the box A and validate
	Given I enter to the drag and drop page
	When I change the position of the box B to A
	Then the box "B" must be on the position of the box A
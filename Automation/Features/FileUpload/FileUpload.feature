Feature: FileUpload
	In order to test the upload file component
	As a normal user
	I want to be able to upload files from my desktop

@mytag
Scenario: Create a file and upload on the page
	Given I create a file with "testing" as text
	And I enter to the upload file component
	When I upload the file
	Then the file should be uploaded correctly

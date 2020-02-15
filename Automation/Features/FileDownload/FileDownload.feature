Feature: FileDownload
	In order to validate the hiperlink downloads a file
	As a normal user
	I want to be able to download files with the hiperlink

@mytag
Scenario: Download and validate the file
	Given I enter to the file download page
	When I click in the hiperlink
	Then the file should be downloaded

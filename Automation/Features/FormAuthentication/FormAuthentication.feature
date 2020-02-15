Feature: FormAuthentication
	In order to validate the login form
	As a normal user
	I want the system validates the info that I´m submiting

@mytag
Scenario Outline: 01 - Login with correct credentials
	Given I enter to the login page
	And I enter my username = "tomsmith" and password = "SuperSecretPassword!"
	When I press login
	Then I should see the secure area

Scenario: 02 - Logout of the super secret page
	Given I enter to the login page
	And I enter my username = "tomsmith" and password = "SuperSecretPassword!"
	When I press login
	When I press logout
	Then I should see the login page again

Scenario: 03 - Validate invalid username
	Given I enter to the login page
	And I enter my username = "tomsmith1" and password = "SuperSecretPassword!"
	When I press login
	Then I should see the following message "Your username is invalid!"

Scenario: 04 - Validate invalid password
	Given I enter to the login page
	And I enter my username = "tomsmith" and password = "SuperS1ecretPassword!"
	When I press login
	Then I should see the following message "Your password is invalid!"

	Examples: 
	| username | password             |
	| tomsmith | SuperSecretPassword! |
	| Andres   | pass123              |
	| novutek  | novuteksc            |
	|          | empty                |

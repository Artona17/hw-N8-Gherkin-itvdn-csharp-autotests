Feature: Login
Login in the saucedemo website with standard username and empty password

Scenario: Having not right credentials should return an error message
	Given open the page
	When type 'standard_user' in the username field and '' in the password field
	Then error message 'Epic sadface: Password is required' should be present on page

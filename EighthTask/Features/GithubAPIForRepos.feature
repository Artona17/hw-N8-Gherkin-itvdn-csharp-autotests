Feature: GithubAPIForRepos
Testing Github API for getting repos by API request

Scenario: Checking successful HTTP response status after performing API request for user repos
	Given connect to github API
	And create get request
	When send request
	Then response is success

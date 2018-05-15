Feature: DoclerWebsiteTestScenarios
	According to the QA_Docler_Homework.doc
	to achive 100% test requirement coverage
	there are 5 scenarios to test the 12 cases.
	1st scenario tests: REQ-UI-01, 02, 03, 04, 09, 10.
	2nd scenario tests: REQ-UI-01, 02, 08, 09, 10.
	3rd scenario tests: REQ-UI-01, 02, 05, 06, 11.
	4th scenario tests: REQ-UI-12.
	5th scenario tests: REQ-UI-07.

@test
Scenario: Check the Home page
	Given I am on the Home Page
	When I click the Home button
	Then Navigated to Home Page
	And the title should be "UI Testing Site" 
	And the company logo should be visible
	And the Home button should be in active status
	And the text should be visible in h tag "Welcome to the Docler Holding QA Department"
	And the text should be visible in p tag "This site is dedicated to perform some exercises and demonstrate automated web testing."

@test
Scenario: Check the UI Testing page
	Given I am on the Home Page
	When I click the UI Testing button
	Then Navigated to Home Page
	And the title should be "UI Testing Site" 
	And the company logo should be visible
	And the text should be visible in h tag "Welcome to the Docler Holding QA Department"
	And the text should be visible in p tag "This site is dedicated to perform some exercises and demonstrate automated web testing."

@test
Scenario: Check the Form page
	Given I am on the Home Page
	When I click the Form button
	Then Navigated to Form Page
	And the title should be "UI Testing Site" 
	And the company logo should be visible
	And the Form button should be in active status
	And There should be one button and a box

@test
Scenario Outline: Check the submit method on form page
	Given I am at the Form Page
	When I enter the <Name> in the input box
	And I press the submit button
	Then Navigated to Hello Page
	And the title should be "UI Testing Site" 
	And the company logo should be visible
	And I should see the result <Result>
Examples:
	| Name    | Result         |
	| John    | Hello John!    |
	| Sophia  | Hello Sophia!  |
	| Charlie | Hello Charlie! |
	| Emily   | Hello Emily!   |

@test
Scenario: Check the Error page
	Given I am at the Form Page
	When I click the Error button
	Then Not Navigated to Error Page
	And I should get an error response
Feature: Email Entry On Scheduling Tab 1
	In order to enter an email on the scheduling
	tab of the search form it should email the user
	the results of the search when scheduled.

@ValidEmailCheck
Scenario: Emails when checked should be valid
	Given I have a saved search
	And I have entered a valid email joewalters999@gmail.com in to the scheduling tab
	Then The email will be marked as valid
	
@InvalidEmailCheck
Scenario: Emails when checked should show invalid
	Given I have a saved search
	And I have entered an invalid email aninvalidemailaddress in to the scheduling tab
	Then The email will be marked as invalid


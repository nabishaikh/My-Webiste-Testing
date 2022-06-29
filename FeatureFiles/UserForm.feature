Feature: UserForm
	Entering userdata

@mytag
Scenario: Filling data in user Form
   Given user is on form page
   When user select title
   And user enter Initial
   And user enter FirstName
   And user enter MiddleName
   And user select gender
   And user select languages
   And user save the details
   And user generate Aleart message
   Then user able to do successfully
Feature: SalesAndMarketingTab
	In order to manage sales
	As a CRM user
	I want to have access to all modules in the Sales & Marketing tab

Scenario Outline: CRM user can create new contact
	Given admin user logged in to the CRM entering password admin 
	When user clicks on Sales & Marketing tab
	And user clicks Contacts menu item
	And user creates new contact by enterning <first name>, <last name>, <role>, <first category>, <second category> and saving the form
	Then created contact data matches entered values: <first name>, <last name>, <role>, <first category>, <second category>
	Examples: 
	| first name | last name | role | first category | second category |
	| Madleine   | Lechowicz | CEO  | Customers      | Suppliers       |

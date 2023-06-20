Feature: ReportsAndSettingsTab
	In order to check the results
	As a CRM user
	I want to have access to all reports in Reports & Settings tab

@tag1
Scenario: CRM user can check the report
	Given admin user logged in to the CRM entering password admin 
	When user clicks on Reports & Settings tab
	And user searches for Project Profitability report
	And user clicks Run Report button
	Then list of report items is visible

Feature: DeleteCustomer
		Delete customer

@smoke
Scenario: Perform deleting customer
	Given I launch the application
	And I click on the Bank Manager Login link
	And I click on the Customers menu item
	When I click on the Deleting Button header
	Then I should see customers list without one customer

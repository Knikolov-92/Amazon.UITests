Feature: AddItemToBasket

Background: 

	Given User has navigated to the Amazon page
	Then The Amazon page is loaded

Scenario: Search a book and add it to basket
	
	When User searches for a book with title "Harry Potter and the Cursed Child"
	
	

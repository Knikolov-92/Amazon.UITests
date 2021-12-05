Feature: AddItemToBasket

Background: 

	Given User has navigated to the Amazon page
	Then The Amazon page is loaded

Scenario: Search a book and add it to basket
	
	When User searches for a book with title: "Harry Potter and the Cursed Child"
	Then The first item has the title: "Harry Potter and the Cursed Child - Parts One and Two: The Official Playscript of the Original West End Production"
	And The first item has a badge
	And The first item has type: "Paperback"
	And The first item has price for type: "Paperback"
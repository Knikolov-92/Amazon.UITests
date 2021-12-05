using Amazon.UITests.TestInfrastructure.Models;
using Amazon.UITests.TestInfrastructure.Pages.Cookie;
using Amazon.UITests.TestInfrastructure.Pages.ItemDetails;
using Amazon.UITests.TestInfrastructure.Pages.Search;
using Amazon.UITests.TestInfrastructure.Pages.SearchResult;
using TechTalk.SpecFlow;

namespace Amazon.UITests.Steps
{
    [Binding]
    public sealed class AddItemToBasketStepDefinitions
    {
        private readonly SearchFacade _search = new SearchFacade();
        private readonly SearchResultFacade _searchResult = new SearchResultFacade();
        private readonly ItemDetailsFacade _itemDetails = new ItemDetailsFacade();
        private readonly Book _book = new Book();

        [Given("^User has navigated to the Amazon page$")]
        public void GivenUserHasNavigatedToTheAmazonPage()
        {
            _search.NavigateToSearchPage();
        }
        
        [Then("^The Amazon page is loaded$")]
        public void ThenTheAmazonPageIsLoaded()
        {
            var cookieFacade = new CookieFacade();

            _search.Validate().SearchPageIsLoaded();
            cookieFacade.AcceptCookies();
        }

        [When("^User searches for a book with title: \"(.*)\"$")]
        public void WhenUserSearchesForABookWithTitle(string title)
        {
            _search.SearchForABook(title);
        }

        [Then("^The first item has the title: \"(.*)\"$")]
        public void ThenTheFirstItemHasTheTitle(string title)
        {
            _book.Title = _searchResult.Validate().FirstResultTitleIs(title);            
        }

        [Then("^The first item has a badge$")]
        public void ThenTheFirstItemHasABadge()
        {
            _searchResult.Validate().FirstResultContainsBadge();
        }

        [Then("^The first item has type: \"(.*)\"$")]
        public void ThenTheFirstItemHasType(string type)
        {
            _searchResult.Validate().FirstResultHasType(type);

            _book.Type = type;
        }

        [Then("^The first item has price for type$")]
        public void ThenTheFirstItemHasPriceForType()
        {
            _book.Price = _searchResult.Validate().FirstResultHasPriceForType(_book.Type);
        }

        [When("^User opens the book details$")]
        public void WhenUserOpensTheBookDetails()
        {
            _searchResult.OpenFirstItemDetails();
        }

        [Then("^The item has the correct title$")]
        public void ThenTheItemHasTheTitle()
        {
            _itemDetails.Validate().ItemHasTitle(_book.Title);
        }

        [Then("^The item has a badge$")]
        public void ThenTheItemHasABadge()
        {
            _itemDetails.Validate().ItemHasBadge();
        }

        [Then("^The item has the correct selected type$")]
        public void ThenTheItemHasType()
        {
            _itemDetails.Validate().SelectedItemTypeIs(_book.Type);
        }

        [Then("^The item has the correct selected price$")]
        public void ThenTheItemHasPriceForType()
        {
            _itemDetails.Validate().SelectedItemPriceIs(_book.Price);
        }
    }
}

using Amazon.UITests.TestInfrastructure.Pages.Cookie;
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
            _searchResult.Validate().FirstResultTitleIs(title);
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
        }
    }
}

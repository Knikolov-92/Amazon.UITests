using Amazon.UITests.TestInfrastructure.Pages.Cookie;
using Amazon.UITests.TestInfrastructure.Pages.Search;
using TechTalk.SpecFlow;

namespace Amazon.UITests.Steps
{
    [Binding]
    public sealed class AddItemToBasketStepDefinitions
    {
        private readonly CookieFacade _cookie = new CookieFacade();
        private readonly SearchFacade _search = new SearchFacade();        


        [Given("^User has navigated to the Amazon page$")]
        public void GivenUserHasNavigatedToTheAmazonPage()
        {
            _search.NavigateToSearchPage();
        }
        
        [Then("^The Amazon page is loaded$")]
        public void ThenTheAmazonPageIsLoaded()
        {
            _search.Validate().SearchPageIsLoaded();
            _cookie.AcceptCookies();
        }

        [When("^User searches for a book with title: \"(.*)\"$")]
        public void WhenUserSearchesForABookWithTitle(string title)
        {
            _search.SearchForABook(title);
        }

        [Then("^The First item has the title: \"(.*)\"$")]
        public void ThenTheFirstItemHasTheTitle(string title)
        {

        }

    }
}

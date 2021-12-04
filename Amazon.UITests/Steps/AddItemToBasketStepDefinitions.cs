using Amazon.UITests.TestInfrastructure.Pages.Cookie;
using Amazon.UITests.TestInfrastructure.Pages.Search;
using TechTalk.SpecFlow;

namespace Amazon.UITests.Steps
{
    [Binding]
    public sealed class AddItemToBasketStepDefinitions
    {        
        private SearchFacade _search;
        private CookieFacade _cookie;

        public AddItemToBasketStepDefinitions()
        {
            _search = new SearchFacade();
        }

        [Given("^I navigate to AmazonPage$")]
        public void GivenINavigateToAmazonPage()
        {
            _search.NavigateToSearchPage();
        }
        
        [Then("^The AmazonPage is loaded$")]
        public void ThenTheAmazonPageIsLoaded()
        {
            _search.Validate().SearchPageIsLoaded();
            _cookie.AcceptCookies();
        }

    }
}

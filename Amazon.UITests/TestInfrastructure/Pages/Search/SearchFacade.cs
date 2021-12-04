using Amazon.UITests.TestInfrastructure.Constants;

namespace Amazon.UITests.TestInfrastructure.Pages.Search
{
    public class SearchFacade : BaseFacade<SearchElements, SearchValidator>
    {
        public SearchFacade() : base()
        {
        }

        public void NavigateToSearchPage()
        {
            NavigateToPage(PageUrls.SEARCH_PAGE_URL);
        }        
    }
}

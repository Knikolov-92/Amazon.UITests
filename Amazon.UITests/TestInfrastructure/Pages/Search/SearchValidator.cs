using Amazon.UITests.TestInfrastructure.Constants;

namespace Amazon.UITests.TestInfrastructure.Pages.Search
{
    public class SearchValidator : BaseValidator<SearchElements>
    {
        public void SearchPageIsLoaded()
        {
            ValidateCurrentPageUrlIs(PageUrls.SEARCH_PAGE_URL);
            ValidateCurrentPageTitleIs(PageTitles.SEARCH_PAGE_TITLE);
        }
    }
}

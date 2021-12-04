using Amazon.UITests.TestInfrastructure.Constants;

namespace Amazon.UITests.TestInfrastructure.Pages.Search
{
    public class SearchValidator : BaseValidator<SearchElements>
    {
        public void SearchPageIsLoaded()
        {
            CurrentPageUrlIs(PageUrls.SEARCH_PAGE_URL);
            CurrentPageTitleIs(PageTitles.SEARCH_PAGE_TITLE);
        }
    }
}


namespace Amazon.UITests.TestInfrastructure.Pages.SearchResult
{
    public class SearchResultFacade : BaseFacade<SearchResultElements, SearchResultValidator> 
    {
        public SearchResultFacade() : base()
        {
        }

        public void OpenFirstItemDetails()
        {
            ClickOn(() => Elements.FirstItemTitle);
        }
    }
}

using Amazon.UITests.TestInfrastructure.Constants;
using Amazon.UITests.TestInfrastructure.Helpers;
using Amazon.UITests.TestInfrastructure.Extensions;

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

        public void SearchForABook(string bookTitle)
        {
            SelectSearchCategory(SearchCategories.BOOKS);
            SearchForItem(bookTitle);
        }

        private void SearchForItem(string itemName)
        {
            EnterTextInField(() => Elements.SearchInputField, itemName);
            ClickOn(() => Elements.SearchButton);
        }

        private void SelectSearchCategory(string category)
        {
            var dropdownElementButton = WebElementUtility.WaitForElementToBeDisplayed(() => Elements.CategoryDropdownButton);
            dropdownElementButton.WaitForElementToBeClickable();

            SelectItemFromDropdown(Elements.CategoryDropdown, category);           
        }
    }
}

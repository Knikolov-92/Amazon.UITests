using Amazon.UITests.TestInfrastructure.Constants;
using Amazon.UITests.TestInfrastructure.Helpers;
using Amazon.UITests.TestInfrastructure.Extensions;
using OpenQA.Selenium.Support.UI;

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
            var searchField = WebElementUtility.WaitForElementToBeDisplayed(() => Elements.SearchInputField);
            var searchButton = WebElementUtility.WaitForElementToBeDisplayed(() => Elements.SearchButton);

            searchField.Clear();
            searchField.SendKeys(itemName);

            searchButton.WaitForElementToBeClickable();
            searchButton.Click();
        }

        private void SelectSearchCategory(string category)
        {
            var dropdownElementButton = WebElementUtility.WaitForElementToBeDisplayed(() => Elements.CategoryDropdownButton);
            dropdownElementButton.WaitForElementToBeClickable();
            SelectElement categoryDropdown = new SelectElement(Elements.CategoryDropdown);

            categoryDropdown.SelectByText(category);
        }
    }
}

using OpenQA.Selenium;
using Amazon.UITests.TestInfrastructure.Extensions;

namespace Amazon.UITests.TestInfrastructure.Pages.SearchResult
{
    public class SearchResultElements : BaseElements
    {
        private const string BaseSearchResultLocator = "//div[contains(@data-component-type, 'search-result')]";

        public IWebElement FirstItem => Driver.FindElementWithExplicitWait(By.XPath(BaseSearchResultLocator));

        public IWebElement FirstItemTitle => Driver.FindElementWithExplicitWait(By.XPath($"{BaseSearchResultLocator}//h2//span"));

        public IWebElement FirstItemRating => Driver.FindElementWithExplicitWait(By.XPath(
            $"{BaseSearchResultLocator}//div[contains(@class, 'top-micro')]/div[@class='a-row a-size-small']/span"));
    }
}

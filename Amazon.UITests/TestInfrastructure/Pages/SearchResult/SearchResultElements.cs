using OpenQA.Selenium;
using Amazon.UITests.TestInfrastructure.Extensions;

namespace Amazon.UITests.TestInfrastructure.Pages.SearchResult
{
    public class SearchResultElements : BaseElements
    {
        private const string FirstSearchResultLocator = "//div[contains(@data-component-type, 'search-result') and @data-index='0']";

        public IWebElement FirstItem => Driver.FindElementWithExplicitWait(By.XPath(FirstSearchResultLocator));

        public IWebElement FirstItemTitle => Driver.FindElementWithExplicitWait(By.XPath($"{FirstSearchResultLocator}//h2//span"));

        public IWebElement FirstItemRating => Driver.FindElementWithExplicitWait(By.XPath(
            $"{FirstSearchResultLocator}//div[contains(@class, 'top-micro')]/div[@class='a-row a-size-small']/span[position()=1]"));
    }
}

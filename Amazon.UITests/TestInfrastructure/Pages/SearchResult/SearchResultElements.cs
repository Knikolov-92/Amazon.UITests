using OpenQA.Selenium;
using Amazon.UITests.TestInfrastructure.Extensions;
using System.Collections.Generic;

namespace Amazon.UITests.TestInfrastructure.Pages.SearchResult
{
    public class SearchResultElements : BaseElements
    {
        private const string FirstSearchResultLocator = "//div[contains(@data-component-type, 'search-result') and @data-index='0']";

        private readonly string ItemPriceLocator = 
            $"{FirstSearchResultLocator}//a[@class='a-size-base a-link-normal a-text-bold'][normalize-space()='!itemType!']//following::span[@class='a-price'][position()=1]";

        public IWebElement FirstItem => Driver.FindElementWithExplicitWait(By.XPath(FirstSearchResultLocator));

        public IWebElement FirstItemTitle => Driver.FindElementWithExplicitWait(By.XPath($"{FirstSearchResultLocator}//h2//span"));

        public IWebElement FirstItemRating => Driver.FindElementWithExplicitWait(By.XPath(
            $"{FirstSearchResultLocator}//div[contains(@class, 'top-micro')]/div[@class='a-row a-size-small']/span[position()=1]"));

        public IEnumerable<IWebElement> FirstItemTypes => Driver.FindElements(By.XPath
            ($"{FirstSearchResultLocator}//a[@class='a-size-base a-link-normal a-text-bold']"));

        public IWebElement GetFirstItemPrice(string itemType)
        {
            string priceLocator = ItemPriceLocator.Replace("!itemType!", itemType);

            return Driver.FindElementWithExplicitWait(By.XPath(priceLocator));
        }
    }
}

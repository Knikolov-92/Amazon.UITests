using OpenQA.Selenium;
using Amazon.UITests.TestInfrastructure.Extensions;

namespace Amazon.UITests.TestInfrastructure.Pages.ItemDetails
{
    public class ItemDetailsElements : BaseElements
    {
        public IWebElement ItemTitle => Driver.FindElementWithExplicitWait(By.Id("productTitle"));

        public IWebElement ItemRating => Driver.FindElement(By.Id("averageCustomerReviews"));

        public IWebElement SelectedItemType => Driver.FindElementWithExplicitWait(By.XPath("//span[contains(@class,'button-selected')]//a/span[1]"));

        public IWebElement SelectedItemPrice => Driver.FindElementWithExplicitWait(By.XPath("//span[contains(@class,'button-selected')]//a/span[2]"));
    }
}

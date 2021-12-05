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

        public IWebElement AddToBasketButton => Driver.FindElementWithExplicitWait(By.Id("add-to-cart-button"));

        public IWebElement AddToBasketConfirmationMessage => Driver.FindElementWithExplicitWait(By.XPath("//div[@id='sw-atc-confirmation']//span"));
    }
}

using Amazon.UITests.TestInfrastructure.Extensions;
using OpenQA.Selenium;

namespace Amazon.UITests.TestInfrastructure.Pages.Basket
{
    public class BasketElements : BaseElements
    {
        public IWebElement ItemTitle => Driver.FindElementWithExplicitWait(By.XPath("//span[contains(@class, 'product-title')]"));

        public IWebElement ItemType => Driver.FindElementWithExplicitWait(By.XPath("//span[contains(@class, 'product-binding')]"));

        public IWebElement ItemPrice => Driver.FindElementWithExplicitWait(By.XPath("//span[contains(@class, 'product-price')]"));

        public IWebElement ItemQuantity => Driver.FindElementWithExplicitWait(By.XPath("//span[@data-a-class='quantity']//span[@class='a-dropdown-prompt']"));

        public IWebElement Subtotal => Driver.FindElementWithExplicitWait(By.XPath("//span[@id='sc-subtotal-amount-activecart']/span"));
    }
}

using Amazon.UITests.TestInfrastructure.Extensions;
using OpenQA.Selenium;

namespace Amazon.UITests.TestInfrastructure.Pages.Navigation
{
    public class NavigationElements : BaseElements
    {
        public IWebElement ItemsCountInBasket => Driver.FindElementWithExplicitWait(By.Id("nav-cart-count"));
    }
}

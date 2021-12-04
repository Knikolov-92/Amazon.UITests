using Amazon.UITests.TestInfrastructure.Extensions;
using OpenQA.Selenium;

namespace Amazon.UITests.TestInfrastructure.Pages.Cookie
{
    public class CookieElements : BaseElements
    {
        public IWebElement AcceptCookiesButton => Driver.FindElementWithExplicitWait(By.Id("sp-cc-accept"));
    }
}

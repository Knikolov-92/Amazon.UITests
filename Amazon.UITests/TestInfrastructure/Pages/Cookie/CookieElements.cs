using OpenQA.Selenium;

namespace Amazon.UITests.TestInfrastructure.Pages.Cookie
{
    public class CookieElements : BaseElements
    {
        public IWebElement AcceptCookiesButton => Driver.FindElement(By.Id("sp-cc-accept"));
    }
}

using OpenQA.Selenium;

namespace Amazon.UITests.TestInfrastructure.Pages.Search
{
    public class SearchElements : BaseElements
    {
        public IWebElement AcceptCookiesButton => Driver.FindElement(By.Id("sp-cc-accept"));
    }
}

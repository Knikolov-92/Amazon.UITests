using OpenQA.Selenium;
using Amazon.UITests.TestInfrastructure.Extensions;

namespace Amazon.UITests.TestInfrastructure.Pages.Search
{
    public class SearchElements : BaseElements
    {
        public IWebElement CategoryDropdownButton => Driver.FindElementWithExplicitWait(By.XPath("//div[@id='nav-search-dropdown-card']"));

        public IWebElement CategoryDropdown => Driver.FindElementWithExplicitWait(By.Id("searchDropdownBox"));

        public IWebElement SearchInputField => Driver.FindElementWithExplicitWait(By.Id("twotabsearchtextbox"));

        public IWebElement SearchButton => Driver.FindElementWithExplicitWait(By.XPath("//input[@id='nav-search-submit-button']"));
    }
}

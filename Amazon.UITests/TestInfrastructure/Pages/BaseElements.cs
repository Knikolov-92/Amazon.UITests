using Amazon.UITests.Drivers;
using OpenQA.Selenium;

namespace Amazon.UITests.TestInfrastructure.Pages
{
    public class BaseElements
    {
        protected readonly IWebDriver Driver;

        protected BaseElements()
        {
            Driver = Browser.Instance.WebDriver;
        }
    }
}

using Amazon.UITests.Drivers;
using Amazon.UITests.TestInfrastructure.Constants;
using OpenQA.Selenium;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using System;
using OpenQA.Selenium.Support.UI;

namespace Amazon.UITests.TestInfrastructure.Extensions
{
    public static class WebElementExtensions
    {
        public static void WaitForElementToBeClickable(this IWebElement element)
        {
            var wait = new WebDriverWait(Browser.Instance.WebDriver, TimeSpan.FromSeconds(Timeouts.DEFAULT_TIMEOUT_IN_SECONDS));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public static string GetAriaLabel(this IWebElement element)
        {
            return element.GetAttribute("aria-label");
        }
    }
}

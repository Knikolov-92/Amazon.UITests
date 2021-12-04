using Amazon.UITests.Drivers;
using Amazon.UITests.TestInfrastructure.Constants;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Amazon.UITests.TestInfrastructure.Extensions
{
    public static class WebDriverExtensions
    {
        public static IWebElement FindElementWithExplicitWait(this IWebDriver driver, By locator, int timeoutInSeconds = Timeouts.DEFAULT_TIMEOUT_IN_SECONDS)
        {
            if (timeoutInSeconds <= 0) return driver.FindElement(locator);

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            var element = wait.Until(d => d.FindElement(locator));

            return element;
        }

        public static void WaitForElementToBeClickable(this IWebElement element)
        {
            var wait = new WebDriverWait(Browser.Instance.WebDriver, TimeSpan.FromSeconds(Timeouts.DEFAULT_TIMEOUT_IN_SECONDS));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }
    }
}

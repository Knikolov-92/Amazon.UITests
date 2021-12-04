using Amazon.UITests.Drivers;
using Amazon.UITests.TestInfrastructure.Constants;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Amazon.UITests.TestInfrastructure.Helpers
{
    public static class WebElementUtility
    {
        public static IWebElement WaitForElementToBeDisplayed(Func<IWebElement> element)
        {
            WebDriverWait wait = new WebDriverWait(Browser.Instance.WebDriver, TimeSpan.FromSeconds(Timeouts.DEFAULT_TIMEOUT_IN_SECONDS));
            wait.PollingInterval = TimeSpan.FromSeconds(Timeouts.DEFAULT_RETRY_COUNT);

            wait.Until(condition =>
            {
                try
                {
                    var isDisplayed = element.Invoke().Displayed;

                    if (isDisplayed == false)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                catch (Exception e)
                {
                    Type exType = e.GetType();

                    if (exType == typeof(StaleElementReferenceException) ||
                        exType == typeof(NoSuchElementException))
                    {
                        return false;
                    }
                    else
                    {
                        throw;
                    }
                }
            });

            return element.Invoke();
        }        
    }
}

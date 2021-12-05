using Amazon.UITests.Drivers;
using Amazon.UITests.TestInfrastructure.Helpers;
using Amazon.UITests.TestInfrastructure.Extensions;
using OpenQA.Selenium;
using System;

namespace Amazon.UITests.TestInfrastructure.Pages
{
    public class BaseFacade<TElementMap, TValidator> where TElementMap : BaseElements, new()
        where TValidator : BaseValidator<TElementMap>, new()
    {
        protected TElementMap Elements => new TElementMap();

        public TValidator Validate()
        {
            return new TValidator();
        }

        protected void NavigateToPage(string url)
        {
            Browser.Instance.WebDriver.Navigate().GoToUrl(url);
        }

        protected void ClickOn(Func<IWebElement> action)
        {
            var element = WebElementUtility.WaitForElementToBeDisplayed(action);

            element.WaitForElementToBeClickable();
            element.Click();
        }
    }  
}

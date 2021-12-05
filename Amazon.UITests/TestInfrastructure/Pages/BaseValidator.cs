using Amazon.UITests.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using Amazon.UITests.TestInfrastructure.Helpers;

namespace Amazon.UITests.TestInfrastructure.Pages
{
    public class BaseValidator<TElementMap> where TElementMap : BaseElements, new()
    {
        protected TElementMap Elements => new TElementMap();

        protected void ValidateCurrentPageUrlIs(string expectedUrl)
        {
            string actualUrl = Browser.Instance.WebDriver.Url;

            Assert.That(actualUrl, Is.EqualTo(expectedUrl));
        }

        protected void ValidateCurrentPageTitleIs(string expectedTitle)
        {
            string actualTitle = Browser.Instance.WebDriver.Title;

            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }

        protected void ValidateElementTextIs(Func<IWebElement> action, string expectedText)
        {
            var element = WebElementUtility.WaitForElementToBeDisplayed(action);
            string actualText = element.Text.Trim();

            Assert.That(actualText, Is.EqualTo(expectedText));
        }
    }
}

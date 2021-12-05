﻿using Amazon.UITests.Drivers;
using Amazon.UITests.TestInfrastructure.Helpers;
using Amazon.UITests.TestInfrastructure.Extensions;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;

namespace Amazon.UITests.TestInfrastructure.Pages
{
    public class BaseFacade<TElementMap, TValidator> where TElementMap : BaseElements, new()
        where TValidator : BaseValidator<TElementMap>, new()
    {
        public BaseFacade(){}

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

        protected void EnterTextInField(Func<IWebElement> element, string text)
        {
            var field = WebElementUtility.WaitForElementToBeDisplayed(element);

            field.Clear();
            field.SendKeys(text);
        }

        protected void SelectItemFromDropdown(IWebElement dropdown, string text)
        {
            SelectElement categoryDropdown = new SelectElement(dropdown);

            categoryDropdown.SelectByText(text);
        }
    }  
}

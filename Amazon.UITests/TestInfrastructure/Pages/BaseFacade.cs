using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Amazon.UITests.TestInfrastructure.Pages
{
    public class BaseFacade
    {
        private IWebDriver Driver;

        public BaseFacade(ScenarioContext scenarioContext)
        {
            this.Driver = scenarioContext.Get<IWebDriver>("WebDriver");
        }

        public void NavigateToPage(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }
    }

    public class BaseFacade<TElementMap, TValidator> where TElementMap : BaseElements, new()
        where TValidator : BaseValidator<TElementMap>, new()
    {
        protected BaseFacade() : base()
        {
        }

        protected TElementMap Elements => new TElementMap();

        public TValidator Validate()
        {
            return new TValidator();
        }
    }    
}

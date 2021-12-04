using Amazon.UITests.TestInfrastructure.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Amazon.UITests.Steps
{
    [Binding]
    public sealed class AddItemToBasketStepDefinitions
    {        
        private BaseFacade _base;

        private readonly ScenarioContext _scenarioContext;

        public AddItemToBasketStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _base = new BaseFacade(scenarioContext);
        }

        [Given("^I navigate to Amazon page$")]
        public void GivenINavigateToAmazonPage()
        {
            _base.NavigateToPage("http://amazon.co.uk");
        }       
    }
}

using Amazon.UITests.Drivers;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Amazon.UITests.Hooks
{
    [Binding]
    public sealed class HookInit
    {       
        private readonly ScenarioContext _scenarioContext;

        public HookInit(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            SeleniumDriver seleniumDriver = new SeleniumDriver(_scenarioContext);
            _scenarioContext.Set(seleniumDriver, "SeleniumDriver");
            _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Init();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _scenarioContext.Get<IWebDriver>("WebDriver").Quit();
            _scenarioContext.Get<IWebDriver>("WebDriver").Dispose();
        }
    }
}

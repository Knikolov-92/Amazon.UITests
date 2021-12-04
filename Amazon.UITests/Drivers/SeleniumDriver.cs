using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing;
using TechTalk.SpecFlow;

namespace Amazon.UITests.Drivers
{
    public class SeleniumDriver
    {
        private IWebDriver Driver;

        private readonly ScenarioContext _scenarioContext;

        public SeleniumDriver(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        public IWebDriver Init()
        {
            var chromeOptions = SetChromeOptions();

            Driver = new ChromeDriver(chromeOptions);
            Driver.Manage().Cookies.DeleteAllCookies();
            Driver.Manage().Window.Size = new Size(1920, 1080);
            Driver.Manage().Window.Maximize();            

            _scenarioContext.Set(Driver, "WebDriver");

            return Driver;
        }

        private static ChromeOptions SetChromeOptions()
        {
            return new ChromeOptions
            {
                PageLoadStrategy = PageLoadStrategy.Normal,
                Proxy = null
            };
        }
    }
}

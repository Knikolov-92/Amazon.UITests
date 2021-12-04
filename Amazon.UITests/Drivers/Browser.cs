using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Drawing;

namespace Amazon.UITests.Drivers
{
    public sealed class Browser
    {
        private static readonly Lazy<Browser> LazyInit = new Lazy<Browser>(() => new Browser());

        private Browser()
        {
        }

        public static Browser Instance => LazyInit.Value;

        public IWebDriver WebDriver { get; set; }      
        
        public void CloseBrowser()
        {
            WebDriver.Quit();            
            WebDriver.Dispose();
        }

        public IWebDriver OpenBrowser()
        {
            var chromeOptions = SetChromeOptions();

            WebDriver = new ChromeDriver(chromeOptions);
            WebDriver.Manage().Cookies.DeleteAllCookies();
            WebDriver.Manage().Window.Size = new Size(1920, 1080);
            WebDriver.Manage().Window.Maximize();          

            return WebDriver;
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

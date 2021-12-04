using Amazon.UITests.Drivers;
using NUnit.Framework;

namespace Amazon.UITests.TestInfrastructure.Pages
{
    public class BaseValidator<TElementMap> where TElementMap : BaseElements, new()
    {
        protected TElementMap Elements => new TElementMap();

        protected void CurrentPageUrlIs(string expectedUrl)
        {
            string actualUrl = Browser.Instance.WebDriver.Url;

            Assert.That(actualUrl, Is.EqualTo(expectedUrl));
        }

        protected void CurrentPageTitleIs(string expectedTitle)
        {
            string actualTitle = Browser.Instance.WebDriver.Title;

            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }
    }
}

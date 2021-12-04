using Amazon.UITests.Drivers;


namespace Amazon.UITests.TestInfrastructure.Pages
{
    public class BaseFacade
    {
        protected void NavigateToPage(string url)
        {
            Browser.Instance.WebDriver.Navigate().GoToUrl(url);
        }
    }

    public class BaseFacade<TElementMap, TValidator> : BaseFacade where TElementMap : BaseElements, new()
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

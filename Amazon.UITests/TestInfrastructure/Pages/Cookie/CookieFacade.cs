﻿
namespace Amazon.UITests.TestInfrastructure.Pages.Cookie
{
    public class CookieFacade : BaseFacade<CookieElements, CookieValidator> 
    {
        public void AcceptCookies()
        {
            Elements.AcceptCookiesButton.Click();
        }
    }
}

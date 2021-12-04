using Amazon.UITests.Drivers;
using TechTalk.SpecFlow;

namespace Amazon.UITests.Hooks
{
    [Binding]
    public sealed class HookInit
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            Browser.Instance.OpenBrowser();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Browser.Instance.CloseBrowser();
        }
    }
}

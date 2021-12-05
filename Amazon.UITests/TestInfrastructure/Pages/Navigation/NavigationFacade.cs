
namespace Amazon.UITests.TestInfrastructure.Pages.Navigation
{
    public class NavigationFacade : BaseFacade<NavigationElements, NavigationValidator>
    {
        public NavigationFacade() : base()
        {

        }

        public void OpenBasket()
        {
            ClickOn(() => Elements.OpenBasketButton);
        }
    }
}


namespace Amazon.UITests.TestInfrastructure.Pages.Navigation
{
    public class NavigationValidator : BaseValidator<NavigationElements>
    {
        public void NumberOfItemsAddedToBasketIs(int number)
        {
            ValidateElementTextIs(() => Elements.ItemsCountInBasket, number.ToString());
        }
    }
}

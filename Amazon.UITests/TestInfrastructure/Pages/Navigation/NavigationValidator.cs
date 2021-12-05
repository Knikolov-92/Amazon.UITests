using Amazon.UITests.TestInfrastructure.Helpers;
using NUnit.Framework;

namespace Amazon.UITests.TestInfrastructure.Pages.Navigation
{
    public class NavigationValidator : BaseValidator<NavigationElements>
    {
        public void NumberOfItemsAddedToBasketIs(int number)
        {
            var basket = WebElementUtility.WaitForElementToBeDisplayed(() => Elements.ItemsCountInBasket);

            Assert.That(basket.Text.Trim(), Is.EqualTo(number.ToString()));
        }
    }
}

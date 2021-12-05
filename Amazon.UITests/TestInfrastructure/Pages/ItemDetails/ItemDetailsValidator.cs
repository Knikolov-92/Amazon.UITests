using Amazon.UITests.TestInfrastructure.Helpers;
using Amazon.UITests.TestInfrastructure.Extensions;
using NUnit.Framework;
using Amazon.UITests.TestInfrastructure.Constants;

namespace Amazon.UITests.TestInfrastructure.Pages.ItemDetails
{
    public class ItemDetailsValidator : BaseValidator<ItemDetailsElements>
    {
        public void ItemHasTitle(string title)
        {
            ValidateElementTextIs(() => Elements.ItemTitle, title);
        }

        public void ItemHasBadge()
        {
            bool ItemHasBadge = WebElementUtility.DoesElementExistInDom(() => Elements.ItemRating);

            Assert.That(ItemHasBadge, Is.True);
        }

        public void SelectedItemTypeIs(string type)
        {
            ValidateElementTextIs(() => Elements.SelectedItemType, type);            
        }

        public void SelectedItemPriceIs(string price)
        {
            var itemType = WebElementUtility.WaitForElementToBeDisplayed(() => Elements.SelectedItemPrice);

            Assert.That(itemType.Text.GetDecimalPriceFromText(), Is.EqualTo(price));
        }

        public void ConfirmationMessageIsDisplayed()
        {
            var message = WebElementUtility.WaitForElementToBeDisplayed(() => Elements.AddToBasketConfirmationMessage);

            Assert.Multiple(() =>
            {
                Assert.That(message.Displayed, Is.True);
                Assert.That(message.Text.Trim(), Is.EqualTo(Messages.ADD_TO_BASKET_CONFIRMATION_MESSAGE));
            });            
        }
    }
}

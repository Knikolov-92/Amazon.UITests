using Amazon.UITests.TestInfrastructure.Helpers;
using Amazon.UITests.TestInfrastructure.Extensions;
using NUnit.Framework;

namespace Amazon.UITests.TestInfrastructure.Pages.ItemDetails
{
    public class ItemDetailsValidator : BaseValidator<ItemDetailsElements>
    {
        public void ItemHasTitle(string title)
        {
            var titleElement = WebElementUtility.WaitForElementToBeDisplayed(() => Elements.ItemTitle);

            Assert.That(titleElement.Text.Trim(), Is.EqualTo(title));
        }

        public void ItemHasBadge()
        {
            bool ItemHasBadge = WebElementUtility.DoesElementExistInDom(() => Elements.ItemRating);

            Assert.That(ItemHasBadge, Is.True);
        }

        public void SelectedItemTypeIs(string type)
        {
            var itemType = WebElementUtility.WaitForElementToBeDisplayed(() => Elements.SelectedItemType);

            Assert.That(itemType.Text.Trim(), Is.EqualTo(type));
        }

        public void SelectedItemPriceIs(string price)
        {
            var itemType = WebElementUtility.WaitForElementToBeDisplayed(() => Elements.SelectedItemPrice);

            Assert.That(itemType.Text.GetDecimalPriceFromText(), Is.EqualTo(price));
        }
    }
}

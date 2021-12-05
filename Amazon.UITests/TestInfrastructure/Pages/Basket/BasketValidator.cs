using Amazon.UITests.TestInfrastructure.Models;

namespace Amazon.UITests.TestInfrastructure.Pages.Basket
{
    public class BasketValidator : BaseValidator<BasketElements>
    {
        public void CorrectInfoForTheAddedItemIsDisplayed(Book book)
        {
            ValidateItemTitleIs(book.Title);
            ValidateItemTypeIs(book.Type);
            ValidateItemPriceIs(book.Price);
            ValidateItemQuantityIs(book.Quantity);
            ValidateSubtotalIs(book.Price);
        }

        private void ValidateItemTitleIs(string title)
        {
            ValidateElementTextIs(() => Elements.ItemTitle, title);
        }

        private void ValidateItemTypeIs(string type)
        {
            ValidateElementTextIs(() => Elements.ItemType, type);
        }

        private void ValidateItemPriceIs(string price)
        {
            ValidateElementTextIs(() => Elements.ItemPrice, price);
        }

        private void ValidateItemQuantityIs(int quantity)
        {
            ValidateElementTextIs(() => Elements.ItemQuantity, quantity.ToString());
        }

        private void ValidateSubtotalIs(string amount)
        {
            ValidateElementTextIs(() => Elements.Subtotal, amount);
        }
    }
}

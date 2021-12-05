
namespace Amazon.UITests.TestInfrastructure.Pages.ItemDetails
{
    public class ItemDetailsFacade : BaseFacade<ItemDetailsElements, ItemDetailsValidator>
    {
        public ItemDetailsFacade() : base()
        {

        }

        public void AddItemToBasket()
        {
            ClickOn(() => Elements.AddToBasketButton);
        }
    }
}

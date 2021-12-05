using Amazon.UITests.TestInfrastructure.Helpers;
using Amazon.UITests.TestInfrastructure.Extensions;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Linq;

namespace Amazon.UITests.TestInfrastructure.Pages.SearchResult
{
    public class SearchResultValidator : BaseValidator<SearchResultElements> 
    {
        public string FirstResultTitleIs(string expectedTitle)
        {
            string actualTitle = ValidateElementTextIs(() => Elements.FirstItemTitle, expectedTitle);

            return actualTitle;
        }

        public void FirstResultContainsBadge()
        {
            var element = WebElementUtility.WaitForElementToBeDisplayed(() => Elements.FirstItemRating);
            var regex = new Regex(@"^[1-5]\.[0-9]\s+out of 5\s+stars$");

            Assert.That(regex.IsMatch(element.GetAriaLabel()), Is.True);
        }

        public void FirstResultHasType(string type)
        {
            WebElementUtility.WaitForElementToBeDisplayed(() => Elements.FirstItem);
            var itemTypes = Elements.FirstItemTypes;
            var doesTypeExist = itemTypes.Any(element => element.Text.Equals(type));

            Assert.That(doesTypeExist, Is.True);
        }

        public string FirstResultHasPriceForType(string type)
        {
            var priceElement = WebElementUtility.WaitForElementToBeDisplayed(() => Elements.GetFirstItemPrice(type));
            var actualPrice = priceElement.Text.GetDecimalPriceFromText();

            Assert.That(string.IsNullOrEmpty(priceElement.Text), Is.False);

            return actualPrice;
        }
    }
}

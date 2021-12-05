﻿using Amazon.UITests.TestInfrastructure.Helpers;
using Amazon.UITests.TestInfrastructure.Extensions;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace Amazon.UITests.TestInfrastructure.Pages.SearchResult
{
    public class SearchResultValidator : BaseValidator<SearchResultElements> 
    {
        public void FirstResultTitleIs(string expectedTitle)
        {
            ValidateElementTextIs(() => Elements.FirstItemTitle, expectedTitle);
        }

        public void FirstResultContainsBadge()
        {
            var element = WebElementUtility.WaitForElementToBeDisplayed(() => Elements.FirstItemRating);
            var regex = new Regex(@"^[1-5]\.[0-9]\s+out of 5\s+stars$");

            Assert.That(regex.IsMatch(element.GetAriaLabel()), Is.True);
        }
    }
}

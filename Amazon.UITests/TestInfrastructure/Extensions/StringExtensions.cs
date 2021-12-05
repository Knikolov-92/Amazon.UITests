
namespace Amazon.UITests.TestInfrastructure.Extensions
{
    public static class StringExtensions
    {
        public static string GetDecimalPriceFromText(this string text)
        {
            return text.Trim().Replace("\r\n", ".");
        }
    }
}

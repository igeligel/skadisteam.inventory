namespace skadisteam.inventory.Extensions
{
    internal static class StringExtensions
    {
        internal static string AddTradableItemParameter(this string input)
        {
            return input + "&trading=1";
        }

        internal static string AddNewTradableItemParameter(this string input)
        {
            return input + "?trading=1";
        }
    }
}

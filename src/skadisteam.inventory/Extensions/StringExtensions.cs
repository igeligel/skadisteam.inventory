namespace skadisteam.inventory.Extensions
{
    /// <summary>
    /// Class which provide extensions for the string class.
    /// </summary>
    internal static class StringExtensions
    {
        /// <summary>
        /// Will add the tradable parameter to urls.
        /// It will append to an existing parameter url.
        /// </summary>
        /// <param name="input">
        /// String which should be extended.
        /// </param>
        /// <returns>
        /// The string with extended trading parameter.
        /// </returns>
        internal static string AddTradableItemParameter(this string input)
        {
            return input + "&trading=1";
        }

        /// <summary>
        /// Will add the tradable parameter to urls as first parameter.
        /// </summary>
        /// <param name="input">
        /// String which should be extended.
        /// </param>
        /// <returns>
        /// The String with extended trading parameter.
        /// </returns>
        internal static string AddNewTradableItemParameter(this string input)
        {
            return input + "?trading=1";
        }
    }
}

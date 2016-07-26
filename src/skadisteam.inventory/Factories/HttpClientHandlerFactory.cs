using System.Net;
using System.Net.Http;
using skadisteam.inventory.Extensions;

namespace skadisteam.inventory.Factories
{
    /// <summary>
    /// Class to generate HttpClientHandlers.
    /// </summary>
    internal class HttpClientHandlerFactory
    {
        /// <summary>
        /// Returns a basic HttpClientHandler for interacting with
        /// Steam. It will automatically set the steam language
        /// cookie to english.
        /// </summary>
        /// <returns>
        /// A HttpClientHandler which is creating the default
        /// HttpClientHandler. It will automatically decompress gzipped
        /// and deflated content. Also it will have the steam language
        /// set to english.
        /// </returns>
        internal static HttpClientHandler Create()
        {
            var cookieContainer = new CookieContainer();
            cookieContainer.AddEnglishSteamLanguageCookie();
            return new HttpClientHandler
            {
                CookieContainer = cookieContainer,
                AutomaticDecompression = DecompressionMethods.GZip |
                                         DecompressionMethods.Deflate
            };
        }

        /// <summary>
        /// Method to create a basic HttpClientHandler with an appended
        /// CookieContainer.
        /// </summary>
        /// <param name="cookieContainer">
        /// <see cref="CookieContainer"/> which should be added to the 
        /// HttpClientHandler.
        /// </param>
        /// <returns>
        /// A basic HttpClientHandler which will decompress gzipped and deflated
        /// Content. Also it will be bound to the <see cref="CookieContainer"/>
        /// which is given as parameter.
        /// </returns>
        internal static HttpClientHandler Create(CookieContainer cookieContainer)
        {
            return new HttpClientHandler
            {
                CookieContainer = cookieContainer,
                AutomaticDecompression = DecompressionMethods.GZip |
                                         DecompressionMethods.Deflate
            };
        }
    }
}

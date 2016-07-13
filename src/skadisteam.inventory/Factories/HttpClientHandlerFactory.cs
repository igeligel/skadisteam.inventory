using System.Net;
using System.Net.Http;
using skadisteam.inventory.Extensions;

namespace skadisteam.inventory.Factories
{
    internal class HttpClientHandlerFactory
    {
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
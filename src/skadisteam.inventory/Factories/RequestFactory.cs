using System.Net;
using System.Net.Http;
using skadisteam.inventory.Constants;

namespace skadisteam.inventory.Factories
{
    /// <summary>
    /// Class to create HTTP requests to the steam community api.
    /// </summary>
    internal class RequestFactory
    {
        /// <summary>
        /// <see cref="CookieContainer"/> which is used for the requests.
        /// </summary>
        private CookieContainer _cookieContainer;

        /// <summary>
        /// Constructor for the factory.
        /// This will just create an instance of the class.
        /// </summary>
        internal RequestFactory()
        {
            _cookieContainer = new CookieContainer();
        }

        /// <summary>
        /// Constructor for the request factory with a <see cref="CookieContainer"/>.
        /// It will instantiate the class and bind the <see cref="CookieContainer"/>
        /// to the requests which are done by the factory.
        /// </summary>
        /// <param name="cookieContainer">
        /// <see cref="CookieContainer"/> which is bound to the requests done by the
        /// factory.
        /// </param>
        internal RequestFactory(CookieContainer cookieContainer)
        {
            _cookieContainer = cookieContainer;
        }

        /// <summary>
        /// Creates the HTTP Request to load inventories.
        /// This method is only used for public inventories, because
        /// there needs to be specific Headers set.
        /// </summary>
        /// <param name="path">
        /// Path of the requests. For creating this path lookup:
        /// <see cref="PathFactory"/>.
        /// </param>
        /// <returns>
        /// A <see cref="HttpResponseMessage"/> which is the response
        /// to the actual request done.
        /// </returns>
        internal HttpResponseMessage CreateLoadInventory(string path)
        {
            HttpResponseMessage response;
            var handler = HttpClientHandlerFactory.Create();
            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = Uris.SteamCommunityBase;
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    HttpHeaderKeys.CacheControl, HttpHeaderValues.NoCache);
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    HttpHeaderKeys.Pragma, HttpHeaderValues.NoCache);
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    HttpHeaderKeys.Accept,
                    "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    HttpHeaderKeys.AcceptEncoding,
                    HttpHeaderValues.GzipAndDeflate);
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    HttpHeaderKeys.AcceptLanguage,
                    HttpHeaderValues.AcceptLanguage);
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    HttpHeaderKeys.UserAgent,
                    HttpHeaderValues.UserAgent);
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    HttpHeaderKeys.UpgradeInsecureRequests, "1");
                client.DefaultRequestHeaders.Host = Uris.SteamCommunityBase.Host;

                response = client.GetAsync(path).Result;
            }
            return response;
        }

        /// <summary>
        /// Creates the HTTP Request to load private partner
        /// inventories.
        /// This method can be used for private and public inventories.
        /// </summary>
        /// <param name="path">
        /// Path of the requests. For creating this path lookup:
        /// <see cref="PathFactory"/>.
        /// </param>
        /// <param name="steam32Id">
        /// Steam 32 Id. For example this is a steam 32 Id: 68364320.
        /// </param>
        /// <param name="tradeToken">
        /// Trade Token of the partner.
        /// </param>
        /// <returns>
        /// A <see cref="HttpResponseMessage"/> which is the response
        /// to the actual request done.
        /// </returns>
        internal HttpResponseMessage CreatePartnerInventory(string path,
           int steam32Id, string tradeToken)
        {
            var handler = HttpClientHandlerFactory.Create(_cookieContainer);
            HttpResponseMessage response;
            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = Uris.SteamCommunityBaseSecured;
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    HttpHeaderKeys.Accept,
                    "text/javascript, text/html, application/xml, text/xml, */*");
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    HttpHeaderKeys.XPrototypeVersion, "1.7");
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    HttpHeaderKeys.XRequestedWith, "XMLHttpRequest");
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    HttpHeaderKeys.UserAgent,
                    HttpHeaderValues.UserAgent);
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    HttpHeaderKeys.Referer,
                    "https://steamcommunity.com/tradeoffer/new/?partner=" +
                    steam32Id + "&token=" + tradeToken);
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    HttpHeaderKeys.AcceptEncoding,
                    HttpHeaderValues.GzipDeflateSdhcAndBr);
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    HttpHeaderKeys.AcceptLanguage,
                    HttpHeaderValues.AcceptLanguage);
                client.DefaultRequestHeaders.Host =
                    Uris.SteamCommunityBaseSecured.Host;
                response = client.GetAsync(path).Result;
            }
            return response;
        }
    }
}

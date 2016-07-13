using System.Net;
using System.Net.Http;
using skadisteam.inventory.Constants;

namespace skadisteam.inventory.Factories
{
    internal class RequestFactory
    {
        private CookieContainer _cookieContainer;

        internal RequestFactory()
        {
        }

        internal RequestFactory(CookieContainer cookieContainer)
        {
            _cookieContainer = cookieContainer;
        }

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
using System;
using skadisteam.inventory.Models;
using System.Net;
using System.Net.Http;
using skadisteam.inventory.Constants;
using skadisteam.inventory.Extensions;
using skadisteam.inventory.Factories;

namespace skadisteam.inventory
{
    public class SkadiInventory
    {
        public static void LoadInventory(
            SkadiLoadInventoryConfiguration skadiLoadInventory)
        {
            var path =
                PathFactory.CreatePublicInventoryPath(
                    skadiLoadInventory.PartnerId, skadiLoadInventory.AppId,
                    skadiLoadInventory.ContextId);

            if (skadiLoadInventory.TradableItems)
            {
                path = path.AddNewTradableItemParameter();
            }

            var cookieContainer = new CookieContainer();
            HttpResponseMessage response = null;
            var handler = new HttpClientHandler
            {
                CookieContainer = cookieContainer,
                AutomaticDecompression = DecompressionMethods.GZip |
                                         DecompressionMethods.Deflate
            };
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
        }

        public static void LoadPartnerInventory(long partnerCommunityId,
            int appId, int contextId, string sessionId,
            string steamLoginSecure, string tradeToken, bool tradableItems,
            int steam32Id)
        {
            
            var path = "/tradeoffer/new/partnerinventory/?sessionid=" +
                       sessionId + "&partner=" + partnerCommunityId + "&appid=" +
                       appId + "&contextid=" + contextId;
            if (tradableItems)
            {
                path = path.AddTradableItemParameter();
            }

            var uri = new Uri(Resources.SteamCommunityBaseSecured);

            var cookieContainer = new CookieContainer()
                .AddEnglishSteamLanguageCookie()
                .AddSteamSessionIdCookie(sessionId)
                .AddSteamLoginSecureCookie(steamLoginSecure);

            HttpResponseMessage response = null;
            var handler = new HttpClientHandler
            {
                CookieContainer = cookieContainer,
                AutomaticDecompression = DecompressionMethods.GZip |
                                         DecompressionMethods.Deflate
            };

            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = uri;
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
                client.DefaultRequestHeaders.Host = uri.Host;
                response = client.GetAsync(path).Result;
            }
        }
    }
}

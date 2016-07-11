using System;
using skadisteam.inventory.Models;
using System.Net;
using System.Net.Http;

namespace skadisteam.inventory
{
    public class SkadiInventory
    {
        public static void loadInventory(
            SkadiLoadInventoryConfiguration skadiLoadInventory)
        {
            var baseUrl = "http://steamcommunity.com";
            var path = "/profiles/" +
                      skadiLoadInventory.PartnerId +
                      "/inventory/json/" + skadiLoadInventory.AppId + "/" +
                      skadiLoadInventory.ContextId;
            if (skadiLoadInventory.TradableItems)
            {
                path += "?trading=1";
            }

            Uri uri = new Uri(baseUrl);

            CookieContainer _cookieContainer = new CookieContainer();
            HttpResponseMessage response = null;
            var handler = new HttpClientHandler();
            handler.CookieContainer = _cookieContainer;
            handler.AutomaticDecompression = DecompressionMethods.GZip |
                                             DecompressionMethods.Deflate;
            using (var client = new HttpClient(handler))
            {
                
                client.BaseAddress = uri;
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    "Cache-Control", "no-cache");
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    "Pragma", "no-cache");
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    "Accept",
                    "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    "Accept-Encoding", "gzip, deflate");
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    "Accept-Language",
                    "de-DE,de;q=0.8,en-US;q=0.6,en;q=0.4,it;q=0.2");
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    "User-Agent",
                    "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.106 Safari/537.36");
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    "Upgrade-Insecure-Requests", "1");

                // : 
                // : 
                // : 
                // : 
                // : 
                client.DefaultRequestHeaders.Host = uri.Host;

                response = client.GetAsync(path).Result;
            }
        }
    }
}

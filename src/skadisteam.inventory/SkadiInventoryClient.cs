using System;
using skadisteam.inventory.Models;
using System.Net;
using Newtonsoft.Json;
using skadisteam.inventory.Extensions;
using skadisteam.inventory.Factories;
using skadisteam.inventory.Models.Json;

namespace skadisteam.inventory
{
    public class SkadiInventoryClient
    {
        public static SkadiInventory LoadInventory(
            SkadiLoadInventoryConfiguration skadiLoadInventory)
        {
            var path =
                PathFactory.CreatePublicInventoryPath(
                    skadiLoadInventory.PartnerId, skadiLoadInventory.AppId,
                    skadiLoadInventory.ContextId,
                    skadiLoadInventory.TradableItems);

            var requestFactory = new RequestFactory();
            var response = requestFactory.CreateLoadInventory(path);
            var responseBody = response.Content.ReadAsStringAsync().Result;
            var inventory =
                JsonConvert.DeserializeObject<RootInventory>(responseBody);
            var skadiInventory = SkadiInventoryFactory.Create(inventory);
            return skadiInventory;
        }

        public static void LoadPartnerInventory(long partnerCommunityId,
            int appId, int contextId, string sessionId,
            string steamLoginSecure, string tradeToken, bool tradableItems,
            int steam32Id)
        {
            var path = PathFactory.CreatePartnerInventoryPath(sessionId,
                partnerCommunityId,
                appId, contextId, tradableItems);

            var cookieContainer = new CookieContainer()
                .AddEnglishSteamLanguageCookie()
                .AddSteamSessionIdCookie(sessionId)
                .AddSteamLoginSecureCookie(steamLoginSecure);

            var requestFactory = new RequestFactory(cookieContainer);
            var response = requestFactory.CreatePartnerInventory(path,
                steam32Id, tradeToken);
            var responseBody = response.Content.ReadAsStringAsync().Result;
        }
    }
}

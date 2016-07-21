using skadisteam.inventory.Models;
using System.Net;
using Newtonsoft.Json;
using skadisteam.inventory.Extensions;
using skadisteam.inventory.Factories;
using skadisteam.inventory.Models.Json;

namespace skadisteam.inventory
{
    /// <summary>
    /// Class which is used for requesting inventories. Just call the methods
    /// without instancing this class.
    /// </summary>
    /// <example>
    /// // Public inventory
    /// var inventory = SkadiInventoryClient.LoadInventory(...);
    /// 
    /// // Partner Inventory
    /// var privateInventory = 
    ///     SkadiInventoryClient.LoadPartnerInventory(...);
    /// </example>
    public static class SkadiInventoryClient
    {
        /// <summary>
        /// Method to request the inventory of a public accessible inventory.
        /// </summary>
        /// <param name="skadiLoadInventory">
        /// Configuration Instance of 
        /// <see cref="SkadiLoadInventoryConfiguration"/>.
        /// </param>
        /// <returns>
        /// An instance of <see cref="SkadiInventory"/>. Its a simplified
        /// formatted data structure which holds the inventory.
        /// </returns>
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

        /// <summary>
        /// Method to request the inventory of a private accessible inventory.
        /// </summary>
        /// <param name="partnerCommunityId">
        /// Steam community id of the inventory requested.
        /// </param>
        /// <param name="appId">
        /// App Id which should be requested.
        /// </param>
        /// <param name="contextId">
        /// Context Id related to app id.
        /// </param>
        /// <param name="sessionId">
        /// Session id of a login session.
        /// </param>
        /// <param name="steamLoginSecure">
        /// Steam login secure value of a login session.
        /// </param>
        /// <param name="tradeToken">
        /// Trade token of the profile which the inventory is requested for.
        /// </param>
        /// <param name="tradableItems">
        /// Value which filters just for tradable items.
        /// </param>
        /// <param name="steam32Id">
        /// Steam id in 32 Bit format.
        /// </param>
        /// <returns>
        /// An instance of <see cref="SkadiInventory"/>. Its a simplified
        /// formatted data structure which holds the inventory.
        /// </returns>
        public static SkadiInventory LoadPartnerInventory(long partnerCommunityId,
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
            var inventory =
                JsonConvert.DeserializeObject<RootInventory>(responseBody);
            var skadiInventory = SkadiInventoryFactory.Create(inventory);
            return skadiInventory;
        }
    }
}

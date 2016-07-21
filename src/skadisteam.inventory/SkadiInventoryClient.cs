using System;
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
        /// <returns>
        /// An instance of <see cref="SkadiInventory"/>. Its a simplified
        /// formatted data structure which holds the inventory.
        /// </returns>
        public static SkadiInventory LoadPartnerInventory(
            SkadiLoadPartnerInventoryConfiguration
                skadiLoadPartnerInventoryConfiguration)
        {
            var steam32Id =
                Convert.ToInt32(
                    (skadiLoadPartnerInventoryConfiguration.PartnerCommunityId -
                     76561197960265728)/2);
            var path =
                PathFactory.CreatePartnerInventoryPath(
                    skadiLoadPartnerInventoryConfiguration.SessionId,
                    skadiLoadPartnerInventoryConfiguration.PartnerCommunityId,
                    skadiLoadPartnerInventoryConfiguration.AppId,
                    skadiLoadPartnerInventoryConfiguration.ContextId,
                    skadiLoadPartnerInventoryConfiguration.TradableItems);

            var cookieContainer = new CookieContainer()
                .AddEnglishSteamLanguageCookie()
                .AddSteamSessionIdCookie(
                    skadiLoadPartnerInventoryConfiguration.SessionId)
                .AddSteamLoginSecureCookie(
                    skadiLoadPartnerInventoryConfiguration.SteamLoginSecure);

            var requestFactory = new RequestFactory(cookieContainer);
            var response = requestFactory.CreatePartnerInventory(path,
                steam32Id, skadiLoadPartnerInventoryConfiguration.TradeToken);
            var responseBody = response.Content.ReadAsStringAsync().Result;
            var inventory =
                JsonConvert.DeserializeObject<RootInventory>(responseBody);
            var skadiInventory = SkadiInventoryFactory.Create(inventory);
            return skadiInventory;
        }
    }
}

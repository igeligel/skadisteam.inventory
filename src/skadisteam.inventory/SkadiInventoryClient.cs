using System;
using System.Net;
using Newtonsoft.Json;
using skadisteam.inventory.Extensions;
using skadisteam.inventory.Factories;
using skadisteam.inventory.Interfaces;
using skadisteam.inventory.Constants;
using skadisteam.inventory.Models;
using skadisteam.inventory.Models.Json.LoadInventory;

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
        /// <see cref="ISkadiLoadInventoryConfiguration"/>.
        /// </param>
        /// <returns>
        /// An instance of <see cref="ISkadiInventory"/>. Its a simplified
        /// formatted data structure which holds the inventory.
        /// </returns>
        [Obsolete("LoadInventory is deprecated, please use LoadInventoryItems instead.")]
        public static ISkadiInventory LoadInventory(
            ISkadiLoadInventoryConfiguration skadiLoadInventory)
        {
            var path =
                PathFactory.CreatePublicInventoryPath(
                    skadiLoadInventory.PartnerCommunityId,
                    skadiLoadInventory.AppId,
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

        public static Models.SkadiItemInventory.SkadiItemInventory LoadInventoryItems(
            SkadiLoadItemInventoryConfiguration
                skadiLoadItemInventoryConfiguration)
        {
            string path;
            if (skadiLoadItemInventoryConfiguration.Count != null)
            {
                path = PathFactory.CreatePublicItemInventoryPath(
                    skadiLoadItemInventoryConfiguration.PartnerCommunityId,
                    skadiLoadItemInventoryConfiguration.AppId,
                    skadiLoadItemInventoryConfiguration.ContextId,
                    skadiLoadItemInventoryConfiguration.Count.Value);
            }
            else
            {
                path = PathFactory.CreatePublicItemInventoryPath(
                    skadiLoadItemInventoryConfiguration.PartnerCommunityId,
                    skadiLoadItemInventoryConfiguration.AppId,
                    skadiLoadItemInventoryConfiguration.ContextId);
            }
            var requestFactory = new RequestFactory();
            var response = requestFactory.CreateLoadInventory(path);
            var responseBody = response.Content.ReadAsStringAsync().Result;
            var inventory =
                JsonConvert
                    .DeserializeObject<Models.Json.LoadItemInventory.
                        RootInventory>(responseBody);
            var skadiInventory = SkadiInventoryFactory.CreateNew(inventory);
            return skadiInventory;
        }

        /// <summary>
        /// Method to request the inventory of a private accessible inventory.
        /// </summary>
        /// <param name="skadiLoadPartnerInventoryConfiguration">
        /// Configuration for loading partner inventories.
        /// For further reference lookup
        /// <see cref="ISkadiLoadPartnerInventoryConfiguration"/>.
        /// </param>
        /// <returns>
        /// An instance of <see cref="ISkadiInventory"/>. Its a simplified
        /// formatted data structure which holds the inventory.
        /// </returns>
        public static ISkadiInventory LoadPartnerInventory(
            ISkadiLoadPartnerInventoryConfiguration
                skadiLoadPartnerInventoryConfiguration)
        {
            var steam32Id =
                Convert.ToInt32(
                    (skadiLoadPartnerInventoryConfiguration.PartnerCommunityId -
                     SteamIds.StandardCommunity) / 2);
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

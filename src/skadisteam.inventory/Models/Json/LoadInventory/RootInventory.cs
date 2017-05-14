using System.Collections.Generic;
using Newtonsoft.Json;

namespace skadisteam.inventory.Models.Json.LoadInventory
{
    /// <summary>
    /// JSON Model to deserialize the JSON string given by
    /// Steam's inventory endpoint.
    /// </summary>
    internal class RootInventory
    {
        /// <summary>
        /// Boolean which describes if it is needed to query for more
        /// items in the inventory because the inventory can be bigger
        /// than 1000 items. Then you need to make an additional call
        /// to the endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "more")]
        internal bool More { get; set; }

        // TODO: XML Documentation
        [JsonProperty(PropertyName = "more_start")]
        internal bool MoreStart { get; set; }

        /// <summary>
        /// Information about app you are requesting the inventory to.
        /// </summary>
        [JsonProperty(PropertyName = "rgAppInfo")]
        internal bool AppInfo { get; set; }

        // TODO: Implement currencies.
        /// <summary>
        /// Information about currencies.
        /// </summary>
        [JsonProperty(PropertyName = "rgCurrency")]
        internal List<object> Currencies { get; set; }

        /// <summary>
        /// Dictionary of descriptions given by steam for items that are in
        /// your inventory. For further information lookup
        /// <see cref="Description"/>.
        /// </summary>
        [JsonProperty(PropertyName = "rgDescriptions")]
        internal Dictionary<string, Description> Descriptions { get; set; }

        /// <summary>
        /// Dictionary which contains all the items of the inventory. There
        /// are just the basic id's provided. You need to fetch them dynamically
        /// to the descriptions given by the JSON response.
        /// </summary>
        [JsonProperty(PropertyName = "rgInventory")]
        internal Dictionary<string, Item> Inventory { get; set; }

        /// <summary>
        /// Boolean value which describes if the call was successful or not.
        /// </summary>
        [JsonProperty(PropertyName = "success")]
        internal bool Success { get; set; }
    }
}

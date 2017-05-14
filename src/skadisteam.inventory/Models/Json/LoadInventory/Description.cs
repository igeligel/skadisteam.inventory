using System.Collections.Generic;
using Newtonsoft.Json;

namespace skadisteam.inventory.Models.Json.LoadInventory
{
    /// <summary>
    /// Description of the JSON responses. This will include
    /// descriptions for all items to the inventory requested.
    /// </summary>
    internal class Description
    {
        /// <summary>
        /// App id of the requested inventory.
        /// </summary>
        [JsonProperty(PropertyName = "appid")]
        internal int AppId { get; set; }

        /// <summary>
        /// Background color of the item. This property is related
        /// to the game. Some games do not have this color.
        /// </summary>
        [JsonProperty(PropertyName = "background_color")]
        internal string BackgroundColor { get; set; }

        /// <summary>
        /// Id of the class. The class is describing the item.
        /// </summary>
        [JsonProperty(PropertyName = "classid")]
        internal long ClassId { get; set; }

        /// <summary>
        /// Is describing the actual content of the description.
        /// </summary>
        [JsonProperty(PropertyName = "commodity")]
        internal int Commodity { get; set; }

        /// <summary>
        /// Contains a list of more specific descriptions.
        /// </summary>
        [JsonProperty(PropertyName = "descriptions")]
        internal List<ExtraDescription> Descriptions { get; set; }

        /// <summary>
        /// URL for the icon which is used to drag in the steamcommunity
        /// services.
        /// </summary>
        [JsonProperty(PropertyName = "icon_drag_url")]
        internal string IconDragUrl { get; set; }

        /// <summary>
        /// Icon URL which is used for icons in the steamcommunity services.
        /// </summary>
        [JsonProperty(PropertyName = "icon_url")]
        internal string IconUrl { get; set; }

        /// <summary>
        /// Instance id of the item. This id is related to the class id. There
        /// can be several items with the same instance id but they have different
        /// classes. So the combination out of class id and instance id is unique
        /// for one inventory.
        /// </summary>
        [JsonProperty(PropertyName = "instanceid")]
        internal long InstanceId { get; set; }

        /// <summary>
        /// Market hash name which is used by the steam market.
        /// </summary>
        [JsonProperty(PropertyName = "market_hash_name")]
        internal string MarketHashName { get; set; }

        /// <summary>
        /// Simple Market name for the steamcommunity market which is used for
        /// representation of the item.
        /// </summary>
        [JsonProperty(PropertyName = "market_name")]
        internal string MarketName { get; set; }

        /// <summary>
        /// Value which describes if the item has a market or trading restriction.
        /// </summary>
        [JsonProperty(PropertyName = "market_tradable_restriction")]
        internal int MarketTradableRestriction { get; set; }

        /// <summary>
        /// Name of the item.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        internal string Name { get; set; }

        /// <summary>
        /// Color of the name.
        /// </summary>
        [JsonProperty(PropertyName = "name_color")]
        internal string NameColor { get; set; }

        /// <summary>
        /// List of special tags for the items. For further
        /// information lookup <see cref="Tag"/>.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        internal List<Tag> Tags { get; set; }

        /// <summary>
        /// Value which describes if the item is tradable or
        /// not.
        /// </summary>
        [JsonProperty(PropertyName = "tradable")]
        internal int Tradable { get; set; }

        /// <summary>
        /// Value which describes the type of the item.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        internal string Type { get; set; }
    }
}

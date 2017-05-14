using System.Collections.Generic;
using Newtonsoft.Json;

namespace skadisteam.inventory.Models.Json.LoadItemInventory
{
    internal class Description
    {
        [JsonProperty(PropertyName = "appid")]
        internal int AppId { get; set; }

        [JsonProperty(PropertyName = "classid")]
        internal string ClassId { get; set; }

        [JsonProperty(PropertyName = "instanceid")]
        internal string InstanceId { get; set; }

        [JsonProperty(PropertyName = "currency")]
        internal int Currency { get; set; }

        [JsonProperty(PropertyName = "background_color")]
        internal string BackgroundColor { get; set; }

        [JsonProperty(PropertyName = "icon_url")]
        internal string IconUrl { get; set; }

        [JsonProperty(PropertyName = "icon_url_large")]
        internal string IconUrlLarge { get; set; }

        [JsonProperty(PropertyName = "descriptions")]
        internal List<InnerDescription> Descriptions { get; set; }

        [JsonProperty(PropertyName = "tradable")]
        internal int Tradable { get; set; }

        [JsonProperty(PropertyName = "name")]
        internal string Name { get; set; }

        [JsonProperty(PropertyName = "type")]
        internal string Type { get; set; }

        [JsonProperty(PropertyName = "market_name")]
        internal string MarketName { get; set; }

        [JsonProperty(PropertyName = "market_hash_name")]
        internal string MarketHashName { get; set; }

        [JsonProperty(PropertyName = "market_fee_app")]
        internal int MarketFeeApp { get; set; }

        [JsonProperty(PropertyName = "commodity")]
        internal int Commodity { get; set; }

        [JsonProperty(PropertyName = "market_tradable_restriction")]
        internal int MarketTradableRestriction { get; set; }

        [JsonProperty(PropertyName = "market_marketable_restriction")]
        internal int MarketMarketableRestriction { get; set; }

        [JsonProperty(PropertyName = "marketable")]
        internal int Marketable { get; set; }

        [JsonProperty(PropertyName = "tags")]
        internal List<Tag> Tags { get; set; }

        [JsonProperty(PropertyName = "actions")]
        internal List<Action> Actions { get; set; }
    }
}

using System.Collections.Generic;

namespace skadisteam.inventory.Models.SkadiItemInventory
{
    public class SkadiItem
    {
        public int AppId { get; set; }
        public int ContextId { get; set; }
        public long AssetId { get; set; }
        public long ClassId { get; set; }
        public long InstanceId { get; set; }
        public int Amount { get; set; }
        public int Currency { get; set; }
        public string BackgroundColor { get; set; }
        public string IconUrl { get; set; }
        public string IconUrlLarge { get; set; }
        public List<SkadiItemDescription> Descriptions { get; set; }
        public bool Tradable { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string MarketName { get; set; }
        public string MarketHashName { get; set; }
        public int MarketFeeApp { get; set; }
        public int Commodity { get; set; }
        public int MarketTradableRestriction { get; set; }
        public int MarketMarketableRestriction { get; set; }
        public bool Marketable { get; set; }
        public List<SkadiItemTag> Tags { get; set; }
        public List<SkadiItemAction> Actions { get; set; }
    }
}

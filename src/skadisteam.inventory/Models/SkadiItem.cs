using System.Collections.Generic;
using skadisteam.inventory.Models.Json;

namespace skadisteam.inventory.Models
{
    public class SkadiItem
    {
        public int Amount { get; set; }
        public long ClassId { get; set; }
        public long AssetId { get; set; }
        public long InstanceId { get; set; }
        public int Position { get; set; }
        public string BackgroundColor { get; set; }
        public int Commodity { get; set; }
        public List<ExtraDescription> Description { get; set; }
        public string IconDragUrl { get; set; }
        public string IconUrl { get; set; }
        public string MarketHashName { get; set; }
        public string MarketName { get; set; }
        public int MarketTradableRestriction { get; set; }
        public string Name { get; set; }
        public string NameColor { get; set; }
        public List<Tag> Tags { get; set; }
        public int Tradable { get; set; }
        public string Type { get; set; }
    }
}

namespace skadisteam.inventory.Models
{
    public class SkadiLoadInventoryConfiguration
    {
        public long PartnerId { get; set; }
        public int AppId { get; set; }
        public int ContextId { get; set; }
        public bool TradableItems { get; set; }
        public long TradeOfferId { get; set; }
        public string Language { get; set; }
    }
}

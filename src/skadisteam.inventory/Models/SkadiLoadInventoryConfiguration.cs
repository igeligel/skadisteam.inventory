namespace skadisteam.inventory.Models
{
    /// <summary>
    /// Configuration Class for providing special properties
    /// to the actual procedure of requesting the inventory.
    /// </summary>
    public class SkadiLoadInventoryConfiguration
    {
        /// <summary>
        /// The Id which should be the inventory requested to.
        /// </summary>
        public long PartnerId { get; set; }

        /// <summary>
        /// Which app id should be requested.
        /// </summary>
        public int AppId { get; set; }

        /// <summary>
        /// Context id to the app id.
        /// </summary>
        public int ContextId { get; set; }

        /// <summary>
        /// Value to decide if jsut tradable items should
        /// be in the output or not.
        /// </summary>
        public bool TradableItems { get; set; }

        /// <summary>
        /// Id for a trade offer which is sent.
        /// </summary>
        public long TradeOfferId { get; set; }

        /// <summary>
        /// Language option.
        /// </summary>
        public string Language { get; set; }
    }
}

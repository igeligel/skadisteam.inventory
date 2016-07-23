using skadisteam.inventory.Interfaces;

namespace skadisteam.inventory.Models
{
    /// <summary>
    /// Configuration Class for providing special properties
    /// to the actual procedure of requesting the inventory.
    /// </summary>
    public class SkadiLoadInventoryConfiguration: ISkadiLoadInventoryConfiguration
    {
        /// <summary>
        /// Which app id should be requested.
        /// </summary>
        public int AppId { get; set; }

        /// <summary>
        /// Context id to the app id.
        /// </summary>
        public int ContextId { get; set; }

        /// <summary>
        /// Steam community id of the inventory requested.
        /// </summary>
        public long PartnerCommunityId { get; set; }

        /// <summary>
        /// Value to decide if jsut tradable items should
        /// be in the output or not.
        /// </summary>
        public bool TradableItems { get; set; }

        /// <summary>
        /// Language option.
        /// </summary>
        public string Language { get; set; }
    }
}

namespace skadisteam.inventory.Models
{
    public class SkadiLoadItemInventoryConfiguration
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

        public int? Count { get; set; }
    }
}

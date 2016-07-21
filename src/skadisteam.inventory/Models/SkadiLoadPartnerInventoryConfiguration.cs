namespace skadisteam.inventory.Models
{
    public class SkadiLoadPartnerInventoryConfiguration
    {
        /// <summary>
        /// App Id which should be requested.
        /// </summary>
        public int AppId { get; set; }

        /// <summary>
        /// Context Id related to app id.
        /// </summary>
        public int ContextId { get; set; }

        /// <summary>
        /// Steam community id of the inventory requested.
        /// </summary>
        public long PartnerCommunityId { get; set; }

        /// <summary>
        /// Session id of a login session.
        /// </summary>
        public string SessionId { get; set; }

        /// <summary>
        /// Steam login secure value of a login session.
        /// </summary>
        public string SteamLoginSecure { get; set; }

        /// <summary>
        /// Trade token of the profile which the inventory is requested for.
        /// </summary>
        public string TradeToken { get; set; }

        /// <summary>
        /// Value which filters just for tradable items.
        /// </summary>
        public bool TradableItems { get; set; }
    }
}

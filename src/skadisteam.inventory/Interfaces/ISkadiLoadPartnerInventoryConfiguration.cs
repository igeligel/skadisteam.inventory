namespace skadisteam.inventory.Interfaces
{
    public interface ISkadiLoadPartnerInventoryConfiguration
    {
        /// <summary>
        /// App Id which should be requested.
        /// </summary>
        int AppId { get; set; }

        /// <summary>
        /// Context Id related to app id.
        /// </summary>
        int ContextId { get; set; }

        /// <summary>
        /// Steam community id of the inventory requested.
        /// </summary>
        long PartnerCommunityId { get; set; }

        /// <summary>
        /// Session id of a login session.
        /// </summary>
        string SessionId { get; set; }

        /// <summary>
        /// Steam login secure value of a login session.
        /// </summary>
        string SteamLoginSecure { get; set; }

        /// <summary>
        /// Trade token of the profile which the inventory is requested for.
        /// </summary>
        string TradeToken { get; set; }

        /// <summary>
        /// Value which filters just for tradable items.
        /// </summary>
        bool TradableItems { get; set; }
    }
}

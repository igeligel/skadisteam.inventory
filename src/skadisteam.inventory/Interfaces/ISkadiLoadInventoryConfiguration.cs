namespace skadisteam.inventory.Interfaces
{
    /// <summary>
    /// Interface to declare minimum of parameters given to
    /// the login.
    /// </summary>
    public interface ISkadiLoadInventoryConfiguration
    {
        /// <summary>
        /// Which app id should be requested.
        /// </summary>
        int AppId { get; set; }

        /// <summary>
        /// Context id to the app id.
        /// </summary>
        int ContextId { get; set; }
        
        /// <summary>
        /// Steam community id of the inventory requested.
        /// </summary>
        long PartnerCommunityId { get; set; }

        /// <summary>
        /// Value to decide if jsut tradable items should
        /// be in the output or not.
        /// </summary>
        bool TradableItems { get; set; }
    }
}

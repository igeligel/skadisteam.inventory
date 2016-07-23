using System.Collections.Generic;

namespace skadisteam.inventory.Interfaces
{
    public interface ISkadiItem
    {
        /// <summary>
        /// Amount of items. This is only used for special items
        /// like gems of the Steam Community.
        /// </summary>
        int Amount { get; set; }

        /// <summary>
        /// Asset Id of the item, which is used in several trading parts.
        /// </summary>
        long AssetId { get; set; }

        /// <summary>
        /// Background color of the item. This property is related
        /// to the game. Some games do not have this color.
        /// </summary>
        string BackgroundColor { get; set; }

        /// <summary>
        /// Id of the class. The class is describing the item.
        /// </summary>
        long ClassId { get; set; }

        /// <summary>
        /// Is describing the actual content of the description.
        /// </summary>
        int Commodity { get; set; }

        /// <summary>
        /// Contains a list of more specific descriptions.
        /// For further information lookup 
        /// <see cref="SkadiItemDescription"/>.
        /// </summary>
        List<ISkadiItemDescription> Description { get; set; }

        /// <summary>
        /// URL for the icon which is used to drag in the steamcommunity
        /// services.
        /// </summary>
        string IconDragUrl { get; set; }

        /// <summary>
        /// Icon URL which is used for icons in the steamcommunity services.
        /// </summary>
        string IconUrl { get; set; }

        /// <summary>
        /// Instance id of the item. This id is related to the class id. There
        /// can be several items with the same instance id but they have different
        /// classes. So the combination out of class id and instance id is unique
        /// for one inventory.
        /// </summary>
        long InstanceId { get; set; }

        /// <summary>
        /// Market hash name which is used by the steam market.
        /// </summary>
        string MarketHashName { get; set; }

        /// <summary>
        /// Simple Market name for the steamcommunity market which is used for
        /// representation of the item.
        /// </summary>
        string MarketName { get; set; }

        /// <summary>
        /// Value which describes if the item has a market or trading restriction.
        /// </summary>
        int MarketTradableRestriction { get; set; }

        /// <summary>
        /// Name of the item.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Color of the name.
        /// </summary>
        string NameColor { get; set; }

        /// <summary>
        /// Position of the item in the inventory.
        /// </summary>
        int Position { get; set; }

        /// <summary>
        /// List of special tags for the items. For further
        /// information lookup <see cref="SkadiItemTag"/>.
        /// </summary>
        List<ISkadiItemTag> Tags { get; set; }

        /// <summary>
        /// Value which describes if the item is tradable or
        /// not.
        /// </summary>
        int Tradable { get; set; }

        /// <summary>
        /// Value which describes the type of the item.
        /// </summary>
        string Type { get; set; }
    }
}

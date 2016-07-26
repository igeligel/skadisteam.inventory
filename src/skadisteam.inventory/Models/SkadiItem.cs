using System.Collections.Generic;
using skadisteam.inventory.Interfaces;

namespace skadisteam.inventory.Models
{
    /// <summary>
    /// Class for defining items in the inventory of a user.
    /// </summary>
    public class SkadiItem: ISkadiItem
    {
        /// <summary>
        /// Amount of items. This is only used for special items
        /// like gems of the Steam Community.
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Asset Id of the item, which is used in several trading parts.
        /// </summary>
        public long AssetId { get; set; }

        /// <summary>
        /// Background color of the item. This property is related
        /// to the game. Some games do not have this color.
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Id of the class. The class is describing the item.
        /// </summary>
        public long ClassId { get; set; }

        /// <summary>
        /// Is describing the actual content of the description.
        /// </summary>
        public int Commodity { get; set; }

        /// <summary>
        /// Contains a list of more specific descriptions.
        /// For further information lookup 
        /// <see cref="ISkadiItemDescription"/>.
        /// </summary>
        public List<ISkadiItemDescription> Description { get; set; }

        /// <summary>
        /// URL for the icon which is used to drag in the steamcommunity
        /// services.
        /// </summary>
        public string IconDragUrl { get; set; }

        /// <summary>
        /// Icon URL which is used for icons in the steamcommunity services.
        /// </summary>
        public string IconUrl { get; set; }

        /// <summary>
        /// Instance id of the item. This id is related to the class id. There
        /// can be several items with the same instance id but they have different
        /// classes. So the combination out of class id and instance id is unique
        /// for one inventory.
        /// </summary>
        public long InstanceId { get; set; }

        /// <summary>
        /// Market hash name which is used by the steam market.
        /// </summary>
        public string MarketHashName { get; set; }

        /// <summary>
        /// Simple Market name for the steamcommunity market which is used for
        /// representation of the item.
        /// </summary>
        public string MarketName { get; set; }

        /// <summary>
        /// Value which describes if the item has a market or trading restriction.
        /// </summary>
        public int MarketTradableRestriction { get; set; }

        /// <summary>
        /// Name of the item.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Color of the name.
        /// </summary>
        public string NameColor { get; set; }

        /// <summary>
        /// Position of the item in the inventory.
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// List of special tags for the items. For further
        /// information lookup <see cref="ISkadiItemTag"/>.
        /// </summary>
        public List<ISkadiItemTag> Tags { get; set; }

        /// <summary>
        /// Value which describes if the item is tradable or
        /// not.
        /// </summary>
        public int Tradable { get; set; }

        /// <summary>
        /// Value which describes the type of the item.
        /// </summary>
        public string Type { get; set; }
    }
}

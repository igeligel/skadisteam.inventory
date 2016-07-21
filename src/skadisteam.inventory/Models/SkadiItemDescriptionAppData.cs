namespace skadisteam.inventory.Models
{
    /// <summary>
    /// Specific information of an item. The propertie's
    /// value is related to the app which is requested.
    /// </summary>
    public class SkadiItemDescriptionAppData
    {
        /// <summary>
        /// Definition Index of the item.
        /// </summary>
        public string DefIndex { get; set; }

        /// <summary>
        /// Value which describes if an item set name is
        /// set.
        /// </summary>
        public int IsItemSetName { get; set; }

        /// <summary>
        /// Value which describes if an item was limited by
        /// Steam.
        /// </summary>
        public int Limited { get; set; }
    }
}

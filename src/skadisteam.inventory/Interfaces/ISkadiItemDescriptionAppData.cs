namespace skadisteam.inventory.Interfaces
{
    public interface ISkadiItemDescriptionAppData
    {
        /// <summary>
        /// Definition Index of the item.
        /// </summary>
        string DefIndex { get; set; }

        /// <summary>
        /// Value which describes if an item set name is
        /// set.
        /// </summary>
        int IsItemSetName { get; set; }

        /// <summary>
        /// Value which describes if an item was limited by
        /// Steam.
        /// </summary>
        int Limited { get; set; }
    }
}

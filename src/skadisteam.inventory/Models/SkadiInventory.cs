using System.Collections.Generic;
using skadisteam.inventory.Interfaces;

namespace skadisteam.inventory.Models
{
    /// <summary>
    /// Class to define a data structure which holds all items
    /// of an inventory. This will just hold a list of
    /// <see cref="ISkadiItem"/>. This model is simplified and
    /// not based on dictionaries which make working with
    /// inventories easier.
    /// </summary>
    public class SkadiInventory: ISkadiInventory
    {
        /// <summary>
        /// List of <see cref="ISkadiItem"/>.
        /// </summary>
        public List<ISkadiItem> Items { get; set; }
    }
}

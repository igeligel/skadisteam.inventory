using System.Collections.Generic;

namespace skadisteam.inventory.Models.SkadiItemInventory
{
    public class SkadiItemInventory
    {
        public int Rwgrsn { get; set; }
        public List<SkadiItem> Items { get; set; }
    }
}

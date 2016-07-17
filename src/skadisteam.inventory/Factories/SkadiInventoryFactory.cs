using skadisteam.inventory.Models;
using skadisteam.inventory.Models.Json;
using System.Collections.Generic;
using System.Linq;

namespace skadisteam.inventory.Factories
{
    public static class SkadiInventoryFactory
    {
        internal static SkadiInventory Create(RootInventory rootInventory)
        {
            SkadiInventory skadiInventory = new SkadiInventory();
            skadiInventory.Items = new List<SkadiItem>();
            
            var descriptions = rootInventory.Descriptions;
            var inventory = rootInventory.Inventory;

            foreach (KeyValuePair<string, Item> entry in inventory)
            {
                SkadiItem skadiItem = new SkadiItem();
                skadiItem.Amount =  entry.Value.Amount;
                skadiItem.ClassId = entry.Value.ClassId;
                skadiItem.InstanceId = entry.Value.InstanceId;
                skadiItem.AssetId = entry.Value.Id;
                skadiItem.Position = entry.Value.Pos;

                var description =
                    descriptions.FirstOrDefault(
                        e =>
                            e.Key ==
                            skadiItem.ClassId + "_" + skadiItem.InstanceId);

                skadiItem.BackgroundColor = description.Value.BackgroundColor;
                skadiItem.Commodity = description.Value.Commodity;
                skadiItem.Description = description.Value.Descriptions;
                skadiItem.IconDragUrl = description.Value.IconDragUrl;
                skadiItem.IconUrl = description.Value.IconUrl;
                skadiItem.MarketHashName = description.Value.MarketHashName;
                skadiItem.MarketName = description.Value.MarketName;
                skadiItem.MarketTradableRestriction = description.Value.MarketTradableRestriction;
                skadiItem.Name = description.Value.Name;
                skadiItem.NameColor = description.Value.NameColor;
                skadiItem.Tags = description.Value.Tags;
                skadiItem.Tradable = description.Value.Tradable;
                skadiItem.Type = description.Value.Type;

                skadiInventory.Items.Add(skadiItem);
            }
            return skadiInventory;
        }
    }
}

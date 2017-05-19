using Newtonsoft.Json;
using skadisteam.inventory.Factories;
using skadisteam.inventory.Models.Json.LoadInventory;
using skadisteam.inventory.test.Constants;
using Xunit;

namespace skadisteam.inventory.test.Factories
{
    public class SkadiInventoryTest
    {
        [Fact]
        public void CsGoInventoryCountOne()
        {
            var rootInventory = JsonConvert.DeserializeObject<RootInventory>(Inventories.CsGoOne);
            var skadiInventory = SkadiInventoryFactory.Create(rootInventory);
            Assert.Equal(4, skadiInventory.Items.Count);
        }

        [Fact]
        public void CsGoInventoryCountTwo()
        {
            var rootInventory = JsonConvert.DeserializeObject<RootInventory>(Inventories.CsGoTwo);
            var skadiInventory = SkadiInventoryFactory.Create(rootInventory);
            Assert.Equal(753, skadiInventory.Items.Count);
        }

        [Fact]
        public void CsGoInventoryCountThree()
        {
            var rootInventory = JsonConvert.DeserializeObject<RootInventory>(Inventories.CsGoThree);
            var skadiInventory = SkadiInventoryFactory.Create(rootInventory);
            Assert.Equal(24, skadiInventory.Items.Count);
        }

        [Fact]
        public void SteamInventoryCountOne()
        {
            var rootInventory = JsonConvert.DeserializeObject<RootInventory>(Inventories.SteamOne);
            var skadiInventory = SkadiInventoryFactory.Create(rootInventory);
            Assert.Equal(58, skadiInventory.Items.Count);
        }

        [Fact]
        public void TeamFortressInventoryCountOne()
        {
            var rootInventory = JsonConvert.DeserializeObject<RootInventory>(Inventories.TeamFortressOne);
            var skadiInventory = SkadiInventoryFactory.Create(rootInventory);
            Assert.Equal(85, skadiInventory.Items.Count);
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(66,22);
        }
    }
}

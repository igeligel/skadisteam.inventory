using skadisteam.inventory.Factories;
using Xunit;

namespace skadisteam.inventory.test.Factories
{
    public class PathTest
    {
        private const string sessionId = "89113adWD1";

        [Fact]
        public void CreatePublicInventoryPath()
        {
            var path = PathFactory.CreatePublicInventoryPath(76561198028630048,
                730, 2, false);
            Assert.Equal("/profiles/76561198028630048/inventory/json/730/2",
                path);
        }

        [Fact]
        public void CreatePublicTradableInventoryPath()
        {
            var path = PathFactory.CreatePublicInventoryPath(76561198028630048,
                730, 2, true);
            Assert.Equal(
                "/profiles/76561198028630048/inventory/json/730/2?trading=1",
                path);
        }

        [Fact]
        public void CreatePartnerInventoryPath()
        {
            var path = PathFactory.CreatePartnerInventoryPath(sessionId,
                76561198028630048, 730, 2, false);
            var expectedPath =
                "/tradeoffer/new/partnerinventory/" +
                "?sessionid=89113adWD1" +
                "&partner=76561198028630048" +
                "&appid=730" +
                "&contextid=2";
            Assert.Equal(expectedPath, path);
        }

        [Fact]
        public void CreatePartnerTradableInventoryPath()
        {
            var path = PathFactory.CreatePartnerInventoryPath(sessionId,
                76561198028630048, 730, 2, true);
            var expectedPath =
                "/tradeoffer/new/partnerinventory/" +
                "?sessionid=89113adWD1" +
                "&partner=76561198028630048" +
                "&appid=730" +
                "&contextid=2" +
                "&trading=1";
            Assert.Equal(expectedPath, path);
        }

        [Fact]
        public void CreatePublicItemInventoryPath()
        {
            var path =
                PathFactory.CreatePublicItemInventoryPath(76561198028630048,
                    730, 2);
            const string expectedPath =
                "/inventory/76561198028630048/730/2?l=english&count=5000";
            Assert.Equal(expectedPath, path);
        }

        [Fact]
        public void CreatePublicItemInventoryPathCount()
        {
            var path =
                PathFactory.CreatePublicItemInventoryPath(76561198028630048,
                    730, 2, 275);
            const string expectedPath =
                "/inventory/76561198028630048/730/2?l=english&count=275";
            Assert.Equal(expectedPath, path);
        }
    }
}

using skadisteam.inventory.Extensions;
using Xunit;

namespace skadisteam.inventory.test.Extensions
{
    public class StringTest
    {
        [Fact]
        public void AddTradableItemParameterToEmptyString()
        {
            var baseString = string.Empty;
            baseString = baseString.AddTradableItemParameter();
            Assert.Equal("&trading=1", baseString);
        }

        [Fact]
        public void AddTradableItemParameterToExistingString()
        {
            var baseString = "http://www.google.com/?test=1";
            baseString = baseString.AddTradableItemParameter();
            Assert.Equal("http://www.google.com/?test=1&trading=1", baseString);
        }

        [Fact]
        public void AddNewTradableItemParameterToEmptyString()
        {
            var baseString = string.Empty;
            baseString = baseString.AddNewTradableItemParameter();
            Assert.Equal("?trading=1", baseString);
        }

        [Fact]
        public void AddNewTradableItemParameterExistingString()
        {
            var baseString = "http://www.google.com/";
            baseString = baseString.AddNewTradableItemParameter();
            Assert.Equal("http://www.google.com/?trading=1", baseString);
        }
    }
}

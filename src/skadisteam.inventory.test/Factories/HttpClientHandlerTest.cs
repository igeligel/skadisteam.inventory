using System;
using skadisteam.inventory.Factories;
using System.Net;
using Xunit;

namespace skadisteam.inventory.test.Factories
{
    public class HttpClientHandlerTest
    {
        [Fact]
        public void CreateCookieCount()
        {
            var clientHandler = HttpClientHandlerFactory.Create();
            Assert.Equal(1, clientHandler.CookieContainer.Count);
        }

        [Fact]
        public void CreateAutomaticDecompression()
        {
            var clientHandler = HttpClientHandlerFactory.Create();
            var decompression = clientHandler.AutomaticDecompression;
            Assert.Equal(decompression,
                DecompressionMethods.GZip | DecompressionMethods.Deflate);
        }

        [Fact]
        public void CreateWithCookieContainerCookieCount()
        {
            CookieContainer cookieContainer = new CookieContainer();
            cookieContainer.Add(new Uri("https://www.google.com"),
                new Cookie("testName", "testValue"));
            var clientHandler = HttpClientHandlerFactory.Create(cookieContainer);
            Assert.Equal(1, clientHandler.CookieContainer.Count);
        }

        [Fact]
        public void CreateWithCookieContainerAutomaticDecompression()
        {
            CookieContainer cookieContainer = new CookieContainer();
            cookieContainer.Add(new Uri("https://www.google.com"),
                new Cookie("testName", "testValue"));
            var clientHandler = HttpClientHandlerFactory.Create(cookieContainer);
            var decompression = clientHandler.AutomaticDecompression;
            Assert.Equal(decompression,
                DecompressionMethods.GZip | DecompressionMethods.Deflate);
        }
    }
}

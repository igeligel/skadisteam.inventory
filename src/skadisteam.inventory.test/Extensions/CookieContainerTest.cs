using skadisteam.inventory.Constants;
using skadisteam.inventory.Extensions;
using System.Net;
using Xunit;

namespace skadisteam.inventory.test.Extensions
{
    public class CookieContainerTest
    {
        private const string sessionId = "89113adWD1";
        private const string steamLoginSecure = "12415698127dwjDWANjndadWdwamnJ71";

        [Fact]
        public void AddEnglishSteamLanguageCookieCount()
        {
            CookieContainer cookieContainer = new CookieContainer();
            cookieContainer.AddEnglishSteamLanguageCookie();
            Assert.Equal(1, cookieContainer.Count);
        }

        [Fact]
        public void AddEnglishSteamLanguageCookieName()
        {
            CookieContainer cookieContainer = new CookieContainer();
            cookieContainer.AddEnglishSteamLanguageCookie();
            var test = cookieContainer.GetCookies(Uris.SteamCommunityBaseSecured);
            Assert.Equal("Steam_Language", test["Steam_Language"].Name);
        }

        [Fact]
        public void AddEnglishSteamLanguageCookieValue()
        {
            CookieContainer cookieContainer = new CookieContainer();
            cookieContainer.AddEnglishSteamLanguageCookie();
            var test = cookieContainer.GetCookies(Uris.SteamCommunityBaseSecured);
            Assert.Equal("english", test["Steam_Language"].Value);
        }

        [Fact]
        public void AddSteamSessionIdCookieCount()
        {
            CookieContainer cookieContainer = new CookieContainer();
            cookieContainer.AddSteamSessionIdCookie(sessionId);
            Assert.Equal(1, cookieContainer.Count);
        }

        [Fact]
        public void AddSteamSessionIdCookieName()
        {
            CookieContainer cookieContainer = new CookieContainer();
            cookieContainer.AddSteamSessionIdCookie(sessionId);
            var test = cookieContainer.GetCookies(Uris.SteamCommunityBaseSecured);
            Assert.Equal(CookieKeys.SessionId, test[CookieKeys.SessionId].Name);
        }

        [Fact]
        public void AddSteamSessionIdCookieValue()
        {
            CookieContainer cookieContainer = new CookieContainer();
            cookieContainer.AddSteamSessionIdCookie(sessionId);
            var test = cookieContainer.GetCookies(Uris.SteamCommunityBaseSecured);
            Assert.Equal(sessionId, test[CookieKeys.SessionId].Value);
        }

        [Fact]
        public void AddSteamLoginSecureCookieCount()
        {
            CookieContainer cookieContainer = new CookieContainer();
            cookieContainer.AddSteamLoginSecureCookie(steamLoginSecure);
            Assert.Equal(1, cookieContainer.Count);
        }

        [Fact]
        public void AddSteamLoginSecureCookieName()
        {
            CookieContainer cookieContainer = new CookieContainer();
            cookieContainer.AddSteamLoginSecureCookie(steamLoginSecure);
            var test = cookieContainer.GetCookies(Uris.SteamCommunityBaseSecured);
            Assert.Equal(CookieKeys.SteamLoginSecure, test[CookieKeys.SteamLoginSecure].Name);
        }

        [Fact]
        public void AddSteamLoginSecureCookieValue()
        {
            CookieContainer cookieContainer = new CookieContainer();
            cookieContainer.AddSteamLoginSecureCookie(steamLoginSecure);
            var test = cookieContainer.GetCookies(Uris.SteamCommunityBaseSecured);
            Assert.Equal(steamLoginSecure, test[CookieKeys.SteamLoginSecure].Value);
        }
    }
}

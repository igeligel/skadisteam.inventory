using System.Net;
using skadisteam.inventory.Constants;

namespace skadisteam.inventory.Extensions
{
    internal static class CookieContainerExtensions
    {
        internal static CookieContainer AddEnglishSteamLanguageCookie(
            this CookieContainer cookieContainer)
        {
            var cookie = new Cookie(CookieKeys.SteamLanguage,
                CookieValues.SteamLanguage, "",
                Uris.SteamCommunityBaseSecured.Host);
            cookieContainer.Add(Uris.SteamCommunityBaseSecured, cookie);
            return cookieContainer;
        }

        internal static CookieContainer AddSteamSessionIdCookie(
            this CookieContainer cookieContainer, string sessionId)
        {
            var cookie = new Cookie(CookieKeys.SessionId, sessionId, "/",
                Uris.SteamCommunityBaseSecured.Host);
            cookieContainer.Add(Uris.SteamCommunityBaseSecured, cookie);
            return cookieContainer;
        }

        internal static CookieContainer AddSteamLoginSecureCookie(
            this CookieContainer cookieContainer, string steamLoginSecure)
        {
            var cookie = new Cookie(CookieKeys.SteamLoginSecure,
                steamLoginSecure, "/", Uris.SteamCommunityBaseSecured.Host);
            cookieContainer.Add(Uris.SteamCommunityBaseSecured, cookie);
            return cookieContainer;
        }
    }
}
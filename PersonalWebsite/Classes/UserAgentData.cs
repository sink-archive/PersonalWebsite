using Microsoft.AspNetCore.Http;
using Microsoft.Net.Http.Headers;
using UAParser;

namespace PersonalWebsite
{
    public static class UserAgentData
    {
        /// <summary>
        /// Gets the user agent, and also populates the fields.
        /// </summary>
        /// <param name="httpContext">The HttpContext</param>
        /// <returns>A ClientInfo object</returns>
        public static ClientInfo GetUserAgent(HttpContext httpContext)
        {
            var ua = httpContext.Request.Headers[HeaderNames.UserAgent][0];
            var uaParser = Parser.GetDefault();
            var c = uaParser.Parse(ua);

            UserOs = c.OS.Family;
            UserDeviceType = c.Device.Family;
            UserOsMajorVer = c.OS.Major;
            UserOsMinorVer = c.OS.Minor;
            UserOsPatchVer = c.OS.Patch;
            UserOsMinorPatchVer = c.OS.PatchMinor;

            return c;
        }

        public static string UserOs;
        public static string UserDeviceType;
        public static string UserOsMajorVer;
        public static string UserOsMinorVer;
        public static string UserOsPatchVer;
        public static string UserOsMinorPatchVer;
    }
}

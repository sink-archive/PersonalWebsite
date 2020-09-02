using System.Collections.Generic;
using System.Linq;

namespace PersonalWebsite
{
    public class JbStatus
    {
        public JbStatus(string name, List<string> unJailbreakbleVers, string method, string url, string alt = null, string alturl = null)
        {
            Name = name;
            UnJailbreakableVers = unJailbreakbleVers;
            Method = method;
            MethodUrl = url;
            AltMethod = alt;
            AltMethodUrl = alturl;
        }

        public string Name;

        public List<string> UnJailbreakableVers;

        public string Method;
        public string MethodUrl;

        public string AltMethod;
        public string AltMethodUrl;

        public bool Jailbreakable(string ver) => UnJailbreakableVers.Where(v => v == ver).Count() != 0;
    }
}

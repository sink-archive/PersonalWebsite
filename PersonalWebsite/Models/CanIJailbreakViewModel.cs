using System.Collections.Generic;
using System.Text;

namespace PersonalWebsite.Models
{
    public class CanIJailbreakViewModel
    {
        public string MajorVer;
        public string MinorVer;
        public string PatchVer;
        public string MinorPatchVer;


        public string DeviceType;
        public string OS;

        public string FriendlyUserAgent {
            get
            {
                var sb = new StringBuilder($"You are running {OS} ");
                ConditionalAppend(ref sb, MajorVer, "");
                ConditionalAppend(ref sb, MinorVer);
                ConditionalAppend(ref sb, PatchVer);
                ConditionalAppend(ref sb, MinorPatchVer);
                ConditionalAppend(ref sb, DeviceType, " on ");

                return sb.ToString();
            }
        }

        private void ConditionalAppend(ref StringBuilder sb, string value, string? separator = ".")
        {
            separator ??= "";
            if (value != string.Empty && value != null && value != "Other") sb.Append(separator + value);
        }

        public List<JbStatus> Iphones;
        public List<JbStatus> Ipads;
        public List<JbStatus> Ipods;
    }
}
using System;

namespace PersonalWebsite
{
    class Artwork
    {
        public Artwork(string name, string relativeSvgUrl, string relativePngUrl)
        {
            Name = name;
            RelativeSvgUrl = relativeSvgUrl;
            RelativePngUrl = relativePngUrl;
        }

        public string RelativeSvgUrl;
        public string RelativePngUrl;
        public string Name;
    }
}

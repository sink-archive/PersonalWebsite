using System;

namespace PersonalWebsite
{
    class Artwork
    {
        public Artwork(string name, string relativeSvgUrl, string relativePngUrl, int width, int height)
        {
            Name = name;
            RelativeSvgUrl = relativeSvgUrl;
            RelativePngUrl = relativePngUrl;
            Width = width;
            Height = height;
        }

        public string RelativeSvgUrl;
        public string RelativePngUrl;
        public string Name;
        public int Width;
        public int Height;
        public string Size => $"{Width} x {Height}";
    }
}

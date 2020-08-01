using Microsoft.AspNetCore.Mvc;
using PersonalWebsite.Models;
using System.Collections.Generic;
using static PersonalWebsite.UserAgentData;

namespace PersonalWebsite.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult VectorGallery()
        {
            var artworks = new List<Artwork>
            {
                new Artwork("Main Avatar", "/abstract_art/vector/avatar/avatar.svg", "/abstract_art/bitmap/avatar/avatar.png", 2000, 2000),
                new Artwork("Dark Avatar", "/abstract_art/vector/avatar/avatar_dark.svg", "/abstract_art/bitmap/avatar/avatar_dark.png", 2000, 2000),
                new Artwork("High Contrast Avatar", "/abstract_art/vector/avatar/avatar_contrast.svg", "/abstract_art/bitmap/avatar/avatar_contrast.png", 2000, 2000),
                new Artwork("Abstract 1", "/abstract_art/vector/abstract-1.svg", "/abstract_art/bitmap/abstract-1.png", 2000, 2000),
                new Artwork("Abstract 2", "/abstract_art/vector/abstract-2.svg", "/abstract_art/bitmap/abstract-2.png", 2000, 2000),
                new Artwork("Abstract 3", "/abstract_art/vector/abstract-3.svg", "/abstract_art/bitmap/abstract-3.png", 2000, 2000),
                new Artwork("Mashup: Chaos", "/abstract_art/vector/mashups/chaos.svg", "/abstract_art/bitmap/mashups/chaos.png", 4000, 4000)
            };

            var vm = new VectorGalleryViewModel { Artworks = artworks };

            return View(vm);
        }

        public IActionResult CanIJailbreak()
        {
            GetUserAgent(HttpContext);

            var unc0verNonsupportedVersions = new List<string>{ "13.5.1", "12.3", "12.3.1", "12.3.2", "12.4.2", "12.4.3", "12.4.4", "12.4.5" };

            // generate ViewModel
            var vm = new CanIJailbreakViewModel
            {
                OS = UserOs,
                DeviceType = UserDeviceType,
                MajorVer = UserOsMajorVer,
                MinorVer = UserOsMinorVer,
                PatchVer = UserOsPatchVer,
                MinorPatchVer = UserOsMinorPatchVer,

                Iphones = new List<JbStatus>
                {
                    // Checkra1n-able devices
                    new JbStatus("iPhone 5S", new List<string>(), "Checkra1n", "//checkra.in"),
                    new JbStatus("iPhone 6 Plus", new List<string>(), "Checkra1n", "//checkra.in"),
                    new JbStatus("iPhone 6S", new List<string>(), "Checkra1n", "//checkra.in"),
                    new JbStatus("iPhone 6S Plus", new List<string>(), "Checkra1n", "//checkra.in"),
                    new JbStatus("iPhone SE (2016)", new List<string>(), "Checkra1n", "//checkra.in"),
                    new JbStatus("iPhone 7", new List<string>(), "Checkra1n", "//checkra.in"),
                    new JbStatus("iPhone 7 Plus", new List<string>(), "Checkra1n", "//checkra.in"),
                    new JbStatus("iPhone 8", new List<string>(), "Checkra1n", "//checkra.in"),
                    new JbStatus("iPhone 8 Plus", new List<string>(), "Checkra1n", "//checkra.in"),
                    new JbStatus("iPhone X", new List<string>(), "Checkra1n", "//checkra.in"),
                    // Non-Checkra1n-able devices
                    new JbStatus("iPhone XR", unc0verNonsupportedVersions, "Unc0ver", "//unc0ver.dev", "Odyssey", "//theodyssey.dev"),
                    new JbStatus("iPhone XS", unc0verNonsupportedVersions, "Unc0ver", "//unc0ver.dev", "Odyssey", "//theodyssey.dev"),
                    new JbStatus("iPhone XS Max", unc0verNonsupportedVersions, "Unc0ver", "//unc0ver.dev", "Odyssey", "//theodyssey.dev"),
                    new JbStatus("iPhone 11", unc0verNonsupportedVersions, "Unc0ver", "//unc0ver.dev", "Odyssey", "//theodyssey.dev"),
                    new JbStatus("iPhone 11 Pro", unc0verNonsupportedVersions, "Unc0ver", "//unc0ver.dev", "Odyssey", "//theodyssey.dev"),
                    new JbStatus("iPhone 11 Pro Max", unc0verNonsupportedVersions, "Unc0ver", "//unc0ver.dev", "Odyssey", "//theodyssey.dev"),
                    new JbStatus("iPhone SE (2020)", unc0verNonsupportedVersions, "Unc0ver", "//unc0ver.dev", "Odyssey", "//theodyssey.dev")
                },
                
                Ipads = new List<JbStatus>
                {
                    // Main line iPads
                    new JbStatus("iPad", new List<string>(), "Checkra1n", "//checkra.in"),
                    new JbStatus("iPad 2", new List<string>(), "Checkra1n", "//checkra.in"),
                    new JbStatus("iPad 3", new List<string>(), "Checkra1n", "//checkra.in"),
                    new JbStatus("iPad 4", new List<string>(), "Checkra1n", "//checkra.in"),
                    new JbStatus("iPad 9.7in (2018)", new List<string>(), "Checkra1n", "//checkra.in"),
                    new JbStatus("iPad 10.2in (2019)", new List<string>(), "Checkra1n", "//checkra.in"),

                    // iPad Airs
                    new JbStatus("iPad Air", new List<string>(), "Checkra1n", "//checkra.in"),
                    new JbStatus("iPad Air 2", new List<string>(), "Checkra1n", "//checkra.in"),
                    new JbStatus("iPad Air (2019)", new List<string>(), "Checkra1n", "//checkra.in"),

                    // iPad Minis
                    new JbStatus("iPad Mini", new List<string>(), "Checkra1n", "//checkra.in"),
                    new JbStatus("iPad Mini 2 /w Retina Display", new List<string>(), "Checkra1n", "//checkra.in"),
                    new JbStatus("iPad Mini 3", new List<string>(), "Checkra1n", "//checkra.in"),
                    new JbStatus("iPad Mini 4", new List<string>(), "Checkra1n", "//checkra.in"),
                    new JbStatus("iPad Mini (2019)", new List<string>(), "Checkra1n", "//checkra.in"),

                    // iPad Pros
                    new JbStatus("iPad Pro 9.7in (2016)", new List<string>(), "Checkra1n", "//checkra.in"),
                    new JbStatus("iPad Pro 10.5in (2017)", new List<string>(), "Checkra1n", "//checkra.in"),
                    new JbStatus("iPad Pro 12.9in (2017)", new List<string>(), "Checkra1n", "//checkra.in"),
                    new JbStatus("iPad Pro 11in (2018)", new List<string>(), "Checkra1n", "//checkra.in"),
                    new JbStatus("iPad Pro 12.9in (2018)", new List<string>(), "Checkra1n", "//checkra.in")
                },

                Ipods = new List<JbStatus>
                {
                    new JbStatus("iPod Touch 7th Generation", new List<string>(), "Checkra1n", "//checkra.in")
                }
            };

            return View(vm);
        }
    }
}

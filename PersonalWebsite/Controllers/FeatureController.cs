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
				new Artwork("Main Avatar", "/abstract_art/vector/avatar/avatar.svg",
				            "/abstract_art/bitmap/avatar/avatar.png", 2000, 2000),
				new Artwork("Dark Avatar", "/abstract_art/vector/avatar/avatar_dark.svg",
				            "/abstract_art/bitmap/avatar/avatar_dark.png", 2000, 2000),
				new Artwork("High Contrast Avatar", "/abstract_art/vector/avatar/avatar_contrast.svg",
				            "/abstract_art/bitmap/avatar/avatar_contrast.png", 2000, 2000),
				new Artwork("Abstract 1", "/abstract_art/vector/abstract-1.svg", "/abstract_art/bitmap/abstract-1.png",
				            2000, 2000),
				new Artwork("Abstract 2", "/abstract_art/vector/abstract-2.svg", "/abstract_art/bitmap/abstract-2.png",
				            2000, 2000),
				new Artwork("Abstract 3", "/abstract_art/vector/abstract-3.svg", "/abstract_art/bitmap/abstract-3.png",
				            2000, 2000),
				new Artwork("Mashup: Chaos", "/abstract_art/vector/mashups/chaos.svg",
				            "/abstract_art/bitmap/mashups/chaos.png", 4000, 4000)
			};

			var vm = new VectorGalleryViewModel {Artworks = artworks};

			return View(vm);
		}

		public IActionResult CanIJailbreak()
		{
			GetUserAgent(HttpContext);

			var unc0verNonsupportedVersions = new List<string>
				{"13.5.1", "12.3", "12.3.1", "12.3.2", "12.4.2", "12.4.3", "12.4.4", "12.4.5"};

			// generate ViewModel
			var vm = new CanIJailbreakViewModel
			{
				OS            = UserOs,
				DeviceType    = UserDeviceType,
				MajorVer      = UserOsMajorVer,
				MinorVer      = UserOsMinorVer,
				PatchVer      = UserOsPatchVer,
				MinorPatchVer = UserOsMinorPatchVer,

				Iphones = new List<JbStatus>
				{
					// Checkra1n-able devices
					new JbStatus("iPhone 5S",        new List<string>(), "Checkra1n", "//checkra.in"),
					new JbStatus("iPhone 6 Plus",    new List<string>(), "Checkra1n", "//checkra.in"),
					new JbStatus("iPhone 6S",        new List<string>(), "Checkra1n", "//checkra.in"),
					new JbStatus("iPhone 6S Plus",   new List<string>(), "Checkra1n", "//checkra.in"),
					new JbStatus("iPhone SE (2016)", new List<string>(), "Checkra1n", "//checkra.in"),
					new JbStatus("iPhone 7",         new List<string>(), "Checkra1n", "//checkra.in"),
					new JbStatus("iPhone 7 Plus",    new List<string>(), "Checkra1n", "//checkra.in"),
					new JbStatus("iPhone 8",         new List<string>(), "Checkra1n", "//checkra.in"),
					new JbStatus("iPhone 8 Plus",    new List<string>(), "Checkra1n", "//checkra.in"),
					new JbStatus("iPhone X",         new List<string>(), "Checkra1n", "//checkra.in"),
					// Non-Checkra1n-able devices
					new JbStatus("iPhone XR", unc0verNonsupportedVersions, "Unc0ver", "//unc0ver.dev", "Odyssey",
					             "//theodyssey.dev"),
					new JbStatus("iPhone XS", unc0verNonsupportedVersions, "Unc0ver", "//unc0ver.dev", "Odyssey",
					             "//theodyssey.dev"),
					new JbStatus("iPhone XS Max", unc0verNonsupportedVersions, "Unc0ver", "//unc0ver.dev", "Odyssey",
					             "//theodyssey.dev"),
					new JbStatus("iPhone 11", unc0verNonsupportedVersions, "Unc0ver", "//unc0ver.dev", "Odyssey",
					             "//theodyssey.dev"),
					new JbStatus("iPhone 11 Pro", unc0verNonsupportedVersions, "Unc0ver", "//unc0ver.dev", "Odyssey",
					             "//theodyssey.dev"),
					new JbStatus("iPhone 11 Pro Max", unc0verNonsupportedVersions, "Unc0ver", "//unc0ver.dev",
					             "Odyssey", "//theodyssey.dev"),
					new JbStatus("iPhone SE (2020)", unc0verNonsupportedVersions, "Unc0ver", "//unc0ver.dev", "Odyssey",
					             "//theodyssey.dev")
				},

				Ipads = new List<JbStatus>
				{
					// Main line iPads
					new JbStatus("iPad",               new List<string>(), "Checkra1n", "//checkra.in"),
					new JbStatus("iPad 2",             new List<string>(), "Checkra1n", "//checkra.in"),
					new JbStatus("iPad 3",             new List<string>(), "Checkra1n", "//checkra.in"),
					new JbStatus("iPad 4",             new List<string>(), "Checkra1n", "//checkra.in"),
					new JbStatus("iPad 9.7in (2018)",  new List<string>(), "Checkra1n", "//checkra.in"),
					new JbStatus("iPad 10.2in (2019)", new List<string>(), "Checkra1n", "//checkra.in"),

					// iPad Airs
					new JbStatus("iPad Air",        new List<string>(), "Checkra1n", "//checkra.in"),
					new JbStatus("iPad Air 2",      new List<string>(), "Checkra1n", "//checkra.in"),
					new JbStatus("iPad Air (2019)", new List<string>(), "Checkra1n", "//checkra.in"),

					// iPad Minis
					new JbStatus("iPad Mini",                     new List<string>(), "Checkra1n", "//checkra.in"),
					new JbStatus("iPad Mini 2 /w Retina Display", new List<string>(), "Checkra1n", "//checkra.in"),
					new JbStatus("iPad Mini 3",                   new List<string>(), "Checkra1n", "//checkra.in"),
					new JbStatus("iPad Mini 4",                   new List<string>(), "Checkra1n", "//checkra.in"),
					new JbStatus("iPad Mini (2019)",              new List<string>(), "Checkra1n", "//checkra.in"),

					// iPad Pros
					new JbStatus("iPad Pro 9.7in (2016)",  new List<string>(), "Checkra1n", "//checkra.in"),
					new JbStatus("iPad Pro 10.5in (2017)", new List<string>(), "Checkra1n", "//checkra.in"),
					new JbStatus("iPad Pro 12.9in (2017)", new List<string>(), "Checkra1n", "//checkra.in"),
					new JbStatus("iPad Pro 11in (2018)",   new List<string>(), "Checkra1n", "//checkra.in"),
					new JbStatus("iPad Pro 12.9in (2018)", new List<string>(), "Checkra1n", "//checkra.in")
				},

				Ipods = new List<JbStatus>
				{
					new JbStatus("iPod Touch 7th Generation", new List<string>(), "Checkra1n", "//checkra.in")
				}
			};

			return View(vm);
		}

		public IActionResult Plugins()
		{
			var synths = new List<Synth>
			{
				new Synth("Phase Plant", "Kilohearts", "Semi-Modular",
				          "A very unique synth, using multiple choices of oscillator and modulation, " +
				          "as well as any Snap-In (including Snap Heap and Multipass!) as an effect.",
				          "//kilohearts.com/products/phase_plant"),
				new Synth("Serum", "Xfer Records", "Wavetable",
				          "A classic synth used by all sorts of producers worldwide.",
				          "//xferrecords.com/products/serum"),
				new Synth("Europa", "Reason Studios / Propellerhead", "Wavetable",
				          "The Props' response to Serum, a versatile Wavetable synth with great modulation routing.",
				          "//www.reasonstudios.com/europa")
			};

			var fx = new List<Effect>
			{
				new Effect("Pro-Q 3", "Fabfilter", "EQ", "Any",
				           "A famous, amazing sounding EQ, with incredible ergonomics.",
				           "//www.fabfilter.com/products/pro-q-3-equalizer-plug-in"),
				new Effect("Transient Shaper", "Kilohearts", "Dynamics", "Making drums punchier",
				           "In my opinion, the simplest Transient Processor to use. Works great and sounds AMAZING!",
				           "//kilohearts.com/products/transient_shaper"),
				new Effect("Disperser", "Kilohearts", "Distortion? (maybe)", "Making kicks sound thick, just messing around",
				           "A very interesting plugin. A big stack of AllPass filters that change the phase of signals, with very cool results.",
				           "//kilohearts.com/products/disperser"),
				new Effect("Saturn 2", "Fabfilter", "Distortion", "Add some crunch",
				           "One of the most versatile saturation plugins there is, you can get very creative.",
				           "//www.fabfilter.com/products/saturn-2-multiband-distortion-saturation-plug-in"),
				new Effect("Pro-R", "Fabfilter", "Reverb", "Adding ambience or space",
				           "An advanced reverb from Fabfilter, sounds great (though you may need to change some defaults) and looks nice.",
				           "//www.fabfilter.com/products/pro-r-reverb-plug-in")
			};

			var vm = new PluginsViewModel
			{
				Synths = synths,
				Fx     = fx
			};
			return View(vm);
		}
	}
}
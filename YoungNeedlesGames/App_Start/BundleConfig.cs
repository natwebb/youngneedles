using System;
using System.Web.Optimization;

namespace YoungNeedlesGames
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            var test = new ScriptBundle("~/test/script").Include(
                "~/static/test.js"
            );

            bundles.Add(test);

            //Boot Scripts
            var system = new ScriptBundle("~/startup/boot").Include(
                "~/static/dist/inline.bundle.js",
				"~/static/dist/vendor.bundle.js",
				"~/static/dist/polyfills.bundle.js",
				"~/static/dist/styles.bundle.js",
				"~/static/dist/main.bundle.js"
			);

            bundles.Add(system);
        }
    }
}

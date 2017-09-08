using System;
using System.Web.Optimization;

namespace YoungNeedlesGames
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Vendor Scripts
            var vendorScripts = new ScriptBundle("~/vendor/scripts").Include(
                "~/static/node_modules/jquery/dist/jquery.js"
            );

            bundles.Add(vendorScripts);

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Optimization;

namespace oleg_izolation
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/mainCss").Include(
                "~/Content/Css/font-awesome.min.css",
                "~/Content/Css/jquery.fancybox.css",
                "~/Content/Css/pnotify.custom.min.css",
                "~/Content/Css/Site.css",
                "~/Content/Css/style.css",
                "~/Content/fancybox/jquery.fancybox.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Content/Scripts/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jQAddons").Include(
                "~/Content/Scripts/jquery.validate.min.js",
                "~/Content/Scripts/jquery.skitter.min.js",
                "~/Content/Scripts/jquery.maskedinput-1.3.min.js",
                "~/Content/Scripts/jquery.fancybox.pack.js",
                "~/Content/Scripts/jquery.easing.1.3.js",
                "~/Content/Scripts/jquery.cookie.js",
                "~/Content/Scripts/jquery.animate-colors-min.js"));
                

            bundles.Add(new ScriptBundle("~/bundles/base").Include(
                "~/Content/Scripts/watch.js",
                "~/Content/Scripts/pnotify.custom.min.js",
                "~/Content/Scripts/base.js"));
        }
    }
}

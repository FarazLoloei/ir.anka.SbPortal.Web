using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace ir.anka.SbPortal.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                Links.Bundles.Scripts.Assets.bootstrap_min_js,
                Links.Bundles.Scripts.Assets.respond_js
                      //"~/Scripts/bootstrap.js",
                      //"~/Scripts/respond.js"
                      ));

            bundles.Add(new StyleBundle(Bundles.Styles.fontAwesomeCss).Include(
                Links.Bundles.Content.Assets.font_awesome_css
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                Links.Bundles.Content.Assets.bootstrap_css,
                Links.Bundles.Content.Assets.Site_css,
                 "~/Content/simple-line-icons/simple-line-icons.min.css",
                 "~/Content/IranSans/IranSans.css",
                 "~/Content/bootstrap-rtl.min.css",
                 "~/Content/bootstrap-switch-rtl.min.css",
                 "~/Content/components-rtl.min.css",
                 "~/Content/components-rtl-overlay.css",
                 "~/Content/bootstrap-overlay.css",
                 "~/Content/plugins-rtl.min.css",
                 "~/Content/theme/layout-rtl.min.css",
                 "~/Content/theme/themes/darkblue-rtl.min.css",
                 "~/Content/css/select2.min.css",
                 "~/Content/Site.css"
                      //"~/Content/bootstrap.css",
                      //"~/Content/site.css"
                      ));

            bundles.Add(new StyleBundle("~/Content/js").Include(
                 "~/Scripts/bootstrap.min.js",
                 "~/Scripts/jquery.slimscroll.min.js",
                 "~/Scripts/jquery.blockUI.js",
                 "~/Scripts/bootstrap-switch.min.js",
                 "~/Scripts/app.min.js",
                 "~/Scripts/layout.min.js",
                 "~/Scripts/quick-sidebar.min.js",
                 "~/Scripts/quick-nav.min.js",
                 "~/Scripts/select2.min.js"
                ));

            //BundleTable.EnableOptimizations = true;
        }
    }
}
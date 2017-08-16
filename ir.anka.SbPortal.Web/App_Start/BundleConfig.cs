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
                Links.Bundles.Content.Assets.Site_css
                      //"~/Content/bootstrap.css",
                      //"~/Content/site.css"
                      ));
        }
    }
}
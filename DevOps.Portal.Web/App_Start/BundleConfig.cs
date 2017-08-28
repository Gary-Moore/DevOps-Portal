﻿using System.Web;
using System.Web.Optimization;

namespace DevOps.Portal.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                       "~/Scripts/toastr.js",
                       "~/Scripts/jquery.signalR-2.2.2.js",
                       "~/Scripts/bower/angular/angular.js",
                       "~/Scripts/bower/angular-ui-router/release/angular-ui-router.js",
                       "~/Scripts/bower/angular-animate/angular-animate.min.js",
                       "~/Scripts/bower/angular-sanitize/angular-sanitize.min.js",
                       "~/Scripts/angular-ui/ui-bootstrap-tpls.min.js",
                       "~/Scripts/select.js",
                       "~/Scripts/angular-signalr-hub.js",
                       "~/app/*module.js",
                       "~/app/core/*module.js",
                       "~/app/core/*.js",
                       "~/app/common/*module.js",
                       "~/app/common/*.js",
                       "~/app/layout/*module.js",
                       "~/app/layout/framework/*.js",
                       "~/app/layout/menu/*.js",
                       "~/app/layout/footer/*.js",
                       "~/app/dashboard/*module.js",
                       "~/app/dashboard/*.js",
                       "~/app/solutioncreator/*module.js",
                       "~/app/solutioncreator/*.js",
                       "~/app/solutioncreator/steps/*.js",
                       "~/app/solutioncreator/confirm/*.js",
                       "~/app/solutioncreator/visualstudio/*.js",
                       "~/app/solutioncreator/teamcity/*.js",
                       "~/app/solutioncreator/progress/*.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/scss/main.css",
                      "~/Content/select.css",
                      "~/Content/font-awesome.css",
                      "~/Content/toastr.css"));
        }
    }
}

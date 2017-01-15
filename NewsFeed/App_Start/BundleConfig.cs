using System;
using System.Web.Optimization;

namespace NewsFeed
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/NewsFeed")
                .Include("~/Scripts/angular.min.js")
                .Include("~/Scripts/angular-route.min.js")
                .Include("~/Scripts/bootstrap.min.js")
                .Include("~/Scripts/jquery-1.9.1.min.js")
                .Include("~/Scripts/moment.min.js")
                .IncludeDirectory("~/Scripts/Controllers", "*.js")
                .Include("~/Scripts/NewsFeed.js"));
        }
    }
}
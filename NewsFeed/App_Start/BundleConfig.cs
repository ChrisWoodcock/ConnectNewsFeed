using System;
using System.Web.Optimization;

namespace NewsFeed
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/NewsFeed")
                .IncludeDirectory("~/Scripts/Controllers", "*.js")
                .Include("~/Scripts/NewsFeed.js"));
        }
    }
}
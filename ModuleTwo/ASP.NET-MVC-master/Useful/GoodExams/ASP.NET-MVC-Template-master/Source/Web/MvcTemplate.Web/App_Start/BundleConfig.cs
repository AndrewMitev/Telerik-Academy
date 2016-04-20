namespace MvcTemplate.Web
{
    using System.Web.Optimization;

    public static class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();
            RegisterScripts(bundles);
            RegisterStyles(bundles);
        }

        private static void RegisterScripts(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js")
                .Include("~/Scripts/jquery.unobtrusive-ajax.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include("~/Scripts/jquery.validate*"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/kendo")
                .Include("~/Scripts/kendoUI/jquery.min.js")
                .Include("~/Scripts/kendoUI/kendo.all.min.js")
                .Include("~/Scripts/kendoUI/kendo.treeview.min.js")
                .Include("~/Scripts/kendoUI/kendo.aspnetmvc.min.js"));
        }

        private static void RegisterStyles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/bootstrap.css", "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/kendo")
                .Include("~/Content/kendoUI/kendo.common-bootstrap.min.css")
                .Include("~/Content/kendoUI/kendo.silver.min.css"));
        }
    }
}

using System.Web;
using System.Web.Optimization;

namespace Angular_with_ASPNet
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Assets/Scripts")
            .Include(
            "~/Assets/bundles/inline.*", 
            "~/Assets/bundles/polyfills.*",
            "~/Assets/bundles/scripts.*", 
            "~/Assets/bundles/vendor.*", 
            "~/Assets/bundles/runtime.*",
            "~/Assets/bundles/main.*"));

            bundles.Add(new StyleBundle("~/Assets/Styles").Include("~/Assets/bundles/styles.*"));
        }
    }
}

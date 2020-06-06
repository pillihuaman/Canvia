using System.Web;
using System.Web.Optimization;

namespace CanviaWeb
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new Bundle("~/bundles/jquery").Include(
                      "~/Scripts/jquery-1.11.3.min.js",
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/ace.min.js",
                      "~/Scripts/jquery.validate.js",
                      "~/Scripts/Canviajs.js",
                      "~/Scripts/jquery-prettyPhoto.js",
                      "~/Scripts/tinymce/jquery.tinymce.js",
                      "~/Scripts/tinymce/tiny_mce.js",
                      "~/Scripts/otf.js"
                      ));
            bundles.Add(new StyleBundle("~/Content/Canvia/css").Include(
                      "~/Content/Canvia/css/bootstrap.min.css",
                      "~/Content/Canvia/css/ace-ie.min.css", "~/Content/Canvia/css/site.css"));
        }
    }
}

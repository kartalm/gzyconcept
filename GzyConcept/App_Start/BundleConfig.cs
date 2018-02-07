using System.Web.Optimization;

namespace GzyConcept.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            #region Admin Panel
            /*
            //Admin Panel css bundles
            bundles.Add(new Bundle("~/bundles/AdminCss").Include(
                "~/Areas/ControlPanel/Content/css/bootstrap.min.css",
                "~/Areas/ControlPanel/Content/css/font-awesome.min.css",
                "~/Areas/ControlPanel/Content/css/templatemo_main.css"));
            //Admin Panel javascript bundles
            bundles.Add(new Bundle("~/bundles/AdminJs").Include(
                "~/Areas/ControlPanel/Content/js/jquery.min.js",
                "~/Areas/ControlPanel/Content/js/Chart.min.js",
                "~/Areas/ControlPanel/Content/js/bootstrap.min.js",
                "~/Areas/ControlPanel/Content/js/templatemo_script.js"
                ));
            //Validation Script bundles
            bundles.Add(new Bundle("~/bundles/ValidationJs").Include(
                "~/Scripts/jquery-1.10.2.min.js",
                "~/Scripts/jquery.validate.min.js",
                "~/Scripts/jquery.validate.unobtrusive.min.js"
                ));
            //cl editor bundles
            bundles.Add(new Bundle("~/bundles/EditorCss").Include(
                "~/Areas/ControlPanel/Content/cleditor/jquery.cleditor.css"));
            bundles.Add(new Bundle("~/bundles/EditorJs").Include(
                "~/Areas/ControlPanel/Content/cleditor/jquery.cleditor.js"
                ));
            //Image Resizer bundles
            bundles.Add(new Bundle("~/bundles/ImageResizerJs").Include(
                "~/Areas/ControlPanel/Content/ImageResizer/cropbox.js"
                ));
            bundles.Add(new Bundle("~/bundles/ImageResizerCss").Include(
                "~/Areas/ControlPanel/Content/ImageResizer/style.css"));
            */
            #endregion

            #region Site

            //Site css bundles
            bundles.Add(new Bundle("~/bundles/SiteCss").Include(
                "~/Styles/bootstrap.css",
                "~/Styles/font-awesome.css",
                "~/Styles/superfish.css",
                "~/Styles/megafish.css",
                "~/Styles/jquery.navgoco.css",
                "~/Styles/owl.carousel.css",
                "~/Styles/owl.theme.css",
                "~/Styles/sb-search.css",
                "~/Styles/magnific-popup.css",
                "~/Styles/fractionslider.css",
                "~/Styles/animate.css",
                "~/Styles/style.css",
                "~/Styles/Site.css"));

            //Site javascript bundles
            bundles.Add(new Bundle("~/bundles/SiteJs").Include(
                "~/Scripts/jquery-1.11.2.min.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/custom.js",
                "~/Scripts/modernizr.custom.js"
                ));

            #if DEBUG

            BundleTable.EnableOptimizations = false;

            #else

            BundleTable.EnableOptimizations = true;

            #endif


            #endregion
             
        }
    }
}
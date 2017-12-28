using System.Web;
using System.Web.Optimization;

namespace ProjectHeart
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

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css", //logic para bundle font awesome
                      "~/Content/site.css").Include("~/Content/font-awesome.css", new CssRewriteUrlTransform()));
            
            //inicio bundle AssetMainPage
            //Bundle da MainPage Bootstrap Core Css; old path: plugins/bootstrap/css/bootstrap.css
            bundles.Add(new StyleBundle("~/Plugins/bootstrap/css/").Include(
                      "~/AssetMainPage/Admin/plugins/bootstrap/css/bootstrap.css" //bundle bootstrap core css
                      ));

            //Bundle da MainPage Waves effect Css; old path: /Plugins/bootstrap/css/
            bundles.Add(new StyleBundle("~/Plugins/node-waves/css").Include(
                      "~/AssetMainPage/Admin/plugins/node-waves/waves.css" //waves effect css
                      ));

            //Bundle da MainPage animate-css; 
            bundles.Add(new StyleBundle("~/Plugins/animate-css").Include(
                      "~/AssetMainPage/Admin/plugins/animate-css/animate.css" //animate-css css
                      ));

            //Bundle da MainPage custom Css; old path: /Content/MainPage/style.css
            bundles.Add(new StyleBundle("~/Content/MainPage/css").Include(
                      "~/AssetMainPage/Admin/css/style.css" //custom css
                      ));

            //bundle script plugin
            bundles.Add(new ScriptBundle("~/plugins/jquery").Include(
            "~/AssetMainPage/Admin/plugins/jquery/jquery.min.js" //Jquery Core Js
            ));

            //bundle script plugin
            bundles.Add(new ScriptBundle("~/Plugins/bootstrap").Include(
            "~/AssetMainPage/Admin/plugins/bootstrap/js/bootstrap.js" // Bootstrap Core Js
            ));

            //bundle script plugin
            bundles.Add(new ScriptBundle("~/Plugins/bootstrap-select").Include(
            "~/AssetMainPage/Admin/plugins/bootstrap-select/js/bootstrap-select.js" //Select Plugin Js
            ));

            //bundle script plugin
            bundles.Add(new ScriptBundle("~/Plugins/jquery-slimscroll").Include(
            "~/AssetMainPage/Admin/plugins/jquery-slimscroll/jquery.slimscroll.js" //Slimscroll Plugin Js
            ));

            //bundle script plugin
            bundles.Add(new ScriptBundle("~/Plugins/node-waves").Include(
            "~/AssetMainPage/Admin/plugins/node-waves/waves.js" //Waves Effect Plugin Js
            ));

            //bundle script plugin
            bundles.Add(new ScriptBundle("~/Plugins/jquery-countto").Include(
            "~/AssetMainPage/Admin/plugins/jquery-countto/jquery.countTo.js" //Jquery CountTo Plugin Js
            ));

            //bundle script plugin
            bundles.Add(new ScriptBundle("~/Plugins/raphael").Include(
            "~/AssetMainPage/Admin/plugins/raphael/raphael.min.js" //Morris Plugin Js 
            ));

            //bundle script plugin
            bundles.Add(new ScriptBundle("~/Plugins/morrisjs").Include(
            "~/AssetMainPage/Admin/plugins/morrisjs/morris.js" //idem acima 
            ));

            //bundle script plugin
            bundles.Add(new ScriptBundle("~/Plugins/chartjs").Include(
            "~/AssetMainPage/Admin/plugins/chartjs/Chart.bundle.js" //ChartJs 
            ));
    
            //bundle script plugin
            bundles.Add(new ScriptBundle("~/Plugins/flot-charts").Include(
            "~/AssetMainPage/Admin/plugins/flot-charts/jquery.flot.js", //Flot Charts Plugin Js
            "~/AssetMainPage/Admin/plugins/flot-charts/jquery.flot.resize.js",//idem acima
            "~/AssetMainPage/Admin/plugins/flot-charts/jquery.flot.pie.js",//idem acima
            "~/AssetMainPage/Admin/plugins/flot-charts/jquery.flot.categories.js",//idem acima
            "~/AssetMainPage/Admin/plugins/flot-charts/jquery.flot.time.js"//idem acima
            ));

            //bundle script plugin
            bundles.Add(new ScriptBundle("~/Plugins/jquery-sparkline").Include(
            "~/AssetMainPage/Admin/plugins/jquery-sparkline/jquery.sparkline.js" //Sparkline Chart Plugin Js
            ));

            //bundle scripts custom js
            bundles.Add(new ScriptBundle("~/bundles/MainPage").Include(
            "~/AssetMainPage/Admin/js/admin.js", //custom
            "~/AssetMainPage/Admin/js/pages/index.js" //index
            ));

            //bundle scripts demo js
            bundles.Add(new ScriptBundle("~/bundles/MainPage/demo").Include(
            "~/AssetMainPage/Admin/js/demo.js" //demo
            ));

            //bundle scripts demo js
            bundles.Add(new ScriptBundle("~/bundles/MainPage/sign-in").Include(
            "~/AssetMainPage/Admin/js/pages/examples/sign-in.js" //demo
            ));

            
            //Bundle  AdminBSB Themes css; old path: /Content/MainPage/themes/theme-red.css
            bundles.Add(new StyleBundle("~/Content/MainPage/theme").Include(
            "~/AssetMainPage/Admin/css/themes/all-themes.css" // AdminBSB Themes
            ));

            //bundle scripts demo js
            bundles.Add(new ScriptBundle("~/bundles/jquery-validation").Include(
            "~/AssetMainPage/Admin/plugins/jquery-validation/jquery.validate.js" //demo
            ));



            //fim bundle AssetMainPage
        }
    }
}

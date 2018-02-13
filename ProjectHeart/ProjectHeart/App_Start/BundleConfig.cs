using System.Web;
using System.Web.Optimization;

namespace ProjectHeart
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //BundleTable.EnableOptimizations = true;

            bundles.Add(new ScriptBundle("~/MainPage/jquery").Include(
            "~/AssetMainPage/Admin/plugins/jquery/jquery.js",//Jquery 
            "~/AssetMainPage/Admin/plugins/jquery/jquery.min.js"
            ));

            //bundle script plugin
            bundles.Add(new ScriptBundle("~/MainPage/plugins/js").Include(
            "~/AssetMainPage/Admin/plugins/flot-charts/jquery.flot.js", //Flot 
            "~/AssetMainPage/Admin/plugins/flot-charts/jquery.flot.resize.js",
            "~/AssetMainPage/Admin/plugins/flot-charts/jquery.flot.pie.js",
            "~/AssetMainPage/Admin/plugins/flot-charts/jquery.flot.categories.js",
            "~/AssetMainPage/Admin/plugins/flot-charts/jquery.flot.time.js",
            "~/AssetMainPage/Admin/plugins/autosize/autosize.js",//autosize
            "~/AssetMainPage/Admin/plugins/autosize/autosize.min.js",
            "~/AssetMainPage/Admin/plugins/bootstrap/js/bootstrap.js",//bootstrap
            "~/AssetMainPage/Admin/plugins/bootstrap/js/bootstrap.min.js",
            "~/AssetMainPage/Admin/plugins/jquery-sparkline/jquery.sparkline.js",//sparkline
            "~/AssetMainPage/Admin/plugins/momentjs/moment.js",//moment
            "~/AssetMainPage/Admin/plugins/bootstrap-material-datetimepicker/js/bootstrap-material-datetimepicker.js",//datetime picker
            "~/Scripts/Input-Mask/jquery.mask.js",//jquery mask
            "~/Scripts/Input-Mask/jquery.mask.min.js",
            "~/AssetMainPage/Admin/plugins/bootstrap-tagsinput/bootstrap-tagsinput-angular.js",//tagsinput
            "~/AssetMainPage/Admin/plugins/bootstrap-tagsinput/bootstrap-tagsinput-angular.min.js",
            "~/AssetMainPage/Admin/plugins/bootstrap-tagsinput/bootstrap-tagsinput.js",
            "~/AssetMainPage/Admin/plugins/bootstrap-tagsinput/bootstrap-tagsinput.min.js",
            "~/AssetMainPage/Admin/plugins/chartjs/Chart.bundle.js",//ChartJs 
            "~/AssetMainPage/Admin/plugins/morrisjs/morris.js",//morris
            "~/AssetMainPage/Admin/plugins/raphael/raphael.min.js",//Morris Plugin Js 
            "~/AssetMainPage/Admin/plugins/jquery-countto/jquery.countTo.js",//Jquery CountTo Plugin Js
            "~/AssetMainPage/Admin/plugins/node-waves/waves.js",//Waves Effect Plugin Js
            "~/AssetMainPage/Admin/plugins/jquery-slimscroll/jquery.slimscroll.js",//Slimscroll Plugin Js
            "~/AssetMainPage/Admin/plugins/bootstrap-select/js/bootstrap-select.js"//Select Plugin Js
            ));

            //bundle script plugin
            bundles.Add(new StyleBundle("~/MainPage/plugins/css").Include(
            "~/AssetMainPage/Admin/plugins/bootstrap/css/bootstrap.css",//bundle bootstrap core css
            "~/AssetMainPage/Admin/plugins/node-waves/waves.css",//waves effect css
            "~/AssetMainPage/Admin/plugins/animate-css/animate.css",//animate-css css
            "~/AssetMainPage/Admin/css/style.css",//style css
            "~/AssetMainPage/Admin/css/themes/all-themes.css",// AdminBSB Themes
            "~/AssetMainPage/Admin/plugins/bootstrap-material-datetimepicker/css/bootstrap-material-datetimepicker.css",
            "~/AssetMainPage/Admin/plugins/waitme/waitMe.css",//waitme
            "~/AssetMainPage/Admin/plugins/bootstrap-select/css/bootstrap-select.css",//bootstrap-select
            "~/AssetMainPage/Admin/plugins/bootstrap-tagsinput/bootstrap-tagsinput.css"//tagsinput
            ));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
            //            "~/Scripts/jquery-ui-{version}.js"));

            ////here
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //     "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
            //            "~/Scripts/jquery-ui-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.unobtrusive*",
            //            "~/Scripts/jquery.validate*"));


            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css", //logic para bundle font awesome
            //          "~/Content/site.css").Include("~/Content/font-awesome.css", new CssRewriteUrlTransform()));

            ////inicio bundle AssetMainPage
            //Bundle da MainPage Bootstrap Core Css; old path: plugins/bootstrap/css/bootstrap.css

            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //"~/AssetMainPage/Admin/plugins/jquery/jquery.min.js" //Jquery Js
            //));

            //bundles.Add(new StyleBundle("~/Plugins/bootstrap/css/").Include(
            //          ));

            ////Bundle da MainPage Waves effect Css; old path: /Plugins/bootstrap/css/
            //bundles.Add(new StyleBundle("~/Plugins/node-waves/css").Include(
            //          "~/AssetMainPage/Admin/plugins/node-waves/waves.css" //waves effect css
            //          ));

            //Bundle da MainPage animate-css; 
            //bundles.Add(new StyleBundle("~/Plugins/animate-css").Include(
            //          "~/AssetMainPage/Admin/plugins/animate-css/animate.css" //animate-css css
            //          ));

            ////Bundle da MainPage custom Css; old path: /Content/MainPage/style.css
            //bundles.Add(new StyleBundle("~/Content/MainPage/css").Include(
            //          "~/AssetMainPage/Admin/css/style.css" //custom css
            //          ));

            //bundle script plugin
            //bundles.Add(new ScriptBundle("~/Plugins/bootstrap").Include(
            //"~/AssetMainPage/Admin/plugins/bootstrap/js/bootstrap.js" // Bootstrap Core Js
            //));

            ////bundle bootstrap-select
            //bundles.Add(new ScriptBundle("~/Plugins/bootstrap-select").Include(
            //"~/AssetMainPage/Admin/plugins/bootstrap-select/js/bootstrap-select.js" //Select Plugin Js
            //));

            ////bundle script plugin
            //bundles.Add(new ScriptBundle("~/Plugins/jquery-slimscroll").Include(
            //"~/AssetMainPage/Admin/plugins/jquery-slimscroll/jquery.slimscroll.js" //Slimscroll Plugin Js
            //));

            //bundle script plugin
            //bundles.Add(new ScriptBundle("~/Plugins/node-waves").Include(
            //"~/AssetMainPage/Admin/plugins/node-waves/waves.js" //Waves Effect Plugin Js
            //));

            //bundle script plugin
            //bundles.Add(new ScriptBundle("~/Plugins/jquery-countto").Include(
            //"~/AssetMainPage/Admin/plugins/jquery-countto/jquery.countTo.js" //Jquery CountTo Plugin Js
            //));

            //bundle script plugin
            //bundles.Add(new ScriptBundle("~/Plugins/raphael").Include(
            //"~/AssetMainPage/Admin/plugins/raphael/raphael.min.js" //Morris Plugin Js 
            //));

            //bundle script plugin
            //bundles.Add(new ScriptBundle("~/Plugins/morrisjs").Include(
            //"~/AssetMainPage/Admin/plugins/morrisjs/morris.js" //morris
            //));

            //bundle script plugin
            //bundles.Add(new ScriptBundle("~/Plugins/chartjs").Include(
            //"~/AssetMainPage/Admin/plugins/chartjs/Chart.bundle.js" 
            //));



            //bundle script plugin
            //bundles.Add(new ScriptBundle("~/Plugins/jquery-sparkline").Include(
            //"~/AssetMainPage/Admin/plugins/jquery-sparkline/jquery.sparkline.js" 
            //));

   

            //bundle admin js
            bundles.Add(new ScriptBundle("~/MainPage/js").Include(
            "~/AssetMainPage/Admin/js/admin.js",
            "~/AssetMainPage/Admin/js/demo.js",
            "~/AssetMainPage/Admin/js/helpers.js"
            ));

            //bundle pages declarando apenas os q estou usando no momento
            bundles.Add(new ScriptBundle("~/MainPage/pages/js").Include(
            "~/AssetMainPage/Admin/js/pages/index.js",
            "~/AssetMainPage/Admin/js/pages/cards/basic.js", //cards
            "~/AssetMainPage/Admin/js/pages/cards/colored.js",
            "~/AssetMainPage/Admin/js/pages/forms/basic-form-elements.js", // forms
            "~/AssetMainPage/Admin/js/pages/forms/advanced-form-elements.js",
            "~/AssetMainPage/Admin/js/pages/forms/form-validation.js",
            "~/AssetMainPage/Admin/js/pages/ui/animations.js",//UI
            "~/AssetMainPage/Admin/js/pages/ui/dialogs.js",
            "~/AssetMainPage/Admin/js/pages/ui/modals.js",
            "~/AssetMainPage/Admin/js/pages/ui/notifications.js",
            "~/AssetMainPage/Admin/js/pages/ui/sortable-nestable.js",
            "~/AssetMainPage/Admin/js/pages/ui/tooltips-popovers.js"
            ));

            //login 
            bundles.Add(new ScriptBundle("~/MainPage/sign-in").Include(
            "~/AssetMainPage/Admin/js/pages/examples/sign-in.js"
            )); 




            //bundle scripts demo js
            //bundles.Add(new ScriptBundle("~/bundles/MainPage/demo").Include(
            //"~/AssetMainPage/Admin/js/demo.js"
            //));

            //bundle tooltips js
            //bundles.Add(new ScriptBundle("~/bundles/tooltips").Include(
            //"~/AssetMainPage/Admin/js/pages/ui/tooltips-popovers.js"
            //));

            //bundle scripts demo js
            //bundles.Add(new ScriptBundle("~/bundles/MainPage/sign-in").Include(
            //"~/AssetMainPage/Admin/js/pages/examples/sign-in.js" //login
            //));

            //bundle basic form
            //bundles.Add(new ScriptBundle("~/bundles/basicform").Include(
            //"~/AssetMainPage/Admin/js/pages/forms/basic-form-elements.js" //demo
            //));

            //bundle index form
            //bundles.Add(new ScriptBundle("~/bundles/MainPage/index").Include(
            //"~/AssetMainPage/Admin/js/pages/index.js" 
            //));

            //Bundle  AdminBSB Themes css; old path: /Content/MainPage/themes/theme-red.css
            //bundles.Add(new StyleBundle("~/Content/MainPage/theme").Include(
            //"~/AssetMainPage/Admin/css/themes/all-themes.css" // AdminBSB Themes
            //));

            //bundle scripts demo js
            //bundles.Add(new ScriptBundle("~/bundles/jquery-validation").Include(
            //"~/AssetMainPage/Admin/plugins/jquery-validation/jquery.validate.js" 
            //));

            ////css para datetimepicker
            //bundles.Add(new StyleBundle("~/bundles/datetimepicker/css").Include(
            //    "~/AssetMainPage/Admin/plugins/bootstrap-material-datetimepicker/css/bootstrap-material-datetimepicker.css"
            //));

            ////wait me css
            //bundles.Add(new StyleBundle("~/bundles/waitme").Include(
            //    "~/AssetMainPage/Admin/plugins/waitme/waitMe.css"
            //));

            ////bootstrap select
            //bundles.Add(new StyleBundle("~/bundles/bootstrap-select/css").Include(
            //    "~/AssetMainPage/Admin/plugins/bootstrap-select/css/bootstrap-select.css"
            //));

            //bundle scripts autosize js
            //bundles.Add(new ScriptBundle("~/bundles/autosize").Include(
            //"~/AssetMainPage/Admin/plugins/autosize/autosize.js" 
            //));

            //bundle scripts moment js
            //bundles.Add(new ScriptBundle("~/bundles/moment").Include(
            //"~/AssetMainPage/Admin/plugins/momentjs/moment.js" 
            //));

            //Bootstrap Material Datetime Picker Plugin Js
            //bundles.Add(new ScriptBundle("~/bundles/datetimepicker").Include(
            //"~/AssetMainPage/Admin/plugins/bootstrap-material-datetimepicker/js/bootstrap-material-datetimepicker.js"
            //));

            //input mask
            //bundles.Add(new ScriptBundle("~/bundles/mask").Include(
            //    "~/Scripts/Input-Mask/jquery.mask.js",
            //    "~/Scripts/Input-Mask/jquery.mask.min.js"
            //));

            //bootstrap tagsinput
            //bundles.Add(new StyleBundle("~/bundles/tagsinput").Include(
            //    "~/AssetMainPage/Admin/plugins/bootstrap-tagsinput/bootstrap-tagsinput.css"
            //));

            //fim bundle AssetMainPage
        }
    }
}

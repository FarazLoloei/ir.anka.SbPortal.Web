﻿// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static partial class MVC
{
    public static ir.anka.SbPortal.Web.Controllers.DashboardController Dashboard = new ir.anka.SbPortal.Web.Controllers.T4MVC_DashboardController();
    public static T4MVC.SharedController Shared = new T4MVC.SharedController();
}

namespace T4MVC
{
}

#pragma warning disable 0436
namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}
#pragma warning restore 0436

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ActionResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
     
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        public const string UrlPath = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
        public static readonly string app_min_js = Url("app.min.js");
        public static readonly string bootstrap_switch_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/bootstrap-switch.min.js") ? Url("bootstrap-switch.min.js") : Url("bootstrap-switch.js");
        public static readonly string bootstrap_switch_min_js = Url("bootstrap-switch.min.js");
        public static readonly string bootstrap_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/bootstrap.min.js") ? Url("bootstrap.min.js") : Url("bootstrap.js");
        public static readonly string bootstrap_min_js = Url("bootstrap.min.js");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class i18n {
            public const string UrlPath = "~/Scripts/i18n";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
            public static readonly string ar_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/ar.min.js") ? Url("ar.min.js") : Url("ar.js");
            public static readonly string az_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/az.min.js") ? Url("az.min.js") : Url("az.js");
            public static readonly string bg_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/bg.min.js") ? Url("bg.min.js") : Url("bg.js");
            public static readonly string ca_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/ca.min.js") ? Url("ca.min.js") : Url("ca.js");
            public static readonly string cs_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/cs.min.js") ? Url("cs.min.js") : Url("cs.js");
            public static readonly string da_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/da.min.js") ? Url("da.min.js") : Url("da.js");
            public static readonly string de_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/de.min.js") ? Url("de.min.js") : Url("de.js");
            public static readonly string el_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/el.min.js") ? Url("el.min.js") : Url("el.js");
            public static readonly string en_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/en.min.js") ? Url("en.min.js") : Url("en.js");
            public static readonly string es_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/es.min.js") ? Url("es.min.js") : Url("es.js");
            public static readonly string et_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/et.min.js") ? Url("et.min.js") : Url("et.js");
            public static readonly string eu_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/eu.min.js") ? Url("eu.min.js") : Url("eu.js");
            public static readonly string fa_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/fa.min.js") ? Url("fa.min.js") : Url("fa.js");
            public static readonly string fi_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/fi.min.js") ? Url("fi.min.js") : Url("fi.js");
            public static readonly string fr_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/fr.min.js") ? Url("fr.min.js") : Url("fr.js");
            public static readonly string gl_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/gl.min.js") ? Url("gl.min.js") : Url("gl.js");
            public static readonly string he_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/he.min.js") ? Url("he.min.js") : Url("he.js");
            public static readonly string hi_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/hi.min.js") ? Url("hi.min.js") : Url("hi.js");
            public static readonly string hr_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/hr.min.js") ? Url("hr.min.js") : Url("hr.js");
            public static readonly string hu_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/hu.min.js") ? Url("hu.min.js") : Url("hu.js");
            public static readonly string id_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/id.min.js") ? Url("id.min.js") : Url("id.js");
            public static readonly string is_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/is.min.js") ? Url("is.min.js") : Url("is.js");
            public static readonly string it_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/it.min.js") ? Url("it.min.js") : Url("it.js");
            public static readonly string ja_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/ja.min.js") ? Url("ja.min.js") : Url("ja.js");
            public static readonly string km_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/km.min.js") ? Url("km.min.js") : Url("km.js");
            public static readonly string ko_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/ko.min.js") ? Url("ko.min.js") : Url("ko.js");
            public static readonly string lt_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/lt.min.js") ? Url("lt.min.js") : Url("lt.js");
            public static readonly string lv_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/lv.min.js") ? Url("lv.min.js") : Url("lv.js");
            public static readonly string mk_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/mk.min.js") ? Url("mk.min.js") : Url("mk.js");
            public static readonly string ms_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/ms.min.js") ? Url("ms.min.js") : Url("ms.js");
            public static readonly string nb_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/nb.min.js") ? Url("nb.min.js") : Url("nb.js");
            public static readonly string nl_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/nl.min.js") ? Url("nl.min.js") : Url("nl.js");
            public static readonly string pl_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/pl.min.js") ? Url("pl.min.js") : Url("pl.js");
            public static readonly string pt_BR_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/pt-BR.min.js") ? Url("pt-BR.min.js") : Url("pt-BR.js");
            public static readonly string pt_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/pt.min.js") ? Url("pt.min.js") : Url("pt.js");
            public static readonly string ro_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/ro.min.js") ? Url("ro.min.js") : Url("ro.js");
            public static readonly string ru_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/ru.min.js") ? Url("ru.min.js") : Url("ru.js");
            public static readonly string sk_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/sk.min.js") ? Url("sk.min.js") : Url("sk.js");
            public static readonly string sr_Cyrl_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/sr-Cyrl.min.js") ? Url("sr-Cyrl.min.js") : Url("sr-Cyrl.js");
            public static readonly string sr_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/sr.min.js") ? Url("sr.min.js") : Url("sr.js");
            public static readonly string sv_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/sv.min.js") ? Url("sv.min.js") : Url("sv.js");
            public static readonly string th_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/th.min.js") ? Url("th.min.js") : Url("th.js");
            public static readonly string tr_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/tr.min.js") ? Url("tr.min.js") : Url("tr.js");
            public static readonly string uk_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/uk.min.js") ? Url("uk.min.js") : Url("uk.js");
            public static readonly string vi_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/vi.min.js") ? Url("vi.min.js") : Url("vi.js");
            public static readonly string zh_CN_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/zh-CN.min.js") ? Url("zh-CN.min.js") : Url("zh-CN.js");
            public static readonly string zh_TW_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/zh-TW.min.js") ? Url("zh-TW.min.js") : Url("zh-TW.js");
        }
    
        public static readonly string jquery_2_2_4_intellisense_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery-2.2.4.intellisense.min.js") ? Url("jquery-2.2.4.intellisense.min.js") : Url("jquery-2.2.4.intellisense.js");
        public static readonly string jquery_2_2_4_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery-2.2.4.min.js") ? Url("jquery-2.2.4.min.js") : Url("jquery-2.2.4.js");
        public static readonly string jquery_2_2_4_min_js = Url("jquery-2.2.4.min.js");
        public static readonly string jquery_2_2_4_min_map = Url("jquery-2.2.4.min.map");
        public static readonly string jquery_blockUI_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery.blockUI.min.js") ? Url("jquery.blockUI.min.js") : Url("jquery.blockUI.js");
        public static readonly string jquery_slimscroll_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery.slimscroll.min.js") ? Url("jquery.slimscroll.min.js") : Url("jquery.slimscroll.js");
        public static readonly string jquery_slimscroll_min_js = Url("jquery.slimscroll.min.js");
        public static readonly string jquery_validate_vsdoc_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery.validate-vsdoc.min.js") ? Url("jquery.validate-vsdoc.min.js") : Url("jquery.validate-vsdoc.js");
        public static readonly string jquery_validate_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery.validate.min.js") ? Url("jquery.validate.min.js") : Url("jquery.validate.js");
        public static readonly string jquery_validate_min_js = Url("jquery.validate.min.js");
        public static readonly string jquery_validate_unobtrusive_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery.validate.unobtrusive.min.js") ? Url("jquery.validate.unobtrusive.min.js") : Url("jquery.validate.unobtrusive.js");
        public static readonly string jquery_validate_unobtrusive_min_js = Url("jquery.validate.unobtrusive.min.js");
        public static readonly string layout_min_js = Url("layout.min.js");
        public static readonly string modernizr_2_8_3_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/modernizr-2.8.3.min.js") ? Url("modernizr-2.8.3.min.js") : Url("modernizr-2.8.3.js");
        public static readonly string quick_nav_min_js = Url("quick-nav.min.js");
        public static readonly string quick_sidebar_min_js = Url("quick-sidebar.min.js");
        public static readonly string respond_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/respond.min.js") ? Url("respond.min.js") : Url("respond.js");
        public static readonly string respond_matchmedia_addListener_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/respond.matchmedia.addListener.min.js") ? Url("respond.matchmedia.addListener.min.js") : Url("respond.matchmedia.addListener.js");
        public static readonly string respond_matchmedia_addListener_min_js = Url("respond.matchmedia.addListener.min.js");
        public static readonly string respond_min_js = Url("respond.min.js");
        public static readonly string select2_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/select2.min.js") ? Url("select2.min.js") : Url("select2.js");
        public static readonly string select2_min_js = Url("select2.min.js");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class typings {
            public const string UrlPath = "~/Scripts/typings";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class jquery {
                public const string UrlPath = "~/Scripts/typings/jquery";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
                public static readonly string jquery_d_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery.d.min.js") ? Url("jquery.d.min.js") : Url("jquery.d.js");
            }
        
        }
    
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        public const string UrlPath = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
        public static readonly string bootstrap_overlay_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/bootstrap-overlay.min.css") ? Url("bootstrap-overlay.min.css") : Url("bootstrap-overlay.css");
        public static readonly string bootstrap_rtl_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/bootstrap-rtl.min.css") ? Url("bootstrap-rtl.min.css") : Url("bootstrap-rtl.css");
        public static readonly string bootstrap_rtl_min_css = Url("bootstrap-rtl.min.css");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class bootstrap_switch {
            public const string UrlPath = "~/Content/bootstrap-switch";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class bootstrap2 {
                public const string UrlPath = "~/Content/bootstrap-switch/bootstrap2";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
                public static readonly string bootstrap_switch_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/bootstrap-switch.min.css") ? Url("bootstrap-switch.min.css") : Url("bootstrap-switch.css");
                public static readonly string bootstrap_switch_min_css = Url("bootstrap-switch.min.css");
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class bootstrap3 {
                public const string UrlPath = "~/Content/bootstrap-switch/bootstrap3";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
                public static readonly string bootstrap_switch_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/bootstrap-switch.min.css") ? Url("bootstrap-switch.min.css") : Url("bootstrap-switch.css");
                public static readonly string bootstrap_switch_min_css = Url("bootstrap-switch.min.css");
            }
        
        }
    
        public static readonly string bootstrap_switch_rtl_min_css = Url("bootstrap-switch-rtl.min.css");
        public static readonly string bootstrap_theme_rtl_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/bootstrap-theme-rtl.min.css") ? Url("bootstrap-theme-rtl.min.css") : Url("bootstrap-theme-rtl.css");
        public static readonly string bootstrap_theme_rtl_min_css = Url("bootstrap-theme-rtl.min.css");
        public static readonly string bootstrap_theme_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/bootstrap-theme.min.css") ? Url("bootstrap-theme.min.css") : Url("bootstrap-theme.css");
        public static readonly string bootstrap_theme_css_map = Url("bootstrap-theme.css.map");
        public static readonly string bootstrap_theme_min_css = Url("bootstrap-theme.min.css");
        public static readonly string bootstrap_theme_min_css_map = Url("bootstrap-theme.min.css.map");
        public static readonly string bootstrap_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/bootstrap.min.css") ? Url("bootstrap.min.css") : Url("bootstrap.css");
        public static readonly string bootstrap_css_map = Url("bootstrap.css.map");
        public static readonly string bootstrap_min_css = Url("bootstrap.min.css");
        public static readonly string bootstrap_min_css_map = Url("bootstrap.min.css.map");
        public static readonly string components_rtl_overlay_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/components-rtl-overlay.min.css") ? Url("components-rtl-overlay.min.css") : Url("components-rtl-overlay.css");
        public static readonly string components_rtl_min_css = Url("components-rtl.min.css");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class css {
            public const string UrlPath = "~/Content/css";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
            public static readonly string select2_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/select2.min.css") ? Url("select2.min.css") : Url("select2.css");
            public static readonly string select2_min_css = Url("select2.min.css");
        }
    
        public static readonly string font_awesome_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/font-awesome.min.css") ? Url("font-awesome.min.css") : Url("font-awesome.css");
        public static readonly string font_awesome_min_css = Url("font-awesome.min.css");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class IranSans {
            public const string UrlPath = "~/Content/IranSans";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
            public static readonly string IRANSans_Bold_web_eot = Url("IRANSans-Bold-web.eot");
            public static readonly string IRANSans_Bold_web_ttf = Url("IRANSans-Bold-web.ttf");
            public static readonly string IRANSans_Bold_web_woff = Url("IRANSans-Bold-web.woff");
            public static readonly string IRANSans_Bold_web_woff2 = Url("IRANSans-Bold-web.woff2");
            public static readonly string IRANSans_Medium_web_eot = Url("IRANSans-Medium-web.eot");
            public static readonly string IRANSans_Medium_web_ttf = Url("IRANSans-Medium-web.ttf");
            public static readonly string IRANSans_Medium_web_woff = Url("IRANSans-Medium-web.woff");
            public static readonly string IRANSans_Medium_web_woff2 = Url("IRANSans-Medium-web.woff2");
            public static readonly string IRANSans_web_eot = Url("IRANSans-web.eot");
            public static readonly string IRANSans_web_ttf = Url("IRANSans-web.ttf");
            public static readonly string IRANSans_web_woff = Url("IRANSans-web.woff");
            public static readonly string IRANSans_web_woff2 = Url("IRANSans-web.woff2");
            public static readonly string IranSans_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/IranSans.min.css") ? Url("IranSans.min.css") : Url("IranSans.css");
            public static readonly string IRANSansWeb_eot = Url("IRANSansWeb.eot");
            public static readonly string IRANSansWeb_woff = Url("IRANSansWeb.woff");
            public static readonly string IRANSansWeb_woff2 = Url("IRANSansWeb.woff2");
            public static readonly string IRANSansWeb_Bold_woff = Url("IRANSansWeb_Bold.woff");
            public static readonly string IRANSansWeb_Bold_woff2 = Url("IRANSansWeb_Bold.woff2");
            public static readonly string IRANSansWeb_Light_woff = Url("IRANSansWeb_Light.woff");
            public static readonly string IRANSansWeb_Light_woff2 = Url("IRANSansWeb_Light.woff2");
            public static readonly string IRANSansWeb_Medium_eot = Url("IRANSansWeb_Medium.eot");
            public static readonly string IRANSansWeb_Medium_woff = Url("IRANSansWeb_Medium.woff");
            public static readonly string IRANSansWeb_Medium_woff2 = Url("IRANSansWeb_Medium.woff2");
            public static readonly string IRANSansWeb_UltraLight_woff = Url("IRANSansWeb_UltraLight.woff");
            public static readonly string IRANSansWeb_UltraLight_woff2 = Url("IRANSansWeb_UltraLight.woff2");
        }
    
        public static readonly string plugins_rtl_min_css = Url("plugins-rtl.min.css");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class simple_line_icons {
            public const string UrlPath = "~/Content/simple-line-icons";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class fonts {
                public const string UrlPath = "~/Content/simple-line-icons/fonts";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
                public static readonly string Simple_Line_Icons_eot = Url("Simple-Line-Icons.eot");
                public static readonly string Simple_Line_Icons_svg = Url("Simple-Line-Icons.svg");
                public static readonly string Simple_Line_Icons_ttf = Url("Simple-Line-Icons.ttf");
                public static readonly string Simple_Line_Icons_woff = Url("Simple-Line-Icons.woff");
                public static readonly string Simple_Line_Iconsd41d_eot = Url("Simple-Line-Iconsd41d.eot");
            }
        
            public static readonly string simple_line_icons_min_css = Url("simple-line-icons.min.css");
        }
    
        public static readonly string Site_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/Site.min.css") ? Url("Site.min.css") : Url("Site.css");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class theme {
            public const string UrlPath = "~/Content/theme";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
            public static readonly string custom_rtl_min_css = Url("custom-rtl.min.css");
            public static readonly string layout_rtl_min_css = Url("layout-rtl.min.css");
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class themes {
                public const string UrlPath = "~/Content/theme/themes";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
                public static readonly string darkblue_rtl_min_css = Url("darkblue-rtl.min.css");
            }
        
        }
    
    }

    
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Bundles
    {
        public static partial class Scripts 
        {
            public static partial class i18n 
            {
                public static class Assets
                {
                    public const string ar_js = "~/Scripts/i18n/ar.js"; 
                    public const string az_js = "~/Scripts/i18n/az.js"; 
                    public const string bg_js = "~/Scripts/i18n/bg.js"; 
                    public const string ca_js = "~/Scripts/i18n/ca.js"; 
                    public const string cs_js = "~/Scripts/i18n/cs.js"; 
                    public const string da_js = "~/Scripts/i18n/da.js"; 
                    public const string de_js = "~/Scripts/i18n/de.js"; 
                    public const string el_js = "~/Scripts/i18n/el.js"; 
                    public const string en_js = "~/Scripts/i18n/en.js"; 
                    public const string es_js = "~/Scripts/i18n/es.js"; 
                    public const string et_js = "~/Scripts/i18n/et.js"; 
                    public const string eu_js = "~/Scripts/i18n/eu.js"; 
                    public const string fa_js = "~/Scripts/i18n/fa.js"; 
                    public const string fi_js = "~/Scripts/i18n/fi.js"; 
                    public const string fr_js = "~/Scripts/i18n/fr.js"; 
                    public const string gl_js = "~/Scripts/i18n/gl.js"; 
                    public const string he_js = "~/Scripts/i18n/he.js"; 
                    public const string hi_js = "~/Scripts/i18n/hi.js"; 
                    public const string hr_js = "~/Scripts/i18n/hr.js"; 
                    public const string hu_js = "~/Scripts/i18n/hu.js"; 
                    public const string id_js = "~/Scripts/i18n/id.js"; 
                    public const string is_js = "~/Scripts/i18n/is.js"; 
                    public const string it_js = "~/Scripts/i18n/it.js"; 
                    public const string ja_js = "~/Scripts/i18n/ja.js"; 
                    public const string km_js = "~/Scripts/i18n/km.js"; 
                    public const string ko_js = "~/Scripts/i18n/ko.js"; 
                    public const string lt_js = "~/Scripts/i18n/lt.js"; 
                    public const string lv_js = "~/Scripts/i18n/lv.js"; 
                    public const string mk_js = "~/Scripts/i18n/mk.js"; 
                    public const string ms_js = "~/Scripts/i18n/ms.js"; 
                    public const string nb_js = "~/Scripts/i18n/nb.js"; 
                    public const string nl_js = "~/Scripts/i18n/nl.js"; 
                    public const string pl_js = "~/Scripts/i18n/pl.js"; 
                    public const string pt_BR_js = "~/Scripts/i18n/pt-BR.js"; 
                    public const string pt_js = "~/Scripts/i18n/pt.js"; 
                    public const string ro_js = "~/Scripts/i18n/ro.js"; 
                    public const string ru_js = "~/Scripts/i18n/ru.js"; 
                    public const string sk_js = "~/Scripts/i18n/sk.js"; 
                    public const string sr_Cyrl_js = "~/Scripts/i18n/sr-Cyrl.js"; 
                    public const string sr_js = "~/Scripts/i18n/sr.js"; 
                    public const string sv_js = "~/Scripts/i18n/sv.js"; 
                    public const string th_js = "~/Scripts/i18n/th.js"; 
                    public const string tr_js = "~/Scripts/i18n/tr.js"; 
                    public const string uk_js = "~/Scripts/i18n/uk.js"; 
                    public const string vi_js = "~/Scripts/i18n/vi.js"; 
                    public const string zh_CN_js = "~/Scripts/i18n/zh-CN.js"; 
                    public const string zh_TW_js = "~/Scripts/i18n/zh-TW.js"; 
                }
            }
            public static partial class typings 
            {
                public static partial class jquery 
                {
                    public static class Assets
                    {
                    }
                }
                public static class Assets
                {
                }
            }
            public static class Assets
            {
                public const string app_min_js = "~/Scripts/app.min.js"; 
                public const string bootstrap_switch_js = "~/Scripts/bootstrap-switch.js"; 
                public const string bootstrap_switch_min_js = "~/Scripts/bootstrap-switch.min.js"; 
                public const string bootstrap_js = "~/Scripts/bootstrap.js"; 
                public const string bootstrap_min_js = "~/Scripts/bootstrap.min.js"; 
                public const string jquery_2_2_4_intellisense_js = "~/Scripts/jquery-2.2.4.intellisense.js"; 
                public const string jquery_2_2_4_js = "~/Scripts/jquery-2.2.4.js"; 
                public const string jquery_2_2_4_min_js = "~/Scripts/jquery-2.2.4.min.js"; 
                public const string jquery_blockUI_js = "~/Scripts/jquery.blockUI.js"; 
                public const string jquery_slimscroll_js = "~/Scripts/jquery.slimscroll.js"; 
                public const string jquery_slimscroll_min_js = "~/Scripts/jquery.slimscroll.min.js"; 
                public const string jquery_validate_js = "~/Scripts/jquery.validate.js"; 
                public const string jquery_validate_min_js = "~/Scripts/jquery.validate.min.js"; 
                public const string jquery_validate_unobtrusive_js = "~/Scripts/jquery.validate.unobtrusive.js"; 
                public const string jquery_validate_unobtrusive_min_js = "~/Scripts/jquery.validate.unobtrusive.min.js"; 
                public const string layout_min_js = "~/Scripts/layout.min.js"; 
                public const string modernizr_2_8_3_js = "~/Scripts/modernizr-2.8.3.js"; 
                public const string quick_nav_min_js = "~/Scripts/quick-nav.min.js"; 
                public const string quick_sidebar_min_js = "~/Scripts/quick-sidebar.min.js"; 
                public const string respond_js = "~/Scripts/respond.js"; 
                public const string respond_matchmedia_addListener_js = "~/Scripts/respond.matchmedia.addListener.js"; 
                public const string respond_matchmedia_addListener_min_js = "~/Scripts/respond.matchmedia.addListener.min.js"; 
                public const string respond_min_js = "~/Scripts/respond.min.js"; 
                public const string select2_js = "~/Scripts/select2.js"; 
                public const string select2_min_js = "~/Scripts/select2.min.js"; 
            }
        }
        public static partial class Content 
        {
            public static partial class bootstrap_switch 
            {
                public static partial class bootstrap2 
                {
                    public static class Assets
                    {
                        public const string bootstrap_switch_css = "~/Content/bootstrap-switch/bootstrap2/bootstrap-switch.css";
                        public const string bootstrap_switch_min_css = "~/Content/bootstrap-switch/bootstrap2/bootstrap-switch.min.css";
                    }
                }
                public static partial class bootstrap3 
                {
                    public static class Assets
                    {
                        public const string bootstrap_switch_css = "~/Content/bootstrap-switch/bootstrap3/bootstrap-switch.css";
                        public const string bootstrap_switch_min_css = "~/Content/bootstrap-switch/bootstrap3/bootstrap-switch.min.css";
                    }
                }
                public static class Assets
                {
                }
            }
            public static partial class css 
            {
                public static class Assets
                {
                    public const string select2_css = "~/Content/css/select2.css";
                    public const string select2_min_css = "~/Content/css/select2.min.css";
                }
            }
            public static partial class IranSans 
            {
                public static class Assets
                {
                    public const string IranSans_css = "~/Content/IranSans/IranSans.css";
                }
            }
            public static partial class simple_line_icons 
            {
                public static partial class fonts 
                {
                    public static class Assets
                    {
                    }
                }
                public static class Assets
                {
                    public const string simple_line_icons_min_css = "~/Content/simple-line-icons/simple-line-icons.min.css";
                }
            }
            public static partial class theme 
            {
                public static partial class themes 
                {
                    public static class Assets
                    {
                        public const string darkblue_rtl_min_css = "~/Content/theme/themes/darkblue-rtl.min.css";
                    }
                }
                public static class Assets
                {
                    public const string custom_rtl_min_css = "~/Content/theme/custom-rtl.min.css";
                    public const string layout_rtl_min_css = "~/Content/theme/layout-rtl.min.css";
                }
            }
            public static class Assets
            {
                public const string bootstrap_overlay_css = "~/Content/bootstrap-overlay.css";
                public const string bootstrap_rtl_css = "~/Content/bootstrap-rtl.css";
                public const string bootstrap_rtl_min_css = "~/Content/bootstrap-rtl.min.css";
                public const string bootstrap_switch_rtl_min_css = "~/Content/bootstrap-switch-rtl.min.css";
                public const string bootstrap_theme_rtl_css = "~/Content/bootstrap-theme-rtl.css";
                public const string bootstrap_theme_rtl_min_css = "~/Content/bootstrap-theme-rtl.min.css";
                public const string bootstrap_theme_css = "~/Content/bootstrap-theme.css";
                public const string bootstrap_theme_min_css = "~/Content/bootstrap-theme.min.css";
                public const string bootstrap_css = "~/Content/bootstrap.css";
                public const string bootstrap_min_css = "~/Content/bootstrap.min.css";
                public const string components_rtl_overlay_css = "~/Content/components-rtl-overlay.css";
                public const string components_rtl_min_css = "~/Content/components-rtl.min.css";
                public const string font_awesome_css = "~/Content/font-awesome.css";
                public const string font_awesome_min_css = "~/Content/font-awesome.min.css";
                public const string plugins_rtl_min_css = "~/Content/plugins-rtl.min.css";
                public const string Site_css = "~/Content/Site.css";
            }
        }
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;

    // Calling T4Extension.TimestampString through delegate to allow it to be replaced for unit testing and other purposes
    public static Func<string, string> TimestampString = System.Web.Mvc.T4Extensions.TimestampString;

    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114



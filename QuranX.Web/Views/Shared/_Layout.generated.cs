﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using QuranX.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Layout.cshtml")]
    public partial class _Views_Shared__Layout_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Layout_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n<head>\r\n\t<meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(" />\r\n\t<meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1.0\"");

WriteLiteral(">\r\n\t<title>");

            
            #line 6 "..\..\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n");

WriteLiteral("\t");

            
            #line 7 "..\..\Views\Shared\_Layout.cshtml"
Write(Styles.Render("~/Content/css"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\t");

            
            #line 8 "..\..\Views\Shared\_Layout.cshtml"
Write(Scripts.Render("~/bundles/jquery"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\t");

            
            #line 9 "..\..\Views\Shared\_Layout.cshtml"
Write(Scripts.Render("~/bundles/modernizr"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\t");

            
            #line 10 "..\..\Views\Shared\_Layout.cshtml"
Write(Scripts.Render("~/bundles/site"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t<script async");

WriteLiteral(" src=\"https://www.googletagmanager.com/gtag/js?id=UA-42308840-1\"");

WriteLiteral("></script>\r\n\t<script>\r\n\t\twindow.dataLayer = window.dataLayer || [];\r\n\t\tfunction g" +
"tag() { dataLayer.push(arguments); }\r\n\t\tgtag(\'js\', new Date());\r\n\t\tgtag(\'config\'" +
", \'UA-42308840-1\');\r\n\t</script>\r\n\t<meta");

WriteLiteral(" property=\"og:image\"");

WriteLiteral(" content=\"https://QuranX.com/Content/Images/QuranXSocialIcon.png\"");

WriteLiteral(" />\r\n\t<meta");

WriteLiteral(" property=\"og:title\"");

WriteLiteral(" content=\"QuranX.com The most complete Quran / Hadith / Tafsir collection availab" +
"le!\"");

WriteLiteral(" />\r\n\t<meta");

WriteLiteral(" property=\"og:url\"");

WriteAttribute("content", Tuple.Create(" content=\"", 822), Tuple.Create("\"", 867)
, Tuple.Create(Tuple.Create("", 832), Tuple.Create("https://QuranX.com", 832), true)
            
            #line 20 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 850), Tuple.Create<System.Object, System.Int32>(Request.RawUrl
            
            #line default
            #line hidden
, 850), false)
);

WriteLiteral(" />\r\n\t<meta");

WriteLiteral(" property=\"og:type\"");

WriteLiteral(" content=\"website\"");

WriteLiteral(" />\r\n</head>\r\n<body>\r\n\t<div");

WriteLiteral(" class=\"quranx navbar navbar-inverse navbar-fixed-top\"");

WriteLiteral(">\r\n\t\t<div>\r\n\t\t\t<div");

WriteLiteral(" class=\"quranx navbar-header\"");

WriteLiteral(">\r\n\t\t\t\t<button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"quranx navbar-toggle\"");

WriteLiteral(" data-toggle=\"collapse\"");

WriteLiteral(" data-target=\".navbar-collapse\"");

WriteLiteral(">\r\n\t\t\t\t\tMENU\r\n\t\t\t\t</button>\r\n\t\t\t\t<a");

WriteLiteral(" href=\"/1.1\"");

WriteLiteral(" class=\"quranx navbar-brand\"");

WriteLiteral(">QuranX</a>\r\n\t\t\t</div>\r\n\t\t\t<div");

WriteLiteral(" class=\"quranx navbar-collapse collapse\"");

WriteLiteral(">\r\n\t\t\t\t<ul");

WriteLiteral(" class=\"quranx nav navbar-nav\"");

WriteLiteral(">\r\n\t\t\t\t\t<li><a");

WriteLiteral(" href=\"/1.1\"");

WriteLiteral(">Quran</a></li>\r\n\t\t\t\t\t<li>");

            
            #line 35 "..\..\Views\Shared\_Layout.cshtml"
                   Write(Html.RouteLink("Commentaries", "Commentators"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n\t\t\t\t\t<li>");

            
            #line 36 "..\..\Views\Shared\_Layout.cshtml"
                   Write(Html.RouteLink("Hadiths", "HadithCollections"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n\t\t\t\t\t<li>");

            
            #line 37 "..\..\Views\Shared\_Layout.cshtml"
                   Write(Html.RouteLink("Search", "SiteSearch"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n\t\t\t\t</ul>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n\t<div");

WriteLiteral(" class=\"container-fluid body-content\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t");

            
            #line 43 "..\..\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n\t</div>\r\n\r\n");

WriteLiteral("\t");

            
            #line 46 "..\..\Views\Shared\_Layout.cshtml"
Write(Scripts.Render("~/bundles/jquery"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\t");

            
            #line 47 "..\..\Views\Shared\_Layout.cshtml"
Write(Scripts.Render("~/bundles/bootstrap"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\t");

            
            #line 48 "..\..\Views\Shared\_Layout.cshtml"
Write(RenderSection("scripts", required: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n</body>\r\n</html>\r\n");

        }
    }
}
#pragma warning restore 1591

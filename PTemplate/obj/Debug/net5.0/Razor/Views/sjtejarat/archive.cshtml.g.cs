#pragma checksum "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d2bee2a49951e469384f199b110430a498fca47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PTemplate.Areas.Admin.Data.Views_sjtejarat_archive), @"mvc.1.0.view", @"/Views/sjtejarat/archive.cshtml")]
namespace PTemplate.Areas.Admin.Data
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\_ViewImports.cshtml"
using PTemplate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\_ViewImports.cshtml"
using PTemplate.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d2bee2a49951e469384f199b110430a498fca47", @"/Views/sjtejarat/archive.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b03a70e338dc36e5bd038aa87a92c7c7ea9b3d79", @"/Views/_ViewImports.cshtml")]
    public class Views_sjtejarat_archive : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PTemplate.Models.DataViewModel.Postarchive>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
  
    ViewData["Title"] = "آرشیو";
    Layout = "~/Views/sjtejarat/Shared/_MainHome.cshtml";
    ViewData["homeUrl"] = "";
    ViewData["externalHomeUrl"] = "/sjtejarat/";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("sitmapplaceholder", async() => {
                WriteLiteral(@"


    <div class=""mag-breadcrumb py-5"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <nav aria-label=""breadcrumb"">
                        <ol class=""breadcrumb rtl"">
                            <li class=""breadcrumb-item""><a");
                BeginWriteAttribute("href", " href=\"", 617, "\"", 652, 1);
#nullable restore
#line 23 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
WriteAttributeValue("", 624, ViewData["externalHomeUrl"], 624, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-home\" aria-hidden=\"true\"></i> خانه</a></li>\r\n                            <li class=\"breadcrumb-item\"><a");
                BeginWriteAttribute("href", " href=\"", 773, "\"", 834, 3);
#nullable restore
#line 24 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
WriteAttributeValue("", 780, ViewData["externalHomeUrl"], 780, 28, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 808, "archive?Idmenu=", 808, 15, true);
                WriteAttributeValue(" ", 823, "0&paging=1", 824, 11, true);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa \" aria-hidden=\"true\"></i> آرشیو</a></li>\r\n");
#nullable restore
#line 25 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
                             if (@ViewData["nameMenu"] != null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"breadcrumb-item\"><a");
                BeginWriteAttribute("href", " href=\"", 1049, "\"", 1130, 4);
#nullable restore
#line 27 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
WriteAttributeValue("", 1056, ViewData["externalHomeUrl"], 1056, 28, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1084, "archive?Idmenu=", 1084, 15, true);
#nullable restore
#line 27 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
WriteAttributeValue(" ", 1099, ViewData["nameMenu"], 1100, 21, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1121, "&paging=1", 1121, 9, true);
                EndWriteAttribute();
                WriteLiteral("> ");
#nullable restore
#line 27 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
                                                                                                                                             Write(ViewData["nameMenu"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></li>\r\n");
#nullable restore
#line 28 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"breadcrumb-item\"><a");
                BeginWriteAttribute("href", " href=\"", 1323, "\"", 1384, 3);
#nullable restore
#line 31 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
WriteAttributeValue("", 1330, ViewData["externalHomeUrl"], 1330, 28, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1358, "archive?Idmenu=", 1358, 15, true);
                WriteAttributeValue(" ", 1373, "0&paging=1", 1374, 11, true);
                EndWriteAttribute();
                WriteLiteral("> همه تکیه های دانایی</a></li>\r\n");
#nullable restore
#line 32 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </ol>\r\n                    </nav>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n");
            }
            );
            WriteLiteral("\r\n\r\n<div class=\"col-12 col-xl-8\">\r\n    <div class=\"archive-posts-area bg-white p-30 mb-30 box-shadow\">\r\n\r\n\r\n");
#nullable restore
#line 50 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
         foreach (var i in Model.post)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- Single Catagory Post -->\r\n            <div class=\"single-catagory-post d-flex flex-wrap\">\r\n                <!-- Thumbnail -->\r\n                <div class=\"post-thumbnail bg-img\"");
            BeginWriteAttribute("style", " style=\"", 1943, "\"", 1986, 4);
            WriteAttributeValue("", 1951, "background-image:", 1951, 17, true);
            WriteAttributeValue(" ", 1968, "url(", 1969, 5, true);
#nullable restore
#line 55 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
WriteAttributeValue("", 1973, i.Pathdata, 1973, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1984, ");", 1984, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 56 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
                     if (i.Idposttype == (int)PTemplate.Models.Enum.Posts.video)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 2121, "\"", 2172, 3);
#nullable restore
#line 58 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
WriteAttributeValue("", 2128, ViewData["externalHomeUrl"], 2128, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2156, "singlepost/", 2156, 11, true);
#nullable restore
#line 58 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
WriteAttributeValue("", 2167, i.Id, 2167, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"video-play\"><i class=\"fa fa-play\"></i></a>\r\n");
#nullable restore
#line 59 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 2323, "\"", 2374, 3);
#nullable restore
#line 62 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
WriteAttributeValue("", 2330, ViewData["externalHomeUrl"], 2330, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2358, "singlepost/", 2358, 11, true);
#nullable restore
#line 62 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
WriteAttributeValue("", 2369, i.Id, 2369, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"video-play\"><i class=\"fa\"></i></a>\r\n");
#nullable restore
#line 63 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n                <!-- Post Contetnt -->\r\n                <div class=\"post-content\">\r\n                    <div class=\"post-meta\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2625, "\"", 2676, 3);
#nullable restore
#line 70 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
WriteAttributeValue("", 2632, ViewData["externalHomeUrl"], 2632, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2660, "singlepost/", 2660, 11, true);
#nullable restore
#line 70 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
WriteAttributeValue("", 2671, i.Id, 2671, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 70 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
                                                                          Write(PTemplate.Models.PersianDate.ToPersianDate((DateTime)i.Datecreate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 71 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
                         if (@i.IdmenuNavigation != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 2867, "\"", 2918, 3);
#nullable restore
#line 73 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
WriteAttributeValue("", 2874, ViewData["externalHomeUrl"], 2874, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2902, "singlepost/", 2902, 11, true);
#nullable restore
#line 73 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
WriteAttributeValue("", 2913, i.Id, 2913, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 73 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
                                                                              Write(i.IdmenuNavigation.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 74 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 3029, "\"", 3080, 3);
#nullable restore
#line 77 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
WriteAttributeValue("", 3036, ViewData["externalHomeUrl"], 3036, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3064, "singlepost/", 3064, 11, true);
#nullable restore
#line 77 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
WriteAttributeValue("", 3075, i.Id, 3075, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"post-title\">");
#nullable restore
#line 77 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
                                                                                         Write(i.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    <!-- Post Meta -->\r\n                    <div class=\"post-meta-2\">\r\n                        <a href=\"#\"><i class=\"fa fa-eye\" aria-hidden=\"true\"></i> ? </a>\r\n");
            WriteLiteral("                    </div>\r\n                    <p>\r\n                        ");
#nullable restore
#line 85 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
                   Write(i.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 89 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 94 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
         if (Model.post != null)
        {
            if (Model.post.Count >= 1)
            {



#line default
#line hidden
#nullable disable
            WriteLiteral("                <!-- Pagination -->\r\n                <nav>\r\n                    <ul class=\"pagination rtl\">\r\n                        <li class=\"page-item \"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3956, "\"", 4034, 4);
#nullable restore
#line 103 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
WriteAttributeValue("", 3963, ViewData["externalHomeUrl"], 3963, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3991, "archive?Idmenu=", 3991, 15, true);
#nullable restore
#line 103 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
WriteAttributeValue("", 4006, ViewData["idmenu"], 4006, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4025, "&paging=1", 4025, 9, true);
            EndWriteAttribute();
            WriteLiteral(">ابتدا</a></li>\r\n");
#nullable restore
#line 104 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
                         for (var p = 1; p <= (int)ViewData["PostRe"]; p++)
                        {
                            if ((int)ViewData["paging"] == p)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"page-item active\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4331, "\"", 4410, 5);
#nullable restore
#line 108 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
WriteAttributeValue("", 4338, ViewData["externalHomeUrl"], 4338, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4366, "archive?Idmenu=", 4366, 15, true);
#nullable restore
#line 108 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
WriteAttributeValue("", 4381, ViewData["idmenu"], 4381, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4400, "&paging=", 4400, 8, true);
#nullable restore
#line 108 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
WriteAttributeValue("", 4408, p, 4408, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 108 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
                                                                                                                                                             Write(p);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 109 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4595, "\"", 4674, 5);
#nullable restore
#line 112 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
WriteAttributeValue("", 4602, ViewData["externalHomeUrl"], 4602, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4630, "archive?Idmenu=", 4630, 15, true);
#nullable restore
#line 112 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
WriteAttributeValue("", 4645, ViewData["idmenu"], 4645, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4664, "&paging=", 4664, 8, true);
#nullable restore
#line 112 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
WriteAttributeValue("", 4672, p, 4672, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 112 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
                                                                                                                                                      Write(p);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 113 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item \">\r\n                            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4844, "\"", 4940, 5);
#nullable restore
#line 116 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
WriteAttributeValue("", 4851, ViewData["externalHomeUrl"], 4851, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4879, "archive?Idmenu=", 4879, 15, true);
#nullable restore
#line 116 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
WriteAttributeValue("", 4894, ViewData["idmenu"], 4894, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4913, "&paging=", 4913, 8, true);
#nullable restore
#line 116 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
WriteAttributeValue("", 4921, ViewData["PostRe"], 4921, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">انتها</a>\r\n                        </li>\r\n\r\n                    </ul>\r\n                </nav>\r\n");
#nullable restore
#line 121 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"text-xlarge center-block\"> موردی یافت نشد </span>\r\n");
#nullable restore
#line 125 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\sjtejarat\archive.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PTemplate.Models.DataViewModel.Postarchive> Html { get; private set; }
    }
}
#pragma warning restore 1591

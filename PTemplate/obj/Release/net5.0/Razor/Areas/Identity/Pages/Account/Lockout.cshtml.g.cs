#pragma checksum "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Identity\Pages\Account\Lockout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4879f5663165c3af599bc22075d89fb4b0290dbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Lockout), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Lockout.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Identity\Pages\_ViewImports.cshtml"
using PTemplate.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Identity\Pages\_ViewImports.cshtml"
using PTemplate.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using PTemplate.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4879f5663165c3af599bc22075d89fb4b0290dbe", @"/Areas/Identity/Pages/Account/Lockout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9744b9b202b7c82517cf2071d3cd8be977f80bab", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b8791c95c95a54dce3de01b08d0477f4f933259", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Lockout : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Identity\Pages\Account\Lockout.cshtml"
  
    ViewData["Title"] = "قفل حساب کاربری";
    Layout = "~/Views/dadras/Shared/_MainPostPages.cshtml";
    ViewData["externalHomeUrl"] = "/dadras/";
    ViewData["HomeUrl"] = "/";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("sitmapplaceholder", async() => {
                WriteLiteral(@"
    <div class=""mag-breadcrumb py-5"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <nav aria-label=""breadcrumb"">
                        <ol class=""breadcrumb rtl"">
                            <li class=""breadcrumb-item""><a");
                BeginWriteAttribute("href", " href=\"", 632, "\"", 667, 1);
#nullable restore
#line 21 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Identity\Pages\Account\Lockout.cshtml"
WriteAttributeValue("", 639, ViewData["externalHomeUrl"], 639, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"><i class=""fa fa-home"" aria-hidden=""true""></i> خانه</a></li>
                            <li class=""breadcrumb-item""><a href=""#""><i class=""fa "" aria-hidden=""true""></i> خروج از اکانت</a></li>


                        </ol>
                    </nav>
                </div>
            </div>
        </div>
    </div>
");
            }
            );
            WriteLiteral("\r\n<div class=\"col-12 col-xl-8\">\r\n    <div class=\"contact-content-area bg-white mb-30 p-30 box-shadow\">\r\n        <header>\r\n            <h1 class=\"text-danger\">");
#nullable restore
#line 36 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Identity\Pages\Account\Lockout.cshtml"
                               Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <p class=\"text-danger\">شما به مدت 5 دقیقه , حساب کاربری شما قفل می باشد.</p>\r\n        </header>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LockoutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LockoutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LockoutModel>)PageContext?.ViewData;
        public LockoutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

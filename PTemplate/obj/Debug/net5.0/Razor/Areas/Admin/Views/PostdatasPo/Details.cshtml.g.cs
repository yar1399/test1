#pragma checksum "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1c5cc24b7ee4c4632e8f08caa10671c0bd4dddf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PTemplate.Areas_Admin_Views_PostdatasPo_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/PostdatasPo/Details.cshtml")]
namespace PTemplate
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
#line 3 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Details.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Details.cshtml"
using PTemplate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Details.cshtml"
using PTemplate.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1c5cc24b7ee4c4632e8f08caa10671c0bd4dddf", @"/Areas/Admin/Views/PostdatasPo/Details.cshtml")]
    public class Areas_Admin_Views_PostdatasPo_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PTemplate.Data.DataBase.Postdata>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Details.cshtml"
  
    ViewData["Title"] = "جزئیات محتوا پست";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>جزئیات محتوای پست</h2>\r\n\r\n<div>\r\n    <h4>Postdata</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            مسیر\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 24 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pathdata));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            فعال\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 30 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Details.cshtml"
       Write(Html.DisplayFor(model => model.Isactive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            توضیح  هات\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 36 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            نوع پست\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 42 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Details.cshtml"
       Write(Html.DisplayFor(model => model.IddatatypeNavigation.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            عنوان\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 48 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdpostNavigation.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1c5cc24b7ee4c4632e8f08caa10671c0bd4dddf5682", async() => {
                WriteLiteral("ویرایش");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1160, "~/Admin/PostdatasPo/Edit/", 1160, 25, true);
#nullable restore
#line 53 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Details.cshtml"
AddHtmlAttributeValue("", 1185, Model.Id, 1185, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1c5cc24b7ee4c4632e8f08caa10671c0bd4dddf7243", async() => {
                WriteLiteral("برگشت");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1223, "~/Admin/PostdatasPo/Index/", 1223, 26, true);
#nullable restore
#line 54 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Details.cshtml"
AddHtmlAttributeValue("", 1249, Model.Id, 1249, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PTemplate.Data.DataBase.Postdata> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf14a1b582031de66d0a57213d018bc5d8174fdc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PTemplate.Areas_Admin_Views_PostdatasPo_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/PostdatasPo/Delete.cshtml")]
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
#line 3 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Delete.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Delete.cshtml"
using PTemplate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Delete.cshtml"
using PTemplate.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf14a1b582031de66d0a57213d018bc5d8174fdc", @"/Areas/Admin/Views/PostdatasPo/Delete.cshtml")]
    public class Areas_Admin_Views_PostdatasPo_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PTemplate.Data.DataBase.Postdata>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>ویرایش جدید</h2>\r\n\r\n\r\n\r\n\r\n\r\n<p>\r\n\r\n\r\n");
#nullable restore
#line 24 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Delete.cshtml"
     if (long.Parse(ViewData["Idpost"].ToString()) >= 1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("harf", " harf=\"", 428, "\"", 481, 2);
            WriteAttributeValue("", 435, "~/Admin/PostdatasPo/Create/", 435, 27, true);
#nullable restore
#line 26 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Delete.cshtml"
WriteAttributeValue("", 462, ViewData["Idpost"], 462, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">محتوای جدید</a>\r\n");
#nullable restore
#line 27 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Delete.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</p>\r\n\r\n\r\n\r\n<div>\r\n");
#nullable restore
#line 36 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Delete.cshtml"
      
        var b = (PTemplate.Data.DataBase.Post)ViewData["post"];

    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1> ");
#nullable restore
#line 40 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Delete.cshtml"
    Write(b.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p> ");
#nullable restore
#line 41 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Delete.cshtml"
   Write(b.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n\r\n\r\n        <dt>\r\n            تاریخ\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 50 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Delete.cshtml"
       Write(PersianDate.ToPersianDateString((DateTime)b.Datecreate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("        </dd>\r\n        <dt>\r\n            وضعیت\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 57 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Delete.cshtml"
       Write(b.Isactive);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            زیر گروه\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 64 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Delete.cshtml"
       Write(b.IdmenuNavigation.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Postdata</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n          مسیر\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 80 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pathdata));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n           فعال\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 86 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Isactive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n          توضیح\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 92 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n          نوع پست\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 98 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IddatatypeNavigation.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n         عنوان\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 104 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IdpostNavigation.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf14a1b582031de66d0a57213d018bc5d8174fdc9726", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bf14a1b582031de66d0a57213d018bc5d8174fdc9992", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 109 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"حذف\" class=\"btn btn-default\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf14a1b582031de66d0a57213d018bc5d8174fdc11792", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2152, "~/Admin/PostdatasPo/Index/", 2152, 26, true);
#nullable restore
#line 111 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\PostdatasPo\Delete.cshtml"
AddHtmlAttributeValue("", 2178, Model.Id, 2178, 9, false);

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
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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

#pragma checksum "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\Factorsubs\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d5935bdf386a2c7bb94e9aa6a4448f46713aecd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Factorsubs_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Factorsubs/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d5935bdf386a2c7bb94e9aa6a4448f46713aecd", @"/Areas/Admin/Views/Factorsubs/Create.cshtml")]
    public class Areas_Admin_Views_Factorsubs_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PTemplate.Data.DataBase.Factorsub>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/Factorsubs/Create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Areas\Admin\Views\Factorsubs\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Create</h2>\r\n\r\n<h4>Factorsub</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d5935bdf386a2c7bb94e9aa6a4448f46713aecd3817", async() => {
                WriteLiteral(@"
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Idproduct"" class=""control-label""></label>
                <select asp-for=""Idproduct"" class =""form-control"" asp-items=""ViewBag.Idproduct""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""Idfactor"" class=""control-label""></label>
                <select asp-for=""Idfactor"" class =""form-control"" asp-items=""ViewBag.Idfactor""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""Idcolor"" class=""control-label""></label>
                <select asp-for=""Idcolor"" class =""form-control"" asp-items=""ViewBag.Idcolor""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""Count"" class=""control-label""></label>
                <input asp-for=""Count"" class=""form-control"" />
                <span asp-validation-for=""Count"" class=""te");
                WriteLiteral(@"xt-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Money"" class=""control-label""></label>
                <input asp-for=""Money"" class=""form-control"" />
                <span asp-validation-for=""Money"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Offpercent"" class=""control-label""></label>
                <input asp-for=""Offpercent"" class=""form-control"" />
                <span asp-validation-for=""Offpercent"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Datecreate"" class=""control-label""></label>
                <input asp-for=""Datecreate"" class=""form-control"" />
                <span asp-validation-for=""Datecreate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-default"" />
            </div>
   ");
                WriteLiteral("     ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a harf=\"~/Admin/Factorsubs/Index\">برگشت</a>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PTemplate.Data.DataBase.Factorsub> Html { get; private set; }
    }
}
#pragma warning restore 1591

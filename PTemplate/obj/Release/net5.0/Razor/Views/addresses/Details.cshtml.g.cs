#pragma checksum "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\addresses\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d06f23227283f94441c36c811372b2019e5e5db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_addresses_Details), @"mvc.1.0.view", @"/Views/addresses/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d06f23227283f94441c36c811372b2019e5e5db", @"/Views/addresses/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b03a70e338dc36e5bd038aa87a92c7c7ea9b3d79", @"/Views/_ViewImports.cshtml")]
    public class Views_addresses_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PTemplate.Data.DataBase.Productaddress>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditIsActiveAddress", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\addresses\Details.cshtml"
  
    ViewData["Title"] = "صفحه نخست";
    Layout = "~/Views/cbkala/Shared/personmanger.cshtml";
    ViewData["externalHomeUrl"] = "/cbkala/";
    ViewData["HomeUrl"] = "/";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div id=""container"">
    <div class=""container"">
        <div class=""row"">
            <h2>توضیح هات</h2>

            <div>
                <h4>Productaddress</h4>
                <hr />
                <dl class=""dl-horizontal"">
                    <dt>
                        ");
#nullable restore
#line 19 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\addresses\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Namefamily));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
#nullable restore
#line 22 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\addresses\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Namefamily));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
#nullable restore
#line 25 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\addresses\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Tell));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
#nullable restore
#line 28 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\addresses\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Tell));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
#nullable restore
#line 31 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\addresses\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
#nullable restore
#line 34 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\addresses\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
#nullable restore
#line 37 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\addresses\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
#nullable restore
#line 40 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\addresses\Details.cshtml"
                   Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
#nullable restore
#line 43 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\addresses\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Province));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
#nullable restore
#line 46 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\addresses\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Province));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
#nullable restore
#line 49 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\addresses\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Postalcode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
#nullable restore
#line 52 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\addresses\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Postalcode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n");
            WriteLiteral("                    <dt>\r\n                        ");
#nullable restore
#line 67 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\addresses\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Createdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
#nullable restore
#line 70 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\addresses\Details.cshtml"
                   Write(PersianDate.ToPersianDateString(DateTime.Parse( Model.Createdate.ToString())));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                      \r\n                    </dd>\r\n");
            WriteLiteral("                </dl>\r\n            </div>\r\n            <div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d06f23227283f94441c36c811372b2019e5e5db9750", async() => {
                WriteLiteral("ویرایش");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\addresses\Details.cshtml"
                                       WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d06f23227283f94441c36c811372b2019e5e5db11920", async() => {
                WriteLiteral("ادرس فعال برای خرید ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\addresses\Details.cshtml"
                                                      WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d06f23227283f94441c36c811372b2019e5e5db14120", async() => {
                WriteLiteral("برگشت");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n              \r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PTemplate.Data.DataBase.Productaddress> Html { get; private set; }
    }
}
#pragma warning restore 1591

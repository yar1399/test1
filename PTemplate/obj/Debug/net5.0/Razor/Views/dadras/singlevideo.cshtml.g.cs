#pragma checksum "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\dadras\singlevideo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a938292cc2f1fab7fae1e399382d182f8e1c5bd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_dadras_singlevideo), @"mvc.1.0.view", @"/Views/dadras/singlevideo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a938292cc2f1fab7fae1e399382d182f8e1c5bd0", @"/Views/dadras/singlevideo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b03a70e338dc36e5bd038aa87a92c7c7ea9b3d79", @"/Views/_ViewImports.cshtml")]
    public class Views_dadras_singlevideo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\dadras\singlevideo.cshtml"
  
    ViewData["Title"] = "محتوی";
    Layout = "~/Views/dadras/Shared/_MainPostPages.cshtml";
    ViewData["externalHomeUrl"] = "/dadras/";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("videoplaceholder", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-12"">
            <div class=""single-video-area bg-white mb-30 box-shadow"">
                <iframe src=""https://www.youtube.com/embed/J_x3-pgV-Ko"" allow=""accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
                <!-- Video Meta Data -->
                <div class=""video-meta-data d-flex align-items-center justify-content-between"">
                    <h6 class=""total-views"">1034 بازدید</h6>
                    <div class=""like-dislike d-flex align-items-center"">
                        <button type=""button""><i class=""fa fa-thumbs-o-up"" aria-hidden=""true""></i> 834 پسندیدن</button>
                        <button type=""button""><i class=""fa fa-thumbs-o-down"" aria-hidden=""true""></i> 34 نپسندیدن</button>
                        <p><i class=""fa fa-comments-o"" aria-hidden=""true""></i> 234 نظر</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n<!-- Post Details Content Area -->\r\n<div class=\"col-12 col-xl-8\">\r\n    <div class=\"post-details-content bg-white mb-30 p-30 box-shadow\">\r\n        <div class=\"blog-thumb mb-30\">\r\n            <img src=\"img/bg-img/50.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1424, "\"", 1430, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        </div>
        <div class=""blog-content"">
            <div class=""post-meta"">
                <a href=""#"">18/9/1398</a>
                <a href=""archive.html"">سواد زندگی</a>
            </div>
            <h4 class=""post-title"">این یک عنوان آزمایشی است</h4>
            <!-- Post Meta -->
            <div class=""post-meta-2 rtl"">
                <a href=""#""><i class=""fa fa-eye"" aria-hidden=""true""></i> 1034</a>
                <a href=""#""><i class=""fa fa-thumbs-o-up"" aria-hidden=""true""></i> 834</a>
                <a href=""#""><i class=""fa fa-comments-o"" aria-hidden=""true""></i> 234</a>
            </div>

            <p>

                لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم ");
            WriteLiteral(@"افزارها شناخت بیستری را برای طراحان رایانه ای و فرهنگ پیشرو در زبان فارسی ایجاد کرد.

            </p>

            <p>

                لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیستری را برای طراحان رایانه ای و فرهنگ پیشرو در زبان فارسی ایجاد کرد.

            </p>

            <div class=""row"">
                <div class=""col-12 col-lg-8"">
                    <p>
                        هدف از نوشتن این متن تنها این است که شما ببینید در صورت پر شدن، شکل ظاهری آن به چه صورت در می آید. با تشکر از لطف و همراهی شماآید. با تشکر از لطف و همراهی شما ...
                    </p>
                    <ul class=""rtl"">
                        <li><i class=""fa fa-check-circle-o"" aria");
            WriteLiteral(@"-hidden=""true""></i> لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است.</li>
                        <li><i class=""fa fa-check-circle-o"" aria-hidden=""true""></i> چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است.</li>
                        <li><i class=""fa fa-check-circle-o"" aria-hidden=""true""></i> شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیستری را برای طراحان رایانه ای و فرهنگ پیشرو در زبان فارسی ایجاد کرد.</li>
                        <li><i class=""fa fa-check-circle-o"" aria-hidden=""true""></i> کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده میباشد.</li>
                    </ul>
                    <p>

                        لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال ");
            WriteLiteral(@"و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیستری را برای طراحان رایانه ای و فرهنگ پیشرو در زبان فارسی ایجاد کرد.

                    </p>
                </div>
                <div class=""col-12 col-lg-4"">
                    <img class=""mb-15"" src=""img/bg-img/51.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4808, "\"", 4814, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
            </div>

            <p>
                لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیستری را برای طراحان رایانه ای و فرهنگ پیشرو در زبان فارسی ایجاد کرد.

            </p>

            <blockquote class=""rtl"">
                <h6 class=""quote-text"">“لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. ”</h6>
                <h6 class=""quote-name"">نام و فامیل</h6>
            </blockquote>

            <p>
                لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنو");
            WriteLiteral(@"لوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیستری را برای طراحان رایانه ای و فرهنگ پیشرو در زبان فارسی ایجاد کرد.

            </p>


        </div>
    </div>

    <!-- Related Post Area -->
    <div class=""related-post-area bg-white mb-30 px-30 pt-30 box-shadow"">
        <!-- Section Title -->
        <div class=""section-heading"">
            <h5>محتوی مشابه</h5>
        </div>

        <div class=""row"">
            <!-- Single Blog Post -->
            <div class=""col-12 col-md-6 col-lg-4"">
                <div class=""single-blog-post style-4 mb-30"">
                    <div class=""post-thumbnail"">
                        <img src=""img/bg-img/29.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6663, "\"", 6669, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"post-content\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 6775, "\"", 6820, 2);
#nullable restore
#line 117 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\dadras\singlevideo.cshtml"
WriteAttributeValue("", 6782, ViewData["externalHomeUrl"], 6782, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6810, "singlepost", 6810, 10, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""post-title"">این یک عنوان آزمایشی است</a>
                        <div class=""post-meta d-flex"">
                            <a href=""#""><i class=""fa fa-eye"" aria-hidden=""true""></i> 1034</a>
                            <a href=""#""><i class=""fa fa-thumbs-o-up"" aria-hidden=""true""></i> 834</a>
                            <a href=""#""><i class=""fa fa-comments-o"" aria-hidden=""true""></i> 234</a>
                        </div>
                    </div>
                </div>
            </div>

            <!-- Single Blog Post -->
            <div class=""col-12 col-md-6 col-lg-4"">
                <div class=""single-blog-post style-4 mb-30"">
                    <div class=""post-thumbnail"">
                        <img src=""img/bg-img/30.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7586, "\"", 7592, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 7622, "\"", 7668, 2);
#nullable restore
#line 132 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\dadras\singlevideo.cshtml"
WriteAttributeValue("", 7629, ViewData["externalHomeUrl"], 7629, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7657, "singlevideo", 7657, 11, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"video-play\"><i class=\"fa fa-play\"></i></a>\r\n                        <span class=\"video-duration\">09:27</span>\r\n                    </div>\r\n                    <div class=\"post-content\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 7890, "\"", 7935, 2);
#nullable restore
#line 136 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\dadras\singlevideo.cshtml"
WriteAttributeValue("", 7897, ViewData["externalHomeUrl"], 7897, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7925, "singlepost", 7925, 10, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""post-title"">این یک عنوان آزمایشی است</a>
                        <div class=""post-meta d-flex"">
                            <a href=""#""><i class=""fa fa-eye"" aria-hidden=""true""></i> 1034</a>
                            <a href=""#""><i class=""fa fa-thumbs-o-up"" aria-hidden=""true""></i> 834</a>
                            <a href=""#""><i class=""fa fa-comments-o"" aria-hidden=""true""></i> 234</a>
                        </div>
                    </div>
                </div>
            </div>

            <!-- Single Blog Post -->
            <div class=""col-12 col-md-6 col-lg-4"">
                <div class=""single-blog-post style-4 mb-30"">
                    <div class=""post-thumbnail"">
                        <img src=""img/bg-img/28.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8701, "\"", 8707, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"post-content\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 8813, "\"", 8858, 2);
#nullable restore
#line 153 "C:\Users\YAR Soft\source\repos\PTemplate\PTemplate\Views\dadras\singlevideo.cshtml"
WriteAttributeValue("", 8820, ViewData["externalHomeUrl"], 8820, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8848, "singlepost", 8848, 10, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""post-title"">این یک عنوان آزمایشی است</a>
                        <div class=""post-meta d-flex"">
                            <a href=""#""><i class=""fa fa-eye"" aria-hidden=""true""></i> 1034</a>
                            <a href=""#""><i class=""fa fa-thumbs-o-up"" aria-hidden=""true""></i> 834</a>
                            <a href=""#""><i class=""fa fa-comments-o"" aria-hidden=""true""></i> 234</a>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>

    <!-- Comment Area Start -->
    <div class=""comment_area clearfix bg-white mb-30 p-30 box-shadow"">
        <!-- Section Title -->
        <div class=""section-heading"">
            <h5>نظرات</h5>
        </div>

        <ol>
            <!-- Single Comment Area -->
            <li class=""single_comment_area rtl"">
                <!-- Comment Content -->
                <div class=""comment-content d-flex"">
                    <!-- Comment Author -->
               ");
            WriteLiteral(@"     <div class=""comment-author"">
                        <img src=""img/bg-img/53.jpg"" alt=""author"">
                    </div>
                    <!-- Comment Meta -->
                    <div class=""comment-meta"">
                        <a href=""#"" class=""comment-date"">18/9/1398</a>
                        <h6>مهسا مهرافشان</h6>
                        <p>
                            لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد.
                        </p>
                        <div class=""d-flex align-items-center rtl"">
                            <a href=""#"" class=""reply"">پاسخ دادن</a>
                            <a href=""#"" class=""like"">خوشم اومد</a>
                        </div>
                    </div>
                </div>

                <ol class=""children"">
         ");
            WriteLiteral(@"           <li class=""single_comment_area rtl"">
                        <!-- Comment Content -->
                        <div class=""comment-content d-flex"">
                            <!-- Comment Author -->
                            <div class=""comment-author"">
                                <img src=""img/bg-img/54.jpg"" alt=""author"">
                            </div>
                            <!-- Comment Meta -->
                            <div class=""comment-meta"">
                                <a href=""#"" class=""comment-date"">18/9/1398</a>
                                <h6>امیر ارسلان نامدار</h6>
                                <p>
                                    لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد.
                                </p>
                          ");
            WriteLiteral(@"      <div class=""d-flex align-items-center rtl"">
                                    <a href=""#"" class=""reply"">پاسخ دادن</a>
                                    <a href=""#"" class=""like"">خوشم اومد</a>
                                </div>
                            </div>
                        </div>
                    </li>
                </ol>
            </li>

            <!-- Single Comment Area -->
            <li class=""single_comment_area rtl"">
                <!-- Comment Content -->
                <div class=""comment-content d-flex"">
                    <!-- Comment Author -->
                    <div class=""comment-author"">
                        <img src=""img/bg-img/55.jpg"" alt=""author"">
                    </div>
                    <!-- Comment Meta -->
                    <div class=""comment-meta"">
                        <a href=""#"" class=""comment-date"">18/9/1398</a>
                        <h6>دانیال حکیمی</h6>
                        <p>
                       ");
            WriteLiteral(@"     لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد.
                        </p>
                        <div class=""d-flex align-items-center rtl"">
                            <a href=""#"" class=""reply"">پاسخ دادن</a>
                            <a href=""#"" class=""like"">خوشم اومد</a>
                        </div>
                    </div>
                </div>
            </li>
        </ol>
    </div>

    <!-- Post A Comment Area -->
    <div class=""post-a-comment-area bg-white mb-30 p-30 box-shadow clearfix"">
        <!-- Section Title -->
        <div class=""section-heading"">
            <h5>ارسال نظر</h5>
        </div>

        <!-- Reply Form -->
        <div class=""contact-form-area"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a938292cc2f1fab7fae1e399382d182f8e1c5bd020965", async() => {
                WriteLiteral(@"
                <div class=""row"">
                    <div class=""col-12 col-lg-6"">
                        <input type=""text"" class=""form-control"" id=""name"" placeholder=""نام شما*"" required>
                    </div>
                    <div class=""col-12 col-lg-6"">
                        <input type=""email"" class=""form-control"" id=""email"" placeholder=""ایمیل*"" required>
                    </div>
                    <div class=""col-12"">
                        <textarea name=""message"" class=""form-control"" id=""message"" cols=""30"" rows=""10"" placeholder=""متن پیغام*"" required></textarea>
                    </div>
                    <div class=""col-12"">
                        <button class=""btn mag-btn mt-30"" type=""submit"">ارسال نظر</button>
                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

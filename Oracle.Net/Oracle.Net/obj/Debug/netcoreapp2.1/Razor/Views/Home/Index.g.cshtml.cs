#pragma checksum "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9998805fc8d947cdaf4cfeea285fef9a7ef9b76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\_ViewImports.cshtml"
using Oracle.Net;

#line default
#line hidden
#line 2 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\_ViewImports.cshtml"
using Oracle.Net.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9998805fc8d947cdaf4cfeea285fef9a7ef9b76", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc752d9315d7ca55328b89a9ad65e59d586dbd3d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Oracle.Net.ViewModels.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "News", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/home/teaching"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/scene.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Testdetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/download.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Download1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "首页";
    Layout = "~/Views/Shared/_LayoutHome.cshtml";

#line default
#line hidden
            BeginContext(136, 451, true);
            WriteLiteral(@"<!--营销banner及新闻动态========================================-->
<div class=""banner-box"">
    <div class=""container focus-min"">
        <div>

        </div>
        <div>
            <div class=""xinshiye-news"">
                <div class=""news-box"">
                    <div class=""news-type"">
                        <div><h2 style=""margin-right:150px"">教学动态</h2></div>
                    </div>
                    <div class=""news-list"">
");
            EndContext();
#line 20 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Index.cshtml"
                         foreach (var item in Model.News)
                        {

#line default
#line hidden
            BeginContext(673, 31, true);
            WriteLiteral("                            <p>");
            EndContext();
            BeginContext(704, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "688a2d6ff56947e6be570f19d3623118", async() => {
                BeginContext(750, 10, false);
#line 22 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Index.cshtml"
                                                                       Write(item.Title);

#line default
#line hidden
                EndContext();
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
#line 22 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Index.cshtml"
                                                      WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(764, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 23 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(797, 200, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!--核心内容展示区-->\r\n<!--首页主体功能区=====================================-->\r\n<div class=\"mainbox\">\r\n");
            EndContext();
            BeginContext(1679, 130, true);
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"course-type\">\r\n            <div>\r\n                <h1>教学场景</h1>\r\n                ");
            EndContext();
            BeginContext(1809, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e864734bb5545c0aa6d211a3ef45387", async() => {
                BeginContext(1835, 4, true);
                WriteLiteral("查看全部");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1843, 198, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"course-card-zhibo\">\r\n                <div class=\"course-card course-card-4\">\r\n                    <div>\r\n                        <a href=\"/home/scene1\">");
            EndContext();
            BeginContext(2041, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "62cfbc0f8e8e41d6a946bdb5622ec1fe", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2075, 421, true);
            WriteLiteral(@"</a>
                    </div>
                    <div class=""course-title"">
                        <h2>场景一</h2>
                        <span>Oracle 11g的安装。</span>
                        <!-- <span><a href="""">播放</a></span> -->
                    </div>
                </div>
                <div class=""course-card course-card-4"">
                    <div>
                        <a href=""/home/scene1"">");
            EndContext();
            BeginContext(2496, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "03149b21777040a98efca4029b132496", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2530, 358, true);
            WriteLiteral(@"</a>
                    </div>
                    <div class=""course-title"">
                        <h2>场景二</h2>
                        <span>启动Oracle 11g数据库。</span>
                    </div>
                </div>
                <div class=""course-card course-card-4"">
                    <div>
                        <a href=""/home/scene1"">");
            EndContext();
            BeginContext(2888, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4efd92ddf5ac4c6ea3e68589d08f7a0e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2922, 362, true);
            WriteLiteral(@"</a>
                    </div>
                    <div class=""course-title"">
                        <h2>场景三</h2>
                        <span>深入了解Oracle 11g的体系结构。</span>
                    </div>
                </div>
                <div class=""course-card course-card-4"">
                    <div>
                        <a href=""/home/scene1"">");
            EndContext();
            BeginContext(3284, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e3d7536cccb54c4c9deabbf6bda1151c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3318, 481, true);
            WriteLiteral(@"</a>
                    </div>
                    <div class=""course-title"">
                        <h2>场景四</h2>
                        <span>Oracle 11g的PL/SQL引擎和SQL引擎。</span>
                    </div>
                </div>
            </div>

        </div>


        <div class=""course-type"">
            <div>
                <h1>在线测评</h1>
                <a href=""/home/scenetest"">查看全部</a>
            </div>
            <div class=""course-card-zhibo"">
");
            EndContext();
#line 106 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Index.cshtml"
                 foreach (var item in Model.Testlist)
                {

#line default
#line hidden
            BeginContext(3873, 71, true);
            WriteLiteral("                    <div class=\"course-card\">\r\n                        ");
            EndContext();
            BeginContext(3944, 213, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5426eb9dff94c4caace16856fc3374a", async() => {
                BeginContext(3995, 66, true);
                WriteLiteral("\r\n                            <h1><span class=\"xsy-blue\">★</span> ");
                EndContext();
                BeginContext(4062, 13, false);
#line 110 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Index.cshtml"
                                                           Write(item.Testname);

#line default
#line hidden
                EndContext();
                BeginContext(4075, 38, true);
                WriteLiteral("</h1>\r\n                            <p>");
                EndContext();
                BeginContext(4114, 9, false);
#line 111 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Index.cshtml"
                          Write(item.Info);

#line default
#line hidden
                EndContext();
                BeginContext(4123, 30, true);
                WriteLiteral("</p>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 109 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Index.cshtml"
                                                     WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(4157, 30, true);
            WriteLiteral("\r\n                    </div>\r\n");
            EndContext();
#line 114 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(4206, 239, true);
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n        <div class=\"course-type\">\r\n            <div>\r\n                <h1>下载内容</h1>\r\n                <a href=\"/home/download\">查看全部</a>\r\n            </div>\r\n            <div class=\"course-card-weike\">\r\n");
            EndContext();
#line 124 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Index.cshtml"
                 foreach (var item in Model.Upload)
                {

#line default
#line hidden
            BeginContext(4517, 120, true);
            WriteLiteral("                    <div class=\"course-card course-card-4\">\r\n                        <div>\r\n                            ");
            EndContext();
            BeginContext(4637, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf0389955bee4997b8d2023cc3017e9d", async() => {
                BeginContext(4687, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6ccbf1a10698447cba9d8b9956efba00", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 128 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Index.cshtml"
                                                        WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(4728, 118, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"course-title\">\r\n                            <h2>");
            EndContext();
            BeginContext(4847, 9, false);
#line 131 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4856, 136, true);
            WriteLiteral("</h2>\r\n\r\n                        </div>\r\n                        <div class=\"course-price-info\">\r\n                            <div>文件大小：");
            EndContext();
            BeginContext(4993, 9, false);
#line 135 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Index.cshtml"
                                 Write(item.Size);

#line default
#line hidden
            EndContext();
            BeginContext(5002, 82, true);
            WriteLiteral("</div>\r\n            \r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 139 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(5103, 69, true);
            WriteLiteral("           \r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Oracle.Net.ViewModels.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Allscore.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f8f032b133f68326f2355096396a92ebb1b7559"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Allscore), @"mvc.1.0.view", @"/Views/Home/Allscore.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Allscore.cshtml", typeof(AspNetCore.Views_Home_Allscore))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f8f032b133f68326f2355096396a92ebb1b7559", @"/Views/Home/Allscore.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc752d9315d7ca55328b89a9ad65e59d586dbd3d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Allscore : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Oracle.Net.Models.Score>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/home/manage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:right;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Allscore.cshtml"
  
    ViewData["Title"] = "AllScore";

#line default
#line hidden
            BeginContext(89, 66, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"news-detail\">\r\n        ");
            EndContext();
            BeginContext(155, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "893f2dba944e450d83927eca3be37c5a", async() => {
                BeginContext(200, 2, true);
                WriteLiteral("返回");
                EndContext();
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
            EndContext();
            BeginContext(206, 786, true);
            WriteLiteral(@"
        <h1><strong>学生成绩</strong></h1>
        <div>
            <table class=""table"">
                <thead>
                    <tr>
                        <th>
                            学期号
                        </th>
                        <th>
                            场景序号
                        </th>
                        <th>
                            测试名称
                        </th>
                        <th>
                            学生
                        </th>
                        <th>
                            分数
                        </th>
                        <th>
                            测试时间
                        </th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 35 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Allscore.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1065, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1162, 9, false);
#line 39 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Allscore.cshtml"
                           Write(item.Term);

#line default
#line hidden
            EndContext();
            BeginContext(1171, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1275, 10, false);
#line 42 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Allscore.cshtml"
                           Write(item.Scene);

#line default
#line hidden
            EndContext();
            BeginContext(1285, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1389, 13, false);
#line 45 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Allscore.cshtml"
                           Write(item.Testname);

#line default
#line hidden
            EndContext();
            BeginContext(1402, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1506, 11, false);
#line 48 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Allscore.cshtml"
                           Write(item.UserId);

#line default
#line hidden
            EndContext();
            BeginContext(1517, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1621, 14, false);
#line 51 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Allscore.cshtml"
                           Write(item.Testscore);

#line default
#line hidden
            EndContext();
            BeginContext(1635, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1739, 13, false);
#line 54 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Allscore.cshtml"
                           Write(item.Testtime);

#line default
#line hidden
            EndContext();
            BeginContext(1752, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 57 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Allscore.cshtml"
                    }

#line default
#line hidden
            BeginContext(1843, 84, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Oracle.Net.Models.Score>> Html { get; private set; }
    }
}
#pragma warning restore 1591

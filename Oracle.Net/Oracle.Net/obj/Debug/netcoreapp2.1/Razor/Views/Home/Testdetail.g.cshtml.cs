#pragma checksum "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Testdetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc41a60f2ca03b54d4f4abf468d28183e2a482cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Testdetail), @"mvc.1.0.view", @"/Views/Home/Testdetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Testdetail.cshtml", typeof(AspNetCore.Views_Home_Testdetail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc41a60f2ca03b54d4f4abf468d28183e2a482cc", @"/Views/Home/Testdetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc752d9315d7ca55328b89a9ad65e59d586dbd3d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Testdetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Oracle.Net.Models.Test>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/main.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-1.6.2.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.reveal.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/reveal.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Testdetail.cshtml"
  
    ViewData["Title"] = "Testdetail";

#line default
#line hidden
            BeginContext(90, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(92, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cf444a5455e34285889f9adf6a811be6", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(153, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(155, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1fe1ee0a5794f1abb2939b3f5332979", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(199, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(201, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bf1c7b2e9274a57aec09cb2e4ca6a7f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(269, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(271, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b9f37107623a488f867cca173bd8b5cb", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(318, 138, true);
            WriteLiteral("\r\n\r\n<!--视频详细介绍========================================-->\r\n<div class=\"mainbox\">\r\n    <div class=\"container\">\r\n        <!-- 测试卡片单元开始 -->\r\n");
            EndContext();
#line 15 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Testdetail.cshtml"
          
            var n = 0;
        

#line default
#line hidden
            BeginContext(503, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 18 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Testdetail.cshtml"
         if (Model != null)
        {
            foreach (var item in Model)
            {
                n++;

#line default
#line hidden
            BeginContext(621, 100, true);
            WriteLiteral("                <div class=\"question-card\">\r\n                    <div>\r\n                        <h2>");
            EndContext();
            BeginContext(722, 7, false);
#line 25 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Testdetail.cshtml"
                       Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(729, 1, true);
            WriteLiteral("、");
            EndContext();
            BeginContext(731, 13, false);
#line 25 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Testdetail.cshtml"
                                Write(item.Question);

#line default
#line hidden
            EndContext();
            BeginContext(744, 34, true);
            WriteLiteral("</h2>\r\n                        <p>");
            EndContext();
            BeginContext(779, 9, false);
#line 26 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Testdetail.cshtml"
                      Write(item.Info);

#line default
#line hidden
            EndContext();
            BeginContext(788, 104, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div>\r\n                        <input type=\"radio\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 892, "\"", 907, 2);
            WriteAttributeValue("", 899, "radio_", 899, 6, true);
#line 29 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Testdetail.cshtml"
WriteAttributeValue("", 905, n, 905, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(908, 15, true);
            WriteLiteral(" value=\"A\">  A：");
            EndContext();
            BeginContext(924, 8, false);
#line 29 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Testdetail.cshtml"
                                                                     Write(item.Op1);

#line default
#line hidden
            EndContext();
            BeginContext(932, 77, true);
            WriteLiteral("\r\n                        <br />\r\n                        <input type=\"radio\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 1009, "\"", 1024, 2);
            WriteAttributeValue("", 1016, "radio_", 1016, 6, true);
#line 31 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Testdetail.cshtml"
WriteAttributeValue("", 1022, n, 1022, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1025, 15, true);
            WriteLiteral(" value=\"B\">  B：");
            EndContext();
            BeginContext(1041, 8, false);
#line 31 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Testdetail.cshtml"
                                                                     Write(item.Op2);

#line default
#line hidden
            EndContext();
            BeginContext(1049, 77, true);
            WriteLiteral("\r\n                        <br />\r\n                        <input type=\"radio\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 1126, "\"", 1141, 2);
            WriteAttributeValue("", 1133, "radio_", 1133, 6, true);
#line 33 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Testdetail.cshtml"
WriteAttributeValue("", 1139, n, 1139, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1142, 15, true);
            WriteLiteral(" value=\"C\">  C：");
            EndContext();
            BeginContext(1158, 8, false);
#line 33 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Testdetail.cshtml"
                                                                     Write(item.Op3);

#line default
#line hidden
            EndContext();
            BeginContext(1166, 77, true);
            WriteLiteral("\r\n                        <br />\r\n                        <input type=\"radio\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 1243, "\"", 1258, 2);
            WriteAttributeValue("", 1250, "radio_", 1250, 6, true);
#line 35 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Testdetail.cshtml"
WriteAttributeValue("", 1256, n, 1256, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1259, 15, true);
            WriteLiteral(" value=\"D\">  D：");
            EndContext();
            BeginContext(1275, 8, false);
#line 35 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Testdetail.cshtml"
                                                                     Write(item.Op4);

#line default
#line hidden
            EndContext();
            BeginContext(1283, 54, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 38 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Testdetail.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(1363, 45, true);
            WriteLiteral("        <div>\r\n            共 <span id=\"test\">");
            EndContext();
            BeginContext(1409, 11, false);
#line 41 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Testdetail.cshtml"
                         Write(ViewBag.Sum);

#line default
#line hidden
            EndContext();
            BeginContext(1420, 62, true);
            WriteLiteral("</span> 题\r\n            <input type=\"hidden\" id=\"txtAnswerList\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1482, "\"", 1503, 1);
#line 42 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Testdetail.cshtml"
WriteAttributeValue("", 1490, ViewBag.Answ, 1490, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1504, 55, true);
            WriteLiteral(" />\r\n            <input type=\"hidden\" id=\"txtScoreList\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1559, "\"", 1580, 1);
#line 43 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Testdetail.cshtml"
WriteAttributeValue("", 1567, ViewBag.Mark, 1567, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1581, 976, true);
            WriteLiteral(@" />
        </div>

        <!-- 分割线 -->
        <!-- 测试卡片单元结束 -->
        <div class=""post-test"">
            <a href=""#"" data-reveal-id=""post-answer""> <input type=""button"" onclick=""showResult()"" value=""提交试卷""></a>
        </div>

        <!--测试结果开始=================-->
        <div id=""post-answer"" class=""reveal-modal"" style=""height: 500px;"">
            <div style=""position: relative;"">
                <h2>您的测评结果为</h2>
                <h1 class=""score-color""><strong id=""show_result4""></strong> 分</h1>
                <p id=""show_result1""></p>
                <p id=""show_result2""></p>
                <p id=""show_result3""></p>
                <p id=""show_result4""></p>
                <a href=""""><div class=""close"">×</div></a>
            </div>
        </div>
        <!--测试结果结束=================-->
    </div>
</div>


<script type=""text/javascript"">

    function getjson() {
        var radio = new Array();
        for (var i = 1; i <= ");
            EndContext();
            BeginContext(2558, 11, false);
#line 73 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Testdetail.cshtml"
                        Write(ViewBag.Sum);

#line default
#line hidden
            EndContext();
            BeginContext(2569, 732, true);
            WriteLiteral(@"; i++) {//获取radio的值
            var radio_name = new String(""radio_"" + i);
            radio[i - 1] = $('input:radio[name=' + radio_name + ']:checked').val()
        }
        return radio;
    }
    function my_confirm() {
        var radio = getjson();
        var msg = ""您真的答案是："" + radio+ "",是否确认提交"";
        if (confirm(msg) == true) {
            return radio;
        } else {
            return false;
        }
    }

    function saveTestScore(re) {
        //Ajax调用处理
        var result = re;
        var time = CurentTime();
        var html = $.ajax({
            type: ""POST"",
            url: ""/home/SaveScore"",
            data: {
                ""Testscore"":result,
                ""Testid"": ");
            EndContext();
            BeginContext(3302, 14, false);
#line 98 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Testdetail.cshtml"
                     Write(ViewBag.Testid);

#line default
#line hidden
            EndContext();
            BeginContext(3316, 1016, true);
            WriteLiteral(@",
                ""Testtime"": time,
            }
        });
    }

    function CurentTime() {
        var now = new Date();
        var year = now.getFullYear();       //年
        var month = now.getMonth() + 1;     //月
        var day = now.getDate();            //日
        var hh = now.getHours();            //时
        var mm = now.getMinutes();          //分
        var clock = year + ""-"";
        if (month < 10)
            clock += ""0"";
        clock += month + ""-"";
        if (day < 10)
            clock += ""0"";
        clock += day + "" "";
        if (hh < 10)
            clock += ""0"";
        clock += hh + "":"";
        if (mm < 10) clock += '0';
        clock += mm;
        return (clock);
    }

    function showResult() {

        var s1 = $(""#txtAnswerList"").val();
        var s2 = $(""#txtScoreList"").val();

        var answer = s1.split(';');
        var answer_score = s2.split(';');
        var user_answer = getjson();//获取用户答案
        var radio_num = ");
            EndContext();
            BeginContext(4333, 11, false);
#line 134 "C:\Users\DELL\Desktop\Oracle数据库学习平台\Oracle.Net\Oracle.Net\Views\Home\Testdetail.cshtml"
                   Write(ViewBag.Sum);

#line default
#line hidden
            EndContext();
            BeginContext(4344, 1321, true);
            WriteLiteral(@";//获取单选个数
        var radio_result = 0;//单选分数
        var radio_right_num = 0;//单选答对个数
        var result = 0;//总分数
        var user_answer_result = new Array();//用户没到题的答题情况


        for (var i = 0; i < user_answer.length; i++) {
            if (user_answer[i] == answer[i]) {
                radio_result = radio_result + parseInt(answer_score[i]);
                radio_right_num++;
                user_answer_result[i] = ""正确"";
            } else {
                user_answer_result[i] = ""错误"";
            }
        }
        result =  radio_result;
        //结果展示
        var show_result1;
        var show_result2;
        var show_result3;
        var show_result4;

        show_result1 = ""你的答案结果为："";
        for (var i = 0; i < user_answer.length; i++) {
            show_result1 = show_result1 + (i + 1) + ""："" + user_answer_result[i] + ""；&nbsp;"";
        }
        show_result2 = ""总题目个数："" + user_answer.length;
        show_result3 = ""答对题目个数："" + radio_right_num + ""；&nbsp;得分："" + radio_");
            WriteLiteral(@"result;
        show_result4 =  result;
        $(""p#show_result1"").html(show_result1);
        $(""p#show_result2"").html(show_result2);
        $(""p#show_result3"").html(show_result3);
        $(""strong#show_result4"").html(show_result4);

        saveTestScore(result);
    }
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Oracle.Net.Models.Test>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\4 курс\БД\MusicalGroup\MusicalGroup\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "562c1d40732bba9ba684d7d1a1f8fe91982e5ce7"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"562c1d40732bba9ba684d7d1a1f8fe91982e5ce7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/activeLike.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin: 0 10%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 281, true);
            WriteLiteral(@"<table id=""dataTable"" class=""table table-bordered"" style=""text-align:center;"">
    <thead>
        <tr>
            <th>Название</th>
            <th>Исполнитель</th>
            <th>Композиция</th>
            <th>Голосование</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 11 "C:\4 курс\БД\MusicalGroup\MusicalGroup\Views\Home\Index.cshtml"
          
            foreach (var sv in Model.AllSongsWithVoices)
            {

#line default
#line hidden
            BeginContext(366, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(413, 12, false);
#line 15 "C:\4 курс\БД\MusicalGroup\MusicalGroup\Views\Home\Index.cshtml"
                   Write(sv.Song.Name);

#line default
#line hidden
            EndContext();
            BeginContext(425, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(457, 29, false);
#line 16 "C:\4 курс\БД\MusicalGroup\MusicalGroup\Views\Home\Index.cshtml"
                   Write(sv.Song.Repertoire.Group.Name);

#line default
#line hidden
            EndContext();
            BeginContext(486, 130, true);
            WriteLiteral("</td>\r\n                    <td style=\"width: 55%;\">\r\n                        <audio controls>\r\n                            <source");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 616, "\"", 653, 1);
#line 19 "C:\4 курс\БД\MusicalGroup\MusicalGroup\Views\Home\Index.cshtml"
WriteAttributeValue("", 622, Url.Content(@sv.Song.FilePath), 622, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(654, 133, true);
            WriteLiteral(" type=\"audio/ogg\">\r\n                        </audio>\r\n                    </td>\r\n                    <td>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 787, "\"", 854, 1);
#line 23 "C:\4 курс\БД\MusicalGroup\MusicalGroup\Views\Home\Index.cshtml"
WriteAttributeValue("", 794, Url.Action("Voiting", "Home", new { _songId = sv.Song.Id }), 794, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(855, 31, true);
            WriteLiteral(">\r\n                            ");
            EndContext();
            BeginContext(886, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "562c1d40732bba9ba684d7d1a1f8fe91982e5ce76379", async() => {
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
            BeginContext(955, 106, true);
            WriteLiteral("\r\n                        </a>\r\n                        <span style=\"color: dimgray; font-size:large;\"><b>");
            EndContext();
            BeginContext(1062, 14, false);
#line 26 "C:\4 курс\БД\MusicalGroup\MusicalGroup\Views\Home\Index.cshtml"
                                                                     Write(sv.CountVoices);

#line default
#line hidden
            EndContext();
            BeginContext(1076, 63, true);
            WriteLiteral("</b></span>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 29 "C:\4 курс\БД\MusicalGroup\MusicalGroup\Views\Home\Index.cshtml"
            }
        

#line default
#line hidden
            BeginContext(1165, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

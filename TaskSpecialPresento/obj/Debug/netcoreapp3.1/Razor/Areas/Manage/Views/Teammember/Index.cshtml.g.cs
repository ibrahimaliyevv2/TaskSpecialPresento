#pragma checksum "C:\Users\ibrahimaliyevv\Desktop\TaskSpecialPresento\TaskSpecialPresento\Areas\Manage\Views\Teammember\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ea164cc9760a2e15c0f25ea53e5dd5288f389f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Teammember_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Teammember/Index.cshtml")]
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
#line 1 "C:\Users\ibrahimaliyevv\Desktop\TaskSpecialPresento\TaskSpecialPresento\Areas\Manage\Views\_ViewImports.cshtml"
using TaskSpecialPresento;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ibrahimaliyevv\Desktop\TaskSpecialPresento\TaskSpecialPresento\Areas\Manage\Views\_ViewImports.cshtml"
using TaskSpecialPresento.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ea164cc9760a2e15c0f25ea53e5dd5288f389f5", @"/Areas/Manage/Views/Teammember/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a0de439d8836366f858e8c79aab974706f5ff52", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Teammember_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Teammember>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\ibrahimaliyevv\Desktop\TaskSpecialPresento\TaskSpecialPresento\Areas\Manage\Views\Teammember\Index.cshtml"
   
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-12"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th scope=""col"">#</th>
                        <th scope=""col"">No:</th>
                        <th scope=""col"">FullName</th>
                        <th scope=""col"">Position</th>
                        <th scope=""col"">Twitter Username</th>
                        <th scope=""col"">Instagram Username</th>
                        <th scope=""col"">Facebook Username</th>
                        <th scope=""col"">LinkedIn Username</th>
                        <th scope=""col"">Image</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 24 "C:\Users\ibrahimaliyevv\Desktop\TaskSpecialPresento\TaskSpecialPresento\Areas\Manage\Views\Teammember\Index.cshtml"
                     foreach (Teammember tm in Model)
                    {
                        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">1</th>\r\n                        <td>");
#nullable restore
#line 29 "C:\Users\ibrahimaliyevv\Desktop\TaskSpecialPresento\TaskSpecialPresento\Areas\Manage\Views\Teammember\Index.cshtml"
                       Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "C:\Users\ibrahimaliyevv\Desktop\TaskSpecialPresento\TaskSpecialPresento\Areas\Manage\Views\Teammember\Index.cshtml"
                       Write(tm.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\ibrahimaliyevv\Desktop\TaskSpecialPresento\TaskSpecialPresento\Areas\Manage\Views\Teammember\Index.cshtml"
                       Write(tm.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "C:\Users\ibrahimaliyevv\Desktop\TaskSpecialPresento\TaskSpecialPresento\Areas\Manage\Views\Teammember\Index.cshtml"
                       Write(tm.TwitterUsername);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 33 "C:\Users\ibrahimaliyevv\Desktop\TaskSpecialPresento\TaskSpecialPresento\Areas\Manage\Views\Teammember\Index.cshtml"
                       Write(tm.InstagramUsername);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "C:\Users\ibrahimaliyevv\Desktop\TaskSpecialPresento\TaskSpecialPresento\Areas\Manage\Views\Teammember\Index.cshtml"
                       Write(tm.FacebookUsername);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 35 "C:\Users\ibrahimaliyevv\Desktop\TaskSpecialPresento\TaskSpecialPresento\Areas\Manage\Views\Teammember\Index.cshtml"
                       Write(tm.LinkedinUsername);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3ea164cc9760a2e15c0f25ea53e5dd5288f389f57321", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1425, "~/main/assets/img/", 1425, 18, true);
#nullable restore
#line 37 "C:\Users\ibrahimaliyevv\Desktop\TaskSpecialPresento\TaskSpecialPresento\Areas\Manage\Views\Teammember\Index.cshtml"
AddHtmlAttributeValue("", 1443, tm.ImageName, 1443, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 40 "C:\Users\ibrahimaliyevv\Desktop\TaskSpecialPresento\TaskSpecialPresento\Areas\Manage\Views\Teammember\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Teammember>> Html { get; private set; }
    }
}
#pragma warning restore 1591
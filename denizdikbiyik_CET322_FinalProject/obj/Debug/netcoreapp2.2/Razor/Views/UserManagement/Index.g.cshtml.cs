#pragma checksum "C:\Users\Deniz\Desktop\denizdikbiyik_CET322_FinalProject\denizdikbiyik_CET322_FinalProject\Views\UserManagement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a77d09a1d9dc7ea385d7d708a057ef56d8f68a88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserManagement_Index), @"mvc.1.0.view", @"/Views/UserManagement/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserManagement/Index.cshtml", typeof(AspNetCore.Views_UserManagement_Index))]
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
#line 1 "C:\Users\Deniz\Desktop\denizdikbiyik_CET322_FinalProject\denizdikbiyik_CET322_FinalProject\Views\_ViewImports.cshtml"
using denizdikbiyik_CET322_FinalProject;

#line default
#line hidden
#line 2 "C:\Users\Deniz\Desktop\denizdikbiyik_CET322_FinalProject\denizdikbiyik_CET322_FinalProject\Views\_ViewImports.cshtml"
using denizdikbiyik_CET322_FinalProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a77d09a1d9dc7ea385d7d708a057ef56d8f68a88", @"/Views/UserManagement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84c57402f21a35670cd91e8ad59cb8fb89c7a97d", @"/Views/_ViewImports.cshtml")]
    public class Views_UserManagement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<denizdikbiyik_CET322_FinalProject.ViewModels.UserModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MakeAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Deniz\Desktop\denizdikbiyik_CET322_FinalProject\denizdikbiyik_CET322_FinalProject\Views\UserManagement\Index.cshtml"
  
    ViewData["Title"] = "Kullanıcı Yönetimi";
    Layout = "_AdminLayout";

#line default
#line hidden
            BeginContext(160, 840, true);
            WriteLiteral(@"<link rel=""stylesheet"" href=""//cdnjs.cloudflare.com/ajax/libs/jodit/3.1.92/jodit.min.css"">
<script src=""//cdnjs.cloudflare.com/ajax/libs/jodit/3.1.92/jodit.min.js""></script>

<section class=""ab-info-main py-md-5"">
    <div class=""container py-md-3"">
        <br/>
        <h1>Kullanıcı Yönetimi</h1>
        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        Kullanıcı Adı
                    </th>
                    <th>
                        Ad Soyad
                    </th>
                    <th>
                        Admin Mi?
                    </th>
                    <th>
                        Admin Yap-Kaldır
                    </th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 32 "C:\Users\Deniz\Desktop\denizdikbiyik_CET322_FinalProject\denizdikbiyik_CET322_FinalProject\Views\UserManagement\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1065, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1150, 43, false);
#line 36 "C:\Users\Deniz\Desktop\denizdikbiyik_CET322_FinalProject\denizdikbiyik_CET322_FinalProject\Views\UserManagement\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1193, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1285, 47, false);
#line 39 "C:\Users\Deniz\Desktop\denizdikbiyik_CET322_FinalProject\denizdikbiyik_CET322_FinalProject\Views\UserManagement\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.UserFullName));

#line default
#line hidden
            EndContext();
            BeginContext(1332, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1424, 46, false);
#line 42 "C:\Users\Deniz\Desktop\denizdikbiyik_CET322_FinalProject\denizdikbiyik_CET322_FinalProject\Views\UserManagement\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.UserIsAdmin));

#line default
#line hidden
            EndContext();
            BeginContext(1470, 63, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");
            EndContext();
#line 45 "C:\Users\Deniz\Desktop\denizdikbiyik_CET322_FinalProject\denizdikbiyik_CET322_FinalProject\Views\UserManagement\Index.cshtml"
                             if (item.UserIsAdmin)
                            {

#line default
#line hidden
            BeginContext(1616, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1648, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a77d09a1d9dc7ea385d7d708a057ef56d8f68a888199", async() => {
                BeginContext(1727, 20, true);
                WriteLiteral("Yöneticilikten Çıkar");
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
#line 47 "C:\Users\Deniz\Desktop\denizdikbiyik_CET322_FinalProject\denizdikbiyik_CET322_FinalProject\Views\UserManagement\Index.cshtml"
                                                              WriteLiteral(item.UserId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1751, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 48 "C:\Users\Deniz\Desktop\denizdikbiyik_CET322_FinalProject\denizdikbiyik_CET322_FinalProject\Views\UserManagement\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(1849, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1881, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a77d09a1d9dc7ea385d7d708a057ef56d8f68a8811094", async() => {
                BeginContext(1959, 12, true);
                WriteLiteral("Yönetici Yap");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "C:\Users\Deniz\Desktop\denizdikbiyik_CET322_FinalProject\denizdikbiyik_CET322_FinalProject\Views\UserManagement\Index.cshtml"
                                                            WriteLiteral(item.UserId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1975, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 52 "C:\Users\Deniz\Desktop\denizdikbiyik_CET322_FinalProject\denizdikbiyik_CET322_FinalProject\Views\UserManagement\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2008, 58, true);
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 55 "C:\Users\Deniz\Desktop\denizdikbiyik_CET322_FinalProject\denizdikbiyik_CET322_FinalProject\Views\UserManagement\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2085, 64, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</section>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2167, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 61 "C:\Users\Deniz\Desktop\denizdikbiyik_CET322_FinalProject\denizdikbiyik_CET322_FinalProject\Views\UserManagement\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(2237, 31, true);
                WriteLiteral("    <script>\r\n\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<denizdikbiyik_CET322_FinalProject.ViewModels.UserModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

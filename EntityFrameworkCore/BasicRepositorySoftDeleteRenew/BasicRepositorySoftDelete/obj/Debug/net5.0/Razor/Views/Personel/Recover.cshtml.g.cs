#pragma checksum "C:\301Sabah\Mobile-for-Beginners\EntityFrameworkCore\BasicRepositorySoftDelete\BasicRepositorySoftDelete\Views\Personel\Recover.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03d07950663e5d92ce8b09bfd3ab870ac7375348"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personel_Recover), @"mvc.1.0.view", @"/Views/Personel/Recover.cshtml")]
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
#line 1 "C:\301Sabah\Mobile-for-Beginners\EntityFrameworkCore\BasicRepositorySoftDelete\BasicRepositorySoftDelete\Views\_ViewImports.cshtml"
using BasicRepositorySoftDelete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\301Sabah\Mobile-for-Beginners\EntityFrameworkCore\BasicRepositorySoftDelete\BasicRepositorySoftDelete\Views\_ViewImports.cshtml"
using BasicRepositorySoftDelete.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03d07950663e5d92ce8b09bfd3ab870ac7375348", @"/Views/Personel/Recover.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"060cf85fdb9f77d3d28e94c3414297abdac19fed", @"/Views/_ViewImports.cshtml")]
    public class Views_Personel_Recover : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BasicRepositorySoftDelete.Models.DTOs.PersonelDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\301Sabah\Mobile-for-Beginners\EntityFrameworkCore\BasicRepositorySoftDelete\BasicRepositorySoftDelete\Views\Personel\Recover.cshtml"
  
    ViewData["Title"] = "Recover";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-5"">
            <h2>Recover List</h2>
            <table class=""table table-bordered"">
                <thead>
                    <tr>
                        <th>
                            Personel Id
                        </th>
                        <th>
                            ");
#nullable restore
#line 19 "C:\301Sabah\Mobile-for-Beginners\EntityFrameworkCore\BasicRepositorySoftDelete\BasicRepositorySoftDelete\Views\Personel\Recover.cshtml"
                       Write(Html.DisplayNameFor(model => model.PersonelName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 22 "C:\301Sabah\Mobile-for-Beginners\EntityFrameworkCore\BasicRepositorySoftDelete\BasicRepositorySoftDelete\Views\Personel\Recover.cshtml"
                       Write(Html.DisplayNameFor(model => model.PersonelSurname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 25 "C:\301Sabah\Mobile-for-Beginners\EntityFrameworkCore\BasicRepositorySoftDelete\BasicRepositorySoftDelete\Views\Personel\Recover.cshtml"
                       Write(Html.DisplayNameFor(model => model.CityName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 30 "C:\301Sabah\Mobile-for-Beginners\EntityFrameworkCore\BasicRepositorySoftDelete\BasicRepositorySoftDelete\Views\Personel\Recover.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 34 "C:\301Sabah\Mobile-for-Beginners\EntityFrameworkCore\BasicRepositorySoftDelete\BasicRepositorySoftDelete\Views\Personel\Recover.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 37 "C:\301Sabah\Mobile-for-Beginners\EntityFrameworkCore\BasicRepositorySoftDelete\BasicRepositorySoftDelete\Views\Personel\Recover.cshtml"
                           Write(Html.DisplayFor(modelItem => item.PersonelName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 40 "C:\301Sabah\Mobile-for-Beginners\EntityFrameworkCore\BasicRepositorySoftDelete\BasicRepositorySoftDelete\Views\Personel\Recover.cshtml"
                           Write(Html.DisplayFor(modelItem => item.PersonelSurname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 43 "C:\301Sabah\Mobile-for-Beginners\EntityFrameworkCore\BasicRepositorySoftDelete\BasicRepositorySoftDelete\Views\Personel\Recover.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CityName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 46 "C:\301Sabah\Mobile-for-Beginners\EntityFrameworkCore\BasicRepositorySoftDelete\BasicRepositorySoftDelete\Views\Personel\Recover.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03d07950663e5d92ce8b09bfd3ab870ac73753488441", async() => {
                WriteLiteral("Back To List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BasicRepositorySoftDelete.Models.DTOs.PersonelDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
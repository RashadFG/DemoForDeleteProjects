#pragma checksum "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Areas\Admin\Views\Newss\DeleteNew.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1abbb6e64fe2574d5bd13ea0c64cc48a8f296af1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Newss_DeleteNew), @"mvc.1.0.view", @"/Areas/Admin/Views/Newss/DeleteNew.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Newss/DeleteNew.cshtml", typeof(AspNetCore.Areas_Admin_Views_Newss_DeleteNew))]
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
#line 1 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Areas\Admin\Views\_ViewImports.cshtml"
using Evimiz;

#line default
#line hidden
#line 2 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Areas\Admin\Views\_ViewImports.cshtml"
using Evimiz.Models;

#line default
#line hidden
#line 3 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Areas\Admin\Views\_ViewImports.cshtml"
using Evimiz.ViewModels;

#line default
#line hidden
#line 4 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1abbb6e64fe2574d5bd13ea0c64cc48a8f296af1", @"/Areas/Admin/Views/Newss/DeleteNew.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea22cad5cf3b07d32feab8ab4d2cdbe7b53f068a", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Newss_DeleteNew : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<News>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid w-100 "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Areas\Admin\Views\Newss\DeleteNew.cshtml"
  
    ViewData["Title"] = "DeleteNew";

#line default
#line hidden
            BeginContext(58, 360, true);
            WriteLiteral(@"
<!-- NewDetails start -->
<section id=""NewDetails"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <h3 class=""text-danger"">Bu elani silməyə əminsiniz?</h3>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-6 col-12"">
                <h3 class="" my-3"">");
            EndContext();
            BeginContext(419, 11, false);
#line 16 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Areas\Admin\Views\Newss\DeleteNew.cshtml"
                             Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(430, 182, true);
            WriteLiteral("</h3>\r\n            </div>\r\n            <div class=\"col-lg-6 col-12\">\r\n                <div class=\"text-right  my-3\">\r\n                    <span class=\"ml-2 New-Author all\">Muəllif : ");
            EndContext();
            BeginContext(613, 12, false);
#line 20 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Areas\Admin\Views\Newss\DeleteNew.cshtml"
                                                           Write(Model.Author);

#line default
#line hidden
            EndContext();
            BeginContext(625, 85, true);
            WriteLiteral(" </span>|<br class=\"d-lg-none\">\r\n                    <span class=\"ml-2 New-Date all\">");
            EndContext();
            BeginContext(711, 48, false);
#line 21 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Areas\Admin\Views\Newss\DeleteNew.cshtml"
                                               Write(String.Format("{0:M/d/yyyy}", Model.PublishDate));

#line default
#line hidden
            EndContext();
            BeginContext(759, 196, true);
            WriteLiteral("</span> |\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-7 col-12\">\r\n                <div class=\"img\">\r\n                    ");
            EndContext();
            BeginContext(955, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e71731b5d0584dc9b1eb37e6d73f6e51", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 965, "~/Images/News/", 965, 14, true);
#line 28 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Areas\Admin\Views\Newss\DeleteNew.cshtml"
AddHtmlAttributeValue("", 979, Model.ImageUrl, 979, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
            BeginContext(1028, 134, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-12\">\r\n                <p class=\"py-3\">\r\n                    ");
            EndContext();
            BeginContext(1163, 10, false);
#line 33 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Areas\Admin\Views\Newss\DeleteNew.cshtml"
               Write(Model.Info);

#line default
#line hidden
            EndContext();
            BeginContext(1173, 139, true);
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                ");
            EndContext();
            BeginContext(1312, 144, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e445a9641a6479cabfd11e3981ea1cf", async() => {
                BeginContext(1332, 117, true);
                WriteLiteral("\r\n                    <input type=\"submit\" class=\"btn btn-click btn-danger btn-block\" value=\"Sil\"/>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1456, 87, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- NewDetails end -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<News> Html { get; private set; }
    }
}
#pragma warning restore 1591

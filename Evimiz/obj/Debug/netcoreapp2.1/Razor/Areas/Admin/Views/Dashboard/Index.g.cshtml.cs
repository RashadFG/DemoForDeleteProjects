#pragma checksum "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Areas\Admin\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e32a6ee9affeb6e8e1498f9566f981346278af1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Dashboard/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Dashboard_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e32a6ee9affeb6e8e1498f9566f981346278af1", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea22cad5cf3b07d32feab8ab4d2cdbe7b53f068a", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 353, true);
            WriteLiteral(@"
<div class=""row m-0"">
    <div class=""col-xl-3 col-4"">
        <div class=""card text-white bg-primary mb-3"" style=""max-width: 18rem;"">
            <div class=""card-header""><i class=""fas fa-bell mr-3""></i> Yeni elanlar </div>
            <div class=""card-body"">
                <div class=""User-Count"" style=""font-size:30px"">
                    ");
            EndContext();
            BeginContext(372, 63, false);
#line 9 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Areas\Admin\Views\Dashboard\Index.cshtml"
               Write(Model.Advertisements.Where(x => x.IsConfirmed == false).Count());

#line default
#line hidden
            EndContext();
            BeginContext(435, 408, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-4"">
        <div class=""card text-white bg-primary mb-3"" style=""max-width: 18rem;"">
            <div class=""card-header""><i class=""fas fa-clipboard mr-3""></i> Elanların sayı</div>
            <div class=""card-body"">
                <div class=""User-Count"" style=""font-size:30px"">
                    ");
            EndContext();
            BeginContext(844, 28, false);
#line 19 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Areas\Admin\Views\Dashboard\Index.cshtml"
               Write(Model.Advertisements.Count());

#line default
#line hidden
            EndContext();
            BeginContext(872, 411, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-4"">
        <div class=""card text-white bg-primary mb-3"" style=""max-width: 18rem;"">
            <div class=""card-header""><i class=""fas fa-check mr-3""></i> Təsdiqlənmiş  elanlar</div>
            <div class=""card-body"">
                <div class=""User-Count"" style=""font-size:30px"">
                    ");
            EndContext();
            BeginContext(1284, 62, false);
#line 29 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Areas\Admin\Views\Dashboard\Index.cshtml"
               Write(Model.Advertisements.Where(x => x.IsConfirmed == true).Count());

#line default
#line hidden
            EndContext();
            BeginContext(1346, 426, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-4"">
        <div class=""card text-white bg-primary mb-3"" style=""max-width: 18rem;"">
            <div class=""card-header""><i class=""fas fa-exclamation-triangle mr-3""></i>Təsdiqlənməmiş elanlar</div>
            <div class=""card-body"">
                <div class=""User-Count"" style=""font-size:30px"">
                    ");
            EndContext();
            BeginContext(1773, 63, false);
#line 39 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Areas\Admin\Views\Dashboard\Index.cshtml"
               Write(Model.Advertisements.Where(x => x.IsConfirmed == false).Count());

#line default
#line hidden
            EndContext();
            BeginContext(1836, 420, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-4"">
        <div class=""card text-white bg-primary mb-3"" style=""max-width: 18rem;"">
            <div class=""card-header""><i class=""fas fa-exclamation-triangle mr-3""></i>Silinmiş elanlar</div>
            <div class=""card-body"">
                <div class=""User-Count"" style=""font-size:30px"">
                    ");
            EndContext();
            BeginContext(2257, 60, false);
#line 49 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Areas\Admin\Views\Dashboard\Index.cshtml"
               Write(Model.Advertisements.Where(x => x.IsDeleted == true).Count());

#line default
#line hidden
            EndContext();
            BeginContext(2317, 405, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-4"">
        <div class=""card text-white bg-primary mb-3"" style=""max-width: 18rem;"">
            <div class=""card-header""><i class=""fas fa-users mr-3""></i> Istifadəçi sayı</div>
            <div class=""card-body"">
                <div class=""User-Count"" style=""font-size:30px"">
                    ");
            EndContext();
            BeginContext(2723, 19, false);
#line 59 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Areas\Admin\Views\Dashboard\Index.cshtml"
               Write(Model.Users.Count());

#line default
#line hidden
            EndContext();
            BeginContext(2742, 88, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

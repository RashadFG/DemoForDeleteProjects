#pragma checksum "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e38a1f4f93fca535e8c4aa308b4311ebbc89e29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Elan_AllPlace), @"mvc.1.0.view", @"/Views/Elan/AllPlace.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Elan/AllPlace.cshtml", typeof(AspNetCore.Views_Elan_AllPlace))]
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
#line 1 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\_ViewImports.cshtml"
using Evimiz;

#line default
#line hidden
#line 2 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\_ViewImports.cshtml"
using Evimiz.Models;

#line default
#line hidden
#line 3 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\_ViewImports.cshtml"
using Evimiz.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e38a1f4f93fca535e8c4aa308b4311ebbc89e29", @"/Views/Elan/AllPlace.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b37c7899817733404d3f451f813828106b62ac92", @"/Views/_ViewImports.cshtml")]
    public class Views_Elan_AllPlace : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Elan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Haqqında", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
  
    ViewData["Title"] = "AllPlace";

#line default
#line hidden
            BeginContext(62, 451, true);
            WriteLiteral(@"
<!-- Torpaq Advertisement start -->
<section id=""advertisement"">
    <div class=""container"">
        <div class=""row head"">
            <div class=""col-md-8 col-12 "">
                <i class=""fas fa-square mr-2 color-blue""></i> Torpaq
            </div>
            <div class=""col-md-4 col-12  d-md-flex justify-content-end "">
            </div>
        </div>
        <div class=""row Advertisement-place justify-content-center Place"">
");
            EndContext();
#line 17 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
             if (Model.Advertisements.Where(x => x.IsConfirmed == true && x.CategoryId == 8 && x.PropertyCategoryId == 1 && x.IsPremium == false && x.IsVip == false).Count() != 0)
            {
                

#line default
#line hidden
#line 19 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
                 foreach (var item in Model.Advertisements.Where(x => x.IsConfirmed == true && x.CategoryId == 8 && x.PropertyCategoryId == 1 && x.IsPremium == false && x.IsVip == false).OrderByDescending(x => x.PublishDate).Take(20))
                {

#line default
#line hidden
            BeginContext(964, 138, true);
            WriteLiteral("                    <div class=\"col-lg-3 col-md-6 col-sm-9  col-10 mt-3\" data-aos=\"fade-up\">\r\n                        <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1102, "\"", 1125, 1);
#line 22 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
WriteAttributeValue("", 1110, ViewBag.Cookie, 1110, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1126, 100, true);
            WriteLiteral(" class=\"Cookie\" />\r\n                        <i class=\"far fa-heart heart fa-2x  f-empty\" data-info=\"");
            EndContext();
            BeginContext(1227, 18, false);
#line 23 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
                                                                           Write(item.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1246, 7, false);
#line 23 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
                                                                                              Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1254, 22, false);
#line 23 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
                                                                                                      Write(item.ApplicationUserId);

#line default
#line hidden
            EndContext();
            BeginContext(1276, 94, true);
            WriteLiteral("\"></i>\r\n                        <i class=\"fas fa-heart heart fa-2x  f-full d-none\" data-info=\"");
            EndContext();
            BeginContext(1371, 18, false);
#line 24 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
                                                                                 Write(item.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1390, 7, false);
#line 24 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
                                                                                                    Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1398, 22, false);
#line 24 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
                                                                                                            Write(item.ApplicationUserId);

#line default
#line hidden
            EndContext();
            BeginContext(1420, 32, true);
            WriteLiteral("\"></i>\r\n                        ");
            EndContext();
            BeginContext(1452, 3300, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8abc09d717343fd848162c4b29a10ab", async() => {
                BeginContext(1523, 199, true);
                WriteLiteral("\r\n                            <div class=\"row\">\r\n                                <div class=\"col-12 \">\r\n                                    <div class=\"img\">\r\n                                        ");
                EndContext();
                BeginContext(1722, 152, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a21f57e8559445fd8dfe0b04b8f3d6b9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1732, "~/images/Advertisement/", 1732, 23, true);
#line 29 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
AddHtmlAttributeValue("", 1755, Model.Images.FirstOrDefault(x => x.AdvertisementId == item.Id && x.IsMainPhoto == true).Name, 1755, 93, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1874, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 30 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
                                         if (item.PropertyCategory.Id == 1)
                                        {

#line default
#line hidden
                BeginContext(1996, 75, true);
                WriteLiteral("                                            <div class=\"Rent\">Satış</div>\r\n");
                EndContext();
#line 33 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
                BeginContext(2203, 76, true);
                WriteLiteral("                                            <div class=\"Sell\">Kirayə</div>\r\n");
                EndContext();
#line 37 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
                                        }

#line default
#line hidden
                BeginContext(2322, 59, true);
                WriteLiteral("                                        <div class=\"Price\">");
                EndContext();
                BeginContext(2382, 10, false);
#line 38 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
                                                      Write(item.Price);

#line default
#line hidden
                EndContext();
                BeginContext(2392, 12, true);
                WriteLiteral(" Azn</div>\r\n");
                EndContext();
#line 39 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
                                         if (item.PropertyDocument.Id == 6)
                                        {

#line default
#line hidden
                BeginContext(2524, 98, true);
                WriteLiteral("                                            <i class=\"fas fa-file-signature document fa-1x\"></i>\r\n");
                EndContext();
#line 42 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
                                        }

#line default
#line hidden
                BeginContext(2665, 343, true);
                WriteLiteral(@"                                    </div>
                                </div>
                                <div class=""col-12"">
                                    <div class=""about-advertisement"">
                                        <div class=""location"">
                                            <div class=""col-12 p-0"">
");
                EndContext();
#line 49 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
                                                 if (item.CityId == 10)
                                                {

#line default
#line hidden
                BeginContext(3132, 90, true);
                WriteLiteral("                                                    <i class=\"fas fa-map-marker-alt\"></i> ");
                EndContext();
                BeginContext(3223, 16, false);
#line 51 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
                                                                                     Write(item.Region.Name);

#line default
#line hidden
                EndContext();
#line 51 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
                                                                                                           
                                                }
                                                else
                                                {

#line default
#line hidden
                BeginContext(3397, 90, true);
                WriteLiteral("                                                    <i class=\"fas fa-map-marker-alt\"></i> ");
                EndContext();
                BeginContext(3488, 14, false);
#line 55 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
                                                                                     Write(item.City.Name);

#line default
#line hidden
                EndContext();
#line 55 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
                                                                                                         
                                                }

#line default
#line hidden
                BeginContext(3555, 213, true);
                WriteLiteral("                                            </div>\r\n                                        </div>\r\n                                        <div class=\"detail\">\r\n                                            <span> ");
                EndContext();
                BeginContext(3769, 9, false);
#line 60 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
                                              Write(item.Area);

#line default
#line hidden
                EndContext();
                BeginContext(3778, 174, true);
                WriteLiteral(" sot </span> |\r\n                                        </div>\r\n                                        <div class=\"date\">\r\n                                            <span>");
                EndContext();
                BeginContext(3953, 14, false);
#line 63 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
                                             Write(item.City.Name);

#line default
#line hidden
                EndContext();
                BeginContext(3967, 60, true);
                WriteLiteral(",</span>\r\n                                            <span>");
                EndContext();
                BeginContext(4028, 49, false);
#line 64 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
                                             Write(String.Format("{0:MM/dd/yyyy}", item.PublishDate));

#line default
#line hidden
                EndContext();
                BeginContext(4077, 57, true);
                WriteLiteral("</span>\r\n                                        </div>\r\n");
                EndContext();
#line 66 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
                                         if (item.IsVip == true)
                                        {

#line default
#line hidden
                BeginContext(4243, 76, true);
                WriteLiteral("                                            <i class=\"fas fa-gem gem\"></i>\r\n");
                EndContext();
#line 69 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
                                        }
                                        else if (item.IsPremium == true)
                                        {

#line default
#line hidden
                BeginContext(4479, 82, true);
                WriteLiteral("                                            <i class=\"fas fa-crown premium\"></i>\r\n");
                EndContext();
#line 73 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
                                        }

#line default
#line hidden
                BeginContext(4604, 144, true);
                WriteLiteral("                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 25 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
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
            BeginContext(4752, 30, true);
            WriteLiteral("\r\n                    </div>\r\n");
            EndContext();
#line 79 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
                }

#line default
#line hidden
#line 79 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
                 
            }
            else
            {

#line default
#line hidden
            BeginContext(4849, 93, true);
            WriteLiteral("                <h4 style=\"font-weight: bold\" class=\"error-h4\">Hal hazırda elan yoxdur</h4>\r\n");
            EndContext();
#line 84 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
            }

#line default
#line hidden
            BeginContext(4957, 166, true);
            WriteLiteral("        </div>\r\n        <div class=\"row Advertisement-place justify-content-center\">\r\n            <div class=\"load-more  mt-3 col-md-4 col-6 \" data-aos=\"fade-left\">\r\n");
            EndContext();
#line 88 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
                 if (Model.Advertisements.Where(x => x.IsConfirmed==true && x.CategoryId == 8 && x.IsPremium == false && x.IsVip == false).Count() > 20)
                {

#line default
#line hidden
            BeginContext(5296, 117, true);
            WriteLiteral("                    <input type=\"hidden\" value=\"20\" id=\"changeSkipPlace\" />\r\n                    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5413, "\"", 5547, 1);
#line 91 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
WriteAttributeValue("", 5421, Model.Advertisements.Where(x => x.IsConfirmed==true && x.CategoryId == 8 && x.IsPremium == false && x.IsVip == false).Count(), 5421, 126, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5548, 197, true);
            WriteLiteral(" />\r\n                    <a class=\"btn Btn-yellow  btn-block load-more-btn-Place\">\r\n                        <i class=\"fas fa-plus\"></i> Daha\r\n                        çox\r\n                    </a>\r\n");
            EndContext();
#line 96 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllPlace.cshtml"
                }

#line default
#line hidden
            BeginContext(5764, 98, true);
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n    </div>\r\n</section>\r\n<!--  Torpaq Advertisement end -->\r\n");
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

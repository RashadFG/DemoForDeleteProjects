#pragma checksum "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a718c430df6cc4324baac01a2bfffcfd69b6be71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Elan_AllOldPlace), @"mvc.1.0.view", @"/Views/Elan/AllOldPlace.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Elan/AllOldPlace.cshtml", typeof(AspNetCore.Views_Elan_AllOldPlace))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a718c430df6cc4324baac01a2bfffcfd69b6be71", @"/Views/Elan/AllOldPlace.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b37c7899817733404d3f451f813828106b62ac92", @"/Views/_ViewImports.cshtml")]
    public class Views_Elan_AllOldPlace : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
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
#line 2 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
  
    ViewData["Title"] = "AllOldPlace";

#line default
#line hidden
            BeginContext(65, 470, true);
            WriteLiteral(@"
<!-- Köhnə tikili Advertisement start -->
<section id=""advertisement"">
    <div class=""container"">
        <div class=""row head"">
            <div class=""col-md-8 col-12 "">
                <i class=""far fa-building mr-2 color-blue""></i> Köhnə tikililər
            </div>
            <div class=""col-md-4 col-12  d-md-flex justify-content-end"">
            </div>
        </div>
        <div class=""row Advertisement-place justify-content-center OldPlace"">
");
            EndContext();
#line 17 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
             if (Model.Advertisements.Where(x => x.IsConfirmed == true && x.CategoryId == 2 && x.IsPremium == false && x.IsVip == false).Count() != 0)
            {
                

#line default
#line hidden
#line 19 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
                 foreach (var item in Model.Advertisements.Where(x => x.IsConfirmed == true && x.CategoryId == 2 && x.IsPremium == false && x.IsVip == false).OrderByDescending(x => x.PublishDate).Take(20))
                {

#line default
#line hidden
            BeginContext(928, 138, true);
            WriteLiteral("                    <div class=\"col-lg-3 col-md-6 col-sm-9  col-10 mt-3\" data-aos=\"fade-up\">\r\n                        <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1066, "\"", 1089, 1);
#line 22 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
WriteAttributeValue("", 1074, ViewBag.Cookie, 1074, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1090, 100, true);
            WriteLiteral(" class=\"Cookie\" />\r\n                        <i class=\"far fa-heart heart fa-2x  f-empty\" data-info=\"");
            EndContext();
            BeginContext(1191, 18, false);
#line 23 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
                                                                           Write(item.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1210, 7, false);
#line 23 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
                                                                                              Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1218, 22, false);
#line 23 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
                                                                                                      Write(item.ApplicationUserId);

#line default
#line hidden
            EndContext();
            BeginContext(1240, 94, true);
            WriteLiteral("\"></i>\r\n                        <i class=\"fas fa-heart heart fa-2x  f-full d-none\" data-info=\"");
            EndContext();
            BeginContext(1335, 18, false);
#line 24 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
                                                                                 Write(item.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1354, 7, false);
#line 24 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
                                                                                                    Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1362, 22, false);
#line 24 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
                                                                                                            Write(item.ApplicationUserId);

#line default
#line hidden
            EndContext();
            BeginContext(1384, 32, true);
            WriteLiteral("\"></i>\r\n                        ");
            EndContext();
            BeginContext(1416, 3485, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "879d2a2baa6c4d7bbdff9bcb13360749", async() => {
                BeginContext(1487, 199, true);
                WriteLiteral("\r\n                            <div class=\"row\">\r\n                                <div class=\"col-12 \">\r\n                                    <div class=\"img\">\r\n                                        ");
                EndContext();
                BeginContext(1686, 146, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ac039257cdfb4d37b6ac3a3b9e6366cb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1696, "~/images/Advertisement/", 1696, 23, true);
#line 29 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
AddHtmlAttributeValue("", 1719, Model.Images.FirstOrDefault(x=>x.AdvertisementId==item.Id && x.IsMainPhoto==true).Name, 1719, 87, false);

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
                BeginContext(1832, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 30 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
                                         if (item.PropertyCategory.Id == 1)
                                        {

#line default
#line hidden
                BeginContext(1954, 75, true);
                WriteLiteral("                                            <div class=\"Rent\">Satış</div>\r\n");
                EndContext();
#line 33 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
                BeginContext(2161, 76, true);
                WriteLiteral("                                            <div class=\"Sell\">Kirayə</div>\r\n");
                EndContext();
#line 37 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
                                        }

#line default
#line hidden
                BeginContext(2280, 59, true);
                WriteLiteral("                                        <div class=\"Price\">");
                EndContext();
                BeginContext(2340, 10, false);
#line 38 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
                                                      Write(item.Price);

#line default
#line hidden
                EndContext();
                BeginContext(2350, 12, true);
                WriteLiteral(" Azn</div>\r\n");
                EndContext();
#line 39 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
                                         if (item.PropertyDocument.Id == 6)
                                        {

#line default
#line hidden
                BeginContext(2482, 98, true);
                WriteLiteral("                                            <i class=\"fas fa-file-signature document fa-1x\"></i>\r\n");
                EndContext();
#line 42 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
                                        }

#line default
#line hidden
                BeginContext(2623, 343, true);
                WriteLiteral(@"                                    </div>
                                </div>
                                <div class=""col-12"">
                                    <div class=""about-advertisement"">
                                        <div class=""location"">
                                            <div class=""col-12 p-0"">
");
                EndContext();
#line 49 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
                                                 if (item.CityId == 10)
                                                {

#line default
#line hidden
                BeginContext(3090, 90, true);
                WriteLiteral("                                                    <i class=\"fas fa-map-marker-alt\"></i> ");
                EndContext();
                BeginContext(3181, 16, false);
#line 51 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
                                                                                     Write(item.Region.Name);

#line default
#line hidden
                EndContext();
#line 51 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
                                                                                                           
                                                }
                                                else
                                                {

#line default
#line hidden
                BeginContext(3355, 90, true);
                WriteLiteral("                                                    <i class=\"fas fa-map-marker-alt\"></i> ");
                EndContext();
                BeginContext(3446, 14, false);
#line 55 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
                                                                                     Write(item.City.Name);

#line default
#line hidden
                EndContext();
#line 55 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
                                                                                                         
                                                }

#line default
#line hidden
                BeginContext(3513, 212, true);
                WriteLiteral("                                            </div>\r\n                                        </div>\r\n                                        <div class=\"detail\">\r\n                                            <span>");
                EndContext();
                BeginContext(3726, 15, false);
#line 60 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
                                             Write(item.Room.Count);

#line default
#line hidden
                EndContext();
                BeginContext(3741, 70, true);
                WriteLiteral(" otaqlı </span> |\r\n                                            <span> ");
                EndContext();
                BeginContext(3812, 9, false);
#line 61 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
                                              Write(item.Area);

#line default
#line hidden
                EndContext();
                BeginContext(3821, 77, true);
                WriteLiteral(" m<sup>2</sup> </span> |\r\n                                            <span> ");
                EndContext();
                BeginContext(3899, 16, false);
#line 62 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
                                              Write(item.Floor.Count);

#line default
#line hidden
                EndContext();
                BeginContext(3915, 1, true);
                WriteLiteral("/");
                EndContext();
                BeginContext(3917, 15, false);
#line 62 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
                                                                Write(item.Rank.Count);

#line default
#line hidden
                EndContext();
                BeginContext(3932, 169, true);
                WriteLiteral(" m</span>\r\n                                        </div>\r\n                                        <div class=\"date\">\r\n                                            <span>");
                EndContext();
                BeginContext(4102, 14, false);
#line 65 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
                                             Write(item.City.Name);

#line default
#line hidden
                EndContext();
                BeginContext(4116, 60, true);
                WriteLiteral(",</span>\r\n                                            <span>");
                EndContext();
                BeginContext(4177, 49, false);
#line 66 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
                                             Write(String.Format("{0:MM/dd/yyyy}", item.PublishDate));

#line default
#line hidden
                EndContext();
                BeginContext(4226, 57, true);
                WriteLiteral("</span>\r\n                                        </div>\r\n");
                EndContext();
#line 68 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
                                         if (item.IsVip == true)
                                        {

#line default
#line hidden
                BeginContext(4392, 76, true);
                WriteLiteral("                                            <i class=\"fas fa-gem gem\"></i>\r\n");
                EndContext();
#line 71 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
                                        }
                                        else if (item.IsPremium == true)
                                        {

#line default
#line hidden
                BeginContext(4628, 82, true);
                WriteLiteral("                                            <i class=\"fas fa-crown premium\"></i>\r\n");
                EndContext();
#line 75 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
                                        }

#line default
#line hidden
                BeginContext(4753, 144, true);
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
#line 25 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
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
            BeginContext(4901, 30, true);
            WriteLiteral("\r\n                    </div>\r\n");
            EndContext();
#line 81 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
                }

#line default
#line hidden
#line 81 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
                 
            }
            else
            {

#line default
#line hidden
            BeginContext(4998, 93, true);
            WriteLiteral("                <h4 style=\"font-weight: bold\" class=\"error-h4\">Hal hazırda elan yoxdur</h4>\r\n");
            EndContext();
#line 86 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
            }

#line default
#line hidden
            BeginContext(5106, 166, true);
            WriteLiteral("        </div>\r\n        <div class=\"row Advertisement-place justify-content-center\">\r\n            <div class=\"load-more  mt-3 col-md-4 col-6 \" data-aos=\"fade-left\">\r\n");
            EndContext();
#line 90 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
                 if (Model.Advertisements.Where(x => x.IsConfirmed==true && x.CategoryId == 2 && x.IsPremium == false && x.IsVip == false).Count() > 20)
                {

#line default
#line hidden
            BeginContext(5445, 120, true);
            WriteLiteral("                    <input type=\"hidden\" value=\"20\" id=\"changeSkipOldPlace\" />\r\n                    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5565, "\"", 5699, 1);
#line 93 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
WriteAttributeValue("", 5573, Model.Advertisements.Where(x => x.IsConfirmed==true && x.IsPremium == false && x.IsVip == false && x.CategoryId == 2).Count(), 5573, 126, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5700, 200, true);
            WriteLiteral(" />\r\n                    <a class=\"btn Btn-yellow  btn-block load-more-btn-OldPlace\">\r\n                        <i class=\"fas fa-plus\"></i> Daha\r\n                        çox\r\n                    </a>\r\n");
            EndContext();
#line 98 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllOldPlace.cshtml"
                }

#line default
#line hidden
            BeginContext(5919, 101, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- Köhnə tikili Advertisement end -->\r\n");
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

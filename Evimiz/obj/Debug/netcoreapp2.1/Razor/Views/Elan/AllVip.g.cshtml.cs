#pragma checksum "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3258686a83073d768b076f4ae5dff6de958a74a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Elan_AllVip), @"mvc.1.0.view", @"/Views/Elan/AllVip.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Elan/AllVip.cshtml", typeof(AspNetCore.Views_Elan_AllVip))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3258686a83073d768b076f4ae5dff6de958a74a3", @"/Views/Elan/AllVip.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b37c7899817733404d3f451f813828106b62ac92", @"/Views/_ViewImports.cshtml")]
    public class Views_Elan_AllVip : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
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
#line 2 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
  
    ViewData["Title"] = "AllVip";

#line default
#line hidden
            BeginContext(61, 452, true);
            WriteLiteral(@"
<!-- Vip Advertisement start -->
<section id=""advertisement"">
    <div class=""container"">
        <div class=""row head"">
            <div class=""col-md-8 col-12 "">
                <i class=""fas fa-gem gem mr-2 color-blue""></i> Vip elanlar
            </div>
            <div class=""col-md-4 col-12  d-md-flex justify-content-end "">
            </div>
        </div>
        <div class=""row Advertisement-place justify-content-center VIP"">
");
            EndContext();
#line 17 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
             if (Model.Advertisements.Where(x => x.IsConfirmed == true && x.IsVip == true).Count() != 0)
            {
                

#line default
#line hidden
#line 19 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                 foreach (var item in Model.Advertisements.Where(x => x.IsConfirmed == true && x.IsVip == true).OrderByDescending(x => x.PublishDate).Take(20))
                {

#line default
#line hidden
            BeginContext(814, 122, true);
            WriteLiteral("            <div class=\"col-lg-3 col-md-6 col-sm-9  col-10 mt-3\" data-aos=\"fade-up\">\r\n                <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 936, "\"", 959, 1);
#line 22 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
WriteAttributeValue("", 944, ViewBag.Cookie, 944, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(960, 92, true);
            WriteLiteral(" class=\"Cookie\" />\r\n                <i class=\"far fa-heart heart fa-2x  f-empty\" data-info=\"");
            EndContext();
            BeginContext(1053, 18, false);
#line 23 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                                                   Write(item.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1072, 7, false);
#line 23 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                                                                      Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1080, 22, false);
#line 23 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                                                                              Write(item.ApplicationUserId);

#line default
#line hidden
            EndContext();
            BeginContext(1102, 86, true);
            WriteLiteral("\"></i>\r\n                <i class=\"fas fa-heart heart fa-2x  f-full d-none\" data-info=\"");
            EndContext();
            BeginContext(1189, 18, false);
#line 24 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                                                         Write(item.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1208, 7, false);
#line 24 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                                                                            Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1216, 22, false);
#line 24 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                                                                                    Write(item.ApplicationUserId);

#line default
#line hidden
            EndContext();
            BeginContext(1238, 24, true);
            WriteLiteral("\"></i>\r\n                ");
            EndContext();
            BeginContext(1262, 6704, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97eab571fcce4dfc9613ba01aeb22761", async() => {
                BeginContext(1333, 167, true);
                WriteLiteral("\r\n                    <div class=\"row\">\r\n                        <div class=\"col-12 \">\r\n                            <div class=\"img\">\r\n                                ");
                EndContext();
                BeginContext(1500, 146, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f774475d20c4488bb35a952aa9283ad4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1510, "~/images/Advertisement/", 1510, 23, true);
#line 29 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
AddHtmlAttributeValue("", 1533, Model.Images.FirstOrDefault(x=>x.AdvertisementId==item.Id && x.IsMainPhoto==true).Name, 1533, 87, false);

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
                BeginContext(1646, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 30 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                 if (item.PropertyCategory.Id == 1)
                                {

#line default
#line hidden
                BeginContext(1752, 67, true);
                WriteLiteral("                                    <div class=\"Rent\">Satış</div>\r\n");
                EndContext();
#line 33 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                }
                                else
                                {

#line default
#line hidden
                BeginContext(1927, 68, true);
                WriteLiteral("                                    <div class=\"Sell\">Kirayə</div>\r\n");
                EndContext();
#line 37 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                }

#line default
#line hidden
                BeginContext(2030, 51, true);
                WriteLiteral("                                <div class=\"Price\">");
                EndContext();
                BeginContext(2082, 10, false);
#line 38 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                              Write(item.Price);

#line default
#line hidden
                EndContext();
                BeginContext(2092, 12, true);
                WriteLiteral(" Azn</div>\r\n");
                EndContext();
#line 39 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                 if (item.PropertyDocument.Id == 6)
                                {

#line default
#line hidden
                BeginContext(2208, 90, true);
                WriteLiteral("                                    <i class=\"fas fa-file-signature document fa-1x\"></i>\r\n");
                EndContext();
#line 42 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                }

#line default
#line hidden
                BeginContext(2333, 295, true);
                WriteLiteral(@"                            </div>
                        </div>
                        <div class=""col-12"">
                            <div class=""about-advertisement"">
                                <div class=""location"">
                                    <div class=""col-12 p-0"">
");
                EndContext();
#line 49 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                         if (item.CityId == 10)
                                        {

#line default
#line hidden
                BeginContext(2736, 82, true);
                WriteLiteral("                                            <i class=\"fas fa-map-marker-alt\"></i> ");
                EndContext();
                BeginContext(2819, 16, false);
#line 51 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                                                             Write(item.Region.Name);

#line default
#line hidden
                EndContext();
#line 51 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                                                                                   
                                        }
                                        else
                                        {

#line default
#line hidden
                BeginContext(2969, 82, true);
                WriteLiteral("                                            <i class=\"fas fa-map-marker-alt\"></i> ");
                EndContext();
                BeginContext(3052, 14, false);
#line 55 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                                                             Write(item.City.Name);

#line default
#line hidden
                EndContext();
#line 55 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                                                                                 
                                        }

#line default
#line hidden
                BeginContext(3111, 84, true);
                WriteLiteral("                                    </div>\r\n                                </div>\r\n");
                EndContext();
#line 59 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                 if (item.CategoryId == 1)
                                {

#line default
#line hidden
                BeginContext(3290, 104, true);
                WriteLiteral("                                    <div class=\"detail\">\r\n                                        <span>");
                EndContext();
                BeginContext(3395, 15, false);
#line 62 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                         Write(item.Room.Count);

#line default
#line hidden
                EndContext();
                BeginContext(3410, 66, true);
                WriteLiteral(" otaqlı </span> |\r\n                                        <span> ");
                EndContext();
                BeginContext(3477, 9, false);
#line 63 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                          Write(item.Area);

#line default
#line hidden
                EndContext();
                BeginContext(3486, 73, true);
                WriteLiteral(" m<sup>2</sup> </span> |\r\n                                        <span> ");
                EndContext();
                BeginContext(3560, 16, false);
#line 64 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                          Write(item.Floor.Count);

#line default
#line hidden
                EndContext();
                BeginContext(3576, 1, true);
                WriteLiteral("/");
                EndContext();
                BeginContext(3578, 15, false);
#line 64 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                                            Write(item.Rank.Count);

#line default
#line hidden
                EndContext();
                BeginContext(3593, 55, true);
                WriteLiteral(" m</span>\r\n                                    </div>\r\n");
                EndContext();
#line 66 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                }
                                else if (item.CategoryId == 2)
                                {

#line default
#line hidden
                BeginContext(3782, 104, true);
                WriteLiteral("                                    <div class=\"detail\">\r\n                                        <span>");
                EndContext();
                BeginContext(3887, 15, false);
#line 70 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                         Write(item.Room.Count);

#line default
#line hidden
                EndContext();
                BeginContext(3902, 66, true);
                WriteLiteral(" otaqlı </span> |\r\n                                        <span> ");
                EndContext();
                BeginContext(3969, 9, false);
#line 71 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                          Write(item.Area);

#line default
#line hidden
                EndContext();
                BeginContext(3978, 73, true);
                WriteLiteral(" m<sup>2</sup> </span> |\r\n                                        <span> ");
                EndContext();
                BeginContext(4052, 16, false);
#line 72 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                          Write(item.Floor.Count);

#line default
#line hidden
                EndContext();
                BeginContext(4068, 1, true);
                WriteLiteral("/");
                EndContext();
                BeginContext(4070, 15, false);
#line 72 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                                            Write(item.Rank.Count);

#line default
#line hidden
                EndContext();
                BeginContext(4085, 55, true);
                WriteLiteral(" m</span>\r\n                                    </div>\r\n");
                EndContext();
#line 74 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                }
                                else if (item.CategoryId == 4)
                                {

#line default
#line hidden
                BeginContext(4274, 104, true);
                WriteLiteral("                                    <div class=\"detail\">\r\n                                        <span>");
                EndContext();
                BeginContext(4379, 15, false);
#line 78 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                         Write(item.Room.Count);

#line default
#line hidden
                EndContext();
                BeginContext(4394, 66, true);
                WriteLiteral(" otaqlı </span> |\r\n                                        <span> ");
                EndContext();
                BeginContext(4461, 9, false);
#line 79 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                          Write(item.Area);

#line default
#line hidden
                EndContext();
                BeginContext(4470, 73, true);
                WriteLiteral(" m<sup>2</sup> </span> |\r\n                                        <span> ");
                EndContext();
                BeginContext(4544, 16, false);
#line 80 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                          Write(item.Floor.Count);

#line default
#line hidden
                EndContext();
                BeginContext(4560, 55, true);
                WriteLiteral(" m</span>\r\n                                    </div>\r\n");
                EndContext();
#line 82 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                }
                                else if (item.CategoryId == 3)
                                {

#line default
#line hidden
                BeginContext(4749, 104, true);
                WriteLiteral("                                    <div class=\"detail\">\r\n                                        <span>");
                EndContext();
                BeginContext(4854, 15, false);
#line 86 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                         Write(item.Room.Count);

#line default
#line hidden
                EndContext();
                BeginContext(4869, 66, true);
                WriteLiteral(" otaqlı </span> |\r\n                                        <span> ");
                EndContext();
                BeginContext(4936, 9, false);
#line 87 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                          Write(item.Area);

#line default
#line hidden
                EndContext();
                BeginContext(4945, 73, true);
                WriteLiteral(" m<sup>2</sup> </span> |\r\n                                        <span> ");
                EndContext();
                BeginContext(5019, 16, false);
#line 88 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                          Write(item.Floor.Count);

#line default
#line hidden
                EndContext();
                BeginContext(5035, 55, true);
                WriteLiteral(" m</span>\r\n                                    </div>\r\n");
                EndContext();
#line 90 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                }
                                else if (item.CategoryId == 5)
                                {

#line default
#line hidden
                BeginContext(5224, 104, true);
                WriteLiteral("                                    <div class=\"detail\">\r\n                                        <span>");
                EndContext();
                BeginContext(5329, 15, false);
#line 94 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                         Write(item.Room.Count);

#line default
#line hidden
                EndContext();
                BeginContext(5344, 66, true);
                WriteLiteral(" otaqlı </span> |\r\n                                        <span> ");
                EndContext();
                BeginContext(5411, 9, false);
#line 95 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                          Write(item.Area);

#line default
#line hidden
                EndContext();
                BeginContext(5420, 73, true);
                WriteLiteral(" m<sup>2</sup> </span> |\r\n                                        <span> ");
                EndContext();
                BeginContext(5494, 16, false);
#line 96 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                          Write(item.Floor.Count);

#line default
#line hidden
                EndContext();
                BeginContext(5510, 55, true);
                WriteLiteral(" m</span>\r\n                                    </div>\r\n");
                EndContext();
#line 98 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                }
                                else if (item.CategoryId == 6)
                                {

#line default
#line hidden
                BeginContext(5699, 104, true);
                WriteLiteral("                                    <div class=\"detail\">\r\n                                        <span>");
                EndContext();
                BeginContext(5804, 15, false);
#line 102 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                         Write(item.Room.Count);

#line default
#line hidden
                EndContext();
                BeginContext(5819, 66, true);
                WriteLiteral(" otaqlı </span> |\r\n                                        <span> ");
                EndContext();
                BeginContext(5886, 9, false);
#line 103 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                          Write(item.Area);

#line default
#line hidden
                EndContext();
                BeginContext(5895, 73, true);
                WriteLiteral(" m<sup>2</sup> </span> |\r\n                                        <span> ");
                EndContext();
                BeginContext(5969, 16, false);
#line 104 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                          Write(item.Floor.Count);

#line default
#line hidden
                EndContext();
                BeginContext(5985, 1, true);
                WriteLiteral("/");
                EndContext();
                BeginContext(5987, 15, false);
#line 104 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                                            Write(item.Rank.Count);

#line default
#line hidden
                EndContext();
                BeginContext(6002, 55, true);
                WriteLiteral(" m</span>\r\n                                    </div>\r\n");
                EndContext();
#line 106 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                }
                                else if (item.CategoryId == 7)
                                {

#line default
#line hidden
                BeginContext(6191, 105, true);
                WriteLiteral("                                    <div class=\"detail\">\r\n                                        <span> ");
                EndContext();
                BeginContext(6297, 9, false);
#line 110 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                          Write(item.Area);

#line default
#line hidden
                EndContext();
                BeginContext(6306, 68, true);
                WriteLiteral(" m<sup>2</sup> </span>\r\n                                    </div>\r\n");
                EndContext();
#line 112 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                }
                                else if (item.CategoryId == 8)
                                {

#line default
#line hidden
                BeginContext(6508, 105, true);
                WriteLiteral("                                    <div class=\"detail\">\r\n                                        <span> ");
                EndContext();
                BeginContext(6614, 9, false);
#line 116 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                          Write(item.Area);

#line default
#line hidden
                EndContext();
                BeginContext(6623, 60, true);
                WriteLiteral(" sot </span> |\r\n                                    </div>\r\n");
                EndContext();
#line 118 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                }
                                else
                                {

#line default
#line hidden
                BeginContext(6791, 104, true);
                WriteLiteral("                                    <div class=\"detail\">\r\n                                        <span>");
                EndContext();
                BeginContext(6896, 15, false);
#line 122 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                         Write(item.Room.Count);

#line default
#line hidden
                EndContext();
                BeginContext(6911, 66, true);
                WriteLiteral(" otaqlı </span> |\r\n                                        <span> ");
                EndContext();
                BeginContext(6978, 9, false);
#line 123 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                          Write(item.Area);

#line default
#line hidden
                EndContext();
                BeginContext(6987, 73, true);
                WriteLiteral(" m<sup>2</sup> </span> |\r\n                                        <span> ");
                EndContext();
                BeginContext(7061, 16, false);
#line 124 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                          Write(item.Floor.Count);

#line default
#line hidden
                EndContext();
                BeginContext(7077, 1, true);
                WriteLiteral("/");
                EndContext();
                BeginContext(7079, 15, false);
#line 124 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                                            Write(item.Rank.Count);

#line default
#line hidden
                EndContext();
                BeginContext(7094, 55, true);
                WriteLiteral(" m</span>\r\n                                    </div>\r\n");
                EndContext();
#line 126 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                }

#line default
#line hidden
                BeginContext(7184, 94, true);
                WriteLiteral("                                <div class=\"date\">\r\n                                    <span>");
                EndContext();
                BeginContext(7279, 14, false);
#line 128 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                     Write(item.City.Name);

#line default
#line hidden
                EndContext();
                BeginContext(7293, 52, true);
                WriteLiteral(",</span>\r\n                                    <span>");
                EndContext();
                BeginContext(7346, 49, false);
#line 129 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                     Write(String.Format("{0:MM/dd/yyyy}", item.PublishDate));

#line default
#line hidden
                EndContext();
                BeginContext(7395, 49, true);
                WriteLiteral("</span>\r\n                                </div>\r\n");
                EndContext();
#line 131 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                 if (item.IsVip == true)
                                {

#line default
#line hidden
                BeginContext(7537, 68, true);
                WriteLiteral("                                    <i class=\"fas fa-gem gem\"></i>\r\n");
                EndContext();
#line 134 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                }
                                else if (item.IsPremium == true)
                                {

#line default
#line hidden
                BeginContext(7741, 74, true);
                WriteLiteral("                                    <i class=\"fas fa-crown premium\"></i>\r\n");
                EndContext();
#line 138 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                                }

#line default
#line hidden
                BeginContext(7850, 112, true);
                WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                ");
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
#line 25 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
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
            BeginContext(7966, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 144 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                }

#line default
#line hidden
#line 144 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                 
            }
            else
            {

#line default
#line hidden
            BeginContext(8055, 93, true);
            WriteLiteral("                <h4 style=\"font-weight: bold\" class=\"error-h4\">Hal hazırda elan yoxdur</h4>\r\n");
            EndContext();
#line 149 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
            }

#line default
#line hidden
            BeginContext(8163, 168, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"row Advertisement-place justify-content-center\">\r\n            <div class=\"load-more  mt-3 col-md-4 col-6 \" data-aos=\"fade-left\">\r\n");
            EndContext();
#line 154 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                 if (Model.Advertisements.Where(x => x.IsConfirmed==true && x.IsVip == true).Count() > 8)
                {

#line default
#line hidden
            BeginContext(8457, 115, true);
            WriteLiteral("                    <input type=\"hidden\" value=\"20\" id=\"changeSkipVip\" />\r\n                    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 8572, "\"", 8660, 1);
#line 157 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
WriteAttributeValue("", 8580, Model.Advertisements.Where(x => x.IsConfirmed==true && x.IsVip == true).Count(), 8580, 80, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8661, 203, true);
            WriteLiteral(" />\r\n                    <a class=\"btn Btn-yellow  btn-block load-more-btn-premium-vip\">\r\n                        <i class=\"fas fa-plus\"></i> Daha\r\n                        çox\r\n                    </a>\r\n");
            EndContext();
#line 162 "D:\R -Copy 2 - Copy\Evimiz.az\Evimiz\Views\Elan\AllVip.cshtml"
                }

#line default
#line hidden
            BeginContext(8883, 94, true);
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n    </div>\r\n</section>\r\n<!-- Vip Advertisement end -->\r\n");
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

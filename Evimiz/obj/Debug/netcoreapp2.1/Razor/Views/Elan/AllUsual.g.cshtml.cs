#pragma checksum "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b02ad2c771d08cec71691afc9aab09869e3a8de6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Elan_AllUsual), @"mvc.1.0.view", @"/Views/Elan/AllUsual.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Elan/AllUsual.cshtml", typeof(AspNetCore.Views_Elan_AllUsual))]
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
#line 1 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\_ViewImports.cshtml"
using Evimiz;

#line default
#line hidden
#line 2 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\_ViewImports.cshtml"
using Evimiz.Models;

#line default
#line hidden
#line 3 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\_ViewImports.cshtml"
using Evimiz.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b02ad2c771d08cec71691afc9aab09869e3a8de6", @"/Views/Elan/AllUsual.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b37c7899817733404d3f451f813828106b62ac92", @"/Views/_ViewImports.cshtml")]
    public class Views_Elan_AllUsual : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
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
            BeginContext(18, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
  
    ViewData["Title"] = "AllUsual";

#line default
#line hidden
            BeginContext(64, 460, true);
            WriteLiteral(@"
<!-- last Advertisement start -->
<section id=""advertisement"">
    <div class=""container"">
        <div class=""row head"">
            <div class=""col-md-8 col-12 "">
                <i class=""fas fa-hourglass-end mr-2 color-blue""></i> Son elanlar
            </div>
            <div class=""col-md-4 col-12  d-md-flex justify-content-end"">
            </div>
        </div>
        <div class=""row Advertisement-place justify-content-center Usual"">
");
            EndContext();
#line 18 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
             if (Model.Advertisements.Where(x => x.IsConfirmed == true && x.IsPremium == false && x.IsVip == false).Count() != 0)
            {

                

#line default
#line hidden
#line 21 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                 foreach (var item in Model.Advertisements.Where(x => x.IsConfirmed == true && x.IsPremium == false && x.IsVip == false).OrderByDescending(x => x.PublishDate).Take(20))
                {

#line default
#line hidden
            BeginContext(877, 122, true);
            WriteLiteral("            <div class=\"col-lg-3 col-md-6 col-sm-9  col-10 mt-3\" data-aos=\"fade-up\">\r\n                <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 999, "\"", 1022, 1);
#line 24 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
WriteAttributeValue("", 1007, ViewBag.Cookie, 1007, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1023, 92, true);
            WriteLiteral(" class=\"Cookie\" />\r\n                <i class=\"far fa-heart heart fa-2x  f-empty\" data-info=\"");
            EndContext();
            BeginContext(1116, 18, false);
#line 25 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                                                   Write(item.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1135, 7, false);
#line 25 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                                                                      Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1143, 22, false);
#line 25 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                                                                              Write(item.ApplicationUserId);

#line default
#line hidden
            EndContext();
            BeginContext(1165, 86, true);
            WriteLiteral("\"></i>\r\n                <i class=\"fas fa-heart heart fa-2x  f-full d-none\" data-info=\"");
            EndContext();
            BeginContext(1252, 18, false);
#line 26 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                                                         Write(item.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1271, 7, false);
#line 26 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                                                                            Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1279, 22, false);
#line 26 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                                                                                    Write(item.ApplicationUserId);

#line default
#line hidden
            EndContext();
            BeginContext(1301, 24, true);
            WriteLiteral("\"></i>\r\n                ");
            EndContext();
            BeginContext(1325, 6704, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27138fefda184382b63ce12de02fb20a", async() => {
                BeginContext(1396, 167, true);
                WriteLiteral("\r\n                    <div class=\"row\">\r\n                        <div class=\"col-12 \">\r\n                            <div class=\"img\">\r\n                                ");
                EndContext();
                BeginContext(1563, 146, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "06d2f2a68ec7496e8cca386e5007f428", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1573, "~/images/Advertisement/", 1573, 23, true);
#line 31 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
AddHtmlAttributeValue("", 1596, Model.Images.FirstOrDefault(x=>x.AdvertisementId==item.Id && x.IsMainPhoto==true).Name, 1596, 87, false);

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
                BeginContext(1709, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 32 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                 if (item.PropertyCategory.Id == 1)
                                {

#line default
#line hidden
                BeginContext(1815, 67, true);
                WriteLiteral("                                    <div class=\"Rent\">Satış</div>\r\n");
                EndContext();
#line 35 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                }
                                else
                                {

#line default
#line hidden
                BeginContext(1990, 68, true);
                WriteLiteral("                                    <div class=\"Sell\">Kirayə</div>\r\n");
                EndContext();
#line 39 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                }

#line default
#line hidden
                BeginContext(2093, 51, true);
                WriteLiteral("                                <div class=\"Price\">");
                EndContext();
                BeginContext(2145, 10, false);
#line 40 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                              Write(item.Price);

#line default
#line hidden
                EndContext();
                BeginContext(2155, 12, true);
                WriteLiteral(" Azn</div>\r\n");
                EndContext();
#line 41 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                 if (item.PropertyDocument.Id == 6)
                                {

#line default
#line hidden
                BeginContext(2271, 90, true);
                WriteLiteral("                                    <i class=\"fas fa-file-signature document fa-1x\"></i>\r\n");
                EndContext();
#line 44 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                }

#line default
#line hidden
                BeginContext(2396, 295, true);
                WriteLiteral(@"                            </div>
                        </div>
                        <div class=""col-12"">
                            <div class=""about-advertisement"">
                                <div class=""location"">
                                    <div class=""col-12 p-0"">
");
                EndContext();
#line 51 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                         if (item.CityId == 10)
                                        {

#line default
#line hidden
                BeginContext(2799, 82, true);
                WriteLiteral("                                            <i class=\"fas fa-map-marker-alt\"></i> ");
                EndContext();
                BeginContext(2882, 16, false);
#line 53 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                                                             Write(item.Region.Name);

#line default
#line hidden
                EndContext();
#line 53 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                                                                                   
                                        }
                                        else
                                        {

#line default
#line hidden
                BeginContext(3032, 82, true);
                WriteLiteral("                                            <i class=\"fas fa-map-marker-alt\"></i> ");
                EndContext();
                BeginContext(3115, 14, false);
#line 57 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                                                             Write(item.City.Name);

#line default
#line hidden
                EndContext();
#line 57 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                                                                                 
                                        }

#line default
#line hidden
                BeginContext(3174, 84, true);
                WriteLiteral("                                    </div>\r\n                                </div>\r\n");
                EndContext();
#line 61 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                 if (item.CategoryId == 1)
                                {

#line default
#line hidden
                BeginContext(3353, 104, true);
                WriteLiteral("                                    <div class=\"detail\">\r\n                                        <span>");
                EndContext();
                BeginContext(3458, 15, false);
#line 64 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                         Write(item.Room.Count);

#line default
#line hidden
                EndContext();
                BeginContext(3473, 66, true);
                WriteLiteral(" otaqlı </span> |\r\n                                        <span> ");
                EndContext();
                BeginContext(3540, 9, false);
#line 65 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                          Write(item.Area);

#line default
#line hidden
                EndContext();
                BeginContext(3549, 73, true);
                WriteLiteral(" m<sup>2</sup> </span> |\r\n                                        <span> ");
                EndContext();
                BeginContext(3623, 16, false);
#line 66 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                          Write(item.Floor.Count);

#line default
#line hidden
                EndContext();
                BeginContext(3639, 1, true);
                WriteLiteral("/");
                EndContext();
                BeginContext(3641, 15, false);
#line 66 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                                            Write(item.Rank.Count);

#line default
#line hidden
                EndContext();
                BeginContext(3656, 55, true);
                WriteLiteral(" m</span>\r\n                                    </div>\r\n");
                EndContext();
#line 68 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                }
                                else if (item.CategoryId == 2)
                                {

#line default
#line hidden
                BeginContext(3845, 104, true);
                WriteLiteral("                                    <div class=\"detail\">\r\n                                        <span>");
                EndContext();
                BeginContext(3950, 15, false);
#line 72 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                         Write(item.Room.Count);

#line default
#line hidden
                EndContext();
                BeginContext(3965, 66, true);
                WriteLiteral(" otaqlı </span> |\r\n                                        <span> ");
                EndContext();
                BeginContext(4032, 9, false);
#line 73 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                          Write(item.Area);

#line default
#line hidden
                EndContext();
                BeginContext(4041, 73, true);
                WriteLiteral(" m<sup>2</sup> </span> |\r\n                                        <span> ");
                EndContext();
                BeginContext(4115, 16, false);
#line 74 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                          Write(item.Floor.Count);

#line default
#line hidden
                EndContext();
                BeginContext(4131, 1, true);
                WriteLiteral("/");
                EndContext();
                BeginContext(4133, 15, false);
#line 74 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                                            Write(item.Rank.Count);

#line default
#line hidden
                EndContext();
                BeginContext(4148, 55, true);
                WriteLiteral(" m</span>\r\n                                    </div>\r\n");
                EndContext();
#line 76 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                }
                                else if (item.CategoryId == 4)
                                {

#line default
#line hidden
                BeginContext(4337, 104, true);
                WriteLiteral("                                    <div class=\"detail\">\r\n                                        <span>");
                EndContext();
                BeginContext(4442, 15, false);
#line 80 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                         Write(item.Room.Count);

#line default
#line hidden
                EndContext();
                BeginContext(4457, 66, true);
                WriteLiteral(" otaqlı </span> |\r\n                                        <span> ");
                EndContext();
                BeginContext(4524, 9, false);
#line 81 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                          Write(item.Area);

#line default
#line hidden
                EndContext();
                BeginContext(4533, 73, true);
                WriteLiteral(" m<sup>2</sup> </span> |\r\n                                        <span> ");
                EndContext();
                BeginContext(4607, 16, false);
#line 82 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                          Write(item.Floor.Count);

#line default
#line hidden
                EndContext();
                BeginContext(4623, 55, true);
                WriteLiteral(" m</span>\r\n                                    </div>\r\n");
                EndContext();
#line 84 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                }
                                else if (item.CategoryId == 3)
                                {

#line default
#line hidden
                BeginContext(4812, 104, true);
                WriteLiteral("                                    <div class=\"detail\">\r\n                                        <span>");
                EndContext();
                BeginContext(4917, 15, false);
#line 88 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                         Write(item.Room.Count);

#line default
#line hidden
                EndContext();
                BeginContext(4932, 66, true);
                WriteLiteral(" otaqlı </span> |\r\n                                        <span> ");
                EndContext();
                BeginContext(4999, 9, false);
#line 89 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                          Write(item.Area);

#line default
#line hidden
                EndContext();
                BeginContext(5008, 73, true);
                WriteLiteral(" m<sup>2</sup> </span> |\r\n                                        <span> ");
                EndContext();
                BeginContext(5082, 16, false);
#line 90 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                          Write(item.Floor.Count);

#line default
#line hidden
                EndContext();
                BeginContext(5098, 55, true);
                WriteLiteral(" m</span>\r\n                                    </div>\r\n");
                EndContext();
#line 92 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                }
                                else if (item.CategoryId == 5)
                                {

#line default
#line hidden
                BeginContext(5287, 104, true);
                WriteLiteral("                                    <div class=\"detail\">\r\n                                        <span>");
                EndContext();
                BeginContext(5392, 15, false);
#line 96 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                         Write(item.Room.Count);

#line default
#line hidden
                EndContext();
                BeginContext(5407, 66, true);
                WriteLiteral(" otaqlı </span> |\r\n                                        <span> ");
                EndContext();
                BeginContext(5474, 9, false);
#line 97 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                          Write(item.Area);

#line default
#line hidden
                EndContext();
                BeginContext(5483, 73, true);
                WriteLiteral(" m<sup>2</sup> </span> |\r\n                                        <span> ");
                EndContext();
                BeginContext(5557, 16, false);
#line 98 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                          Write(item.Floor.Count);

#line default
#line hidden
                EndContext();
                BeginContext(5573, 55, true);
                WriteLiteral(" m</span>\r\n                                    </div>\r\n");
                EndContext();
#line 100 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                }
                                else if (item.CategoryId == 6)
                                {

#line default
#line hidden
                BeginContext(5762, 104, true);
                WriteLiteral("                                    <div class=\"detail\">\r\n                                        <span>");
                EndContext();
                BeginContext(5867, 15, false);
#line 104 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                         Write(item.Room.Count);

#line default
#line hidden
                EndContext();
                BeginContext(5882, 66, true);
                WriteLiteral(" otaqlı </span> |\r\n                                        <span> ");
                EndContext();
                BeginContext(5949, 9, false);
#line 105 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                          Write(item.Area);

#line default
#line hidden
                EndContext();
                BeginContext(5958, 73, true);
                WriteLiteral(" m<sup>2</sup> </span> |\r\n                                        <span> ");
                EndContext();
                BeginContext(6032, 16, false);
#line 106 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                          Write(item.Floor.Count);

#line default
#line hidden
                EndContext();
                BeginContext(6048, 1, true);
                WriteLiteral("/");
                EndContext();
                BeginContext(6050, 15, false);
#line 106 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                                            Write(item.Rank.Count);

#line default
#line hidden
                EndContext();
                BeginContext(6065, 55, true);
                WriteLiteral(" m</span>\r\n                                    </div>\r\n");
                EndContext();
#line 108 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                }
                                else if (item.CategoryId == 7)
                                {

#line default
#line hidden
                BeginContext(6254, 105, true);
                WriteLiteral("                                    <div class=\"detail\">\r\n                                        <span> ");
                EndContext();
                BeginContext(6360, 9, false);
#line 112 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                          Write(item.Area);

#line default
#line hidden
                EndContext();
                BeginContext(6369, 68, true);
                WriteLiteral(" m<sup>2</sup> </span>\r\n                                    </div>\r\n");
                EndContext();
#line 114 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                }
                                else if (item.CategoryId == 8)
                                {

#line default
#line hidden
                BeginContext(6571, 105, true);
                WriteLiteral("                                    <div class=\"detail\">\r\n                                        <span> ");
                EndContext();
                BeginContext(6677, 9, false);
#line 118 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                          Write(item.Area);

#line default
#line hidden
                EndContext();
                BeginContext(6686, 60, true);
                WriteLiteral(" sot </span> |\r\n                                    </div>\r\n");
                EndContext();
#line 120 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                }
                                else
                                {

#line default
#line hidden
                BeginContext(6854, 104, true);
                WriteLiteral("                                    <div class=\"detail\">\r\n                                        <span>");
                EndContext();
                BeginContext(6959, 15, false);
#line 124 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                         Write(item.Room.Count);

#line default
#line hidden
                EndContext();
                BeginContext(6974, 66, true);
                WriteLiteral(" otaqlı </span> |\r\n                                        <span> ");
                EndContext();
                BeginContext(7041, 9, false);
#line 125 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                          Write(item.Area);

#line default
#line hidden
                EndContext();
                BeginContext(7050, 73, true);
                WriteLiteral(" m<sup>2</sup> </span> |\r\n                                        <span> ");
                EndContext();
                BeginContext(7124, 16, false);
#line 126 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                          Write(item.Floor.Count);

#line default
#line hidden
                EndContext();
                BeginContext(7140, 1, true);
                WriteLiteral("/");
                EndContext();
                BeginContext(7142, 15, false);
#line 126 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                                            Write(item.Rank.Count);

#line default
#line hidden
                EndContext();
                BeginContext(7157, 55, true);
                WriteLiteral(" m</span>\r\n                                    </div>\r\n");
                EndContext();
#line 128 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                }

#line default
#line hidden
                BeginContext(7247, 94, true);
                WriteLiteral("                                <div class=\"date\">\r\n                                    <span>");
                EndContext();
                BeginContext(7342, 14, false);
#line 130 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                     Write(item.City.Name);

#line default
#line hidden
                EndContext();
                BeginContext(7356, 52, true);
                WriteLiteral(",</span>\r\n                                    <span>");
                EndContext();
                BeginContext(7409, 49, false);
#line 131 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                     Write(String.Format("{0:MM/dd/yyyy}", item.PublishDate));

#line default
#line hidden
                EndContext();
                BeginContext(7458, 49, true);
                WriteLiteral("</span>\r\n                                </div>\r\n");
                EndContext();
#line 133 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                 if (item.IsVip == true)
                                {

#line default
#line hidden
                BeginContext(7600, 68, true);
                WriteLiteral("                                    <i class=\"fas fa-gem gem\"></i>\r\n");
                EndContext();
#line 136 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                }
                                else if (item.IsPremium == true)
                                {

#line default
#line hidden
                BeginContext(7804, 74, true);
                WriteLiteral("                                    <i class=\"fas fa-crown premium\"></i>\r\n");
                EndContext();
#line 140 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                                }

#line default
#line hidden
                BeginContext(7913, 112, true);
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
#line 27 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
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
            BeginContext(8029, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 146 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                }

#line default
#line hidden
#line 146 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                 
            }
            else
            {

#line default
#line hidden
            BeginContext(8118, 93, true);
            WriteLiteral("                <h4 style=\"font-weight: bold\" class=\"error-h4\">Hal hazırda elan yoxdur</h4>\r\n");
            EndContext();
#line 151 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
            }

#line default
#line hidden
            BeginContext(8226, 166, true);
            WriteLiteral("        </div>\r\n        <div class=\"row Advertisement-place justify-content-center\">\r\n            <div class=\"load-more  mt-3 col-md-4 col-6 \" data-aos=\"fade-left\">\r\n");
            EndContext();
#line 155 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                 if (Model.Advertisements.Where(x => x.IsConfirmed == true && x.IsConfirmed == true && x.IsPremium == false && x.IsVip == false).Count() > 20)
                {

#line default
#line hidden
            BeginContext(8571, 117, true);
            WriteLiteral("                    <input type=\"hidden\" value=\"20\" id=\"changeSkipUsual\" />\r\n                    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 8688, "\"", 8824, 1);
#line 158 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
WriteAttributeValue("", 8696, Model.Advertisements.Where(x => x.IsConfirmed==true && x.IsConfirmed==true && x.IsPremium == false && x.IsVip == false).Count(), 8696, 128, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8825, 197, true);
            WriteLiteral(" />\r\n                    <a class=\"btn Btn-yellow  btn-block load-more-btn-Usual\">\r\n                        <i class=\"fas fa-plus\"></i> Daha\r\n                        çox\r\n                    </a>\r\n");
            EndContext();
#line 163 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllUsual.cshtml"
                }

#line default
#line hidden
            BeginContext(9041, 95, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- last Advertisement end -->\r\n");
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

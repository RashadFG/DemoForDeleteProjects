#pragma checksum "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce8c55acb03acd7d6af136e69b06364412589e3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Elan_AllPropertyObject), @"mvc.1.0.view", @"/Views/Elan/AllPropertyObject.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Elan/AllPropertyObject.cshtml", typeof(AspNetCore.Views_Elan_AllPropertyObject))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce8c55acb03acd7d6af136e69b06364412589e3b", @"/Views/Elan/AllPropertyObject.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b37c7899817733404d3f451f813828106b62ac92", @"/Views/_ViewImports.cshtml")]
    public class Views_Elan_AllPropertyObject : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
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
#line 2 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
  
    ViewData["Title"] = "AllPropertyObject";

#line default
#line hidden
            BeginContext(71, 458, true);
            WriteLiteral(@"
<!-- Obyekt Advertisement start -->
<section id=""advertisement"">
    <div class=""container"">
        <div class=""row head"">
            <div class=""col-md-8 col-12 "">
                <i class=""fas fa-store mr-2 color-blue""></i> Obyekt
            </div>
            <div class=""col-md-4 col-12  d-md-flex justify-content-end"">
            </div>
        </div>
        <div class=""row Advertisement-place justify-content-center PropertyOnject"">
");
            EndContext();
#line 17 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
             if (Model.Advertisements.Where(x => x.IsConfirmed == true && x.CategoryId == 9 && x.IsPremium == false && x.IsVip == false).Count() != 0)
            {
                

#line default
#line hidden
#line 19 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
                 foreach (var item in Model.Advertisements.Where(x => x.IsConfirmed == true && x.CategoryId == 9 && x.IsPremium == false && x.IsVip == false).OrderByDescending(x => x.PublishDate).Take(20))
                {

#line default
#line hidden
            BeginContext(922, 138, true);
            WriteLiteral("                    <div class=\"col-lg-3 col-md-6 col-sm-9  col-10 mt-3\" data-aos=\"fade-up\">\r\n                        <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1060, "\"", 1083, 1);
#line 22 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
WriteAttributeValue("", 1068, ViewBag.Cookie, 1068, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1084, 100, true);
            WriteLiteral(" class=\"Cookie\" />\r\n                        <i class=\"far fa-heart heart fa-2x  f-empty\" data-info=\"");
            EndContext();
            BeginContext(1185, 18, false);
#line 23 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
                                                                           Write(item.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1204, 7, false);
#line 23 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
                                                                                              Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1212, 22, false);
#line 23 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
                                                                                                      Write(item.ApplicationUserId);

#line default
#line hidden
            EndContext();
            BeginContext(1234, 94, true);
            WriteLiteral("\"></i>\r\n                        <i class=\"fas fa-heart heart fa-2x  f-full d-none\" data-info=\"");
            EndContext();
            BeginContext(1329, 18, false);
#line 24 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
                                                                                 Write(item.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1348, 7, false);
#line 24 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
                                                                                                    Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1356, 22, false);
#line 24 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
                                                                                                            Write(item.ApplicationUserId);

#line default
#line hidden
            EndContext();
            BeginContext(1378, 32, true);
            WriteLiteral("\"></i>\r\n                        ");
            EndContext();
            BeginContext(1410, 3468, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "871546aa8e9a47cfba1464ab35513d29", async() => {
                BeginContext(1481, 199, true);
                WriteLiteral("\r\n                            <div class=\"row\">\r\n                                <div class=\"col-12 \">\r\n                                    <div class=\"img\">\r\n                                        ");
                EndContext();
                BeginContext(1680, 146, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9617df7939a3471b92b58fa01044b8cb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1690, "~/images/Advertisement/", 1690, 23, true);
#line 29 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
AddHtmlAttributeValue("", 1713, Model.Images.FirstOrDefault(x=>x.AdvertisementId==item.Id && x.IsMainPhoto==true).Name, 1713, 87, false);

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
                BeginContext(1826, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 30 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
                                         if (item.PropertyCategory.Id == 1)
                                        {

#line default
#line hidden
                BeginContext(1948, 75, true);
                WriteLiteral("                                            <div class=\"Rent\">Satış</div>\r\n");
                EndContext();
#line 33 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
                BeginContext(2155, 76, true);
                WriteLiteral("                                            <div class=\"Sell\">Kirayə</div>\r\n");
                EndContext();
#line 37 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
                                        }

#line default
#line hidden
                BeginContext(2274, 59, true);
                WriteLiteral("                                        <div class=\"Price\">");
                EndContext();
                BeginContext(2334, 10, false);
#line 38 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
                                                      Write(item.Price);

#line default
#line hidden
                EndContext();
                BeginContext(2344, 12, true);
                WriteLiteral(" Azn</div>\r\n");
                EndContext();
#line 39 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
                                         if (item.PropertyDocument.Id == 6)
                                        {

#line default
#line hidden
                BeginContext(2476, 98, true);
                WriteLiteral("                                            <i class=\"fas fa-file-signature document fa-1x\"></i>\r\n");
                EndContext();
#line 42 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
                                        }

#line default
#line hidden
                BeginContext(2617, 343, true);
                WriteLiteral(@"                                    </div>
                                </div>
                                <div class=""col-12"">
                                    <div class=""about-advertisement"">
                                        <div class=""location"">
                                            <div class=""col-12 p-0"">
");
                EndContext();
#line 49 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
                                                 if (item.CityId == 10)
                                                {

#line default
#line hidden
                BeginContext(3084, 90, true);
                WriteLiteral("                                                    <i class=\"fas fa-map-marker-alt\"></i> ");
                EndContext();
                BeginContext(3175, 16, false);
#line 51 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
                                                                                     Write(item.Region.Name);

#line default
#line hidden
                EndContext();
#line 51 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
                                                                                                           
                                                }
                                                else
                                                {

#line default
#line hidden
                BeginContext(3349, 90, true);
                WriteLiteral("                                                    <i class=\"fas fa-map-marker-alt\"></i> ");
                EndContext();
                BeginContext(3440, 14, false);
#line 55 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
                                                                                     Write(item.City.Name);

#line default
#line hidden
                EndContext();
#line 55 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
                                                                                                         
                                                }

#line default
#line hidden
                BeginContext(3507, 212, true);
                WriteLiteral("                                            </div>\r\n                                        </div>\r\n                                        <div class=\"detail\">\r\n                                            <span>");
                EndContext();
                BeginContext(3720, 15, false);
#line 60 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
                                             Write(item.Room.Count);

#line default
#line hidden
                EndContext();
                BeginContext(3735, 70, true);
                WriteLiteral(" otaqlı </span> |\r\n                                            <span> ");
                EndContext();
                BeginContext(3806, 9, false);
#line 61 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
                                              Write(item.Area);

#line default
#line hidden
                EndContext();
                BeginContext(3815, 77, true);
                WriteLiteral(" m<sup>2</sup> </span> |\r\n                                            <span> ");
                EndContext();
                BeginContext(3893, 16, false);
#line 62 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
                                              Write(item.Floor.Count);

#line default
#line hidden
                EndContext();
                BeginContext(3909, 169, true);
                WriteLiteral(" m</span>\r\n                                        </div>\r\n                                        <div class=\"date\">\r\n                                            <span>");
                EndContext();
                BeginContext(4079, 14, false);
#line 65 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
                                             Write(item.City.Name);

#line default
#line hidden
                EndContext();
                BeginContext(4093, 60, true);
                WriteLiteral(",</span>\r\n                                            <span>");
                EndContext();
                BeginContext(4154, 49, false);
#line 66 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
                                             Write(String.Format("{0:MM/dd/yyyy}", item.PublishDate));

#line default
#line hidden
                EndContext();
                BeginContext(4203, 57, true);
                WriteLiteral("</span>\r\n                                        </div>\r\n");
                EndContext();
#line 68 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
                                         if (item.IsVip == true)
                                        {

#line default
#line hidden
                BeginContext(4369, 76, true);
                WriteLiteral("                                            <i class=\"fas fa-gem gem\"></i>\r\n");
                EndContext();
#line 71 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
                                        }
                                        else if (item.IsPremium == true)
                                        {

#line default
#line hidden
                BeginContext(4605, 82, true);
                WriteLiteral("                                            <i class=\"fas fa-crown premium\"></i>\r\n");
                EndContext();
#line 75 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
                                        }

#line default
#line hidden
                BeginContext(4730, 144, true);
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
#line 25 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
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
            BeginContext(4878, 30, true);
            WriteLiteral("\r\n                    </div>\r\n");
            EndContext();
#line 81 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
                }

#line default
#line hidden
#line 81 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
                 
            }
            else
            {

#line default
#line hidden
            BeginContext(4975, 93, true);
            WriteLiteral("                <h4 style=\"font-weight: bold\" class=\"error-h4\">Hal hazırda elan yoxdur</h4>\r\n");
            EndContext();
#line 86 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
            }

#line default
#line hidden
            BeginContext(5083, 166, true);
            WriteLiteral("        </div>\r\n        <div class=\"row Advertisement-place justify-content-center\">\r\n            <div class=\"load-more  mt-3 col-md-4 col-6 \" data-aos=\"fade-left\">\r\n");
            EndContext();
#line 90 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
                 if (Model.Advertisements.Where(x => x.IsConfirmed==true && x.CategoryId == 9 && x.IsPremium == false && x.IsVip == false).Count() > 20)
                {

#line default
#line hidden
            BeginContext(5422, 126, true);
            WriteLiteral("                    <input type=\"hidden\" value=\"20\" id=\"changeSkipPropertyOnject\" />\r\n                    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5548, "\"", 5682, 1);
#line 93 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
WriteAttributeValue("", 5556, Model.Advertisements.Where(x => x.IsConfirmed==true && x.IsPremium == false && x.IsVip == false && x.CategoryId == 9).Count(), 5556, 126, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5683, 206, true);
            WriteLiteral(" />\r\n                    <a class=\"btn Btn-yellow  btn-block load-more-btn-PropertyOnject\">\r\n                        <i class=\"fas fa-plus\"></i> Daha\r\n                        çox\r\n                    </a>\r\n");
            EndContext();
#line 98 "C:\Users\Fuad\Desktop\R\Evimiz.az\Evimiz\Views\Elan\AllPropertyObject.cshtml"
                }

#line default
#line hidden
            BeginContext(5908, 96, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!--  Obyekt Advertisement end -->\r\n");
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

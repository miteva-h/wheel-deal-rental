#pragma checksum "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3408dbba6a1d6f446f07ff39a5d12c68c19e0e47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehicles_Details), @"mvc.1.0.view", @"/Views/Vehicles/Details.cshtml")]
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
#line 1 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\_ViewImports.cshtml"
using WheelDealRental.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\_ViewImports.cshtml"
using WheelDealRental.Domain.DomainModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Details.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Details.cshtml"
using WheelDealRental.Domain.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3408dbba6a1d6f446f07ff39a5d12c68c19e0e47", @"/Views/Vehicles/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e911e33d57862f7f41169fd891488c5762e75664", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicles_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WheelDealRental.Domain.DomainModels.Vehicle>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Vehicles/CheckDate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Vehicles/AddToShoppingCart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Review/Show"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h3 class=\"text-left\">");
#nullable restore
#line 13 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Details.cshtml"
                 Write(Model.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Details.cshtml"
                              Write(Model.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<div class=\"container bg-dark\">\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 543, "\"", 561, 1);
#nullable restore
#line 18 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Details.cshtml"
WriteAttributeValue("", 549, Model.Photo, 549, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"border border-dark rounded w-100\" />\r\n        </div>\r\n        <div class=\"col-6 text-white\">\r\n");
#nullable restore
#line 21 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Details.cshtml"
             if ((SignInManager.IsSignedIn(User)) && (UserManager.GetUserAsync(User).Result.Role == Role.USER))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3408dbba6a1d6f446f07ff39a5d12c68c19e0e477737", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 898, "\"", 915, 1);
#nullable restore
#line 24 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Details.cshtml"
WriteAttributeValue("", 906, Model.Id, 906, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""id"" />
                    <h6>Check if available: </h6>
                    <br />
                    <label class=""text-white"">From:</label><input type=""date"" name=""dateFrom"" />
                    <label class=""text-white pl-3"">To:</label><input type=""date"" name=""dateTo"" /> <button type=""submit"" class=""ml-3"">Check</button>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 32 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Details.cshtml"
                 if (ViewBag.dateAvailable == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3408dbba6a1d6f446f07ff39a5d12c68c19e0e4710341", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1453, "\"", 1470, 1);
#nullable restore
#line 35 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Details.cshtml"
WriteAttributeValue("", 1461, Model.Id, 1461, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"id\" />\r\n            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1518, "\"", 1543, 1);
#nullable restore
#line 36 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Details.cshtml"
WriteAttributeValue("", 1526, ViewBag.dateFrom, 1526, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"dateFrom\" />\r\n            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1597, "\"", 1620, 1);
#nullable restore
#line 37 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Details.cshtml"
WriteAttributeValue("", 1605, ViewBag.dateTo, 1605, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"dateTo\" />\r\n            <p>This date is available: <button type=\"submit\" class=\"ml-3\">Book</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 40 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Details.cshtml"
                        }
                        else if (ViewBag.dateAvailable == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>This date is not available.</p>\r\n");
#nullable restore
#line 44 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Details.cshtml"
                         

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <table class=\"table table-dark\">\r\n                            <tr><td>Location: </td><td>");
#nullable restore
#line 48 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Details.cshtml"
                                                  Write(Model.Location.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                            <tr><td>Registration: </td><td>");
#nullable restore
#line 49 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Details.cshtml"
                                                      Write(Model.Registration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                            <tr><td>Color: </td><td>");
#nullable restore
#line 50 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Details.cshtml"
                                               Write(Model.Color.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                            <tr><td>Fuel: </td><td>");
#nullable restore
#line 51 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Details.cshtml"
                                              Write(Model.Fuel.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                            <tr><td>Price: </td><td>");
#nullable restore
#line 52 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Details.cshtml"
                                               Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</td></tr>\r\n                        </table>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3408dbba6a1d6f446f07ff39a5d12c68c19e0e4716064", async() => {
                WriteLiteral("\r\n                            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2599, "\"", 2616, 1);
#nullable restore
#line 55 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Details.cshtml"
WriteAttributeValue("", 2607, Model.Id, 2607, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"vehicleId\"/>\r\n                            <button type=\"submit\" class=\"btn btn-danger\">Reviews</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            \r\n                </div>\r\n    </div>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3408dbba6a1d6f446f07ff39a5d12c68c19e0e4718044", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<WheelDealRental.Domain.Identity.ERentalUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<WheelDealRental.Domain.Identity.ERentalUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WheelDealRental.Domain.DomainModels.Vehicle> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Locations\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "716a2676122d6a1b795d15c74c99bc7e86a4eff5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Locations_Details), @"mvc.1.0.view", @"/Views/Locations/Details.cshtml")]
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
#line 8 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Locations\Details.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Locations\Details.cshtml"
using WheelDealRental.Domain.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"716a2676122d6a1b795d15c74c99bc7e86a4eff5", @"/Views/Locations/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e911e33d57862f7f41169fd891488c5762e75664", @"/Views/_ViewImports.cshtml")]
    public class Views_Locations_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WheelDealRental.Domain.DomainModels.Vehicle>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Locations\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n");
#nullable restore
#line 15 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Locations\Details.cshtml"
     if ((SignInManager.IsSignedIn(User)) && (UserManager.GetUserAsync(User).Result.Role == Role.ADMIN))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row d-flex justify-content-center\"><a href=\"/Vehicles/Create\" class=\"btn btn-warning text-white col-8\">Add new vehicle</a></div>\r\n");
#nullable restore
#line 18 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Locations\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Locations\Details.cshtml"
     if (Model.Count > 0)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <hr />\r\n        <div class=\"row\">\r\n\r\n");
#nullable restore
#line 25 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Locations\Details.cshtml"
             foreach (var p in Model)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card border-dark mr-5\" style=\"width: 22rem;\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 925, "\"", 939, 1);
#nullable restore
#line 29 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Locations\Details.cshtml"
WriteAttributeValue("", 931, p.Photo, 931, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\"><a");
            BeginWriteAttribute("href", " href=\"", 1068, "\"", 1098, 2);
            WriteAttributeValue("", 1075, "/Vehicles/Details/", 1075, 18, true);
#nullable restore
#line 31 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Locations\Details.cshtml"
WriteAttributeValue("", 1093, p.Id, 1093, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"text-decoration:none;\" class=\"text-dark\">");
#nullable restore
#line 31 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Locations\Details.cshtml"
                                                                                                                            Write(p.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 31 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Locations\Details.cshtml"
                                                                                                                                     Write(p.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 32 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Locations\Details.cshtml"
                                        Write(p.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</p>\r\n                    </div>\r\n\r\n");
#nullable restore
#line 35 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Locations\Details.cshtml"
                     if ((SignInManager.IsSignedIn(User)) && (UserManager.GetUserAsync(User).Result.Role == Role.ADMIN))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            WriteLiteral("<div class=\"card-body\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1493, "\"", 1520, 2);
            WriteAttributeValue("", 1500, "/Vehicles/Edit/", 1500, 15, true);
#nullable restore
#line 38 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Locations\Details.cshtml"
WriteAttributeValue("", 1515, p.Id, 1515, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-block btn-warning text-white col-12\">Edit</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1614, "\"", 1643, 2);
            WriteAttributeValue("", 1621, "/Vehicles/Delete/", 1621, 17, true);
#nullable restore
#line 39 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Locations\Details.cshtml"
WriteAttributeValue("", 1638, p.Id, 1638, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-block btn-danger col-12\">Delete</a>\r\n                        ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 41 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Locations\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n");
#nullable restore
#line 43 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Locations\Details.cshtml"



            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 48 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Locations\Details.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4 class=\"text-center mt-4 text-danger\">There are no currently available vehicles.</h4>\r\n");
#nullable restore
#line 52 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Locations\Details.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "716a2676122d6a1b795d15c74c99bc7e86a4eff510775", async() => {
                WriteLiteral("Back");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WheelDealRental.Domain.DomainModels.Vehicle>> Html { get; private set; }
    }
}
#pragma warning restore 1591

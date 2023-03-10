#pragma checksum "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d649348463e35140fdc193cab812a5f0f1df25d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehicles_Index), @"mvc.1.0.view", @"/Views/Vehicles/Index.cshtml")]
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
#line 7 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Index.cshtml"
using WheelDealRental.Domain.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d649348463e35140fdc193cab812a5f0f1df25d2", @"/Views/Vehicles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e911e33d57862f7f41169fd891488c5762e75664", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WheelDealRental.Domain.DomainModels.Vehicle>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n");
#nullable restore
#line 14 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Index.cshtml"
     if ((SignInManager.IsSignedIn(User)) && (UserManager.GetUserAsync(User).Result.Role == Role.ADMIN))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row d-flex justify-content-center\"><a href=\"/Vehicles/Create\" class=\"btn btn-warning text-white col-8\">Add new vehicle</a></div>\r\n");
#nullable restore
#line 17 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Index.cshtml"
     if (Model.Count > 0)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <hr />\r\n        <div class=\"row\">\r\n\r\n");
#nullable restore
#line 24 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Index.cshtml"
             foreach (var p in Model)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card border-dark mr-5 pl-2 pt-3 mb-4\" style=\"width: 22rem;\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 936, "\"", 950, 1);
#nullable restore
#line 28 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Index.cshtml"
WriteAttributeValue("", 942, p.Photo, 942, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\"><a");
            BeginWriteAttribute("href", " href=\"", 1079, "\"", 1109, 2);
            WriteAttributeValue("", 1086, "/Vehicles/Details/", 1086, 18, true);
#nullable restore
#line 30 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Index.cshtml"
WriteAttributeValue("", 1104, p.Id, 1104, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"text-decoration:none;\" class=\"text-dark\">");
#nullable restore
#line 30 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Index.cshtml"
                                                                                                                            Write(p.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 30 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Index.cshtml"
                                                                                                                                     Write(p.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 31 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Index.cshtml"
                                        Write(p.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</p>\r\n                    </div>\r\n\r\n");
#nullable restore
#line 34 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Index.cshtml"
                     if ((SignInManager.IsSignedIn(User)) && (UserManager.GetUserAsync(User).Result.Role == Role.ADMIN))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            WriteLiteral("<div class=\"card-body\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1504, "\"", 1531, 2);
            WriteAttributeValue("", 1511, "/Vehicles/Edit/", 1511, 15, true);
#nullable restore
#line 37 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Index.cshtml"
WriteAttributeValue("", 1526, p.Id, 1526, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-block btn-warning text-white col-12\">Edit</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1625, "\"", 1654, 2);
            WriteAttributeValue("", 1632, "/Vehicles/Delete/", 1632, 17, true);
#nullable restore
#line 38 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Index.cshtml"
WriteAttributeValue("", 1649, p.Id, 1649, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-block btn-danger col-12\">Delete</a>\r\n                        ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 40 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n");
#nullable restore
#line 42 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Index.cshtml"



            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 47 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4 class=\"text-center mt-4 text-danger\">There are no currently available vehicles.</h4>\r\n");
#nullable restore
#line 51 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Vehicles\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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

#pragma checksum "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Locations\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bd2458d2c77dbd7ff888346a012f360109a3fee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Locations_Edit), @"mvc.1.0.view", @"/Views/Locations/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bd2458d2c77dbd7ff888346a012f360109a3fee", @"/Views/Locations/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e911e33d57862f7f41169fd891488c5762e75664", @"/Views/_ViewImports.cshtml")]
    public class Views_Locations_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WheelDealRental.Domain.DomainModels.Location>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Locations/Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Locations\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"bg-light\" style=\"border:7px solid white\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bd2458d2c77dbd7ff888346a012f360109a3fee5131", async() => {
                WriteLiteral("\r\n        <fieldset>\r\n            <legend>Edit location:</legend>\r\n            <hr />\r\n            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 367, "\"", 384, 1);
#nullable restore
#line 13 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Locations\Edit.cshtml"
WriteAttributeValue("", 375, Model.Id, 375, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"id\" />\r\n            <div class=\"mb-3\">\r\n                <label for=\"inputName\" class=\"form-label\">Name:</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"inputName\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 587, "\"", 606, 1);
#nullable restore
#line 16 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Locations\Edit.cshtml"
WriteAttributeValue("", 595, Model.Name, 595, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n            </div>\r\n            <div class=\"mb-3\">\r\n                <label for=\"inputStreet\" class=\"form-label\">Street:</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"inputStreet\" name=\"street\"");
                BeginWriteAttribute("value", " value=\"", 826, "\"", 847, 1);
#nullable restore
#line 20 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Locations\Edit.cshtml"
WriteAttributeValue("", 834, Model.Street, 834, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n            </div>\r\n            <div class=\"mb-3\">\r\n                <label for=\"inputStreetNumber\" class=\"form-label\">Street Number:</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"inputStreetNumber\" name=\"streetNumber\"");
                BeginWriteAttribute("value", " value=\"", 1092, "\"", 1119, 1);
#nullable restore
#line 24 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Locations\Edit.cshtml"
WriteAttributeValue("", 1100, Model.StreetNumber, 1100, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                <label for=\"open\" class=\"form-label\">Open</label>\r\n                <input type=\"time\" class=\"form-control\" id=\"open\" name=\"open\"");
                BeginWriteAttribute("value", " value=\"", 1324, "\"", 1353, 1);
#nullable restore
#line 28 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Locations\Edit.cshtml"
WriteAttributeValue("", 1332, Model.Open.TimeOfDay, 1332, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                <label for=\"close\" class=\"form-label\">Close</label>\r\n                <input type=\"time\" class=\"form-control\" id=\"close\" name=\"close\"");
                BeginWriteAttribute("value", " value=\"", 1561, "\"", 1591, 1);
#nullable restore
#line 32 "C:\Users\Hristina\source\repos\WheelDealRental\WheelDealRental.Web\Views\Locations\Edit.cshtml"
WriteAttributeValue("", 1569, Model.Close.TimeOfDay, 1569, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n            <hr />\r\n            <div class=\"d-grid gap-2\">\r\n                <button class=\"btn btn-dark text-white\" type=\"submit\">Edit Location</button>\r\n            </div>\r\n            <hr />\r\n        </fieldset>\r\n    ");
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
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bd2458d2c77dbd7ff888346a012f360109a3fee10609", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WheelDealRental.Domain.DomainModels.Location> Html { get; private set; }
    }
}
#pragma warning restore 1591
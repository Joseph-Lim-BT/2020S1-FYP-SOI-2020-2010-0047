#pragma checksum "C:\Users\18014872\source\repos\FYP1\FYP\Views\Shared\SAFStoreman.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "374467d4dd109d22005a45ebe7379b3a0cc23d08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FYP.Pages.Shared.Views_Shared_SAFStoreman), @"mvc.1.0.view", @"/Views/Shared/SAFStoreman.cshtml")]
namespace FYP.Pages.Shared
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
#line 1 "C:\Users\18014872\source\repos\FYP1\FYP\Views\_ViewImports.cshtml"
using FYP;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"374467d4dd109d22005a45ebe7379b3a0cc23d08", @"/Views/Shared/SAFStoreman.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff390737275a4b5093136e0e823ac9009dff6b0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_SAFStoreman : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logoff", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<nav class=""navbar navbar-expand-sm navbar-light bg-light"">

    <!-- Hamburger Menu -->
    <button class=""navbar-toggler"" type=""button""
            data-toggle=""collapse"" data-target=""#navbarSupportedContent""
            aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
        <span class=""navbar-toggler-icon""></span>
    </button>

    <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
        <ul class=""navbar-nav mr-auto"">
            <li class=""dropdown"">
                <a class=""dropdown-toggle"" role=""button"" aria-expanded=""false"" href=""#"" data-toggle=""dropdown"">Equipments<span class=""caret""></span></a>
                <ul class=""dropdown-menu"" role=""menu"">
                    <li>");
#nullable restore
#line 15 "C:\Users\18014872\source\repos\FYP1\FYP\Views\Shared\SAFStoreman.cshtml"
                   Write(Html.ActionLink("View Equipment", "Index", "Equipment", null, new { id = "item 1" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li>");
#nullable restore
#line 16 "C:\Users\18014872\source\repos\FYP1\FYP\Views\Shared\SAFStoreman.cshtml"
                   Write(Html.ActionLink("Add Equipment", "AddEquipment", "Equipment", null, new { id = "item 2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li>");
#nullable restore
#line 17 "C:\Users\18014872\source\repos\FYP1\FYP\Views\Shared\SAFStoreman.cshtml"
                   Write(Html.ActionLink("Mass Add Equipment", "MassAdd", "Equipment", null, new { id = "item 3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li>");
#nullable restore
#line 18 "C:\Users\18014872\source\repos\FYP1\FYP\Views\Shared\SAFStoreman.cshtml"
                   Write(Html.ActionLink("Eqpt Maintenance", "EquipmentMaint", "Equipment", null, new { id = "item 4" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li>");
#nullable restore
#line 19 "C:\Users\18014872\source\repos\FYP1\FYP\Views\Shared\SAFStoreman.cshtml"
                   Write(Html.ActionLink("View Maintenance", "EquipmentMaintCancel", "Equipment", null, new { id = "item 5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                </ul>
            </li>
            <li class=""dropdown"">
                <a class=""dropdown-toggle"" role=""button"" aria-expanded=""false"" href=""#"" data-toggle=""dropdown"">Accessories<span class=""caret""></span></a>
                <ul class=""dropdown-menu"" role=""menu"">
                    <li>");
#nullable restore
#line 25 "C:\Users\18014872\source\repos\FYP1\FYP\Views\Shared\SAFStoreman.cshtml"
                   Write(Html.ActionLink("View Accessories", "Index", "Accessories", null, new { id = "item 1" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li>");
#nullable restore
#line 26 "C:\Users\18014872\source\repos\FYP1\FYP\Views\Shared\SAFStoreman.cshtml"
                   Write(Html.ActionLink("Add Accessories", "AddAccessories", "Accessories", null, new { id = "item 2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li>");
#nullable restore
#line 27 "C:\Users\18014872\source\repos\FYP1\FYP\Views\Shared\SAFStoreman.cshtml"
                   Write(Html.ActionLink("Mass add Accessories", "MassAdd", "Accessories", null, new { id = "item 3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                </ul>
            </li>
            <li class=""dropdown"">
                <a class=""dropdown-toggle"" role=""button"" aria-expanded=""false"" href=""#"" data-toggle=""dropdown"">Stocktake<span class=""caret""></span></a>
                <ul class=""dropdown-menu"" role=""menu"">
                    <li>");
#nullable restore
#line 33 "C:\Users\18014872\source\repos\FYP1\FYP\Views\Shared\SAFStoreman.cshtml"
                   Write(Html.ActionLink("View Stocktake", "ViewStocktake", "Stocktake", null, new { id = "item 1" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li>");
#nullable restore
#line 34 "C:\Users\18014872\source\repos\FYP1\FYP\Views\Shared\SAFStoreman.cshtml"
                   Write(Html.ActionLink("Perform Stockstake", "AddStocktake", "Stocktake", null, new { id = "item 2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li>");
#nullable restore
#line 35 "C:\Users\18014872\source\repos\FYP1\FYP\Views\Shared\SAFStoreman.cshtml"
                   Write(Html.ActionLink("View Archive", "ViewArchive", "Stocktake", null, new { id = "item 3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>

                </ul>
            </li>
            <li class=""dropdown"">
                <a class=""dropdown-toggle"" role=""button"" aria-expanded=""false"" href=""#"" data-toggle=""dropdown"">Loans<span class=""caret""></span></a>
                <ul class=""dropdown-menu"" role=""menu"">
                    <li>");
#nullable restore
#line 42 "C:\Users\18014872\source\repos\FYP1\FYP\Views\Shared\SAFStoreman.cshtml"
                   Write(Html.ActionLink("View Loans", "Loan", "Loan", null, new { id = "item 1" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li>");
#nullable restore
#line 43 "C:\Users\18014872\source\repos\FYP1\FYP\Views\Shared\SAFStoreman.cshtml"
                   Write(Html.ActionLink("Facilitate Loans", "LoanProcess", "Loan", null, new { id = "item 2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li>");
#nullable restore
#line 44 "C:\Users\18014872\source\repos\FYP1\FYP\Views\Shared\SAFStoreman.cshtml"
                   Write(Html.ActionLink("Facilitate Returns", "ReturnProcess", "Loan", null, new { id = "item 3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li>");
#nullable restore
#line 45 "C:\Users\18014872\source\repos\FYP1\FYP\Views\Shared\SAFStoreman.cshtml"
                   Write(Html.ActionLink("View Finished Loans", "Index", "Loan", null, new { id = "item 4" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                </ul>
            </li>
            <li class=""dropdown"">
                <a class=""dropdown-toggle"" role=""button"" aria-expanded=""false"" href=""#"" data-toggle=""dropdown"">Announcement<span class=""caret""></span></a>
                <ul class=""dropdown-menu"" role=""menu"">
                    <li>");
#nullable restore
#line 51 "C:\Users\18014872\source\repos\FYP1\FYP\Views\Shared\SAFStoreman.cshtml"
                   Write(Html.ActionLink("Add Announcement", "AddAnnouncement", "Announcement", null, new { id = "item 1" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li>");
#nullable restore
#line 52 "C:\Users\18014872\source\repos\FYP1\FYP\Views\Shared\SAFStoreman.cshtml"
                   Write(Html.ActionLink("View Announcement list", "Index", "Announcement", null, new { id = "item 2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\r\n                </ul>\r\n            </li>\r\n        </ul>\r\n\r\n        <ul class=\"nav navbar-nav ml-auto\">\r\n            <li>\r\n                <p class=\"navbar-text\">\r\n                    Welcome, ");
#nullable restore
#line 61 "C:\Users\18014872\source\repos\FYP1\FYP\Views\Shared\SAFStoreman.cshtml"
                        Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("!<br />\r\n                </p>\r\n            </li>\r\n            <li>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "374467d4dd109d22005a45ebe7379b3a0cc23d0812116", async() => {
                WriteLiteral("\r\n                    <i class=\"fas fa-sign-out-alt\"></i>\r\n                    Logout\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n            <li>\r\n                &nbsp;&nbsp;&nbsp;\r\n            </li>\r\n        </ul>\r\n    </div>\r\n</nav>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
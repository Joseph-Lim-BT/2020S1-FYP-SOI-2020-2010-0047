#pragma checksum "C:\Users\18014872\source\repos\FYP1\FYP\Views\User\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5e35dd2308c518139fe49504150c0cd1387501c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FYP.Pages.User.Views_User_About), @"mvc.1.0.view", @"/Views/User/About.cshtml")]
namespace FYP.Pages.User
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5e35dd2308c518139fe49504150c0cd1387501c", @"/Views/User/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff390737275a4b5093136e0e823ac9009dff6b0e", @"/Views/_ViewImports.cshtml")]
    public class Views_User_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FYP.Models.Announcement>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Welcome, ");
#nullable restore
#line 3 "C:\Users\18014872\source\repos\FYP1\FYP\Views\User\About.cshtml"
        Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h2>\r\n\r\n<br />\r\n<ul>\r\n    <li>Choose an option to begin a process.</li>\r\n\r\n</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FYP.Models.Announcement> Html { get; private set; }
    }
}
#pragma warning restore 1591

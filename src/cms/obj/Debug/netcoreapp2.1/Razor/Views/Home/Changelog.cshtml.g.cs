#pragma checksum "/Users/sanderpals/Desktop/Spine/src/cms/Views/Home/Changelog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff10c00218918f371309f18fa415819da47f1344"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Changelog), @"mvc.1.0.view", @"/Views/Home/Changelog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Changelog.cshtml", typeof(AspNetCore.Views_Home_Changelog))]
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
#line 1 "/Users/sanderpals/Desktop/Spine/src/cms/Views/_ViewImports.cshtml"
using Site.Data;

#line default
#line hidden
#line 2 "/Users/sanderpals/Desktop/Spine/src/cms/Views/_ViewImports.cshtml"
using Site.Models;

#line default
#line hidden
#line 3 "/Users/sanderpals/Desktop/Spine/src/cms/Views/_ViewImports.cshtml"
using Site.Models.Account.ViewModels;

#line default
#line hidden
#line 4 "/Users/sanderpals/Desktop/Spine/src/cms/Views/_ViewImports.cshtml"
using Site.Models.Manage.ViewModels;

#line default
#line hidden
#line 5 "/Users/sanderpals/Desktop/Spine/src/cms/Views/_ViewImports.cshtml"
using Site.Models.Company;

#line default
#line hidden
#line 6 "/Users/sanderpals/Desktop/Spine/src/cms/Views/_ViewImports.cshtml"
using Site.Models.Page.ViewModels;

#line default
#line hidden
#line 7 "/Users/sanderpals/Desktop/Spine/src/cms/Views/_ViewImports.cshtml"
using Site.Models.ViewModels;

#line default
#line hidden
#line 8 "/Users/sanderpals/Desktop/Spine/src/cms/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 9 "/Users/sanderpals/Desktop/Spine/src/cms/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 10 "/Users/sanderpals/Desktop/Spine/src/cms/Views/_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#line 1 "/Users/sanderpals/Desktop/Spine/src/cms/Views/Home/Changelog.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff10c00218918f371309f18fa415819da47f1344", @"/Views/Home/Changelog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98e3d9b70f762eac4bd771722fad158d8becd5d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Changelog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "/Users/sanderpals/Desktop/Spine/src/cms/Views/Home/Changelog.cshtml"
  
    ViewData["Title"] = "Changelog";

#line default
#line hidden
            BeginContext(127, 15, true);
            WriteLiteral("\r\n<style>\r\n    ");
            EndContext();
            BeginContext(143, 408, true);
            WriteLiteral(@"@media (max-width: 767.5px) {
        .table-responsive {
            margin: 0 !important;
        }
    }
</style>

<div id=""main-wrapper"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""row list-header"">
                <div class=""col-md-12"">
                    <h2>Changelog</h2>
                </div>
            </div>
        </div>
    </div>
</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
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

#pragma checksum "C:\Users\ErkanPer\source\repos\carfully-web-coremvc\carfully-web-coremvc\Views\Home\ErrorPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66071efdb860ebb60af7c6c058ff7ca79da24fcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ErrorPage), @"mvc.1.0.view", @"/Views/Home/ErrorPage.cshtml")]
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
#line 1 "C:\Users\ErkanPer\source\repos\carfully-web-coremvc\carfully-web-coremvc\Views\_ViewImports.cshtml"
using carfully_web_coremvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ErkanPer\source\repos\carfully-web-coremvc\carfully-web-coremvc\Views\_ViewImports.cshtml"
using carfully_web_coremvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66071efdb860ebb60af7c6c058ff7ca79da24fcf", @"/Views/Home/ErrorPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"304b56c6095f47d4a5bc2a4613b097a26f3e4fa1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ErrorPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ErkanPer\source\repos\carfully-web-coremvc\carfully-web-coremvc\Views\Home\ErrorPage.cshtml"
  
    ViewData["Title"] = "Error";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-content bg-white"">
    <!-- Banner  -->
    <div class=""dlab-bnr-inr overlay-primary-dark"" style=""background-image: url(~/OnePage/images/banner/bnr1.jpg);"">
        <div class=""container"">
            <div class=""dlab-bnr-inr-entry"">
                <h1>Error</h1>
                <!-- Breadcrumb Row -->
                <nav aria-label=""breadcrumb"" class=""breadcrumb-row"">
                    <ul class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a href=""/"">Home</a></li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">Error</li>
                    </ul>
                </nav>
                <!-- Breadcrumb Row End -->
            </div>
        </div>
    </div>
    <!-- Banner End -->
    <!-- Error Page -->
    <div class=""section-full"" style=""background-image: url(~/OnePage/images/background/bg1.png);"">
        <div class=""container"">
            <div class=""error-page text-center"">
                <div class=""dla");
            WriteLiteral(@"b_error"">Error</div>
                <h2 class=""error-head"">We are sorry. But the operation cannot complete successfully.</h2>
                <a href=""/"" class=""btn btn-primary radius-no""><span class=""p-lr15"">Back to Homepage</span></a>
            </div>
        </div>
    </div>
    <!-- Error Page End -->
</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\ppatel\WorkingFolder\TestingExamples\GlobalApp\GlobalApp\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "777f3547e2072eaa5af34f6b5b3baef2df3c032d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\ppatel\WorkingFolder\TestingExamples\GlobalApp\GlobalApp\Views\_ViewImports.cshtml"
using GlobalApp;

#line default
#line hidden
#line 2 "C:\Users\ppatel\WorkingFolder\TestingExamples\GlobalApp\GlobalApp\Views\_ViewImports.cshtml"
using GlobalApp.Models;

#line default
#line hidden
#line 1 "C:\Users\ppatel\WorkingFolder\TestingExamples\GlobalApp\GlobalApp\Views\Home\About.cshtml"
using GlobalApp.Resources;

#line default
#line hidden
#line 2 "C:\Users\ppatel\WorkingFolder\TestingExamples\GlobalApp\GlobalApp\Views\Home\About.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"777f3547e2072eaa5af34f6b5b3baef2df3c032d", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fda439a2706cf1a6e35986067d73ed34ab67f96", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(74, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(151, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\ppatel\WorkingFolder\TestingExamples\GlobalApp\GlobalApp\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(194, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(199, 17, false);
#line 10 "C:\Users\ppatel\WorkingFolder\TestingExamples\GlobalApp\GlobalApp\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(216, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(228, 19, false);
#line 11 "C:\Users\ppatel\WorkingFolder\TestingExamples\GlobalApp\GlobalApp\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(247, 71, true);
            WriteLiteral("</h3>\r\n\r\n<p>Use this area to provide additional information.</p>\r\n\r\n<p>");
            EndContext();
            BeginContext(319, 48, false);
#line 15 "C:\Users\ppatel\WorkingFolder\TestingExamples\GlobalApp\GlobalApp\Views\Home\About.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("Shared"));

#line default
#line hidden
            EndContext();
            BeginContext(367, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(377, 22, false);
#line 16 "C:\Users\ppatel\WorkingFolder\TestingExamples\GlobalApp\GlobalApp\Views\Home\About.cshtml"
Write(pageLocalizer["About"]);

#line default
#line hidden
            EndContext();
            BeginContext(399, 8, true);
            WriteLiteral("</p>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer pageLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LocService SharedLocalizer { get; private set; }
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

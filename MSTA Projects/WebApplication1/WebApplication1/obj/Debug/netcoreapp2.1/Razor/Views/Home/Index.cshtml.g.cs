#pragma checksum "C:\Users\docto\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bda59283c0869a7a59656d7bf0490fe6f5687be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\docto\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "C:\Users\docto\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bda59283c0869a7a59656d7bf0490fe6f5687be", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(1, 5, false);
#line 1 "C:\Users\docto\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(6, 22, true);
            WriteLiteral("  HomeIndexViewModel\r\n");
            EndContext();
#line 2 "C:\Users\docto\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(73, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 7 "C:\Users\docto\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
 foreach (var item in Model.events)
{

#line default
#line hidden
            BeginContext(117, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(125, 10, false);
#line 9 "C:\Users\docto\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
  Write(item.title);

#line default
#line hidden
            EndContext();
            BeginContext(135, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 10 "C:\Users\docto\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
}

#line default
#line hidden
#line 11 "C:\Users\docto\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
 foreach (var item in Model.jobs)
{

#line default
#line hidden
            BeginContext(182, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(190, 10, false);
#line 13 "C:\Users\docto\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
  Write(item.title);

#line default
#line hidden
            EndContext();
            BeginContext(200, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 14 "C:\Users\docto\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
}

#line default
#line hidden
#line 15 "C:\Users\docto\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
 foreach (var item in Model.learnings)
{

#line default
#line hidden
            BeginContext(252, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(260, 10, false);
#line 17 "C:\Users\docto\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
  Write(item.title);

#line default
#line hidden
            EndContext();
            BeginContext(270, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 18 "C:\Users\docto\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
}

#line default
#line hidden
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

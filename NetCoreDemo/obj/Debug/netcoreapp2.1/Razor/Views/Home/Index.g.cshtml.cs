#pragma checksum "I:\NetCoreDemo\NetCoreDemo\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4ce5b8027797f29e21b2a1efaeab4c724e76bbd"
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
#line 2 "I:\NetCoreDemo\NetCoreDemo\Views\_ViewImports.cshtml"
using NetCoreDemo.Controllers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4ce5b8027797f29e21b2a1efaeab4c724e76bbd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b1e45e80e392bd86919db8235f5a12a4eef1c38", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomePageViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "I:\NetCoreDemo\NetCoreDemo\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Home控制器下的Index视图";
    //Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(125, 83, true);
            WriteLiteral("\r\n\r\n<h1>欢迎!</h1>\r\n<div>这个消息来自 Home 控制器下的 Index 的视图文件 index.cshtml </div>\r\n<table>\r\n");
            EndContext();
#line 12 "I:\NetCoreDemo\NetCoreDemo\Views\Home\Index.cshtml"
     foreach (var employee in Model.Employees)
    {

#line default
#line hidden
            BeginContext(263, 14, true);
            WriteLiteral("        <tr>\r\n");
            EndContext();
            BeginContext(355, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(381, 17, true);
            WriteLiteral("            <td> ");
            EndContext();
            BeginContext(399, 75, false);
#line 18 "I:\NetCoreDemo\NetCoreDemo\Views\Home\Index.cshtml"
            Write(Html.ActionLink(employee.ID.ToString(), "Detail", new { id = employee.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(474, 24, true);
            WriteLiteral(" </td>\r\n            <td>");
            EndContext();
            BeginContext(499, 13, false);
#line 19 "I:\NetCoreDemo\NetCoreDemo\Views\Home\Index.cshtml"
           Write(employee.Name);

#line default
#line hidden
            EndContext();
            BeginContext(512, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 21 "I:\NetCoreDemo\NetCoreDemo\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(541, 8, true);
            WriteLiteral("</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomePageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

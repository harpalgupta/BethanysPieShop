#pragma checksum "C:\Repos\Personal\BethanysPieShop\Views\Pie\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aaae70b547ae6ebc6e44bb0103472bec03f38dee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pie_List), @"mvc.1.0.view", @"/Views/Pie/List.cshtml")]
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
#line 1 "C:\Repos\Personal\BethanysPieShop\Views\_ViewImports.cshtml"
using BethanysPieShop.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaae70b547ae6ebc6e44bb0103472bec03f38dee", @"/Views/Pie/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4db3dc632e7e5259d4232d7fc5e28ab7e63b0582", @"/Views/_ViewImports.cshtml")]
    public class Views_Pie_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PiesListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h1>");
#nullable restore
#line 4 "C:\Repos\Personal\BethanysPieShop\Views\Pie\List.cshtml"
Write(ViewBag.CurrentCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 5 "C:\Repos\Personal\BethanysPieShop\Views\Pie\List.cshtml"
 foreach (var pie in Model.Pies)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h2>");
#nullable restore
#line 8 "C:\Repos\Personal\BethanysPieShop\Views\Pie\List.cshtml"
       Write(pie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <h3>");
#nullable restore
#line 9 "C:\Repos\Personal\BethanysPieShop\Views\Pie\List.cshtml"
       Write(pie.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <h4>");
#nullable restore
#line 10 "C:\Repos\Personal\BethanysPieShop\Views\Pie\List.cshtml"
       Write(pie.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </div>\r\n");
#nullable restore
#line 12 "C:\Repos\Personal\BethanysPieShop\Views\Pie\List.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PiesListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

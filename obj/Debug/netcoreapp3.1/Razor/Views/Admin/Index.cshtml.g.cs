#pragma checksum "D:\DevOps\SignalRDemo\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5821f196a04b2de35b7e6ff26622463cdefb076"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "D:\DevOps\SignalRDemo\Views\_ViewImports.cshtml"
using SignalRDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\DevOps\SignalRDemo\Views\Admin\Index.cshtml"
using SignalRDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5821f196a04b2de35b7e6ff26622463cdefb076", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c83d3ee8c6725bc2b4b6675479d0fb357d480512", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Article>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\DevOps\SignalRDemo\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Index</h1>\r\n");
#nullable restore
#line 7 "D:\DevOps\SignalRDemo\Views\Admin\Index.cshtml"
 using (Html.BeginForm("Index", "Admin", FormMethod.Post, new { id = "Article" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            Article Heading\r\n        </div>\r\n        <div class=\"col-6\">\r\n            ");
#nullable restore
#line 14 "D:\DevOps\SignalRDemo\Views\Admin\Index.cshtml"
       Write(Html.TextBoxFor(model => Model.articleHeading, new { @maxlength = "50" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <br />\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            Article Content\r\n        </div>\r\n        <div class=\"col-6\">\r\n            ");
#nullable restore
#line 23 "D:\DevOps\SignalRDemo\Views\Admin\Index.cshtml"
       Write(Html.TextBoxFor(model => Model.articleContent, new { @maxlength = "100" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div>\r\n        <button type=\"submit\">Send to All</button>\r\n    </div>\r\n");
#nullable restore
#line 29 "D:\DevOps\SignalRDemo\Views\Admin\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Article> Html { get; private set; }
    }
}
#pragma warning restore 1591

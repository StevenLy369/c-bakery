#pragma checksum "C:\Users\Steven\Desktop\epi\c#\Bakery.Solution\Bakery\Views\Vender\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cff9c403b0941a2f702fa8aadce74367ec58e02d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vender_Index), @"mvc.1.0.view", @"/Views/Vender/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vender/Index.cshtml", typeof(AspNetCore.Views_Vender_Index))]
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
#line 1 "C:\Users\Steven\Desktop\epi\c#\Bakery.Solution\Bakery\Views\Vender\Index.cshtml"
using Bakery.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cff9c403b0941a2f702fa8aadce74367ec58e02d", @"/Views/Vender/Index.cshtml")]
    public class Views_Vender_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 30, true);
            WriteLiteral("\r\n<h1>Vendor</h1>\r\n\r\n\r\n <ul>\r\n");
            EndContext();
#line 7 "C:\Users\Steven\Desktop\epi\c#\Bakery.Solution\Bakery\Views\Vender\Index.cshtml"
   foreach (Vendor vendor in Model)
  {

#line default
#line hidden
            BeginContext(95, 10, true);
            WriteLiteral("    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 105, "\'", 130, 2);
            WriteAttributeValue("", 112, "/vendor/", 112, 8, true);
#line 9 "C:\Users\Steven\Desktop\epi\c#\Bakery.Solution\Bakery\Views\Vender\Index.cshtml"
WriteAttributeValue("", 120, vendor.Id, 120, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(131, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(133, 11, false);
#line 9 "C:\Users\Steven\Desktop\epi\c#\Bakery.Solution\Bakery\Views\Vender\Index.cshtml"
                                Write(vendor.Name);

#line default
#line hidden
            EndContext();
            BeginContext(144, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 10 "C:\Users\Steven\Desktop\epi\c#\Bakery.Solution\Bakery\Views\Vender\Index.cshtml"
  }

#line default
#line hidden
            BeginContext(160, 81, true);
            WriteLiteral("</ul>\r\n\r\n\r\n<button class=\"btn\"><a href=\"/vendor/new\">Add New Vendor!</a></button>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Steven\Desktop\epi\c#\Bakery.Solution\Bakery\Views\Vender\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb53320fbed6e136ecedd64322e5e21bb424bf45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vender_Show), @"mvc.1.0.view", @"/Views/Vender/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vender/Show.cshtml", typeof(AspNetCore.Views_Vender_Show))]
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
#line 1 "C:\Users\Steven\Desktop\epi\c#\Bakery.Solution\Bakery\Views\Vender\Show.cshtml"
using Bakery.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb53320fbed6e136ecedd64322e5e21bb424bf45", @"/Views/Vender/Show.cshtml")]
    public class Views_Vender_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 24, true);
            WriteLiteral("\r\n<h1>Vendor info</h1>\r\n");
            EndContext();
#line 4 "C:\Users\Steven\Desktop\epi\c#\Bakery.Solution\Bakery\Views\Vender\Show.cshtml"
 if (@Model["orders"].Count == 0)
{

#line default
#line hidden
            BeginContext(85, 17, true);
            WriteLiteral("  <p>This Vendor(");
            EndContext();
            BeginContext(103, 20, false);
#line 6 "C:\Users\Steven\Desktop\epi\c#\Bakery.Solution\Bakery\Views\Vender\Show.cshtml"
            Write(Model["vendor"].Name);

#line default
#line hidden
            EndContext();
            BeginContext(123, 23, true);
            WriteLiteral(") has no  orders!</p>\r\n");
            EndContext();
#line 7 "C:\Users\Steven\Desktop\epi\c#\Bakery.Solution\Bakery\Views\Vender\Show.cshtml"
}

#line default
#line hidden
            BeginContext(149, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 10 "C:\Users\Steven\Desktop\epi\c#\Bakery.Solution\Bakery\Views\Vender\Show.cshtml"
 foreach (Order order in @Model["orders"])
{

#line default
#line hidden
            BeginContext(200, 6, true);
            WriteLiteral(" <p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 206, "\'", 256, 4);
            WriteAttributeValue("", 213, "/vendor/", 213, 8, true);
#line 12 "C:\Users\Steven\Desktop\epi\c#\Bakery.Solution\Bakery\Views\Vender\Show.cshtml"
WriteAttributeValue("", 221, Model["vendor"].Id, 221, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 240, "/order/", 240, 7, true);
#line 12 "C:\Users\Steven\Desktop\epi\c#\Bakery.Solution\Bakery\Views\Vender\Show.cshtml"
WriteAttributeValue("", 247, order.Id, 247, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(257, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(259, 11, false);
#line 12 "C:\Users\Steven\Desktop\epi\c#\Bakery.Solution\Bakery\Views\Vender\Show.cshtml"
                                                     Write(order.Title);

#line default
#line hidden
            EndContext();
            BeginContext(270, 10, true);
            WriteLiteral("</a></p>\r\n");
            EndContext();
#line 13 "C:\Users\Steven\Desktop\epi\c#\Bakery.Solution\Bakery\Views\Vender\Show.cshtml"

}

#line default
#line hidden
            BeginContext(285, 24, true);
            WriteLiteral("\r\n<button class=\"btn\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 309, "\'", 353, 3);
            WriteAttributeValue("", 316, "/vendor/", 316, 8, true);
#line 16 "C:\Users\Steven\Desktop\epi\c#\Bakery.Solution\Bakery\Views\Vender\Show.cshtml"
WriteAttributeValue("", 324, Model["vendor"].Id, 324, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 343, "/order/new", 343, 10, true);
            EndWriteAttribute();
            BeginContext(354, 101, true);
            WriteLiteral(">Click to add new order</a></button>\r\n\r\n<button><a href =\'/vendor\'>Click to view vendors</a></button>");
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

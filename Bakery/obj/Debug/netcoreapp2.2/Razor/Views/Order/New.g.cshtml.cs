#pragma checksum "C:\Users\Steven\Desktop\epi\c#\Bakery.Solution\Bakery\Views\Order\New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e8fafe02c17415a9b703ca54425d4f1b2d16794"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_New), @"mvc.1.0.view", @"/Views/Order/New.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/New.cshtml", typeof(AspNetCore.Views_Order_New))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e8fafe02c17415a9b703ca54425d4f1b2d16794", @"/Views/Order/New.cshtml")]
    public class Views_Order_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 55, true);
            WriteLiteral("<h1>Order new</h1>\r\n\r\n<h1>Add a New Order</h1>\r\n\r\n<form");
            EndContext();
            BeginWriteAttribute("action", " action=\'", 55, "\'", 87, 3);
            WriteAttributeValue("", 64, "/vendor/", 64, 8, true);
#line 5 "C:\Users\Steven\Desktop\epi\c#\Bakery.Solution\Bakery\Views\Order\New.cshtml"
WriteAttributeValue("", 72, Model.Id, 72, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 81, "/order", 81, 6, true);
            EndWriteAttribute();
            BeginContext(88, 69, true);
            WriteLiteral(" method=\"post\">\r\n  <input id=\"vendorId\" name=\"vendorId\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 157, "\"", 174, 1);
#line 6 "C:\Users\Steven\Desktop\epi\c#\Bakery.Solution\Bakery\Views\Order\New.cshtml"
WriteAttributeValue("", 165, Model.Id, 165, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(175, 350, true);
            WriteLiteral(@">

  <label for=""type"">Order Type</label>
  <input id=""type"" name=""type"" type=""text"" required>
  <br>

  <label for=""quantity"">Order Quantity</label>
  <input id=""quantity"" name=""quantity"" type=""number"" required>
  <br>

  <button type=""submit"" class=""btn"">Add</button>
</form>


<a href=""/"">Home</a>
<a href=""/vendors"">Vendor List</a>");
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

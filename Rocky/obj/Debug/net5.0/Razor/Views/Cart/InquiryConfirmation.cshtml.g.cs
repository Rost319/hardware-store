#pragma checksum "C:\Users\rosti\source\repos\Rocky\Rocky\Views\Cart\InquiryConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "401ea40df655273440f472339f43588b6a3b678b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_InquiryConfirmation), @"mvc.1.0.view", @"/Views/Cart/InquiryConfirmation.cshtml")]
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
#line 1 "C:\Users\rosti\source\repos\Rocky\Rocky\Views\_ViewImports.cshtml"
using Rocky;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rosti\source\repos\Rocky\Rocky\Views\_ViewImports.cshtml"
using Rocky_Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"401ea40df655273440f472339f43588b6a3b678b", @"/Views/Cart/InquiryConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6bf95cd426d3c4f7c3816bb278dffd66984d43b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cart_InquiryConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Rocky_Models.OrderHeader>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"text-center\">\r\n\r\n");
#nullable restore
#line 5 "C:\Users\rosti\source\repos\Rocky\Rocky\Views\Cart\InquiryConfirmation.cshtml"
     if (Model != null)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<h1 class=\"text-info\">Order Created</h1>\r\n\t\t<p>Order #");
#nullable restore
#line 8 "C:\Users\rosti\source\repos\Rocky\Rocky\Views\Cart\InquiryConfirmation.cshtml"
             Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" has been created successfully</p>\r\n");
#nullable restore
#line 9 "C:\Users\rosti\source\repos\Rocky\Rocky\Views\Cart\InquiryConfirmation.cshtml"
	}
	else
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<h1 class=\"text-info\">Inquiry Confirmation</h1>\r\n\t\t<p>We have recieved your inquiry and someone from our team will contact you shortly!</p>\r\n");
#nullable restore
#line 14 "C:\Users\rosti\source\repos\Rocky\Rocky\Views\Cart\InquiryConfirmation.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t<img src=\"/images/patio.jpg\" width=\"80%\" />\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Rocky_Models.OrderHeader> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

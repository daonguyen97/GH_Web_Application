#pragma checksum "C:\Users\Tiny Evil\source\repos\GH_Web_Application\GH_Web_Application\Views\Admin\BookingManagement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8ab8cffea871cd32199d04d00113931fa26d0f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_BookingManagement), @"mvc.1.0.view", @"/Views/Admin/BookingManagement.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/BookingManagement.cshtml", typeof(AspNetCore.Views_Admin_BookingManagement))]
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
#line 1 "C:\Users\Tiny Evil\source\repos\GH_Web_Application\GH_Web_Application\Views\_ViewImports.cshtml"
using GH_Web_Application.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8ab8cffea871cd32199d04d00113931fa26d0f9", @"/Views/Admin/BookingManagement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4adea0fd807f09c2a8912797648e8aa3ea5c9584", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_BookingManagement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Booking>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Tiny Evil\source\repos\GH_Web_Application\GH_Web_Application\Views\Admin\BookingManagement.cshtml"
  
    ViewData["Title"] = "Administrator Management";
    Layout = "_AdminLayout";

#line default
#line hidden
            BeginContext(119, 508, true);
            WriteLiteral(@"

<h1>List of Bookings:</h1>

<table class=""table table-hover"">
    <thead>
        <tr>
            <th scope=""col"">ID</th>
            <th scope=""col"">CustomerId</th>
            <th scope=""col"">HandymanId</th>
            <th scope=""col"">Title</th>
            <th scope=""col"">Location</th>
            <th scope=""col"">Detail</th>
            <th scope=""col"">Price</th>
            <th scope=""col"">State</th>
            <th scope=""col"">Time</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 25 "C:\Users\Tiny Evil\source\repos\GH_Web_Application\GH_Web_Application\Views\Admin\BookingManagement.cshtml"
         foreach (Booking item in Model)
        {

#line default
#line hidden
            BeginContext(680, 42, true);
            WriteLiteral("        <tr>\r\n            <th scope=\"row\">");
            EndContext();
            BeginContext(723, 14, false);
#line 28 "C:\Users\Tiny Evil\source\repos\GH_Web_Application\GH_Web_Application\Views\Admin\BookingManagement.cshtml"
                       Write(item.BookingId);

#line default
#line hidden
            EndContext();
            BeginContext(737, 23, true);
            WriteLiteral("</th>\r\n            <td>");
            EndContext();
            BeginContext(761, 15, false);
#line 29 "C:\Users\Tiny Evil\source\repos\GH_Web_Application\GH_Web_Application\Views\Admin\BookingManagement.cshtml"
           Write(item.CustomerId);

#line default
#line hidden
            EndContext();
            BeginContext(776, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(800, 15, false);
#line 30 "C:\Users\Tiny Evil\source\repos\GH_Web_Application\GH_Web_Application\Views\Admin\BookingManagement.cshtml"
           Write(item.HandymanId);

#line default
#line hidden
            EndContext();
            BeginContext(815, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(839, 17, false);
#line 31 "C:\Users\Tiny Evil\source\repos\GH_Web_Application\GH_Web_Application\Views\Admin\BookingManagement.cshtml"
           Write(item.BookingTitle);

#line default
#line hidden
            EndContext();
            BeginContext(856, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(880, 13, false);
#line 32 "C:\Users\Tiny Evil\source\repos\GH_Web_Application\GH_Web_Application\Views\Admin\BookingManagement.cshtml"
           Write(item.Location);

#line default
#line hidden
            EndContext();
            BeginContext(893, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(917, 18, false);
#line 33 "C:\Users\Tiny Evil\source\repos\GH_Web_Application\GH_Web_Application\Views\Admin\BookingManagement.cshtml"
           Write(item.WorkingDetail);

#line default
#line hidden
            EndContext();
            BeginContext(935, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(959, 10, false);
#line 34 "C:\Users\Tiny Evil\source\repos\GH_Web_Application\GH_Web_Application\Views\Admin\BookingManagement.cshtml"
           Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(969, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(993, 10, false);
#line 35 "C:\Users\Tiny Evil\source\repos\GH_Web_Application\GH_Web_Application\Views\Admin\BookingManagement.cshtml"
           Write(item.State);

#line default
#line hidden
            EndContext();
            BeginContext(1003, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1027, 9, false);
#line 36 "C:\Users\Tiny Evil\source\repos\GH_Web_Application\GH_Web_Application\Views\Admin\BookingManagement.cshtml"
           Write(item.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1036, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 38 "C:\Users\Tiny Evil\source\repos\GH_Web_Application\GH_Web_Application\Views\Admin\BookingManagement.cshtml"
        }

#line default
#line hidden
            BeginContext(1069, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Booking>> Html { get; private set; }
    }
}
#pragma warning restore 1591

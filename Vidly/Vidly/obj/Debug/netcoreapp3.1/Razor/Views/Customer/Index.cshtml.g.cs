#pragma checksum "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce87426648070ef3d8841067fa2fcaa1a3df379a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
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
#line 1 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\_ViewImports.cshtml"
using Vidly;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\_ViewImports.cshtml"
using Vidly.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce87426648070ef3d8841067fa2fcaa1a3df379a", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5f1cd008877cdb7a8309a52d389048c655f591a", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Customer\Index.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Customer</h2>\r\n");
#nullable restore
#line 9 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Customer\Index.cshtml"
Write(Html.ActionLink("New", "New", "Customer", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Customer\Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>No hay Customers</h2>\r\n");
#nullable restore
#line 13 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Customer\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-hover"">

        <thead>
            <tr>
                <th scope=""col"">Id</th>
                <th scope=""col"">Name </th>
                <th scope=""col"">Membership </th>
                <th scope=""col"">Action </th>

            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 28 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Customer\Index.cshtml"
             foreach (var customer in @Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"table-active\">\r\n\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Customer\Index.cshtml"
                   Write(customer.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Customer\Index.cshtml"
                   Write(customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> ");
#nullable restore
#line 34 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Customer\Index.cshtml"
                    Write(customer.MembershipType.MembershipName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 853, "\"", 881, 2);
            WriteAttributeValue("", 860, "customer/", 860, 9, true);
#nullable restore
#line 37 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Customer\Index.cshtml"
WriteAttributeValue("", 869, customer.Id, 869, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 39 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Customer\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n\r\n    </table>\r\n");
#nullable restore
#line 43 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Customer\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

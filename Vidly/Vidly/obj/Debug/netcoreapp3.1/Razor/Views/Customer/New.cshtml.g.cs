#pragma checksum "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Customer\New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f670d4304fc16fe4303991941757d1f194daedc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_New), @"mvc.1.0.view", @"/Views/Customer/New.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f670d4304fc16fe4303991941757d1f194daedc", @"/Views/Customer/New.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5f1cd008877cdb7a8309a52d389048c655f591a", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vidly.ViewModels.CustomerMembershipTypeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Customer\New.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>title</h2>\r\n\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Customer\New.cshtml"
 using (Html.BeginForm("Create", "Customer"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 14 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Customer\New.cshtml"
   Write(Html.LabelFor(m => m.Customer.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 15 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Customer\New.cshtml"
   Write(Html.TextBoxFor(m => m.Customer.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 19 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Customer\New.cshtml"
   Write(Html.LabelFor(m => m.Customer.Birthdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 20 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Customer\New.cshtml"
   Write(Html.TextBoxFor(m => m.Customer.Birthdate, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 24 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Customer\New.cshtml"
   Write(Html.LabelFor(m => m.Customer.MembershipType.MembershipName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 25 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Customer\New.cshtml"
   Write(Html.DropDownListFor(m => m.Customer.MembershipTypeId, new SelectList(Model.MembershipTypes, "Id", "MembershipName"), "Select Membership Type", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"checkbox\">\r\n        <label>\r\n            ");
#nullable restore
#line 30 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Customer\New.cshtml"
       Write(Html.CheckBoxFor(m => m.Customer.IsSubscribedToNewsLetter));

#line default
#line hidden
#nullable disable
            WriteLiteral(" isSubscribedToNewsLetter?\r\n        </label>\r\n    </div>\r\n");
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n");
#nullable restore
#line 35 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Customer\New.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vidly.ViewModels.CustomerMembershipTypeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
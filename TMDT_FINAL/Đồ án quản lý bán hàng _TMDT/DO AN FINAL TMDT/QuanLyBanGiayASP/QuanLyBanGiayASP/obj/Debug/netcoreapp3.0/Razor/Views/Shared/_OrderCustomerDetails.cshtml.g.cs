#pragma checksum "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Views\Shared\_OrderCustomerDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb1e1afe7f94d2bdc6867e2a5600a0e41279b361"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__OrderCustomerDetails), @"mvc.1.0.view", @"/Views/Shared/_OrderCustomerDetails.cshtml")]
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
#line 1 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Views\_ViewImports.cshtml"
using QuanLyBanGiayASP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Views\_ViewImports.cshtml"
using QuanLyBanGiayASP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb1e1afe7f94d2bdc6867e2a5600a0e41279b361", @"/Views/Shared/_OrderCustomerDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7488ec97579ce4f1f82ef0d085dc672a066b2261", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__OrderCustomerDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuanLyBanGiayASP.Models.Orders>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div style=""height:auto; background-color:aliceblue"" class=""container border"">
    <div class=""col-12"">
        <div class=""row"" style=""padding-top:10px"">
            <div class=""col-md-4"">
                Full Name
            </div>
            <div class=""col-6 col-md-8"">
                <span>");
#nullable restore
#line 10 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Views\Shared\_OrderCustomerDetails.cshtml"
                 Write(Model.Customers.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n            <div class=\"col-6 col-md-4\">\r\n                Email\r\n            </div>\r\n            <div class=\"col-6 col-md-8\">\r\n                <span>");
#nullable restore
#line 16 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Views\Shared\_OrderCustomerDetails.cshtml"
                 Write(Model.Customers.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n            <div class=\"col-6 col-md-4\">\r\n                Phone Number\r\n            </div>\r\n            <div class=\"col-6 col-md-8\">\r\n                <span>");
#nullable restore
#line 22 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Views\Shared\_OrderCustomerDetails.cshtml"
                 Write(Model.Customers.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n            <div class=\"col-6 col-md-4\">\r\n                Order Date\r\n            </div>\r\n            <div class=\"col-6 col-md-8\">\r\n               <span>");
#nullable restore
#line 28 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Views\Shared\_OrderCustomerDetails.cshtml"
                Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n    <div class=\"col-12\">\r\n        <div class=\"row\" style=\"padding-top:10px;\">\r\n            \r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyBanGiayASP.Models.Orders> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\CustomerOrder\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5e6ebbe6f8579147ac48f205d1d4d48282efc9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_CustomerOrder_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/CustomerOrder/Index.cshtml")]
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
#line 1 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\_ViewImports.cshtml"
using QuanLyBanGiayASP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\_ViewImports.cshtml"
using QuanLyBanGiayASP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5e6ebbe6f8579147ac48f205d1d4d48282efc9c", @"/Areas/Customer/Views/CustomerOrder/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7488ec97579ce4f1f82ef0d085dc672a066b2261", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_CustomerOrder_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuanLyBanGiayASP.Models.ViewModels.CustomerOrderViewModels>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TableButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\CustomerOrder\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


    <div class=""container"" style=""padding-top:40px"">
        <h2>Danh sách Order</h2>
        <table class=""table table-striped border"">
            <tr class=""table-info"">
                <th>
                    Họ Tên
                </th>
                <th>
                    Ngày Đặt
                </th>
                <th>
                    Số ĐT
                </th>
                <th>
                    Mail
                </th>
                <th>
                    Địa Chỉ
                </th>
                <th>
                    Tình Trạng
                </th>
                <th></th>
                <th></th>
            </tr>
");
#nullable restore
#line 34 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\CustomerOrder\Index.cshtml"
             foreach (var item in Model.Orders)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 39 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\CustomerOrder\Index.cshtml"
                   Write(Html.DisplayFor(m => item.CustomerPerson.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 43 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\CustomerOrder\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 46 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\CustomerOrder\Index.cshtml"
                   Write(Html.DisplayFor(m => item.CustomerPerson.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 49 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\CustomerOrder\Index.cshtml"
                   Write(Html.DisplayFor(m => item.CustomerPerson.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 52 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\CustomerOrder\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 55 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\CustomerOrder\Index.cshtml"
                   Write(Html.DisplayFor(m => item.isConfirmed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a5e6ebbe6f8579147ac48f205d1d4d48282efc9c7984", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 58 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\CustomerOrder\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.ID;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 61 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\CustomerOrder\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyBanGiayASP.Models.ViewModels.CustomerOrderViewModels> Html { get; private set; }
    }
}
#pragma warning restore 1591

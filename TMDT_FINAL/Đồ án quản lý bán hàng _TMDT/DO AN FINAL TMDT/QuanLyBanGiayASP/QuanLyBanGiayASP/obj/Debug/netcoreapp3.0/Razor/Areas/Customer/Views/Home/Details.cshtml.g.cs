#pragma checksum "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fda53d0a753916688c51711b6c76e3ed3e33cf0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Details), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Details.cshtml")]
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
#nullable restore
#line 3 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\Home\Details.cshtml"
using QuanLyBanGiayASP.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\Home\Details.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\Home\Details.cshtml"
using QuanLyBanGiayASP.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\Home\Details.cshtml"
using QuanLyBanGiayASP.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\Home\Details.cshtml"
using QuanLyBanGiayASP.Utility;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fda53d0a753916688c51711b6c76e3ed3e33cf0", @"/Areas/Customer/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7488ec97579ce4f1f82ef0d085dc672a066b2261", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuanLyBanGiayASP.Models.Products>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Remove From Bag"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Add to Bag"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn essence-btn form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"<div class=""cart-bg-overlay""></div>
<section class=""single_product_details_area d-flex align-items-center"">


    <div class=""container"" style=""padding-top:50px;padding-bottom:50px;"">

        <div class=""row"">
            <div class="" col-md-6"" >
                <img");
            BeginWriteAttribute("src", " src=\"", 582, "\"", 600, 1);
#nullable restore
#line 19 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\Home\Details.cshtml"
WriteAttributeValue("", 588, Model.Image, 588, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /> <br /><br />\r\n");
#nullable restore
#line 20 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\Home\Details.cshtml"
                  
                    //nếu sản phẩm có số lượng thì sẽ xuất hiện hình instock
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\" col-md-6\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fda53d0a753916688c51711b6c76e3ed3e33cf09345", async() => {
                WriteLiteral("\r\n                        <div class=\"row\">\r\n                            <div class=\"col-8\">\r\n                                <span>");
#nullable restore
#line 33 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\Home\Details.cshtml"
                                 Write(Model.Brands.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>\r\n                                <h2>");
#nullable restore
#line 34 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\Home\Details.cshtml"
                               Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("  <span style=\"padding-left:30px;color:red\">");
#nullable restore
#line 34 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\Home\Details.cshtml"
                                                                                      Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" $</span></h2>\r\n                               \r\n                                <span><p style=\"width:500px\">");
#nullable restore
#line 36 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\Home\Details.cshtml"
                                                        Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p> </span>\r\n");
                WriteLiteral(@"                                <div class=""form-group row"">
                                    <div class=""col-4"">
                                        <label for=""tanggiam"">Số lượng</label>
                                    </div>
                                    <div class=""col-4"">
");
#nullable restore
#line 46 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\Home\Details.cshtml"
                                          
                                            bool isInBag = false;
                                            List<Amount_Product> lstCart = HttpContextAccessor.HttpContext.Session.Get<List<Amount_Product>>("ssShoppingCart");
                                            if (lstCart != null)
                                            {
                                                foreach (Amount_Product item in lstCart)
                                                {
                                                    if (item.IDProduct == Model.ID)
                                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5fda53d0a753916688c51711b6c76e3ed3e33cf012769", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 55 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\Home\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.Amount);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 56 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\Home\Details.cshtml"
                                                        isInBag = true;
                                                    }
                                                }

                                            }
                                            //số lượng lớn nhất của Spinner là số lượng sản phẩm đang có trong kho( sản phẩm tương)
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\Home\Details.cshtml"
                                             if (!isInBag)
                                            {
                                                int maxSoLuong = _db.Products.Where(s => s.ID == Model.ID).Select(s => s.InStock).FirstOrDefault();
                                                int defaulValue = 1, minSoLuong = 1;
                                                if (maxSoLuong == 0)
                                                {
                                                    minSoLuong = 0; defaulValue = 0;
                                                }


#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <input type=\"number\" id=\"tanggiam\" name=\"Amount\"");
                BeginWriteAttribute("value", " value=\"", 3787, "\"", 3807, 1);
#nullable restore
#line 71 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\Home\Details.cshtml"
WriteAttributeValue("", 3795, defaulValue, 3795, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("min", " min=\"", 3808, "\"", 3825, 1);
#nullable restore
#line 71 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\Home\Details.cshtml"
WriteAttributeValue("", 3814, minSoLuong, 3814, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("max", " max=\"", 3826, "\"", 3843, 1);
#nullable restore
#line 71 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\Home\Details.cshtml"
WriteAttributeValue("", 3832, maxSoLuong, 3832, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 72 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\Home\Details.cshtml"

                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n                                    </div>\r\n                                    <div class=\"col-4\"></div>\r\n");
#nullable restore
#line 81 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\Home\Details.cshtml"
                                      
                                        if (User.IsInRole(SD.Customer))
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <div class=\"row\" style=\"padding-left:25px;padding-top:40px  \">\r\n\r\n");
#nullable restore
#line 86 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\Home\Details.cshtml"
                                                 if (isInBag)
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fda53d0a753916688c51711b6c76e3ed3e33cf019207", async() => {
                    WriteLiteral("Xóa khỏi giỏ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\Home\Details.cshtml"
                                                                                                                        WriteLiteral(Model.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 89 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\Home\Details.cshtml"

                                                }
                                                //Nếu còn sản phẩm sẽ xuất hiện nút addtobag
                                                else
                                                {
                                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\Home\Details.cshtml"
                                                     if (@Model.InStock > 0)
                                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fda53d0a753916688c51711b6c76e3ed3e33cf022964", async() => {
                    WriteLiteral("Thêm vào giỏ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 96 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\Home\Details.cshtml"
                                                                                                   WriteLiteral(Model.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 97 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\Home\Details.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        <button type=\"submit\" style=\"margin-right:50px\" value=\"Add to Bag\" disabled class=\"btn essence-btn\"> </button>\r\n");
#nullable restore
#line 101 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\Home\Details.cshtml"

                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\Home\Details.cshtml"
                                                     

                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            </div>\r\n");
#nullable restore
#line 106 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\Home\Details.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                            <div class=""row"" style=""padding-left:25px;padding-top:40px"">
                                                    <button type=""submit"" style=""margin-right:50px"" value=""Add to Bag"" disabled class=""btn essence-btn"">Thêm vào giỏ </button>
                                            </div>
");
#nullable restore
#line 112 "C:\Users\Admin\Desktop\ThuongMaiDienTu\TMDT_FINAL\Đồ án quản lý bán hàng _TMDT\DO AN FINAL TMDT\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Customer\Views\Home\Details.cshtml"
                                        }
                                    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n\r\n                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n</section>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ApplicationDbContext _db { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyBanGiayASP.Models.Products> Html { get; private set; }
    }
}
#pragma warning restore 1591

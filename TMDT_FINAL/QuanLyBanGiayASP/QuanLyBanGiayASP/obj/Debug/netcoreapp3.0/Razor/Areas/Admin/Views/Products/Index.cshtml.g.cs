#pragma checksum "C:\Users\hoang\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e44c6bac857dfdeadd8646c868513977bcf0e23d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Products_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Products/Index.cshtml")]
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
#line 1 "C:\Users\hoang\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\_ViewImports.cshtml"
using QuanLyBanGiayASP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hoang\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\_ViewImports.cshtml"
using QuanLyBanGiayASP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e44c6bac857dfdeadd8646c868513977bcf0e23d", @"/Areas/Admin/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7488ec97579ce4f1f82ef0d085dc672a066b2261", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QuanLyBanGiayASP.Models.Products>>
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
#line 2 "C:\Users\hoang\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminPanel.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<br />

<div class=""row"">
    <div class=""col-12"">
        <h2 style=""text-align:center ""> Product List</h2>
    </div>
</div>
<br />
<div class=""container"">
    <div>
        <table class=""table table-striped border"">
            <tr class=""table-info"">
                <th>
                    ");
#nullable restore
#line 20 "C:\Users\hoang\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\Products\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 23 "C:\Users\hoang\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\Products\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 26 "C:\Users\hoang\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\Products\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Available));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 29 "C:\Users\hoang\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\Products\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 32 "C:\Users\hoang\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\Products\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Merchants));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 35 "C:\Users\hoang\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\Products\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Brands));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n                <th></th>\r\n            </tr>\r\n\r\n");
#nullable restore
#line 41 "C:\Users\hoang\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\Products\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 45 "C:\Users\hoang\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 48 "C:\Users\hoang\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\Products\Index.cshtml"
                   Write(String.Format("{0:c}", item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 51 "C:\Users\hoang\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Available));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 54 "C:\Users\hoang\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 57 "C:\Users\hoang\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\Products\Index.cshtml"
                         if (!item.Merchants.Name_merchant.Equals("--None--"))
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\hoang\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\Products\Index.cshtml"
                       Write(Html.DisplayFor(m => item.Merchants.Name_merchant));

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\hoang\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\Products\Index.cshtml"
                                                                               
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 64 "C:\Users\hoang\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\Products\Index.cshtml"
                         if (!item.Brands.Name.Equals("--None--"))
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\hoang\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\Products\Index.cshtml"
                       Write(Html.DisplayFor(m => item.Brands.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\hoang\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\Products\Index.cshtml"
                                                                   
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e44c6bac857dfdeadd8646c868513977bcf0e23d11577", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 71 "C:\Users\hoang\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\Products\Index.cshtml"
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
#line 74 "C:\Users\hoang\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\Products\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QuanLyBanGiayASP.Models.Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Admin\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\StoreImport\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a367349f98d0c21fcb91738026e939982a685a03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_StoreImport_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/StoreImport/Index.cshtml")]
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
#line 1 "C:\Users\Admin\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\_ViewImports.cshtml"
using QuanLyBanGiayASP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\_ViewImports.cshtml"
using QuanLyBanGiayASP.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\StoreImport\Index.cshtml"
using QuanLyBanGiayASP.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\StoreImport\Index.cshtml"
using QuanLyBanGiayASP.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a367349f98d0c21fcb91738026e939982a685a03", @"/Areas/Admin/Views/StoreImport/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7488ec97579ce4f1f82ef0d085dc672a066b2261", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_StoreImport_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QuanLyBanGiayASP.Models.ImportDetails>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn essence-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Admin\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\StoreImport\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<br />\r\n");
#nullable restore
#line 9 "C:\Users\Admin\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\StoreImport\Index.cshtml"
  
   //thống kê tổng số lượng sản phẩm theo ngày nhập
 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <h2 style=\"text-align:center\"> Import  List</h2>\r\n\r\n        </div><div class=\"col-9\"></div>\r\n        <div class=\"col-md-3 col-sm-6 text-right\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a367349f98d0c21fcb91738026e939982a685a035683", async() => {
                WriteLiteral("<i class=\"fas fa-plus\"></i>   &nbsp; Import Store");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
    <br />
    <div>
        <table class=""table table-striped border"">
            <tr class=""table-info"">
                <th>
                    Date import
                </th>
                <th>
                    Amount
                </th>
            </tr>

");
#nullable restore
#line 34 "C:\Users\Admin\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\StoreImport\Index.cshtml"
              

                int count = 0;
                DateTime date = DateTime.Now;
                DateTime[] A = new DateTime[50];
                int i = 0, first = 0, k = 0;
                foreach (var itemout in Model)
                {
                    k = 0;
                    if (first == 0)
                    {
                        foreach (var itemin in Model)
                        {
                            if (itemout.DateImport == itemin.DateImport)
                            {
                                count++;
                            }
                        }
                        first++;
                        A[i] = itemout.DateImport;
                        i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 57 "C:\Users\Admin\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\StoreImport\Index.cshtml"
                           Write(itemout.DateImport);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 60 "C:\Users\Admin\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\StoreImport\Index.cshtml"
                           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 63 "C:\Users\Admin\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\StoreImport\Index.cshtml"
                        count = 0;
                    }
                    else
                    {
                        for (int j = 0; j < i; j++)
                        {
                            if (itemout.DateImport == A[j])
                            {
                                k = 1;
                            }
                        }
                        if (k != 1)
                        {
                            for (int j = 0; j < i; j++)
                            {
                                if (itemout.DateImport != A[j])
                                {
                                    foreach (var itemin in Model)
                                    {
                                        if (itemout.DateImport == itemin.DateImport)
                                        {
                                            count++;
                                        }
                                    }
                                    A[i] = itemout.DateImport;
                                    i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 91 "C:\Users\Admin\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\StoreImport\Index.cshtml"
                                       Write(Html.DisplayFor(t => itemout.DateImport));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 94 "C:\Users\Admin\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\StoreImport\Index.cshtml"
                                       Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 97 "C:\Users\Admin\Desktop\chcuhcuchcu\tmdt\17110139-ChuMinhHoang17110168-PhamHuynhThanhLam\DO AN FINAL WEB\QuanLyBanGiayASP\QuanLyBanGiayASP\Areas\Admin\Views\StoreImport\Index.cshtml"
                                    count = 0;
                                    break;
                                }
                            }
                        }
                    }

                }

            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QuanLyBanGiayASP.Models.ImportDetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591

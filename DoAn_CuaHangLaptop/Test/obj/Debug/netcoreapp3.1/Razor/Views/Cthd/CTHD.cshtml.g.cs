#pragma checksum "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Cthd\CTHD.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cea5faea2e10838999d148bf39589b9c86bac2b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cthd_CTHD), @"mvc.1.0.view", @"/Views/Cthd/CTHD.cshtml")]
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
#line 1 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\_ViewImports.cshtml"
using Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\_ViewImports.cshtml"
using Test.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cea5faea2e10838999d148bf39589b9c86bac2b7", @"/Views/Cthd/CTHD.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b938626c1cb27b4184c87d029e4bd0625527155", @"/Views/_ViewImports.cshtml")]
    public class Views_Cthd_CTHD : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Test.Models.Cthd>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Cthd\CTHD.cshtml"
  
    ViewData["Title"] = "CTHD";
    Layout = "~/Areas/Identity/Pages/Account/Manage/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table"">
    <thead>
        <tr>
            <th>
                Hình ảnh
            </th>
            <th>
                Tên sản phẩm
            </th>
            <th>
                Gía
            </th>
            <th>
                Số lượng
            </th>
            <th>
                Tổng tiền
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 30 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Cthd\CTHD.cshtml"
         foreach (var item in Model) {
            var thanhtien = item.Soluong * @item.MaspNavigation.Dongia;
                

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n                    <td style=\"width: 300px; height: 171px\">\r\n                        <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 825, "\"", 859, 1);
#nullable restore
#line 34 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Cthd\CTHD.cshtml"
WriteAttributeValue("", 831, item.MaspNavigation.Hinhanh, 831, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></img>\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 37 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Cthd\CTHD.cshtml"
                   Write(item.MaspNavigation.Tensp);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 40 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Cthd\CTHD.cshtml"
                   Write(item.MaspNavigation.Dongia?.ToString("#,### VNĐ"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 43 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Cthd\CTHD.cshtml"
                   Write(item.Soluong);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 46 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Cthd\CTHD.cshtml"
                   Write(thanhtien?.ToString("#,### VNĐ"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 49 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Cthd\CTHD.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Test.Models.Cthd>> Html { get; private set; }
    }
}
#pragma warning restore 1591

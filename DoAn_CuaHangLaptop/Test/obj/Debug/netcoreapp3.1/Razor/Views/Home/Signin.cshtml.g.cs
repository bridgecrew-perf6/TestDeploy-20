#pragma checksum "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Home\Signin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8fce934491af33581a7b8c8221a42feaae5dffa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Signin), @"mvc.1.0.view", @"/Views/Home/Signin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8fce934491af33581a7b8c8221a42feaae5dffa", @"/Views/Home/Signin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b938626c1cb27b4184c87d029e4bd0625527155", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Signin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width: 40em; margin: auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""hero-wrap hero-bread"" style=""background-image: url(/images/bg_6.jpg);"">
    <div class=""container"">

        <div class=""row no-gutters slider-text align-items-center justify-content-center"">
            <div class=""col-md-9 ftco-animate text-center"">
                <h1 class=""mb-0 bread"">Đăng Nhập</h1>
            </div>
        </div>

        <div class=""nav flex-column nav-pills"" id=""v-pills-tab"" role=""tablist"" aria-orientation=""vertical"">
            <a class=""nav-link rad-border-top-left-right-35px active"" id=""v-pills-signin-tab"" data-toggle=""pill"" href=""#v-pills-signin"" role=""tab"" aria-controls=""v-pills-signin"" aria-selected=""true"">Đăng nhập</a>
            <a class=""nav-link rad-border-top-left-right-35px"" id=""v-pills-profile-tab"" data-toggle=""pill"" href=""#v-pills-profile"" role=""tab"" aria-controls=""v-pills-profile"" aria-selected=""false"">Đăng ký</a>
        </div>

        <div class=""tab-content"" id=""v-pills-tabContent"">
            <div class=""tab-pane fade show active"" ");
            WriteLiteral("id=\"v-pills-signin\" role=\"tabpanel\" aria-labelledby=\"v-pills-signin-tab\">\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8fce934491af33581a7b8c8221a42feaae5dffa5168", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""validationCustomUsername"">Tên đăng nhập</label>
                        <input type=""text"" class=""form-control rad-border-15px"" id=""validationCustomUsername"" placeholder=""Nhập tên đăng nhập""");
                BeginWriteAttribute("value", " value=\"", 1472, "\"", 1480, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                        <div class=""valid-feedback"">
                            Tên đăng nhập hợp lệ.
                        </div>
                        <div class=""invalid-feedback"">
                            Tên đăng nhập không hợp lệ.
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label for=""exampleInputPassword1"">Mật khẩu</label>
                        <input type=""password"" class=""form-control rad-border-15px"" id=""exampleInputPassword1"" placeholder=""Nhập mật khẩu"" required>
                        <div class=""valid-feedback"">
                            Mật khẩu hợp lệ.
                        </div>
                        <div class=""invalid-feedback"">
                            Mật khẩu không hợp lệ.
                        </div>
                    </div>
                    <div class=""form-group form-check"">
                        <input type=""checkbox"" class=""form-check-input"" ");
                WriteLiteral("id=\"exampleCheck1\">\r\n                        <label class=\"form-check-label\" for=\"exampleCheck1\">Ghi nhớ đăng nhập</label>\r\n                    </div>\r\n                    <button type=\"submit\" class=\"btn btn-primary\">Đăng nhập</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"tab-pane fade\" id=\"v-pills-profile\" role=\"tabpanel\" aria-labelledby=\"v-pills-profile\r\n                 -tab\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8fce934491af33581a7b8c8221a42feaae5dffa8863", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""validationCustomName"">Họ và tên</label>
                        <input type=""text"" class=""form-control rad-border-15px"" id=""validationCustomName"" placeholder=""Nhập họ và tên""");
                BeginWriteAttribute("value", " value=\"", 3280, "\"", 3288, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                        <div class=""valid-feedback"">
                            Họ và tên hợp lệ.
                        </div>
                        <div class=""invalid-feedback"">
                            Họ và tên không hợp lệ.
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label for=""validationCustomNumber"">Số điện thoại</label>
                        <input type=""text"" class=""form-control rad-border-15px"" id=""validationCustomNumber"" placeholder=""Nhập số điện thoại""");
                BeginWriteAttribute("value", " value=\"", 3874, "\"", 3882, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                        <div class=""valid-feedback"">
                            Số điện thoại hợp lệ.
                        </div>
                        <div class=""invalid-feedback"">
                            Số điện thoại không hợp lệ.
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label for=""validationCustomMail"">Email</label>
                        <input type=""email"" class=""form-control rad-border-15px"" id=""validationCustomMail"" placeholder=""Nhập Email""");
                BeginWriteAttribute("value", " value=\"", 4457, "\"", 4465, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                        <div class=""valid-feedback"">
                            Email hợp lệ.
                        </div>
                        <div class=""invalid-feedback"">
                            Email không hợp lệ.
                        </div>
                    </div>

                    <fieldset class=""form-group"">
                        <label for=""validationCustomGender"">Giới tính</label>
                        

                        <div class=""row"">

                            <div class=""col-sm-10"">
                                <div class=""form-check"">
                                    <input class=""form-check-input"" type=""radio"" name=""gridRadios"" id=""gridRadios1"" value=""option1"" checked>
                                    <label class=""form-check-label"" for=""gridRadios1"">
                                        Nam
                                    </label>
                                </div>
                                <div clas");
                WriteLiteral(@"s=""form-check"">
                                    <input class=""form-check-input"" type=""radio"" name=""gridRadios"" id=""gridRadios2"" value=""option2"">
                                    <label class=""form-check-label"" for=""gridRadios2"">
                                        Nữ
                                    </label>
                                </div>
                                <div class=""form-check"">
                                    <input class=""form-check-input"" type=""radio"" name=""gridRadios"" id=""gridRadios3"" value=""option3"">
                                    <label class=""form-check-label"" for=""gridRadios3"">
                                        Khác
                                    </label>
                                </div>
                            </div>
                        </div>
                    </fieldset>

                    <div class=""form-group"">
                        <label for=""validationCustomUsername1"">Tên đăng nhập</label>
        ");
                WriteLiteral("                <input type=\"text\" class=\"form-control rad-border-15px\" id=\"validationCustomUsername1\" placeholder=\"Nhập tên đăng nhập\"");
                BeginWriteAttribute("value", " value=\"", 6649, "\"", 6657, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                        <div class=""valid-feedback"">
                            Tên đăng nhập hợp lệ.
                        </div>
                        <div class=""invalid-feedback"">
                            Tên đăng nhập không hợp lệ.
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label for=""exampleInputPassword1"">Mật khẩu</label>
                        <input type=""text"" class=""form-control rad-border-15px"" id=""exampleInputPassword1"" placeholder=""Nhập mật khẩu"" required>
                        <div class=""valid-feedback"">
                            Mật khẩu hợp lệ.
                        </div>
                        <div class=""invalid-feedback"">
                            Mật khẩu không hợp lệ.
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label for=""exampleInputPassword2"">Xác nhận mật khẩu</label");
                WriteLiteral(@">
                        <input type=""text"" class=""form-control rad-border-15px"" id=""exampleInputPassword2"" placeholder=""Nhập mật khẩu"" required>
                        <div class=""valid-feedback"">
                            Mật khẩu trùng khớp.
                        </div>
                        <div class=""invalid-feedback"">
                            Mật khẩu không trùng khớp.
                        </div>
                    </div>

                    <div class=""form-group form-check"">
                        <input type=""checkbox"" class=""form-check-input"" id=""exampleCheck1"">
                        <label class=""form-check-label"" for=""exampleCheck1"">Ghi nhớ đăng nhập</label>
                    </div>
                    <button type=""submit"" class=""btn btn-primary"">Đăng nhập</button>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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

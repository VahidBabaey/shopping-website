#pragma checksum "E:\projects\web3\Shop\Areas\Admin\Views\Shared\Components\AdminMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c71f1bd25ce7a8fd9ff924f39735bb0ea18f9e4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_AdminMenu_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/AdminMenu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/Components/AdminMenu/Default.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared_Components_AdminMenu_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c71f1bd25ce7a8fd9ff924f39735bb0ea18f9e4e", @"/Areas/Admin/Views/Shared/Components/AdminMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a137d6b7e34ce471addfa227493297504d67088", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components_AdminMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/action_page.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 101, true);
            WriteLiteral("\r\n<div class=\"col d-sm-none d-block bg-dark\">\r\n    <nav class=\"navbar bg-dark navbar-dark\">\r\n        ");
            EndContext();
            BeginContext(101, 269, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba0aab37ece04876ba10ce9045c5c46c", async() => {
                BeginContext(153, 210, true);
                WriteLiteral("\r\n            <div class=\"input-group\">\r\n                <button class=\"btn btn-danger\">جستجو</button>\r\n                <input type=\"text\" class=\"form-control\" placeholder=\"جستجو\">\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(370, 4501, true);
            WriteLiteral(@"
    </nav>
    <nav class=""navbar navbar-expand-md bg-dark navbar-dark"">

        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#collapsibleNavbar"">
            <span class=""navbar-toggler-icon""></span>
        </button>

        <!-- Navbar links -->
        <div class=""collapse navbar-collapse"" id=""collapsibleNavbar"">


            <ul class=""navbar-nav"">

                <li class=""nav-item dropdown"">
                    <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbardrop"" data-toggle=""dropdown"">
                        کاتالوگ
                    </a>
                    <div class=""dropdown-menu"">
                        <a class=""dropdown-item"" href=""#"">محصولات</a>
                        <a class=""dropdown-item"" href=""#"">دسته ها</a>

                    </div>
                </li>
                <li class=""nav-item dropdown"">
                    <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbardrop"" data-toggle=""dropdown"">
  ");
            WriteLiteral(@"                      مشتریان
                    </a>
                    <div class=""dropdown-menu"">
                        <a class=""dropdown-item"" href=""/Admin/Customer/List"">مدیریت مشتریان</a>
                        <a class=""dropdown-item"" href=""#"">گزارش مشتریان</a>

                    </div>
                </li>
                <li class=""nav-item dropdown"">
                    <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbardrop"" data-toggle=""dropdown"">
                        فروش
                    </a>
                    <div class=""dropdown-menu"">
                        <a class=""dropdown-item"" href=""#"">سفارشات</a>
                        <a class=""dropdown-item"" href=""#"">مرسوله ها</a>
                    </div>
                </li>
                <li class=""nav-item dropdown"">
                    <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbardrop"" data-toggle=""dropdown"">
                        پیکربندی
                    </a>
                    <di");
            WriteLiteral(@"v class=""dropdown-menu"">
                        <a class=""dropdown-item"" href=""#"">تنظیمات مشتری</a>
                        <a class=""dropdown-item"" href=""#"">تنظیمات صفحه اصلی</a>
                    </div>
                </li>
            </ul>
        </div>
    </nav>
</div>

<div class=""col-sm-5 col-md-4 col-lg-3 col-xl-2 d-none d-sm-block bg-dark"" style=""height:700px;"">


    <nav class=""navbar navbar-dark "">
        <div class=""input-group"">
            <button class=""btn btn-danger"">جستجو</button>
            <input type=""text"" class=""form-control"" placeholder=""جستجو"">
        </div>
        <ul class=""navbar-nav"">

            <li class=""nav-item dropdown"">
                <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbardrop"" data-toggle=""dropdown"">
                    کاتالوگ
                </a>
                <div class=""dropdown-menu"">
                    <a class=""dropdown-item"" href=""/Admin/Product/Index"">محصولات</a>
                    <a class=""dropdown-item");
            WriteLiteral(@""" href=""/Admin/Category/Index"">دسته ها</a>
                </div>
            </li>
            <li class=""nav-item dropdown"">
                <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbardrop"" data-toggle=""dropdown"">
                    مشتریان
                </a>
                <div class=""dropdown-menu"">
                    <a class=""dropdown-item"" href=""/Admin/Customer/List"">مدیریت مشتریان</a>
                    <a class=""dropdown-item"" href=""#"">گزارش مشتریان</a>

                </div>
            </li>
            <li class=""nav-item dropdown"">
                <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbardrop"" data-toggle=""dropdown"">
                    فروش
                </a>
                <div class=""dropdown-menu"">
                    <a class=""dropdown-item"" href=""#"">سفارشات</a>
                    <a class=""dropdown-item"" href=""#"">مرسوله ها</a>
                </div>
            </li>
            <li class=""nav-item dropdown"">
                <a cla");
            WriteLiteral(@"ss=""nav-link dropdown-toggle"" href=""#"" id=""navbardrop"" data-toggle=""dropdown"">
                    پیکربندی
                </a>
                <div class=""dropdown-menu"">
                    <a class=""dropdown-item"" href=""#"">تنظیمات مشتری</a>
                    <a class=""dropdown-item"" href=""#"">تنظیمات صفحه اصلی</a>
                </div>
            </li>
        </ul>

    </nav>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

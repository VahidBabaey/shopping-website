#pragma checksum "E:\projects\web3\Shop\Views\Catalog\_PictureBox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b447f3e3cd4577ea0aff470bd298c48a0d0c2e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog__PictureBox), @"mvc.1.0.view", @"/Views/Catalog/_PictureBox.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Catalog/_PictureBox.cshtml", typeof(AspNetCore.Views_Catalog__PictureBox))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b447f3e3cd4577ea0aff470bd298c48a0d0c2e4", @"/Views/Catalog/_PictureBox.cshtml")]
    public class Views_Catalog__PictureBox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.ProductItemModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 75, true);
            WriteLiteral("\r\n<div class=\"card p-0\" style=\"width:100%;\">\r\n    <img class=\"card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 107, "\"", 128, 1);
#line 4 "E:\projects\web3\Shop\Views\Catalog\_PictureBox.cshtml"
WriteAttributeValue("", 113, Model.Imageurl, 113, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 129, "\"", 146, 1);
#line 4 "E:\projects\web3\Shop\Views\Catalog\_PictureBox.cshtml"
WriteAttributeValue("", 135, Model.Name, 135, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(147, 48, true);
            WriteLiteral(" style=\"height:200px;width:100%;cursor:pointer;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 195, "\"", 241, 3);
            WriteAttributeValue("", 205, "location.href=\'/Catalog/", 205, 24, true);
#line 4 "E:\projects\web3\Shop\Views\Catalog\_PictureBox.cshtml"
WriteAttributeValue("", 229, Model.Name, 229, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 240, "\'", 240, 1, true);
            EndWriteAttribute();
            BeginContext(242, 63, true);
            WriteLiteral(">\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">");
            EndContext();
            BeginContext(306, 10, false);
#line 6 "E:\projects\web3\Shop\Views\Catalog\_PictureBox.cshtml"
                          Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(316, 42, true);
            WriteLiteral("</h5>\r\n        <p class=\"card-text\">قیمت: ");
            EndContext();
            BeginContext(359, 11, false);
#line 7 "E:\projects\web3\Shop\Views\Catalog\_PictureBox.cshtml"
                              Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(370, 122, true);
            WriteLiteral("</p>\r\n        <p class=\"card-text\">قیمت قدیم: <span style=\"text-decoration-line:line-through; text-decoration-color:red;\">");
            EndContext();
            BeginContext(493, 14, false);
#line 8 "E:\projects\web3\Shop\Views\Catalog\_PictureBox.cshtml"
                                                                                                               Write(Model.OldPrice);

#line default
#line hidden
            EndContext();
            BeginContext(507, 357, true);
            WriteLiteral(@"</span></p>
        <div class=""btn-group"">
            <button class=""btn btn-sm btn-primary""><i class=""fa fa-shopping-cart""></i><span class=""d-sm-block d-none"">اضافه</span></button>
            <button class=""btn btn-sm btn-success""><i class=""fa fa-plane""></i><span class=""d-sm-block d-none"">مقایسه</span></button>

        </div>
    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.ProductItemModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

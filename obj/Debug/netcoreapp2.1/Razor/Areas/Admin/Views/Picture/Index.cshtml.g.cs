#pragma checksum "E:\projects\web3\Shop\Areas\Admin\Views\Picture\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3da9f41d038aa9cc6a5b78e0ad9ee00bffa4c555"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Picture_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Picture/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Picture/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Picture_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3da9f41d038aa9cc6a5b78e0ad9ee00bffa4c555", @"/Areas/Admin/Views/Picture/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a137d6b7e34ce471addfa227493297504d67088", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Picture_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\projects\web3\Shop\Areas\Admin\Views\Picture\Index.cshtml"
  
    var idfile = Model + "file";
    var idpic = Model + "pic";
    var idprogree = Model + "progress-dev";

#line default
#line hidden
            BeginContext(133, 20, true);
            WriteLiteral("\r\n<input type=\"file\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 153, "\"", 165, 1);
#line 8 "E:\projects\web3\Shop\Areas\Admin\Views\Picture\Index.cshtml"
WriteAttributeValue("", 158, idfile, 158, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(166, 88, true);
            WriteLiteral(" style=\"display:none\" />\r\n<i class=\"fa fa-upload\" style=\"font-size:25px;cursor:pointer;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 254, "\"", 313, 4);
            WriteAttributeValue("", 264, "return", 264, 6, true);
            WriteAttributeValue(" ", 270, "document.getElementById(\'", 271, 26, true);
#line 9 "E:\projects\web3\Shop\Areas\Admin\Views\Picture\Index.cshtml"
WriteAttributeValue("", 296, idfile, 296, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 303, "\').click()", 303, 10, true);
            EndWriteAttribute();
            BeginContext(314, 11, true);
            WriteLiteral("></i>\r\n<img");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 325, "\"", 336, 1);
#line 10 "E:\projects\web3\Shop\Areas\Admin\Views\Picture\Index.cshtml"
WriteAttributeValue("", 330, idpic, 330, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(337, 47, true);
            WriteLiteral(" style=\"height:60px;width:60px;cursor:pointer;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 384, "\"", 460, 3);
            WriteAttributeValue("", 394, "window.open(document.getElementById(\'", 394, 37, true);
#line 10 "E:\projects\web3\Shop\Areas\Admin\Views\Picture\Index.cshtml"
WriteAttributeValue("", 431, idpic, 431, 6, false);

#line default
#line hidden
            WriteAttributeValue("", 437, "\').getAttribute(\'src\'))", 437, 23, true);
            EndWriteAttribute();
            BeginContext(461, 24, true);
            WriteLiteral("/>\r\n<input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 485, "\"", 496, 1);
#line 11 "E:\projects\web3\Shop\Areas\Admin\Views\Picture\Index.cshtml"
WriteAttributeValue("", 490, Model, 490, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(497, 83, true);
            WriteLiteral("/>\r\n<div class=\"progress mt-1\" style=\"width:150px;\">\r\n    <div class=\"progress-bar\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 580, "\"", 595, 1);
#line 13 "E:\projects\web3\Shop\Areas\Admin\Views\Picture\Index.cshtml"
WriteAttributeValue("", 585, idprogree, 585, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(596, 207, true);
            WriteLiteral(" role=\"progressbar\" aria-valuenow=\"0\"\r\n         aria-valuemin=\"0\" aria-valuemax=\"100\" style=\"width:0%\">\r\n        <span class=\"sr-only\"></span>\r\n    </div>\r\n</div>\r\n\r\n\r\n<script>\r\n    document.getElementById(\'");
            EndContext();
            BeginContext(804, 6, false);
#line 21 "E:\projects\web3\Shop\Areas\Admin\Views\Picture\Index.cshtml"
                        Write(idfile);

#line default
#line hidden
            EndContext();
            BeginContext(810, 213, true);
            WriteLiteral("\').addEventListener(\"change\", function () {\r\n\r\n        var file = this.files[0];\r\n        var upload = new Upload(file, \"/Admin/Picture/AsyncUploadPicture\", function (data) {\r\n            document.getElementById(\'");
            EndContext();
            BeginContext(1024, 5, false);
#line 25 "E:\projects\web3\Shop\Areas\Admin\Views\Picture\Index.cshtml"
                                Write(idpic);

#line default
#line hidden
            EndContext();
            BeginContext(1029, 95, true);
            WriteLiteral("\').setAttribute(\'src\', \'/Pictures/\' + data.id + \'.jpg\');\r\n            document.getElementById(\'");
            EndContext();
            BeginContext(1125, 5, false);
#line 26 "E:\projects\web3\Shop\Areas\Admin\Views\Picture\Index.cshtml"
                                Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(1130, 38, true);
            WriteLiteral("\').value = data.id;\r\n\r\n            },\'");
            EndContext();
            BeginContext(1169, 9, false);
#line 28 "E:\projects\web3\Shop\Areas\Admin\Views\Picture\Index.cshtml"
          Write(idprogree);

#line default
#line hidden
            EndContext();
            BeginContext(1178, 337, true);
            WriteLiteral(@"');

            if (upload.getType() != ""image/jpeg"") {
                alert(""فرمت عکس صحیح نیست"");
                return;
            }
            if (upload.getSize()>1000000) {
                alert(""اندازه فایل بزرگ است"");
                return;
            }

            upload.devsharpUpload();
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591

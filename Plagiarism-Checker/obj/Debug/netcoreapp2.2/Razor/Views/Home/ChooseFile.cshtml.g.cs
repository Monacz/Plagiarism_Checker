#pragma checksum "C:\Users\Misha Demchyshyn\Desktop\універ\.net\project\Plagiarism_Checker\Plagiarism-Checker\Views\Home\ChooseFile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d24eca05d6c66c7f063df0a2b279456855ca1df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ChooseFile), @"mvc.1.0.view", @"/Views/Home/ChooseFile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ChooseFile.cshtml", typeof(AspNetCore.Views_Home_ChooseFile))]
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
#line 1 "C:\Users\Misha Demchyshyn\Desktop\універ\.net\project\Plagiarism_Checker\Plagiarism-Checker\Views\_ViewImports.cshtml"
using Plagiarism_Checker;

#line default
#line hidden
#line 2 "C:\Users\Misha Demchyshyn\Desktop\універ\.net\project\Plagiarism_Checker\Plagiarism-Checker\Views\_ViewImports.cshtml"
using Plagiarism_Checker.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d24eca05d6c66c7f063df0a2b279456855ca1df", @"/Views/Home/ChooseFile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4629291b9607b6f696e738bdc026a069f08427a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ChooseFile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Misha Demchyshyn\Desktop\універ\.net\project\Plagiarism_Checker\Plagiarism-Checker\Views\Home\ChooseFile.cshtml"
  
    ViewBag.Title = "Add File";

#line default
#line hidden
            BeginContext(40, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 6 "C:\Users\Misha Demchyshyn\Desktop\універ\.net\project\Plagiarism_Checker\Plagiarism-Checker\Views\Home\ChooseFile.cshtml"
 using (Html.BeginForm("AddFile", "Home", FormMethod.Post, new { enctype = "multipart/form-data" }))
{


#line default
#line hidden
            BeginContext(151, 8, true);
            WriteLiteral("    <h1>");
            EndContext();
            BeginContext(160, 18, false);
#line 9 "C:\Users\Misha Demchyshyn\Desktop\універ\.net\project\Plagiarism_Checker\Plagiarism-Checker\Views\Home\ChooseFile.cshtml"
   Write(Html.Label("File"));

#line default
#line hidden
            EndContext();
            BeginContext(178, 52, true);
            WriteLiteral("</h1>\r\n    <table>\r\n\r\n        <tr>\r\n            <td>");
            EndContext();
            BeginContext(231, 18, false);
#line 13 "C:\Users\Misha Demchyshyn\Desktop\універ\.net\project\Plagiarism_Checker\Plagiarism-Checker\Views\Home\ChooseFile.cshtml"
           Write(Html.Label("file"));

#line default
#line hidden
            EndContext();
            BeginContext(249, 203, true);
            WriteLiteral("</td>\r\n            <td><input type=\"file\" name=\"files\" multiple /><br></td>\r\n        </tr>\r\n\r\n\r\n\r\n\r\n\r\n    </table>\r\n    <p><input type=\"submit\" value=\"Submit\" /><input type=\"reset\" value=\"Reset\" /></p>\r\n");
            EndContext();
#line 23 "C:\Users\Misha Demchyshyn\Desktop\універ\.net\project\Plagiarism_Checker\Plagiarism-Checker\Views\Home\ChooseFile.cshtml"
}

#line default
#line hidden
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

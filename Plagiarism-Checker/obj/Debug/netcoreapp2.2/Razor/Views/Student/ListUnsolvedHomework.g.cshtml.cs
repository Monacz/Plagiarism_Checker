#pragma checksum "D:\3 курс\_Net\Plagiarism-Checker-Nataha\Plagiarism-Checker\Views\Student\ListUnsolvedHomework.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc4122992c30fee19ad3cd5b5a7488d1657a0b4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_ListUnsolvedHomework), @"mvc.1.0.view", @"/Views/Student/ListUnsolvedHomework.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/ListUnsolvedHomework.cshtml", typeof(AspNetCore.Views_Student_ListUnsolvedHomework))]
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
#line 1 "D:\3 курс\_Net\Plagiarism-Checker-Nataha\Plagiarism-Checker\Views\_ViewImports.cshtml"
using Plagiarism_Checker;

#line default
#line hidden
#line 2 "D:\3 курс\_Net\Plagiarism-Checker-Nataha\Plagiarism-Checker\Views\_ViewImports.cshtml"
using Plagiarism_Checker.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc4122992c30fee19ad3cd5b5a7488d1657a0b4b", @"/Views/Student/ListUnsolvedHomework.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4629291b9607b6f696e738bdc026a069f08427a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_ListUnsolvedHomework : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Plagiarism_Checker.Models.Student._FullTask>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\3 курс\_Net\Plagiarism-Checker-Nataha\Plagiarism-Checker\Views\Student\ListUnsolvedHomework.cshtml"
  
    ViewData["Title"] = "UnsolvedHomework";
    Layout = "~/Views/Shared/_StudentLayout.cshtml";

#line default
#line hidden
            BeginContext(166, 98, true);
            WriteLiteral("\r\n<div class=\"largeDarkDiv\" style=\"flex-direction:column;\">\r\n    <h2>Невиконанані завдання:</h2>\r\n");
            EndContext();
#line 10 "D:\3 курс\_Net\Plagiarism-Checker-Nataha\Plagiarism-Checker\Views\Student\ListUnsolvedHomework.cshtml"
     foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(309, 200, true);
            WriteLiteral("            <div style=\"width:80%;height:180px;margin-bottom:20px;border:solid;border-width:1px\">\r\n                <div style=\"background-color:#d8d8d8\">\r\n                    <p style=\"color:#000000\">");
            EndContext();
            BeginContext(510, 21, false);
#line 14 "D:\3 курс\_Net\Plagiarism-Checker-Nataha\Plagiarism-Checker\Views\Student\ListUnsolvedHomework.cshtml"
                                        Write(item.NameOfDiscipline);

#line default
#line hidden
            EndContext();
            BeginContext(531, 87, true);
            WriteLiteral("</p>\r\n                </div>\r\n                <p style=\"color:#d8d8d8; font-size:13px\">");
            EndContext();
            BeginContext(619, 33, false);
#line 16 "D:\3 курс\_Net\Plagiarism-Checker-Nataha\Plagiarism-Checker\Views\Student\ListUnsolvedHomework.cshtml"
                                                    Write(item.TaskAssignment.Requirenments);

#line default
#line hidden
            EndContext();
            BeginContext(652, 90, true);
            WriteLiteral("</p>\r\n                <p style=\"color:#555454; font-size:10px; justify-content:flex-end;\">");
            EndContext();
            BeginContext(743, 11, false);
#line 17 "D:\3 курс\_Net\Plagiarism-Checker-Nataha\Plagiarism-Checker\Views\Student\ListUnsolvedHomework.cshtml"
                                                                               Write(item.Lector);

#line default
#line hidden
            EndContext();
            BeginContext(754, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(758, 9, false);
#line 17 "D:\3 курс\_Net\Plagiarism-Checker-Nataha\Plagiarism-Checker\Views\Student\ListUnsolvedHomework.cshtml"
                                                                                              Write(item.Time);

#line default
#line hidden
            EndContext();
            BeginContext(767, 241, true);
            WriteLiteral("</p>\r\n\r\n                <div style=\"display: flex;justify-content: center;margin-top:8px\">\r\n                    <button style=\"        font-size: 6px;\r\n        padding: 0.0025em 0.75em;\r\n        border: none;\r\n\" type=\"submit\" class=\"button2\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1008, "\"", 1103, 3);
            WriteAttributeValue("", 1018, "location.href=\'", 1018, 15, true);
#line 23 "D:\3 курс\_Net\Plagiarism-Checker-Nataha\Plagiarism-Checker\Views\Student\ListUnsolvedHomework.cshtml"
WriteAttributeValue("", 1033, Url.Action("AddSolutionPage", "Student", new { id = item._Task.Id }), 1033, 69, false);

#line default
#line hidden
            WriteAttributeValue("", 1102, "\'", 1102, 1, true);
            EndWriteAttribute();
            BeginContext(1104, 116, true);
            WriteLiteral(" >Виконати</button>\r\n\r\n                </div>\r\n                <div style=\"clear:both;\"></div>\r\n            </div>\r\n");
            EndContext();
#line 28 "D:\3 курс\_Net\Plagiarism-Checker-Nataha\Plagiarism-Checker\Views\Student\ListUnsolvedHomework.cshtml"
        }

#line default
#line hidden
            BeginContext(1231, 13, true);
            WriteLiteral("\r\n    <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1244, "\"", 1301, 3);
            WriteAttributeValue("", 1254, "location.href=\'", 1254, 15, true);
#line 30 "D:\3 курс\_Net\Plagiarism-Checker-Nataha\Plagiarism-Checker\Views\Student\ListUnsolvedHomework.cshtml"
WriteAttributeValue("", 1269, Url.Action("Index", "Student"), 1269, 31, false);

#line default
#line hidden
            WriteAttributeValue("", 1300, "\'", 1300, 1, true);
            EndWriteAttribute();
            BeginContext(1302, 44, true);
            WriteLiteral(" class=\"button2\">НА ГОЛОВНУ</button>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Plagiarism_Checker.Models.Student._FullTask>> Html { get; private set; }
    }
}
#pragma warning restore 1591

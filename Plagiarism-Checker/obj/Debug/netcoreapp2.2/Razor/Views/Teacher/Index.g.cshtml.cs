#pragma checksum "D:\3 курс\_Net\Plagiarism-Checker-Nataha\Plagiarism-Checker\Views\Teacher\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18a095236119aaf41a430de580644f6323850a9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_Index), @"mvc.1.0.view", @"/Views/Teacher/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Teacher/Index.cshtml", typeof(AspNetCore.Views_Teacher_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18a095236119aaf41a430de580644f6323850a9f", @"/Views/Teacher/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4629291b9607b6f696e738bdc026a069f08427a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Plagiarism_Checker.Models.Teacher.TeacherTasks>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\3 курс\_Net\Plagiarism-Checker-Nataha\Plagiarism-Checker\Views\Teacher\Index.cshtml"
  
    Layout = "~/Views/Shared/_TeacherLayout.cshtml";

#line default
#line hidden
            BeginContext(118, 28, true);
            WriteLiteral("\r\n\r\n\r\n<h1>Головна</h1>\r\n<div");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 146, "\"", 210, 3);
            WriteAttributeValue("", 156, "location.href=\'", 156, 15, true);
#line 10 "D:\3 курс\_Net\Plagiarism-Checker-Nataha\Plagiarism-Checker\Views\Teacher\Index.cshtml"
WriteAttributeValue("", 171, Url.Action("ListSubjects", "Teacher"), 171, 38, false);

#line default
#line hidden
            WriteAttributeValue("", 209, "\'", 209, 1, true);
            EndWriteAttribute();
            BeginContext(211, 295, true);
            WriteLiteral(@" style=""min-height: 80px;
    background: #333333;
    justify-content: center;
    padding: 2em;"">
    <h2 style=""color: whitesmoke; cursor:pointer;"">ПЕРЕЛІК ДИСЦИПЛІН</h2>
</div>
<div class=""largeDarkDiv"" style=""flex-direction: column;margin: 5em;"">
    <h2>Найближчі самостійні:</h2>
");
            EndContext();
#line 18 "D:\3 курс\_Net\Plagiarism-Checker-Nataha\Plagiarism-Checker\Views\Teacher\Index.cshtml"
     foreach (var item in Model.Tests)
    {

#line default
#line hidden
            BeginContext(553, 188, true);
            WriteLiteral("        <div style=\"width:80%;height:180px;margin-bottom:20px;border:solid;border-width:1px\">\r\n            <div style=\"background-color:#d8d8d8\">\r\n                <p style=\"color:#000000\">");
            EndContext();
            BeginContext(742, 21, false);
#line 22 "D:\3 курс\_Net\Plagiarism-Checker-Nataha\Plagiarism-Checker\Views\Teacher\Index.cshtml"
                                    Write(item.NameOfDiscipline);

#line default
#line hidden
            EndContext();
            BeginContext(763, 79, true);
            WriteLiteral("</p>\r\n            </div>\r\n            <p style=\"color:#d8d8d8; font-size:13px\">");
            EndContext();
            BeginContext(843, 33, false);
#line 24 "D:\3 курс\_Net\Plagiarism-Checker-Nataha\Plagiarism-Checker\Views\Teacher\Index.cshtml"
                                                Write(item.TaskAssignment.Requirenments);

#line default
#line hidden
            EndContext();
            BeginContext(876, 86, true);
            WriteLiteral("</p>\r\n            <p style=\"color:#555454; font-size:10px; justify-content:flex-end;\">");
            EndContext();
            BeginContext(963, 10, false);
#line 25 "D:\3 курс\_Net\Plagiarism-Checker-Nataha\Plagiarism-Checker\Views\Teacher\Index.cshtml"
                                                                           Write(item.Group);

#line default
#line hidden
            EndContext();
            BeginContext(973, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(977, 9, false);
#line 25 "D:\3 курс\_Net\Plagiarism-Checker-Nataha\Plagiarism-Checker\Views\Teacher\Index.cshtml"
                                                                                         Write(item.Time);

#line default
#line hidden
            EndContext();
            BeginContext(986, 202, true);
            WriteLiteral("</p>\r\n\r\n            <div style=\"display: flex;justify-content: center;margin-top:8px\">\r\n                <button style=\"font-size:6px; padding:0.0025em 0.75em; border:none;\" type=\"submit\" class=\"button2\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1188, "\"", 1283, 3);
            WriteAttributeValue("", 1198, "location.href=\'", 1198, 15, true);
#line 28 "D:\3 курс\_Net\Plagiarism-Checker-Nataha\Plagiarism-Checker\Views\Teacher\Index.cshtml"
WriteAttributeValue("", 1213, Url.Action("AddSolutionPage", "Student", new { id = item._Task.Id }), 1213, 69, false);

#line default
#line hidden
            WriteAttributeValue("", 1282, "\'", 1282, 1, true);
            EndWriteAttribute();
            BeginContext(1284, 106, true);
            WriteLiteral(">Переглянути</button>\r\n\r\n            </div>\r\n            <div style=\"clear:both;\"></div>\r\n        </div>\r\n");
            EndContext();
#line 33 "D:\3 курс\_Net\Plagiarism-Checker-Nataha\Plagiarism-Checker\Views\Teacher\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1397, 7, true);
            WriteLiteral("<button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1404, "\"", 1465, 3);
            WriteAttributeValue("", 1414, "location.href=\'", 1414, 15, true);
#line 34 "D:\3 курс\_Net\Plagiarism-Checker-Nataha\Plagiarism-Checker\Views\Teacher\Index.cshtml"
WriteAttributeValue("", 1429, Url.Action("ListTests", "Teacher"), 1429, 35, false);

#line default
#line hidden
            WriteAttributeValue("", 1464, "\'", 1464, 1, true);
            EndWriteAttribute();
            BeginContext(1466, 100, true);
            WriteLiteral(" class=\"button2\">УСІ НАЙБЛИЖЧІ САМОСТІЙНІ</button>\r\n</div>\r\n<div style=\"display: flex\">\r\n    <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1566, "\"", 1630, 3);
            WriteAttributeValue("", 1576, "location.href=\'", 1576, 15, true);
#line 37 "D:\3 курс\_Net\Plagiarism-Checker-Nataha\Plagiarism-Checker\Views\Teacher\Index.cshtml"
WriteAttributeValue("", 1591, Url.Action("ListHomework", "Teacher"), 1591, 38, false);

#line default
#line hidden
            WriteAttributeValue("", 1629, "\'", 1629, 1, true);
            EndWriteAttribute();
            BeginContext(1631, 65, true);
            WriteLiteral(" class=\"button2\">ПЕРЕГЛЯНУТИ ГОТОВІ ДОМАШНІ</button>\r\n    <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1696, "\"", 1763, 3);
            WriteAttributeValue("", 1706, "location.href=\'", 1706, 15, true);
#line 38 "D:\3 курс\_Net\Plagiarism-Checker-Nataha\Plagiarism-Checker\Views\Teacher\Index.cshtml"
WriteAttributeValue("", 1721, Url.Action("ListSolvedTests", "Teacher"), 1721, 41, false);

#line default
#line hidden
            WriteAttributeValue("", 1762, "\'", 1762, 1, true);
            EndWriteAttribute();
            BeginContext(1764, 68, true);
            WriteLiteral(" class=\"button2\">ПЕРЕГЛЯНУТИ ГОТОВІ САМОСТІЙНІ</button>\r\n    <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1832, "\"", 1891, 3);
            WriteAttributeValue("", 1842, "location.href=\'", 1842, 15, true);
#line 39 "D:\3 курс\_Net\Plagiarism-Checker-Nataha\Plagiarism-Checker\Views\Teacher\Index.cshtml"
WriteAttributeValue("", 1857, Url.Action("AddTask", "Teacher"), 1857, 33, false);

#line default
#line hidden
            WriteAttributeValue("", 1890, "\'", 1890, 1, true);
            EndWriteAttribute();
            BeginContext(1892, 85, true);
            WriteLiteral(" class=\"button2\">ДОДАТИ ДОМАШНЄ ЗАВДАННЯ/САМОСТІЙНУ РОБОТУ</button>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Plagiarism_Checker.Models.Teacher.TeacherTasks> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Administrator\Documents\GitHub\net\Plagiarism_Checker\Plagiarism-Checker\Views\Teacher\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d51f2255ab72b7fbfd5d8fc8cf01ebee3c0cd839"
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
#line 1 "C:\Users\Administrator\Documents\GitHub\net\Plagiarism_Checker\Plagiarism-Checker\Views\_ViewImports.cshtml"
using Plagiarism_Checker;

#line default
#line hidden
#line 2 "C:\Users\Administrator\Documents\GitHub\net\Plagiarism_Checker\Plagiarism-Checker\Views\_ViewImports.cshtml"
using Plagiarism_Checker.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d51f2255ab72b7fbfd5d8fc8cf01ebee3c0cd839", @"/Views/Teacher/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4629291b9607b6f696e738bdc026a069f08427a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Plagiarism_Checker.Models.Student.StudentTasks>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Administrator\Documents\GitHub\net\Plagiarism_Checker\Plagiarism-Checker\Views\Teacher\Index.cshtml"
  
    Layout = "~/Views/Shared/_TeacherLayout.cshtml";

#line default
#line hidden
            BeginContext(118, 28, true);
            WriteLiteral("\r\n\r\n\r\n<h1>Головна</h1>\r\n<div");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 146, "\"", 210, 3);
            WriteAttributeValue("", 156, "location.href=\'", 156, 15, true);
#line 10 "C:\Users\Administrator\Documents\GitHub\net\Plagiarism_Checker\Plagiarism-Checker\Views\Teacher\Index.cshtml"
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
#line 18 "C:\Users\Administrator\Documents\GitHub\net\Plagiarism_Checker\Plagiarism-Checker\Views\Teacher\Index.cshtml"
     foreach (var item in Model.Tests)
    {

#line default
#line hidden
            BeginContext(553, 188, true);
            WriteLiteral("        <div style=\"width:80%;height:180px;margin-bottom:20px;border:solid;border-width:1px\">\r\n            <div style=\"background-color:#d8d8d8\">\r\n                <p style=\"color:#000000\">");
            EndContext();
            BeginContext(742, 21, false);
#line 22 "C:\Users\Administrator\Documents\GitHub\net\Plagiarism_Checker\Plagiarism-Checker\Views\Teacher\Index.cshtml"
                                    Write(item.NameOfDiscipline);

#line default
#line hidden
            EndContext();
            BeginContext(763, 79, true);
            WriteLiteral("</p>\r\n            </div>\r\n            <p style=\"color:#d8d8d8; font-size:13px\">");
            EndContext();
            BeginContext(843, 33, false);
#line 24 "C:\Users\Administrator\Documents\GitHub\net\Plagiarism_Checker\Plagiarism-Checker\Views\Teacher\Index.cshtml"
                                                Write(item.TaskAssignment.Requirenments);

#line default
#line hidden
            EndContext();
            BeginContext(876, 86, true);
            WriteLiteral("</p>\r\n            <p style=\"color:#555454; font-size:10px; justify-content:flex-end;\">");
            EndContext();
            BeginContext(963, 11, false);
#line 25 "C:\Users\Administrator\Documents\GitHub\net\Plagiarism_Checker\Plagiarism-Checker\Views\Teacher\Index.cshtml"
                                                                           Write(item.Lector);

#line default
#line hidden
            EndContext();
            BeginContext(974, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(978, 9, false);
#line 25 "C:\Users\Administrator\Documents\GitHub\net\Plagiarism_Checker\Plagiarism-Checker\Views\Teacher\Index.cshtml"
                                                                                          Write(item.Time);

#line default
#line hidden
            EndContext();
            BeginContext(987, 202, true);
            WriteLiteral("</p>\r\n\r\n            <div style=\"display: flex;justify-content: center;margin-top:8px\">\r\n                <button style=\"font-size:6px; padding:0.0025em 0.75em; border:none;\" type=\"submit\" class=\"button2\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1189, "\"", 1284, 3);
            WriteAttributeValue("", 1199, "location.href=\'", 1199, 15, true);
#line 28 "C:\Users\Administrator\Documents\GitHub\net\Plagiarism_Checker\Plagiarism-Checker\Views\Teacher\Index.cshtml"
WriteAttributeValue("", 1214, Url.Action("AddSolutionPage", "Student", new { id = item._Task.Id }), 1214, 69, false);

#line default
#line hidden
            WriteAttributeValue("", 1283, "\'", 1283, 1, true);
            EndWriteAttribute();
            BeginContext(1285, 106, true);
            WriteLiteral(">Переглянути</button>\r\n\r\n            </div>\r\n            <div style=\"clear:both;\"></div>\r\n        </div>\r\n");
            EndContext();
#line 33 "C:\Users\Administrator\Documents\GitHub\net\Plagiarism_Checker\Plagiarism-Checker\Views\Teacher\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1398, 7, true);
            WriteLiteral("<button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1405, "\"", 1469, 3);
            WriteAttributeValue("", 1415, "location.href=\'", 1415, 15, true);
#line 34 "C:\Users\Administrator\Documents\GitHub\net\Plagiarism_Checker\Plagiarism-Checker\Views\Teacher\Index.cshtml"
WriteAttributeValue("", 1430, Url.Action("ListTestWork", "Teacher"), 1430, 38, false);

#line default
#line hidden
            WriteAttributeValue("", 1468, "\'", 1468, 1, true);
            EndWriteAttribute();
            BeginContext(1470, 67, true);
            WriteLiteral(" class=\"button2\">УСІ НАЙБЛИЖЧІ САМОСТІЙНІ</button>\r\n</div>\r\n<button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1537, "\"", 1601, 3);
            WriteAttributeValue("", 1547, "location.href=\'", 1547, 15, true);
#line 36 "C:\Users\Administrator\Documents\GitHub\net\Plagiarism_Checker\Plagiarism-Checker\Views\Teacher\Index.cshtml"
WriteAttributeValue("", 1562, Url.Action("ListHomework", "Teacher"), 1562, 38, false);

#line default
#line hidden
            WriteAttributeValue("", 1600, "\'", 1600, 1, true);
            EndWriteAttribute();
            BeginContext(1602, 61, true);
            WriteLiteral(" class=\"button2\">ПЕРЕГЛЯНУТИ ГОТОВІ ДОМАШНІ</button>\r\n<button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1663, "\"", 1730, 3);
            WriteAttributeValue("", 1673, "location.href=\'", 1673, 15, true);
#line 37 "C:\Users\Administrator\Documents\GitHub\net\Plagiarism_Checker\Plagiarism-Checker\Views\Teacher\Index.cshtml"
WriteAttributeValue("", 1688, Url.Action("ListSolvedTests", "Teacher"), 1688, 41, false);

#line default
#line hidden
            WriteAttributeValue("", 1729, "\'", 1729, 1, true);
            EndWriteAttribute();
            BeginContext(1731, 67, true);
            WriteLiteral(" class=\"button2\">ПЕРЕГЛЯНУТИ ГОТОВІ САМОСТІЙНІ</button>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Plagiarism_Checker.Models.Student.StudentTasks> Html { get; private set; }
    }
}
#pragma warning restore 1591
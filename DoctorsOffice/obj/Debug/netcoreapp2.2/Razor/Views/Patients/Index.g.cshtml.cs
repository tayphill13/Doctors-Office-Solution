#pragma checksum "/Users/iangregg/Desktop/DoctorsOffice.solution/DoctorsOffice/Views/Patients/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adff7588794e8bb2f3f66a5dfd4e4b5ed5962810"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patients_Index), @"mvc.1.0.view", @"/Views/Patients/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Patients/Index.cshtml", typeof(AspNetCore.Views_Patients_Index))]
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
#line 5 "/Users/iangregg/Desktop/DoctorsOffice.solution/DoctorsOffice/Views/Patients/Index.cshtml"
using DoctorsOffice.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adff7588794e8bb2f3f66a5dfd4e4b5ed5962810", @"/Views/Patients/Index.cshtml")]
    public class Views_Patients_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DoctorsOffice.Models.Patient>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/iangregg/Desktop/DoctorsOffice.solution/DoctorsOffice/Views/Patients/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(100, 20, true);
            WriteLiteral("\n<h1>Patients</h1>\n\n");
            EndContext();
#line 10 "/Users/iangregg/Desktop/DoctorsOffice.solution/DoctorsOffice/Views/Patients/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(146, 44, true);
            WriteLiteral("  <h3>No patients have been added yet!</h3>\n");
            EndContext();
#line 13 "/Users/iangregg/Desktop/DoctorsOffice.solution/DoctorsOffice/Views/Patients/Index.cshtml"
} 

#line default
#line hidden
            BeginContext(193, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 15 "/Users/iangregg/Desktop/DoctorsOffice.solution/DoctorsOffice/Views/Patients/Index.cshtml"
 foreach (Patient patient in Model)
{

#line default
#line hidden
            BeginContext(232, 6, true);
            WriteLiteral("  <li>");
            EndContext();
            BeginContext(239, 77, false);
#line 17 "/Users/iangregg/Desktop/DoctorsOffice.solution/DoctorsOffice/Views/Patients/Index.cshtml"
 Write(Html.ActionLink($"{patient.Name}", "Details", new { id = patient.PatientId }));

#line default
#line hidden
            EndContext();
            BeginContext(316, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 18 "/Users/iangregg/Desktop/DoctorsOffice.solution/DoctorsOffice/Views/Patients/Index.cshtml"
}

#line default
#line hidden
            BeginContext(324, 45, true);
            WriteLiteral("<hr>\n<input type=\"button\" value=\"Add Patient\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 369, "\"", 429, 3);
            WriteAttributeValue("", 379, "location.href=\'", 379, 15, true);
#line 20 "/Users/iangregg/Desktop/DoctorsOffice.solution/DoctorsOffice/Views/Patients/Index.cshtml"
WriteAttributeValue("", 394, Url.Action("Create", "Patients"), 394, 33, false);

#line default
#line hidden
            WriteAttributeValue("", 427, "\';", 427, 2, true);
            EndWriteAttribute();
            BeginContext(430, 68, true);
            WriteLiteral(" class=\"btn btn-primary\" />\n<input type=\"button\" value=\"Return Home\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 498, "\"", 553, 3);
            WriteAttributeValue("", 508, "location.href=\'", 508, 15, true);
#line 21 "/Users/iangregg/Desktop/DoctorsOffice.solution/DoctorsOffice/Views/Patients/Index.cshtml"
WriteAttributeValue("", 523, Url.Action("Index", "Home"), 523, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 551, "\';", 551, 2, true);
            EndWriteAttribute();
            BeginContext(554, 27, true);
            WriteLiteral(" class=\"btn btn-primary\" />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DoctorsOffice.Models.Patient>> Html { get; private set; }
    }
}
#pragma warning restore 1591

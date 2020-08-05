#pragma checksum "/Users/iangregg/Desktop/DoctorsOffice.solution/DoctorsOffice/Views/Doctors/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15991714f8999c20318bc66eb993ede2abc072dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctors_Index), @"mvc.1.0.view", @"/Views/Doctors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Doctors/Index.cshtml", typeof(AspNetCore.Views_Doctors_Index))]
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
#line 5 "/Users/iangregg/Desktop/DoctorsOffice.solution/DoctorsOffice/Views/Doctors/Index.cshtml"
using DoctorsOffice.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15991714f8999c20318bc66eb993ede2abc072dc", @"/Views/Doctors/Index.cshtml")]
    public class Views_Doctors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DoctorsOffice.Models.Doctor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/iangregg/Desktop/DoctorsOffice.solution/DoctorsOffice/Views/Doctors/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(99, 19, true);
            WriteLiteral("\n<h1>Doctors</h1>\n\n");
            EndContext();
#line 10 "/Users/iangregg/Desktop/DoctorsOffice.solution/DoctorsOffice/Views/Doctors/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(144, 43, true);
            WriteLiteral("  <h3>No doctors have been added yet!</h3>\n");
            EndContext();
#line 13 "/Users/iangregg/Desktop/DoctorsOffice.solution/DoctorsOffice/Views/Doctors/Index.cshtml"
} 

#line default
#line hidden
            BeginContext(190, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 15 "/Users/iangregg/Desktop/DoctorsOffice.solution/DoctorsOffice/Views/Doctors/Index.cshtml"
 foreach (Doctor doctor in Model)
{

#line default
#line hidden
            BeginContext(227, 6, true);
            WriteLiteral("  <li>");
            EndContext();
            BeginContext(234, 74, false);
#line 17 "/Users/iangregg/Desktop/DoctorsOffice.solution/DoctorsOffice/Views/Doctors/Index.cshtml"
 Write(Html.ActionLink($"{doctor.Name}", "Details", new { id = doctor.DoctorId }));

#line default
#line hidden
            EndContext();
            BeginContext(308, 4, true);
            WriteLiteral(" || ");
            EndContext();
            BeginContext(313, 11, false);
#line 17 "/Users/iangregg/Desktop/DoctorsOffice.solution/DoctorsOffice/Views/Doctors/Index.cshtml"
                                                                                Write(doctor.Name);

#line default
#line hidden
            EndContext();
            BeginContext(324, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 18 "/Users/iangregg/Desktop/DoctorsOffice.solution/DoctorsOffice/Views/Doctors/Index.cshtml"
}

#line default
#line hidden
            BeginContext(332, 48, true);
            WriteLiteral("<hr>\n<input type=\"button\" value=\"Add new doctor\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 380, "\"", 439, 3);
            WriteAttributeValue("", 390, "location.href=\'", 390, 15, true);
#line 20 "/Users/iangregg/Desktop/DoctorsOffice.solution/DoctorsOffice/Views/Doctors/Index.cshtml"
WriteAttributeValue("", 405, Url.Action("Create", "Doctors"), 405, 32, false);

#line default
#line hidden
            WriteAttributeValue("", 437, "\';", 437, 2, true);
            EndWriteAttribute();
            BeginContext(440, 68, true);
            WriteLiteral(" class=\"btn btn-primary\" />\n<input type=\"button\" value=\"Return Home\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 508, "\"", 563, 3);
            WriteAttributeValue("", 518, "location.href=\'", 518, 15, true);
#line 21 "/Users/iangregg/Desktop/DoctorsOffice.solution/DoctorsOffice/Views/Doctors/Index.cshtml"
WriteAttributeValue("", 533, Url.Action("Index", "Home"), 533, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 561, "\';", 561, 2, true);
            EndWriteAttribute();
            BeginContext(564, 27, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DoctorsOffice.Models.Doctor>> Html { get; private set; }
    }
}
#pragma warning restore 1591

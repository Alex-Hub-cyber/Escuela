#pragma checksum "C:\Users\user\Desktop\Documents\GitHub\Escuela\Escuela\Escuela\Views\Estudiante\Insertar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05a8963f7d7330335670f6535209463e75e0f179"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Estudiante_Insertar), @"mvc.1.0.view", @"/Views/Estudiante/Insertar.cshtml")]
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
#line 1 "C:\Users\user\Desktop\Documents\GitHub\Escuela\Escuela\Escuela\Views\_ViewImports.cshtml"
using Escuela;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\Documents\GitHub\Escuela\Escuela\Escuela\Views\_ViewImports.cshtml"
using Escuela.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05a8963f7d7330335670f6535209463e75e0f179", @"/Views/Estudiante/Insertar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ad1daf75ad34d7efa7ede8e232fbd89a93ea7bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Estudiante_Insertar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\user\Desktop\Documents\GitHub\Escuela\Escuela\Escuela\Views\Estudiante\Insertar.cshtml"
  
    ViewData["Title"] = "Insertar";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"border-top-color:darkcyan\">Actualizar</h1>\r\n");
#nullable restore
#line 8 "C:\Users\user\Desktop\Documents\GitHub\Escuela\Escuela\Escuela\Views\Estudiante\Insertar.cshtml"
 using (Html.BeginForm("GuardarDatos", "Estudiante", FormMethod.Post))
{ 

#line default
#line hidden
#nullable disable
            WriteLiteral("<label for=\"StudentId\">StudentId</label>\r\n<br />\r\n<input type=\"text\" name=\"StudentId\"");
            BeginWriteAttribute("value", " value=\"", 311, "\"", 337, 1);
#nullable restore
#line 12 "C:\Users\user\Desktop\Documents\GitHub\Escuela\Escuela\Escuela\Views\Estudiante\Insertar.cshtml"
WriteAttributeValue("", 319, ViewBag.StudentId, 319, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
            WriteLiteral("    <label for=\"LastName\">LastName</label>\r\n    <br />\r\n    <input  type=\"text\" name=\"LastName\"");
            BeginWriteAttribute("value", " value=\"", 440, "\"", 465, 1);
#nullable restore
#line 16 "C:\Users\user\Desktop\Documents\GitHub\Escuela\Escuela\Escuela\Views\Estudiante\Insertar.cshtml"
WriteAttributeValue("", 448, ViewBag.LastName, 448, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n    <br />\r\n");
            WriteLiteral("    <label for=\"FirstMidName\">FirstMidName</label>\r\n    <br />\r\n    <input type=\"text\" name=\"FirstMidName\"");
            BeginWriteAttribute("value", " value=\"", 590, "\"", 619, 1);
#nullable restore
#line 21 "C:\Users\user\Desktop\Documents\GitHub\Escuela\Escuela\Escuela\Views\Estudiante\Insertar.cshtml"
WriteAttributeValue("", 598, ViewBag.FirstMidName, 598, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n    <br />\r\n");
            WriteLiteral("    <label for=\"ErollementsDate\">ErollementsDate</label>\r\n    <br />\r\n   <input  type=\"text\" name=\"ErollementsDate\"");
            BeginWriteAttribute("value", " value=\"", 753, "\"", 785, 1);
#nullable restore
#line 26 "C:\Users\user\Desktop\Documents\GitHub\Escuela\Escuela\Escuela\Views\Estudiante\Insertar.cshtml"
WriteAttributeValue("", 761, ViewBag.ErollementsDate, 761, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n   <br />\r\n");
            WriteLiteral("   <input style=\"color:red\"  type=\"submit\" value=\"Update\"/>\r\n");
#nullable restore
#line 30 "C:\Users\user\Desktop\Documents\GitHub\Escuela\Escuela\Escuela\Views\Estudiante\Insertar.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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

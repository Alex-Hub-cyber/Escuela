#pragma checksum "C:\Users\user\Desktop\Documents\GitHub\Escuela\Escuela\Escuela\Views\Curso\MostrarCursos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e0eb0669eaad4fb8e4f0659838873b2544763f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Curso_MostrarCursos), @"mvc.1.0.view", @"/Views/Curso/MostrarCursos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e0eb0669eaad4fb8e4f0659838873b2544763f6", @"/Views/Curso/MostrarCursos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ad1daf75ad34d7efa7ede8e232fbd89a93ea7bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Curso_MostrarCursos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Escuela.Dominio.Course>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\Desktop\Documents\GitHub\Escuela\Escuela\Escuela\Views\Curso\MostrarCursos.cshtml"
  
    ViewData["Title"] = "MostrarCursos";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"color:lightgreen\">MostrarCursos</h1>\r\n\r\n<br />\r\n");
#nullable restore
#line 10 "C:\Users\user\Desktop\Documents\GitHub\Escuela\Escuela\Escuela\Views\Curso\MostrarCursos.cshtml"
Write(Html.ActionLink(" GuardarCourse", "InsertarCourse", new { CourseId = 0 }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<table class=\"table table-dark table-striped\">\r\n    <thead>\r\n");
            WriteLiteral("    <th>\r\n        Title\r\n    </th>\r\n    <th>\r\n        Credits\r\n    </th>\r\n    </thead>\r\n\r\n    <tbody>\r\n\r\n");
#nullable restore
#line 27 "C:\Users\user\Desktop\Documents\GitHub\Escuela\Escuela\Escuela\Views\Curso\MostrarCursos.cshtml"
         foreach (var iteracion in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
            WriteLiteral("                <td>");
#nullable restore
#line 31 "C:\Users\user\Desktop\Documents\GitHub\Escuela\Escuela\Escuela\Views\Curso\MostrarCursos.cshtml"
               Write(iteracion.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\user\Desktop\Documents\GitHub\Escuela\Escuela\Escuela\Views\Curso\MostrarCursos.cshtml"
               Write(iteracion.Credits);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                \r\n\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "C:\Users\user\Desktop\Documents\GitHub\Escuela\Escuela\Escuela\Views\Curso\MostrarCursos.cshtml"
               Write(Html.ActionLink("Update", "InsertarCourse", new { CourseId = iteracion.CourseId, Title = iteracion.Title, Credits = iteracion.Credits}, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 42 "C:\Users\user\Desktop\Documents\GitHub\Escuela\Escuela\Escuela\Views\Curso\MostrarCursos.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Escuela.Dominio.Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\user\Desktop\Documents\GitHub\Escuela\Escuela\Escuela\Views\Estudiante\MostrarEstudiantesInscritos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c93876d430279f89cae8036276019c81237c31dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Estudiante_MostrarEstudiantesInscritos), @"mvc.1.0.view", @"/Views/Estudiante/MostrarEstudiantesInscritos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c93876d430279f89cae8036276019c81237c31dd", @"/Views/Estudiante/MostrarEstudiantesInscritos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ad1daf75ad34d7efa7ede8e232fbd89a93ea7bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Estudiante_MostrarEstudiantesInscritos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Escuela.Dominio.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\Desktop\Documents\GitHub\Escuela\Escuela\Escuela\Views\Estudiante\MostrarEstudiantesInscritos.cshtml"
  
    ViewData["Title"] = "MostrarEstudiantesInscritos";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"color:blueviolet\">MostrarEstudiantesInscritos</h1>\r\n<br />\r\n");
#nullable restore
#line 9 "C:\Users\user\Desktop\Documents\GitHub\Escuela\Escuela\Escuela\Views\Estudiante\MostrarEstudiantesInscritos.cshtml"
Write(Html.ActionLink("GuardarDatos", "Insertar", new { StudentId = 0 }, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<table class=\"table table-dark table-striped\">\r\n    <thead>\r\n \r\n    <th>\r\n        LastName\r\n    </th>\r\n    <th>\r\n        FirstMidName\r\n    </th>\r\n    <th>\r\n        ErollementsDate\r\n    </th>\r\n\r\n    </thead>\r\n    <tbody>\r\n\r\n");
#nullable restore
#line 27 "C:\Users\user\Desktop\Documents\GitHub\Escuela\Escuela\Escuela\Views\Estudiante\MostrarEstudiantesInscritos.cshtml"
         foreach (var iteracion in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n              \r\n                <td>");
#nullable restore
#line 31 "C:\Users\user\Desktop\Documents\GitHub\Escuela\Escuela\Escuela\Views\Estudiante\MostrarEstudiantesInscritos.cshtml"
               Write(iteracion.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\user\Desktop\Documents\GitHub\Escuela\Escuela\Escuela\Views\Estudiante\MostrarEstudiantesInscritos.cshtml"
               Write(iteracion.FirstMidName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\user\Desktop\Documents\GitHub\Escuela\Escuela\Escuela\Views\Estudiante\MostrarEstudiantesInscritos.cshtml"
               Write(iteracion.ErollementsDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "C:\Users\user\Desktop\Documents\GitHub\Escuela\Escuela\Escuela\Views\Estudiante\MostrarEstudiantesInscritos.cshtml"
               Write(Html.ActionLink("Update", "Insertar", new { StudentId=iteracion.StudentId,  LastName = iteracion.LastName, FirstMidName = iteracion.FirstMidName, ErollementsDate = iteracion.ErollementsDate }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                 \r\n\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 42 "C:\Users\user\Desktop\Documents\GitHub\Escuela\Escuela\Escuela\Views\Estudiante\MostrarEstudiantesInscritos.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Escuela.Dominio.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591

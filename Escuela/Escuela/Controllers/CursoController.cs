using Microsoft.AspNetCore.Mvc;
using System;
using Escuela.Dominio;
using Escuela.Servicio;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escuela.Data;
using Escuela.Servicios;

namespace Escuela.Controllers
{
    public class CursoController : Controller
    {
        private ApplicationDbContext app;
        private ICourse icourse;
        public CursoController(ApplicationDbContext app, ICourse icourse)
        {
            this.app = app;
            this.icourse = icourse;
        }
        public IActionResult MostrarCursos()
        {
            var MostrarCurso = icourse.ListarCourses();

            return View(MostrarCurso);
        }


        public IActionResult InsertarCourse(int CourseId, string Title, int Credits)
        {
            ViewBag.CourseId = CourseId;
            ViewBag.Title = Title;
            ViewBag.Credits = Credits;
       
            return View("InsertarCourse");
        }

        [HttpPost]
        public IActionResult GuardarCourse(int CourseId, string Title, int Credits)
        {

            Course courses = new Course();

            if (CourseId == 0)
            {

                courses.CourseId = CourseId;
                courses.Title = Title;
                courses.Credits = Credits;
                icourse.Insertar(courses);
              
            }
            else
            {
                int Update = CourseId;
                Course coursess = app.courses.Where(a => a.CourseId == Update).FirstOrDefault();
                coursess.CourseId = CourseId;
                coursess.Title = Title;
                coursess.Credits = Credits;
                icourse.Update(coursess);

             
            }
            return Redirect("/Curso/MostrarCursos");
        }

    }
}

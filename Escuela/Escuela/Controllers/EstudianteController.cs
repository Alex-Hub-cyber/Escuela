using Escuela.Data;
using Escuela.Dominio;
using Escuela.Servicio;
using Escuela.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Controllers
{
    public class EstudianteController : Controller
    {
        private ApplicationDbContext app;

        private IStudent student;


        public EstudianteController(ApplicationDbContext app, IStudent student)
        {
            this.app = app;
            this.student = student;
        }
        public IActionResult MostrarEstudiantesInscritos()
        {

            var MostrarEstudiantes = student.ListOfStudent();



            return View(MostrarEstudiantes);

        }


        //Esta es para actualizar los datos.
        
        public IActionResult Insertar(int StudentId, string LastName, string FirstMidName, string ErollementsDate)
        {
            
            ViewBag.StudentId = StudentId;
            ViewBag.LastName = LastName;
            ViewBag.FirstMidName = FirstMidName;
            ViewBag.ErollementsDate = ErollementsDate;
            return View("Insertar");
        }



        [HttpPost]
        //Esta es para guardar los datos a la base de datos.
        public IActionResult GuardarDatos(int StudentId , string LastName, string FirstMidName, DateTime ErollementsDate)
        {

            Student students = new Student();
            if (StudentId == 0)
            {
                students.LastName = LastName;
                students.FirstMidName = FirstMidName;
                students.ErollementsDate = ErollementsDate;
                student.Insert(students);
            }
            else
            {
                int Update = StudentId;
                Student save =app.students.Where(a=>a.StudentId==Update).FirstOrDefault();
                save.LastName = LastName;
                save.FirstMidName = FirstMidName;
                save.ErollementsDate = ErollementsDate;
                student.Update(save);
            }
            return Redirect("/Estudiante/MostrarEstudiantesInscritos");
        }
    }
}
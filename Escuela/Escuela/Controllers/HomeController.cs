using Escuela.Dominio;
using Escuela.Models;
using Escuela.Servicio;
using Escuela.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ICourse iCourse;
        private IErollement irollement;
        private IStudent student;
        public HomeController(ILogger<HomeController> logger, ICourse icourse, IErollement ierollement, IStudent student)
        {
            this.iCourse = icourse;
            this.student = student;
            this.irollement = ierollement;
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            var Listado = irollement.UnionDeTablas();
            //for (int i = 0; i < 100; i++)
            //{
            //    Course course = new Course();
            //    course.Title = "Poo";
            //    course.Credits = 100;
            //    iCourse.Insertar(course);
            //}
            //var Listado = irollement.UnionDeTablas();
            //_ = Listado;
            //return View(Listado);
            return View(Listado);

        }
        public IActionResult ComboBox()
        {
            var informationOfTheComboBox = iCourse.ListarCourses();
            var informationtheComboboxforStudent = student.ListOfStudent();
           
             List<SelectListItem> listaCourse = new List<SelectListItem>();
            List<SelectListItem> listaStudent = new List<SelectListItem>();
            foreach ( var iterarinformacion in informationOfTheComboBox)
            {
                listaCourse.Add(new SelectListItem
                {
                    Text = iterarinformacion.Title,
                    Value = Convert.ToString
                         (iterarinformacion.CourseId)
                });

                ViewBag.estado = listaCourse;
            }
            foreach (var iterarinformacion in informationtheComboboxforStudent)
            {
             listaStudent.Add(
                    new SelectListItem
                    {
                        Text = iterarinformacion.FirstMidName,
                        Value = Convert.ToString(iterarinformacion.StudentId)
                    });


                ViewBag.estadoStudents = listaStudent;

            }

            return View();

        }
              

        public IActionResult getinformationCombobox(Erollement e)
        {
          //  _ = e;
            return View("Combobox");
        }
        public IActionResult NuevaVista()
        {

            return View();
        }

        public IActionResult VistaDeUnionDeTablas()
        {
            var Listado = irollement.UnionDeTablas();
           // _ = Listado;
            return View();
        }
        public IActionResult GetAllForJoinJsonLinq()
        {
            var Listado = irollement.UnionDeTablas();

            var CombinacionDeArreglos = (from union in Listado
                                         select new
                                         {
                                             union.Course.Title,
                                             union.Student.LastName,
                                             union.Student.FirstMidName,
                                             union.Grade
                                         }).ToList();
            return Json(new { CombinacionDeArreglos });

          
        }
        public IActionResult GetAll()
        {// se envia del backen al frontend
            var DandoFormatoJson = iCourse.ListarCourses();
            return Json(new { Data = DandoFormatoJson });
          
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

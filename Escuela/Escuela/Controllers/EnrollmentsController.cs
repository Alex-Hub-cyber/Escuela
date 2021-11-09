using Escuela.Data;
using Escuela.Servicio;
using Escuela.Servicios;
using Escuela.Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Controllers
{
    public class EnrollmentsController : Controller
    {
        private ApplicationDbContext App;
        private IErollement ierollement;
        private IStudent istudent;
        private ICourse icourse;

        public EnrollmentsController(ApplicationDbContext App, IErollement ierollement, IStudent istudent, ICourse icourse)
        {
            this.App = App;
            this.ierollement = ierollement;
            this.istudent = istudent;
            this.icourse = icourse;
        }
        public IActionResult UnionTabla()
        {
            var Inscripcion = ierollement.UnionDeTablas();

            return View(Inscripcion);
        }


        public IActionResult Combobox()
        {
            var informationOfTheComboBox = icourse.ListarCourses();
            var informationtheComboboxforStudent = istudent.ListOfStudent();

            List<SelectListItem> lista = new List<SelectListItem>();
            List<SelectListItem> ListaEstudiante = new List<SelectListItem>();

            foreach (var IteracionInformacion in informationOfTheComboBox)
                lista.Add(
                    new SelectListItem
                    {
                        Text = IteracionInformacion.Title,
                        Value = Convert.ToString(IteracionInformacion.CourseId)


                    }) ;

            ViewBag.ListadoEstudiante = lista;


            foreach (var IteracionInformacion in informationtheComboboxforStudent)
            {
                ListaEstudiante.Add(
                    new SelectListItem
                    {
                        Text = IteracionInformacion.FirstMidName + " " + IteracionInformacion.LastName,
                        Value = Convert.ToString(IteracionInformacion.StudentId)

                    });

                ViewBag.Estado = ListaEstudiante;
            }
            


            return View();
        }



        public IActionResult getinformationCombobox()
        {


            return View("Combobox");
        }

        public IActionResult GuardarLosDatos(Erollement erollements)
        {

            Erollement erollement = new Erollement();
            erollement.CourseID = erollements.CourseID;
            erollement.StudentID = erollements.StudentID;
            erollement.Grade = erollements.Grade;

            ierollement.Insertar(erollement);

            return Redirect("/Enrollments/UnionTabla");
        }
    }
}

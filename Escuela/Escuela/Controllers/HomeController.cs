using Escuela.Dominio;
using Escuela.Models;
using Escuela.Servicios;
using Microsoft.AspNetCore.Mvc;
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

        public HomeController(ILogger<HomeController> logger, ICourse icourse)
        {
            this.iCourse = icourse;
            _logger = logger;
        }

        public IActionResult Index()
        {
            Course course = new Course();
            course.Title = "Poo";
            course.Credits = 100;
            iCourse.Insertar(course);
            return View();
        }


        public IActionResult NuevaVista()
        {
            Course course = new Course();


            course.Title = "Hola";
            course.Credits = 3;
            iCourse.Insertar(course);
            return View();
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

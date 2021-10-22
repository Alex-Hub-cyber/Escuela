﻿using Escuela.Dominio;
using Escuela.Models;
using Escuela.Servicio;
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



        private IErollement irollement;
        public HomeController(ILogger<HomeController> logger, ICourse icourse)
        {
            this.iCourse = icourse;
            this.irollement = irollement;
            _logger = logger;
        }

        public IActionResult Index()
        {
            //for (int i = 0; i < 100; i++)
            //{
            //    Course course = new Course();
            //    course.Title = "Poo";
            //    course.Credits = 100;
            //    iCourse.Insertar(course);
            //}
            var Listado = irollement.UnionDeTablas();
                return View(Listado);
            
        }

        public IActionResult NuevaVista()
        {

            return View();
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

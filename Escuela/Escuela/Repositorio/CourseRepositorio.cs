using Escuela.Data;
using Escuela.Dominio;
using Escuela.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Repositorio
{
    public class CourseRepositorio : ICourse
    {
        private ApplicationDbContext app;
        public CourseRepositorio(ApplicationDbContext app)
        {

            this.app = app;
        }


        // PARA BUSCAR UN COURSE EN LA VISTA
        public void Buscar(Course c)
        {
            app.courses.Find(c);
        }



        // PARA ELIMINAR UN COURSE 
        public void Delete(Course c)
        {
            app.courses.Remove(c);
        }





        //PARA INSERTAR UN CURSO A LA BASE DE DATOS

            public void Insertar(Course c)
            {// app.add(c); llama a la clase de Servicio
                app.Add( c);

                //app.SaveChanges(); Guarda los datos en base de datos 
                app.SaveChanges();


            }




        //PARA ACTUALIZAR UN CURSO DESDE LA VISTA A LA BASE DE DATOS
        public void Update(Course c)
        {
            app.Update(c);
            app.SaveChanges();
        }





        //PARA LISTAR LOS CURSOS DE LA BASE DE DATOS Y PODER MOSTRARLA EN LA VISTA
            public List<Course> ListarCourses()
            {
            return app.courses.ToList();

            }
        }
    }

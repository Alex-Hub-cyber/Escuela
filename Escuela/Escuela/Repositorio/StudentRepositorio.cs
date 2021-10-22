using Escuela.Data;
using Escuela.Dominio;
using Escuela.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Repositorio
{
    public class StudentRepositorio:IStudent
    {
        private ApplicationDbContext db;


        public StudentRepositorio(ApplicationDbContext db)
        {
            this.db = db;

        }

        public List<Student> Estudiantes()
        {
            return db.students.ToList();
        }

      }
    }
    

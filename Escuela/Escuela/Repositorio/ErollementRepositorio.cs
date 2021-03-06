using Escuela.Data;
using Escuela.Dominio;
using Escuela.Servicio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Repositorio
{
    public class ErollementRepositorio : IErollement
    {
        private ApplicationDbContext db;


    public  ErollementRepositorio (ApplicationDbContext db)
        {
            this.db = db;
        }


    

        public List<Erollement>UnionDeTablas()
        {
            var Union = db.erollements.Include(e => e.Student).Include(c => c.Course).ToList();

            return Union;
        }

        public void Insertar(Erollement erollement)
        {
            db.Add(erollement);
            db.SaveChanges();
        }

    }
}

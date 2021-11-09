using Escuela.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Servicio
{
  public interface IErollement
    {
          List<Erollement> UnionDeTablas();

        public void Insertar(Erollement erollement);

    }
}
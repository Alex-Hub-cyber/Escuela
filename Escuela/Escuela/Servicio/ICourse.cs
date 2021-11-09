using Escuela.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Servicios
{
    public interface ICourse
    {
      
       public  void Update(Course c);




        public void Insertar(Course c);






        void Delete(Course c);






     
        
        void Buscar(Course c);









        //metodo definido
        List<Course> ListarCourses();
    }
}
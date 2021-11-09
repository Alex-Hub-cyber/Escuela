﻿using Escuela.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Servicio
{
    public interface IStudent
    {
        List<Student> ListOfStudent();

        public void Insert(Student student);
        public void Update(Student student);


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Escuela.Dominio
{
    public class Student
    {

        // Key llave primaria en Base de datos
        // DatabaseGenerated(DatabaseGeneratedOption.Identity)]fUNCIONA PARA INCREMENTAR EL ID
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }

        public string LastName { get; set; }


        public DateTime ErollementsDate { get; set; }

        public ICollection<Erollement> erollements { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Libreria.modelos
{
    public class Biblioteca
    {
        [Key] public int Id { get; set; }

        public string Nombre_Biblioteca { get; set; }
        public string Direccion { get; set; }

        List<Libro> Libros { get; set; } = new List<Libro>(); 
    }
}

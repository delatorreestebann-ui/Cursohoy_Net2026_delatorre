using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Libreria.modelos
{
    public class Autor
    {
        [Key] public int Id{ get; set; }
        public string Nombre_Autor { get; set; }
        public string Apellido_Autor { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }

        [ForeignKey("PaisId")]
        public int PaisId { get; set; }
        public Pais? Pais {  get; set; }
        
        List<Libro>? Libros { get; set; } = new List<Libro>();
    }
}

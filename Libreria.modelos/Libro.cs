using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Libreria.modelos
{
    public class Libro
    {
        [Key] public int Id { get; set; }
        public string Titulo_Libro { get; set; }
        public int stock_libro { get; set; }

        [ForeignKey("AutorId")]
        public int AutorId { get; set; }
        public Autor? Autor { get; set; }
        
        [ForeignKey("BibliotecaId")]
        public int BibliotecaId { get; set; }
        public Biblioteca? Biblioteca { get; set; }

        List<Prestamo>? Prestamos { get; set; } = new List<Prestamo>();

    }
}

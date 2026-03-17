using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Libreria.modelos
{
    public class Pais
    {
        [Key] public int Id { get; set; }
        public string Nombre_Pais { get; set; }

        List<Autor> Autores { get; set; } = new List<Autor>();
    }
}

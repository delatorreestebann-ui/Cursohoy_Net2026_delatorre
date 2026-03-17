using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Libreria.modelos
{
    public class Paises
    {
        [Key] public int Id { get; set; }
        public string Nombre_Pais { get; set; }
    }
}

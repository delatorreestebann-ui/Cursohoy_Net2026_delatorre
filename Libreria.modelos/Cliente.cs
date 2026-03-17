using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Libreria.modelos
{
    internal class Cliente
    {
        [Key] public int Id { get; set; }

        public string Nombre_Cliente { get; set; }
        public string Apellido_Cliente { get; set; }
        public string Correo_Cliente { get; set; }

        public string Nombre_Usiario { get; set; }
        public string contra_Cliente { get; set; }
    }
}

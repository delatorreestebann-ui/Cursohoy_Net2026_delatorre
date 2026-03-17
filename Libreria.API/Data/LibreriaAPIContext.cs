using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Libreria.modelos;

namespace Libreria.API.Data
{
    public class LibreriaAPIContext : DbContext
    {
        public LibreriaAPIContext (DbContextOptions<LibreriaAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Libreria.modelos.Autor> Autor { get; set; } = default!;
        public DbSet<Libreria.modelos.Biblioteca> Biblioteca { get; set; } = default!;
        public DbSet<Libreria.modelos.Cliente> Cliente { get; set; } = default!;
        public DbSet<Libreria.modelos.Libro> Libro { get; set; } = default!;
        public DbSet<Libreria.modelos.Pais> Pais { get; set; } = default!;
        public DbSet<Libreria.modelos.Prestamo> Prestamo { get; set; } = default!;
    }
}

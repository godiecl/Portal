using Microsoft.EntityFrameworkCore;
using Portal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configuracion de base de datos, puede estar en Startup.cs
            // optionsBuilder.UseInMemoryDatabase("db");
            // optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BaseDatosPersonas;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuration del modelo
        }

        // Vista de base de datos de Persona
        public DbSet<Persona> Personas { get; set; }

        // Vista de base de datos de Vehiculo
        public DbSet<Vehiculo> Vehiculo { get; set; }

    }
}

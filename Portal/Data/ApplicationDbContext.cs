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
            // optionsBuilder.UseInMemoryDatabase("db");
            // optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BaseDatosPersonas;Trusted_Connection=True;");
        }

        public DbSet<Persona> Personas { get; set; }

        public DbSet<Portal.Models.Vehiculo> Vehiculo { get; set; }

    }
}

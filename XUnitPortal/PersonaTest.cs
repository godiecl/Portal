using Microsoft.EntityFrameworkCore;
using Portal.DAO;
using Portal.Data;
using Portal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace XUnitPortal
{
    public class PersonaTest
    {
        [Fact]
        public void Create()
        {

            // Repositorio de personas
            IRepository<Persona> personaRepo = GetInMemoryRepository<Persona>();

            // La tabla de persona deben estar vacio
            Assert.Empty(personaRepo.Find().ToList());

            // Persona a insertar en la base de datos
            Persona persona = new Persona()
            {
                Rut = "130144918",
                Nombre = "Diego",
                Paterno = "Urrutia",
                Materno = "Astorga",
                Password = "durrutia123",
                Email = "durrutia@ucn.cl"
            };

            // Insercion en la base de datos via repositorio
            personaRepo.Add(persona);

            // La lista no debe estar vacia
            Assert.NotEmpty(personaRepo.Find().ToList());

            // Debe tener solo un elemento
            Assert.Single(personaRepo.Find().ToList());

            //List<Portal.Models.Persona> personas = dao.Find().ToList(); //;.Where(c => c.RUT = "130144918

            //Persona p1 = dao.GetById(1);
            //Assert.Equal(persona, p1);
        }

        /// <summary>
        /// Helper para construir repositorios de BaseEntity.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private IRepository<T> GetInMemoryRepository<T>() where T : BaseEntity
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            builder.UseInMemoryDatabase("db");

            ApplicationDbContext applicationDbContext = new ApplicationDbContext(builder.Options);
            return new EntityRepository<T>(applicationDbContext);
        }


    }
}

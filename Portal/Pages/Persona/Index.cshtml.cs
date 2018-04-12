using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Portal.DAO;
using Portal.Data;
using Portal.Models;

namespace Portal.Pages.Persona
{
    public class IndexModel : PageModel
    {
        /// <summary>
        /// Conexion con el respositorio de codigo.
        /// </summary>
        private readonly IRepository<Models.Persona> _personaRepository;

        /// <summary>
        /// Construccion de la pagina de inicio
        /// </summary>
        /// <param name="personaRepositorio">Repositorio de Personas</param>
        public IndexModel(IRepository<Models.Persona> personaRepositorio)
        {
            _personaRepository = personaRepositorio;
        }

        public List<Models.Persona> Personas { get; set; }

        public async void OnGetAsync()
        {
            Personas = await _personaRepository.Find().ToListAsync();
        }
    }
}

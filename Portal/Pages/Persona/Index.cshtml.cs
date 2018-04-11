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
        private readonly IRepository<Models.Persona> _personaRepository;

        public IndexModel(IRepository<Models.Persona> personaRepositorio)
        {
            _personaRepository = personaRepositorio;
        }

        public List<PersonaViewModel> Personas { get; set; } = new List<PersonaViewModel>();

        public class PersonaViewModel
        {
            public string Nombre { get; set; }
        }

        public async Task OnGetAsync()
        {
            Personas = _personaRepository.List()
                .Select(p => new PersonaViewModel { Nombre = p.Nombre + p.Paterno + p.Materno }).ToList();
        }
    }
}

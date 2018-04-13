using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Models
{
    public class Vehiculo : BaseEntity
    {
        [Required(ErrorMessage = "Se requiere la placa patente")]
        [MinLength(6), MaxLength(6)]
        public string Placa { set; get; }

        public string Color { set; get; }

        public string Marca { set; get; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { set; get; }

        // Asociacion con Persona
        public int PersonaId { get; set; }
        public Persona Persona { get; set; }
    }
}

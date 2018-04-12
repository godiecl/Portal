using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Models
{
    public class Persona : BaseEntity
    {
        [DisplayName("R.U.T.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N}")]
        public string RUT { get; set; }

        [Required(ErrorMessage = "Se requiere el nombre")]
        [StringLength(40)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Se requiere el apellido paterno")]
        [StringLength(80)]
        public string Paterno { get; set; }

        public string Materno { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public override string ToString()
        {
            return $"{Nombre} {Paterno} {Materno}";
        }
    }
}

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
        [Required(ErrorMessage = "Se debe ingresar el RUT")]
        public string Rut { get; set; }

        [Required(ErrorMessage = "Se requiere el nombre")]
        [StringLength(40)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Se requiere el apellido paterno")]
        [StringLength(80, ErrorMessage = "Tamanio maximo 80")]
        public string Paterno { get; set; }

        [StringLength(40)]
        public string Materno { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        // Asociacion con los Vehiculos
        public ICollection<Vehiculo> Vehiculos { get; set; }

        public override string ToString()
        {
            return $"{Nombre} {Paterno} {Materno}";
        }
    }
}

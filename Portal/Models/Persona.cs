using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Models
{
    public class Persona : BaseEntity
    {
        public string RUT { get; set; }

        public string Nombre { get; set; }

        public string Paterno { get; set; }

        public string Materno { get; set; }

        public override string ToString()
        {
            return $"{Nombre} {Paterno} {Materno}";
        }
    }
}

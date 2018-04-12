using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Models
{
    public class BaseEntity
    {
        /// <summary>
        /// Llave primaria de la entidad
        /// </summary>
        [ScaffoldColumn(false)]
        public int Id { get; set; }

    }
}

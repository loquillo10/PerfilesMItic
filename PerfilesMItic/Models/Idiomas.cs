using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PerfilesMItic.Models
{
    public class Idiomas
    {
        [Key]
        public int IdIdioma { get; set; }
        [MaxLength(200)]
        public string Capacidad { get; set; }
        [MaxLength(200)]
        public string Nombre { get; set; }

        public int Id { get; set; }

    }
}

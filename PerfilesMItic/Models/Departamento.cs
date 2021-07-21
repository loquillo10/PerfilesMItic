using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PerfilesMItic.Models
{
    public class Departamento
    {
        [Key]
        public int IdDepartamento { get; set; }
        public string Nombre { get; set; }

        public Ciudad Ciudad { get; set; }
    }
}

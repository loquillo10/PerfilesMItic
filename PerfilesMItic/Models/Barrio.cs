using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PerfilesMItic.Models
{
    public class Barrio
    {
        [Key]
        public int IdBarrio { get; set; }
        public string NombreB { get; set; }
    }
}

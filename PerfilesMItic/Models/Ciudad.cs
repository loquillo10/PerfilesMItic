using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APPWEB.Models
{
    public class Ciudad
    {
        [Key]
        public int IdCiudad { get; set; }
        public string Nombre { get; set; }
    }
}

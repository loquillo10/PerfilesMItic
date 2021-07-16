using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APPWEB.Models
{
    public class Hijo
    {
        [Key]
        public int IdHijo { get; set; }
        public string NombreH { get; set; }
        public string ApellidoH { get; set; }
        public DateTime? FechaNacimientoH { get; set; }
        public string cantidadHijos { get; set; }
    }
}

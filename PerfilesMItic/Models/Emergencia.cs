using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PerfilesMItic.Models
{
    public class Emergencia
    {
        [Key]
        public int IdEmergencia { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [Column("LineaBaja")]
        public string Telefono { get; set; }
        [Column("Celular")]
        public string Movil { get; set; }
    }
}

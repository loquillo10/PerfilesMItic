using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PerfilesMItic.Models
{
    public class Capacitaciones
    {
        public int IdCapacitaciones { get; set; }
        public string Tema { get; set; }
        public DateTime Fecha { get; set; }


        [ForeignKey("IdFuncionario")]
        public int Id { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PerfilesMItic.Models
{
    public class Hijo
    {
        [Key]
        public int IdHijo { get; set; }
        public string NombreH { get; set; }
        public string ApellidoH { get; set; }
        public DateTime? FechaNacimientoH { get; set; }
        public string cedulaH { get; set; }
        public string cantidadHijos { get; set; }

        [ForeignKey("IdFuncionario")]
        public Funcionario Funcionario { get; set; }
    }
}

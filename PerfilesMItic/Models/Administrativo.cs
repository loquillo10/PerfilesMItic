using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PerfilesMItic.Models
{
    public class Administrativo
    {
        [Key]
        public int IdAdministrativo { get; set; }
        [MaxLength(200)]
        public string Cargo_Funcion { get; set; }
        [MaxLength(200)]
        public string Dependencia_Funcion { get; set; }
        [MaxLength(200)]
        public string Horario { get; set; }
        [MaxLength(200)]
        public string Interno_Telefono { get; set; }
        [MaxLength(200)]
        public string SuperiorInmediato { get; set; }

        [ForeignKey("IdFuncionario")]
        public int Id { get; set; }

    }
}

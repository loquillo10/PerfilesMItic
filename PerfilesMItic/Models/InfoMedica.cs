using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PerfilesMItic.Models
{
    public class InfoMedica
    {
        [Key]
        public int IdMedica { get; set; }
        public string GrupoSanguineo { get; set; }
        public string Enfermedad { get; set; }
        public string NombreSeguro { get; set; }
        public string NroCarnet { get; set; }

        [ForeignKey("IdFuncionario")]
        public int Id { get; set; }
    }
}

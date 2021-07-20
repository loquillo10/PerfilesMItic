using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PerfilesMItic.Models
{
    public class Familiar
    {
        [Key]
        public int IdFamiliar { get; set; }
        public string NombreF { get; set; }
        public string ApellidoF { get; set; }
        public string TipoFamiliar { get; set; }

        [ForeignKey("IdFuncionario")]
        public Funcionario Funcionario { get; set; }

    }
}

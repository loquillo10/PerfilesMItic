using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APPWEB.Models
{
    public class FuncionPublica
    {
        [Key]
        [Column("IdFuncionPublica")]
        public int IdFP { get; set; }
        public string NombreFP { get; set; }
        public string ApellidoFP { get; set; }
        public string Entidad { get; set; }
        public string Cargo { get; set; }

        [ForeignKey("IdFuncionario")]
        public Funcionario Funcionario { get; set; }
    }
}

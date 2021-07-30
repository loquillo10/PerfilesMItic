using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PerfilesMItic.Models
{
    public class ExperienciaLaboral
    {
        [Key]
        public int IdExperiencia { get; set; }
        public string Cargo { get; set; }
        [Column("Institucion")]
        public string Entidad { get; set; }
        [Column("Horas")]
        public DateTime TiempoTrabajado { get; set; }

        [ForeignKey("IdFuncionario")]
        public int Id { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PerfilesMItic.Models
{
    public class EstudiosRealizados
    {
        [Key]
        public int IdEstudio { get; set; }
        [MaxLength(200)]
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        [MaxLength(150)]
        public string Titulo { get; set; }
        [MaxLength(200)]
        public string Institucion { get; set; }
        [MaxLength(20)]
        public string Estado { get; set; }


        [ForeignKey("IdFuncionario")]
        public int Id { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PerfilesMItic.Models
{
    
    public class Funcionario
    {
        [Key]
        [Column("IdFuncionario")]
        public int Id { get; set; }
        [Required]
        public int Cedula { get; set; }
        [MaxLength(60), Required]
        public string Nombre { get; set; }
        [MaxLength(60), Required]
        public string Apellido { get; set; }

        [Column("Imagen")]
        public byte[] JpgImagen { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Sexo { get; set; }

        [MaxLength(10),MinLength(6, ErrorMessage ="Complete el Campo Con los Numeros.")]
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string TipoFuncionario { get; set; }
        public string EstadoCivil { get; set; }
        public string EmailParticular { get; set; }
        public string Observaciones { get; set; }
        public bool Activo { get; set; }
        [MaxLength(15), MinLength(10, ErrorMessage = "Complete el Campo Con los Numeros.")]
        public string TelefonoMovil { get; set; }

        public List<Pais> PaisNacimiento { get; set; }
        public List<Ciudad> CiudadNacimiento { get; set; }

        public string Pasaporte { get; set; }
        public string RegConducir { get; set; }
        public string Categoria { get; set; }
        public string RUC { get; set; }
        public List<Ciudad> Ciudad { get; set; }
        public List<Barrio> Barrio { get; set; }
        public List<Departamento> Departamento { get; set; }

    }
}

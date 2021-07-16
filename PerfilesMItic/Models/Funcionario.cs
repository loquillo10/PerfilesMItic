using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APPWEB.Models
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

        //Clase Ciudad
        [ForeignKey("IdCiudad")]
        [Column(Order =1)]
        public Ciudad Ciudad { get; set; }

        //Clase Departamento
        [ForeignKey("IdDepartamento")]
        [Column(Order = 2)]
        public Departamento Departamento { get; set; }

        //Clase Hijos
        [ForeignKey("IdHijos")]
        [Column(Order = 3)]
        public Hijo Hijo { get; set; }

        //Clase Pais
        [ForeignKey("IdPais")]
        [Column(Order = 4)]
        public Pais Pais { get; set; }

    }
}

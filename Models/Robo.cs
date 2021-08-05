using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Models
{
    public class Robo
    {
        [Display(Name ="Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "La {0} es obligatoria")]
        public string Cedula { get; set; }

        [Display(Name = "Querellante")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string Nombre { get; set; }

        [Display(Name = "Fecha del hecho")]
        [Required(ErrorMessage = "La {0} es obligatoria")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "La {0} es obligatoria")]
        public string Sustraccion { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        public double Valor { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [MaxLength(150,ErrorMessage = "El {0} no puede contener mas de 150 caracteres")]
        public string Lugar { get; set; }

        [Required(ErrorMessage = "La {0} es obligatoria")]
        public double Latitud { get; set; }

        [Required(ErrorMessage = "La {0} es obligatoria")]
        public double Longitud { get; set; }
    }
}

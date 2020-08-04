using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nera.Web.Data.Entities
{
    public class Rescatista
    {
        public int ID { get; set; }

        [MaxLength(11, ErrorMessage = "El {0} no puede contener mas de {1} Caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Rut { get; set; }

        [MaxLength(50, ErrorMessage = "El {0} no puede contener mas de {1} Caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Nombres { get; set; }

        [MaxLength(20, ErrorMessage = "El {0} no puede contener mas de {1} Caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Apellido Paterno")]
        public string ApellidoPaterno { get; set; }

        [MaxLength(20, ErrorMessage = "El {0} no puede contener mas de {1} Caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Apellido Materno")]
        public string ApellidoMaterno { get; set; }

        [MaxLength(15, ErrorMessage = "El {0} no puede contener mas de {1} Caracteres.")]
        public string Telefono { get; set; }

        [MaxLength(15, ErrorMessage = "El {0} no puede contener mas de {1} Caracteres.")]
        public string Celular { get; set; }

        [MaxLength(100, ErrorMessage = "El {0} no puede contener mas de {1} Caracteres.")]
        public string Direccion { get; set; }

        [Display(Name = "Rescatista")]
        public string NombreCompleto => $"{Nombres} {ApellidoPaterno} {ApellidoMaterno}";

        [Display(Name = "Rescatista")]
        public string NombreCompletoRut => $"{Nombres} {ApellidoPaterno} {ApellidoMaterno} - {Rut}";

        public ICollection<Rescate> Rescates { get; set; }
    }
}

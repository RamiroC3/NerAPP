using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Nera.Web.Data.Entities
{
    public class Vehiculo
    {
        public int Id { get; set; }

        [Display(Name = "Vehiculo")]
        [MaxLength(50, ErrorMessage = "El {0}  de rescate no puede contener mas de {1} caracteres.")]
        [Required(ErrorMessage = "El Campo {0} es obligatorio.")]
        public string Nombre { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nera.Web.Data.Entities
{
    public class RegistroRescate
    {
        public int Id { get; set; }

       
        [Display(Name = "Descripcion*")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Description { get; set; }

        [Display(Name = "Fecha*")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public string Comentarios { get; set; }

        public int Odometro { get; set; }

        public Boolean Estado { get; set; }


        [Display(Name = "Fecha*")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateLocal => Date.ToLocalTime();

        public Vehiculo Vehiculo { get; set; }

        public Rescate Rescate { get; set; }
    }
}

  

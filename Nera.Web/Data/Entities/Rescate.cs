using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nera.Web.Data.Entities
{
    public class Rescate
    {
        public int Id { get; set; }

        [Display(Name = "Cliente")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Cliente { get; set; }

        [Display(Name = "Imagen")]
        public string ImageUrl { get; set; }

       // [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
       // public string TipoRescate { get; set; }

       
        [Display(Name = "Fecha")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        public string Comentarios { get; set; }

        
        //TODO: replace the correct URL for the image
        public string ImageFullPath => string.IsNullOrEmpty(ImageUrl)
            ? null
            : $"https://TDB.azurewebsites.net{ImageUrl.Substring(1)}";

        public TipoRescate TipoRescate { get; set; }

        public Rescatista Rescatista { get; set; }

        public ICollection<RegistroRescate> RegistroRescates { get; set; }

    }
}

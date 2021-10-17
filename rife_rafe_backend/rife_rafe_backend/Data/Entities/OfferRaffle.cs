using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace rife_rafe_backend.Data.Entities
{
    public class OfferRaffle
    {
        public int Id { get; set; }

        [Display(Name = "Precio de la boleta")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public decimal Price;


        [Display(Name = "¿De cuantos digitos es la boleta?")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int Digits;

        [Display(Name = "Información adicional")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string AdditionalInfo;

        public Offer Offer { get; set; }
    }
}

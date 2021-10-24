using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace rife_rafe_backend.Models
{
    public class ProductViewModel
    {
        [Display(Name = "Categoría del producto")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int CategoryId { get; set; }

        public string UserId { get; set; }

        [Display(Name = "Titulo")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Title { get; set; }

        [Display(Name = "Características ")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Features { get; set; }

        [Display(Name = "Descripción")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Description { get; set; }

        [Display(Name = "Terminos y condiciones")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string TermsAndConditions { get; set; }

        [Display(Name = "Foto")]
        public IFormFile ImageFullPath;

        [Display(Name = "Tipo de Oferta")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int OffertType { get; set; }

        [Display(Name = "Fecha de cierre")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}")]
        public DateTime ClosingDate { get; set; }

        [Display(Name = "Precio comercial del producto")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal TradePrice { get; set; }

        #region Auction
        [Display(Name = "Precio inicial de la subasta")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal BasePrice;

        [Display(Name = "Intervalos minimos de subasta")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal Ratio;
        #endregion

        #region Rafle
        [Display(Name = "Precio de la boleta")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal Price;

        [Display(Name = "¿De cuantos digitos es la boleta?")]
        public int Digits;

        [Display(Name = "Información adicional")]
        [DataType(DataType.MultilineText)]
        public string AdditionalInfo;
        #endregion

        [Display(Name = "Images")]
        public IList<IFormFile> ImageFile { get; set; }
    }
}

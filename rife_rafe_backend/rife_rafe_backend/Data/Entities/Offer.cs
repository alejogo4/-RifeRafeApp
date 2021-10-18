using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace rife_rafe_backend.Data.Entities
{
    public class Offer
    {


        public int Id { get; set; }


        [Display(Name = "Producto")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int ProductId { get; set; }

        


        [Display(Name = "Fecha de cierre")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}")]
        public DateTime ClosingDate { get; set; }



        [Display(Name = "Precio comercial del producto")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal TradePrice { get; set; }

        public ICollection<Applicants> Applicants { get; set; }



        public Product Product { get; set; }
    }
}

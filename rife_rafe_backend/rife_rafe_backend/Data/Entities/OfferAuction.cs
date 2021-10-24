using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace rife_rafe_backend.Data.Entities
{
    public class OfferAuction
    {
        public int Id { get; set; }

        [Display(Name = "Tipo")]
        public int OfferId { get; set; }

        [Display(Name = "Precio inicial de la subasta")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal BasePrice { get; set; }

        [Display(Name = "Intervalos minimos de subasta")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal Ratio { get; set; }

        public Offer Offer { get; set; }
    }
}

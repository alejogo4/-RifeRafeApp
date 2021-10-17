using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace rife_rafe_backend.Data.Entities
{
    public class Payment
    {

        public int Id { get; set; }


        [Display(Name = "Fecha")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}")]
        public DateTime Date { get; set; }


        [Display(Name = "Id de pago")]
        public int PaymentId { get; set; }

        public string Method { get; set; }


        public decimal Amount { get; set; }


        //@TODO: Asociar con user
        /*
        [Display(Name = "Propietario")]
        [JsonIgnore]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public User User { get; set; }
        */
    }
}

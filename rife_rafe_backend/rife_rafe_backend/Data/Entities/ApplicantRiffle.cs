using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace rife_rafe_backend.Data.Entities
{
    public class ApplicantRiffle
    {


        public int Id { get; set; }


        [Display(Name = "Fecha")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}")]
        public DateTime Date { get; set; }


        [Display(Name = "Fecha")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}")]
        public DateTime DateLocal => Date.ToLocalTime();


        [Display(Name = "Seleccionar numero de rifa")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int Number { get; set; }


    }
}

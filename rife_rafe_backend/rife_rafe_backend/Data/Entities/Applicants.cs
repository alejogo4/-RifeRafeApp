using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;

namespace rife_rafe_backend.Data.Entities
{
    public class Applicants
    {
        public int Id { get; set; }


        public Offer Offer { get; set; }

        public bool Winner;


        //@TODO: Asociar con user
        /*
        [Display(Name = "Propietario")]
        [JsonIgnore]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public User User { get; set; }
        */
    }
}

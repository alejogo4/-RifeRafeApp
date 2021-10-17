using System.ComponentModel.DataAnnotations;

namespace rife_rafe_backend.Data.Entities
{
    public class Evaluation
    {
        public int Id { get; set; }

        public int IdEvaluator { get; set; }

        public int IdUser { get; set; }


        [Display(Name = "Mensaje")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }

        [Display(Name = "Calificación")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int calification { get; set; }
        //@TODO: Asociar con user
        /*
        [Display(Name = "Propietario")]
        [JsonIgnore]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public User User { get; set; }
        */

    }
}

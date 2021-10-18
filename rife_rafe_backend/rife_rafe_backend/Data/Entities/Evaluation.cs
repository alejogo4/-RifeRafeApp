using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace rife_rafe_backend.Data.Entities
{
    public class Evaluation
    {
        public int Id { get; set; }

        [ForeignKey("User")]
        public int IdEvaluator { get; set; }

        [ForeignKey("User")]
        public int IdUser { get; set; }

    


        [Display(Name = "Mensaje")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }

        [Display(Name = "Calificación")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int calification { get; set; }


        
        [JsonIgnore]
        public User User { get; set; }


 

    }
}

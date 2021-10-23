using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace rife_rafe_backend.Data.Entities
{
    public class Evaluation
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string EvaluatorId { get; set; }
        public string UserId { get; set; }

        [Display(Name = "Mensaje")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }

        [Display(Name = "Calificación")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int calification { get; set; }

        [JsonIgnore]
        public virtual User User { get; set; }

        [JsonIgnore]
        public virtual User Evaluator { get; set; }
    }
}

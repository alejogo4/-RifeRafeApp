using System.ComponentModel.DataAnnotations;

namespace rife_rafe_backend.Data.Entities
{
    public class Message
    {
        public int Id { get; set; }

        public int IdSender { get; set; }

        public int IdUser { get; set; }


        [Display(Name = "Mensaje")]
        [DataType(DataType.MultilineText)]
        public string MessageTxt { get; set; }

        //@TODO: Asociar con user
        /*
        [Display(Name = "Propietario")]
        [JsonIgnore]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public User User { get; set; }
        */

    }
}

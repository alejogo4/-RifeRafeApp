using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace rife_rafe_backend.Data.Entities
{
    public class Message
    {
        public int Id { get; set; }

        [ForeignKey("User")]
        public int IdReceived { get; set; }

        [ForeignKey("User")]
        public int IdSender { get; set; }

       


        [Display(Name = "Mensaje")]
        [DataType(DataType.MultilineText)]
        public string MessageTxt { get; set; }


        
        [JsonIgnore]
        public User User { get; set; }



    }
}

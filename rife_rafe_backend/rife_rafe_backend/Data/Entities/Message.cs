using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace rife_rafe_backend.Data.Entities
{
    public class Message
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Received")]
        public string ReceivedId { get; set; }

        [ForeignKey("Sender")]
        public string SenderId { get; set; }

        [Display(Name = "Mensaje")]
        [DataType(DataType.MultilineText)]
        public string MessageTxt { get; set; }

        [JsonIgnore]
        public virtual User Received { get; set; }

        [JsonIgnore]
        public virtual User Sender { get; set; }
    }
}

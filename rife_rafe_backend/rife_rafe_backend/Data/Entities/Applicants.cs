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
        public int UserId { get; set; }

        public Offer Offer { get; set; }

        public bool Winner;


        [JsonIgnore]
        public User User { get; set; }


    }
}

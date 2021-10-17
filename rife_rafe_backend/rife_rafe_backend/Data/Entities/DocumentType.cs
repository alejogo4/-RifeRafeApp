﻿using System.ComponentModel.DataAnnotations;

namespace rife_rafe_backend.Data.Entities
{
    public class DocumentType
    {
        public int Id { get; set; }

        [Display(Name = "Tipo de documento")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Description { get; set; }

        //@TODO: Relacion con users
        /*
        [JsonIgnore]
        public ICollection<User> Users { get; set; }
        */
    }
}
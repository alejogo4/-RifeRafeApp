﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;

namespace rife_rafe_backend.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }


        [Display(Name = "Categoría del producto")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public Category Category { get; set; }


        [Display(Name = "Titulo")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Title { get; set; }

        [Display(Name = "Características ")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Features { get; set; }

        [Display(Name = "Descripción")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Description { get; set; }

        [Display(Name = "Terminos y condiciones")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string TermsAndConditions { get; set; }


        public ICollection<ProductPhoto> ProductPhoto { get; set; }

        [Display(Name = "# Fotos")]
        public int ProductPhotosCount => ProductPhoto == null ? 0 : ProductPhoto.Count;

        [Display(Name = "Foto")]
        public string ImageFullPath => ProductPhoto == null || ProductPhoto.Count == 0
            ? $"https://vehicleszulu.azurewebsites.net/images/noimage.png"
            : ProductPhoto.FirstOrDefault().ImageFullPath;


        //@TODO: Asociar con user
        /*
        [Display(Name = "Propietario")]
        [JsonIgnore]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public User User { get; set; }
        */

    }
}
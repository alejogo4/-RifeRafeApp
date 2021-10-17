using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace rife_rafe_backend.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name = "Categoría")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }

        public Guid ImageId { get; set; }

        public ICollection<Product> Product { get; set; }

        //@TODO: crear blob storage
        [Display(Name = "Foto")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://vehicleszulu.azurewebsites.net/images/noimage.png"
            : $"https://vehicleszulu.blob.core.windows.net/vehiclephotos/{ImageId}";
    }
}

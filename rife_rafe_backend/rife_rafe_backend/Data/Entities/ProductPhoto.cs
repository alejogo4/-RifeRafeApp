using System;
using System.ComponentModel.DataAnnotations;

namespace rife_rafe_backend.Data.Entities
{
    public class ProductPhoto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public Product Product { get; set; }

        [Display(Name = "Foto")]
        public Guid ImageId { get; set; }


        //@TODO: crear blob storage
        [Display(Name = "Foto")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://vehicleszulu.azurewebsites.net/images/noimage.png"
            : $"https://vehicleszulu.blob.core.windows.net/vehiclephotos/{ImageId}";
    }
}

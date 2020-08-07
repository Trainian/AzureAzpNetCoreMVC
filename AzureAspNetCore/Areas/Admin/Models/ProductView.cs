using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace AzureAspNetCore.Areas.Admin.Models
{
    public class ProductView
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Название, обязательно для заполнения")]
        [DisplayName("Название")]
        [StringLength(maximumLength: 100, MinimumLength = 1, ErrorMessage = "Название не должно быть меньше 1 и больше 100 символов")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Цена должна быть назначена")]
        [DisplayName("Цена")]
        public decimal Price { get; set; }

        [DisplayName("Позиция")]
        public int Order { get; set; }

        [DisplayName("Картинка")]
        public string ImageUrl { get; set; }

        [DisplayName("Бренд")]
        public BrandSectionView Brand { get; set; }

        [DisplayName("Секция")]
        public BrandSectionView Section { get; set; }
    }
}

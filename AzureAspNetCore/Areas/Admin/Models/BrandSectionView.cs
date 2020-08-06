using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AzureAspNetCore.Areas.Admin.Models
{
    public class BrandSectionView
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Название обязательно к заполнению")]
        [DisplayName("Название")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Позиция обязательна к заполнению")]
        [DisplayName("Позиция")]
        public int Order { get; set; }
    }
}

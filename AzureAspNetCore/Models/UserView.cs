using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AzureAspNetCore.Models
{
    public class UserView
    {
        [Required, MaxLength(255)]
        [Display(Name = "Имя", AutoGenerateField = false)]
        public string Name { get; set; }

        [Required, DataType(DataType.Password)]
        [Display(Name = "Пароль", AutoGenerateField = false)]
        public string Password { get; set; }

        [Required, DataType(DataType.Password), Compare(nameof(Password))]
        [DisplayName("Пароль повторно")]
        public string ConfirmPassword { get; set; }
    }
}

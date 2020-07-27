using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AzureAspNetCore.Areas.Admin.Models
{
    public class UserView
    {
        public UserView()
        {
            Role = new List<string>();
        }
        public string Id { get; set; }

        [Required(ErrorMessage = "Имя не может быть пустым")]
        [DisplayName("Пользователь")]
        public string UserName { get; set; }

        [DisplayName("Почта")]
        [EmailAddress(ErrorMessage = "Не верная почта")]
        public string Email { get; set; }

        [DisplayName("Телефон")]
        [Phone(ErrorMessage = "Не верный телефон")]
        public string PhoneNumber { get; set; }

        [DisplayName("Роль")]
        public List<string> Role { get; set; }
    }
}

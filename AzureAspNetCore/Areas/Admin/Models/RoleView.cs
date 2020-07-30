using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AzureAspNetCore.Areas.Admin.Models
{
    public class RoleView
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Название Роли должно быть заполнено !")]
        public string Name { get; set; }

        public bool IsEnable { get; set; }
    }
}

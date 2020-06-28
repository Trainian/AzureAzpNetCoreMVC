using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AzureAspNetCore.Models
{
    public class EmployeeViews
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "ID не может быть пустым")]
        [Display(Name = "ИД")]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Имя не может быть пустым")]
        [Display(Name = "Имя")]
        [StringLength(maximumLength: 50, MinimumLength = 1, ErrorMessage = "Имя должно быть не меньше 1 и не больше 50 символов")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Фамилия не может быть пустой")]
        [Display(Name = "Фамилия")]
        [StringLength(maximumLength:50, MinimumLength = 1, ErrorMessage = "Фамилия должна быть не меньше 1 и не больше 50 символов")]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Возраст не может быть пустым")]
        [Display(Name = "Возраст")]
        [Range(minimum:0,maximum:100,ErrorMessage = "Возраст не может быть отрицательным или больше 100")]
        public short Age { get; set; }

        public EmployeeViews() { }

        public EmployeeViews(int id, string firstName, string lastName, short age)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}

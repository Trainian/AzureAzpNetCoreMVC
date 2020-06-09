using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureAspNetCore.Models
{
    public class EmployeeViews
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public short Age { get; set; }

        public EmployeeViews(string firstName, string lastName, short age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}

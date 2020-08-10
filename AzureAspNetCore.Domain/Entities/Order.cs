using AzureAspNetCore.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureAspNetCore.Domain.Entities
{
    public class Order : NamedEntity
    {
        public string Phone { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public virtual ICollection<OrderItem> items { get; set; }

        public virtual User User { get; set; }
    }
}

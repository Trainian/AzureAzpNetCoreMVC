using System;
using System.Collections.Generic;
using System.Text;
using AzureAspNetCore.Domain.Entities.Base;
using AzureAspNetCore.Models;

namespace AzureAspNetCore.Domain.Entities
{
    public class Brand : OrderedEntity
    {
        public virtual ICollection<Product> Products { get; set; }
    }
}

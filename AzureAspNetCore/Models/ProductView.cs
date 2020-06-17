using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureAspNetCore.Domain.Entities.Base;

namespace AzureAspNetCore.Models
{
    public class ProductView : OrderedEntity
    {
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
    }
}

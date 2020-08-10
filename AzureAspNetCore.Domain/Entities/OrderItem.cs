using AzureAspNetCore.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AzureAspNetCore.Domain.Entities
{
    public class OrderItem : BaseEntity
    {
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public int Count { get; set; }

        public int OrderId { get; set; }

        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }

    }
}

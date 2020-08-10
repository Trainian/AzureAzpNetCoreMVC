using System.ComponentModel.DataAnnotations.Schema;
using AzureAspNetCore.Domain.Entities.Base;

namespace AzureAspNetCore.Domain.Entities
{
    public class Product : OrderedEntity
    {
        public int SectionId { get; set; }

        [ForeignKey("SectionId")]
        public virtual Section Section { get; set; }

        public int? BrandId { get; set; }

        [ForeignKey("BrandId")]
        public virtual Brand Brand { get; set; }

        public string ImageUrl { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureAspNetCore.Models
{
    /// <summary>
    /// Класс для фильтрации товаров
    /// </summary>
    public class ProductFilter
    {
        public int? SectionId { get; set; }
        public int? BrandId { get; set; }
    }
}

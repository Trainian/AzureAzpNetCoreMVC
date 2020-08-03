using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureAspNetCore.Infrastructure.Sql;
using AzureAspNetCore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AzureAspNetCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        private readonly SqlProductData _sqlProductData;

        public ProductController(SqlProductData sqlProductData)
        {
            _sqlProductData = sqlProductData;
        }
        public IActionResult Products() //TODO: Исправить View для Продуктов, что бы можно было видеть Брэнд и Секцию
        {
            var products = _sqlProductData.GetProducts(new ProductFilter());
            var model = new CatalogView()
            {
                BrandId = null,
                SectionId = null,
                Products = products.Select(p => new ProductView()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Order = p.Order,
                    ImageUrl = p.ImageUrl,
                    Price = p.Price
                }).OrderBy(p => p.Order).ToList()
            };
            return View(model);
        }

        public IActionResult Brends()
        {
            return View();
        }

        public IActionResult Sections()
        {
            return View();
        }
    }
}

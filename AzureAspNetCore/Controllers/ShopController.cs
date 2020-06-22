using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AzureAspNetCore.Infrastructure.Interfaces;
using AzureAspNetCore.Models;

namespace AzureAspNetCore.Controllers
{
    public class ShopController : Controller
    {
        private readonly IProductData _products;

        public ShopController(IProductData products)
        {
            _products = products;
        }

        public IActionResult Products(int? sectionId, int? brandId)
        {
            var products = _products.GetProducts(new ProductFilter { SectionId = sectionId, BrandId = brandId });
            var model = new CatalogView()
            {
                BrandId = brandId,
                SectionId = sectionId,
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

        public IActionResult Product_Details()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
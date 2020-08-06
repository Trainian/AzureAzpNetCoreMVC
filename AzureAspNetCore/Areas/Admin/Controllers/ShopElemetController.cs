using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureAspNetCore.Domain.Entities;
using AzureAspNetCore.Infrastructure.Interfaces;
using AzureAspNetCore.Infrastructure.Sql;
using AzureAspNetCore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductView = AzureAspNetCore.Areas.Admin.Models.ProductView;

namespace AzureAspNetCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ShopElemetController : Controller
    {
        private readonly IProductData _sqlProductData;

        public ShopElemetController(IProductData sqlProductData)
        {
            _sqlProductData = sqlProductData;
        }
        public IActionResult Products()
        {
            List<ProductView> productsViews = new List<ProductView>();
            var products = _sqlProductData.GetProducts(new ProductFilter());
            foreach (var product in products)
            {
                productsViews.Add(new ProductView()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Order = product.Order,
                    ImageUrl = product.ImageUrl,
                    BrandId = product.BrandId,
                    SectionId = product.SectionId
                });
            }
            return View(productsViews);
        }

        [HttpGet]
        public IActionResult Product(int? id)
        {
            ViewBag.Brands = _sqlProductData.GetBrands();
            ViewBag.Sections = _sqlProductData.GetSections();

            var product = id != null ? _sqlProductData.GetProductById((int)id) : new Product(){Id = -1};
            return View(product);
        }

        [HttpPost]
        public IActionResult Product(Product product) // TODO: Реализовать POST для Product
        {
            ViewBag.Brands = new List<Brand>();
            ViewBag.Sections = new List<Section>();
            if (ModelState.IsValid)
            {
                if (product.Id != -1)
                {

                }
            }
            return View(product);
        }

        public IActionResult Brands() // TODO: Реализовать GET для Brands
        {
            var brands = _sqlProductData.GetBrands();
            return View(brands);
        }

        public IActionResult Sections() // TODO: Реализовать GET для Sections
        {
            var sections = _sqlProductData.GetSections();
            return View(sections);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AzureAspNetCore.Areas.Admin.Models;
using AzureAspNetCore.Domain.Entities;
using AzureAspNetCore.Infrastructure.Interfaces;
using AzureAspNetCore.Infrastructure.Sql;
using AzureAspNetCore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProductView = AzureAspNetCore.Areas.Admin.Models.ProductView;

namespace AzureAspNetCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ShopElemetController : Controller
    {
        private readonly IProductData _sqlProductData;
        private readonly IWebHostEnvironment _environment;

        public ShopElemetController(IProductData sqlProductData, IWebHostEnvironment environment)
        {
            _sqlProductData = sqlProductData;
            _environment = environment;
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
                    Brand = new BrandSectionView()
                    {
                        Id = product.Brand.Id,
                        Name = product.Brand.Name,
                        Order = product.Brand.Order
                    },
                    Section = new BrandSectionView()
                    {
                        Id = product.Section.Id,
                        Name = product.Section.Name,
                        Order = product.Section.Order
                    }
                });
            }
            return View(productsViews);
        }

        [HttpGet]
        public IActionResult Product(int? id)
        {      
            var productDB = id != null ? _sqlProductData.GetProductById((int)id) : new Product(){Id = -1};
            var productView = new ProductView()
            {
                Id = productDB.Id,
                Name = productDB.Name,
                Order = productDB.Order,
                Price = productDB.Price,
                ImageUrl = productDB.ImageUrl,
                BrandId = (int)(productDB.BrandId != null ? productDB.BrandId : null),
                Brand = new BrandSectionView()
                {
                    Id = productDB.Brand.Id,
                    Name = productDB.Brand.Name,
                    Order = productDB.Brand.Order
                },
                SectionId = productDB.SectionId,
                Section = new BrandSectionView()
                { 
                    Id = productDB.Section.Id,
                    Name = productDB.Section.Name,
                    Order = productDB.Section.Order
                }
            };

            var brands = _sqlProductData.GetBrands();
            ViewBag.Brands = new SelectList(brands, "Id", "Name", productView.BrandId);

            var sections = _sqlProductData.GetSections();
            ViewBag.Sections = new SelectList(sections, "Id", "Name", productView.SectionId);

            return View(productView);
        }

        [HttpPost]
        public async Task<IActionResult> Product(ProductView product, IFormFile? formFile)
        {
            ViewBag.Brands = new List<Brand>();
            ViewBag.Sections = new List<Section>();

            if (ModelState.IsValid)
            {
                if (product.Id != -1)
                {
                    var productDB = _sqlProductData.GetProductById(product.Id);
                    productDB.Name = product.Name;
                    productDB.Order = product.Order;
                    productDB.Price = product.Price;
                    productDB.ImageUrl = formFile?.FileName ?? product.ImageUrl;
                    productDB.BrandId = product.BrandId;
                    productDB.SectionId = product.SectionId;
                }
                else
                {
                    var productNew = new Product()
                    {
                        Name = product.Name,
                        Order = product.Order,
                        Price = product.Price,
                        ImageUrl = formFile?.FileName ?? product.ImageUrl,
                        BrandId = product.BrandId,
                        SectionId = product.SectionId
                    };
                    _sqlProductData.CreateProduct(productNew);
                }

                if (formFile != null)
                {
                    var path = "/images/shop/" + formFile.FileName;

                    using (var fs = new FileStream(_environment.WebRootPath + path, FileMode.Create))
                    {
                        await formFile.CopyToAsync(fs);
                    }
                }
                _sqlProductData.SaveDB();
                return RedirectToAction("Products", "ShopElemet", new { area = "Admin" });
            }

            var brands = _sqlProductData.GetBrands();
            ViewBag.Brands = new SelectList(brands, "Id", "Name");

            var sections = _sqlProductData.GetSections();
            ViewBag.Sections = new SelectList(sections, "Id", "Name");

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

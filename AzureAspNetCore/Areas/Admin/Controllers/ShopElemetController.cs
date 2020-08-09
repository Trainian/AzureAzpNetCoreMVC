﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureAspNetCore.Areas.Admin.Models;
using AzureAspNetCore.Domain.Entities;
using AzureAspNetCore.Infrastructure.Interfaces;
using AzureAspNetCore.Infrastructure.Sql;
using AzureAspNetCore.Models;
using Microsoft.AspNetCore.Authorization;
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
            
            var brands = _sqlProductData.GetBrands();
            ViewBag.Brands = new SelectList(brands, "Id", "Name");

            var sections = _sqlProductData.GetSections();
            ViewBag.Sections = new SelectList(sections, "Id", "Name");

            var productDB = id != null ? _sqlProductData.GetProductById((int)id) : new Product(){Id = -1};
            var productView = new ProductView()
            {
                Id = productDB.Id,
                Name = productDB.Name,
                Order = productDB.Order,
                Price = productDB.Price,
                ImageUrl = productDB.ImageUrl,
                Brand = new BrandSectionView()
                {
                    Id = productDB.Brand.Id,
                    Name = productDB.Brand.Name,
                    Order = productDB.Brand.Order
                },
                Section = new BrandSectionView()
                { 
                    Id = productDB.Section.Id,
                    Name = productDB.Section.Name,
                    Order = productDB.Section.Order
                }
            };

            return View(productView);
        }

        [HttpPost]
        public IActionResult Product(ProductView product, IFormFile? formFile) // TODO: Реализовать POST для Product
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

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureAspNetCore.Infrastructure.Interfaces;
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
        private readonly IProductData _sqlProductData;

        public ProductController(IProductData sqlProductData)
        {
            _sqlProductData = sqlProductData;
        }
        public IActionResult Products() //TODO: Исправить View для Продуктов, что бы можно было видеть Брэнд и Секцию
        {
            var products = _sqlProductData.GetProducts(new ProductFilter());
            return View(products);
        }

        public IActionResult Brends()
        {
            var brends = _sqlProductData.GetBrands();
            return View(brends);
        }

        public IActionResult Sections()
        {
            var sections = _sqlProductData.GetSections();
            return View(sections);
        }
    }
}

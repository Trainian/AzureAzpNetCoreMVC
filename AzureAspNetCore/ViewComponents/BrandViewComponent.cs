﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureAspNetCore.Infrastructure.Interfaces;
using AzureAspNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace AzureAspNetCore.ViewComponents
{
    public class BrandViewComponent : ViewComponent
    {
        private readonly IProductData _productData;

        public BrandViewComponent(IProductData productData)
        {
            _productData = productData;
        }

        public IViewComponentResult Invoke()
        {
            var brands = GetBrands();
            return View(brands);
        }

        private List<BrandView> GetBrands()
        {
            var brands = _productData.GetBrands();
            var listBrands = new List<BrandView>();
            foreach (var brand in brands)
            {
                listBrands.Add(new BrandView()
                {
                    Id = brand.Id,
                    Name = brand.Name,
                    Order = brand.Order,
                    ProductsCount = _productData.GetBrandProductsCount(brand.Id)
                });
            }

            listBrands.OrderBy(e => e.Id).ToList();
            return listBrands;
        }
    }
}

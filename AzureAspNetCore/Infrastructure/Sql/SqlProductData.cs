using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureAspNetCore.DAL.Context;
using AzureAspNetCore.Domain.Entities;
using AzureAspNetCore.Infrastructure.Interfaces;
using AzureAspNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace AzureAspNetCore.Infrastructure.Sql
{
    public class SqlProductData : IProductData
    {
        private readonly AzureAspNetCoreContext _context;

        public SqlProductData(AzureAspNetCoreContext context)
        {
            _context = context;
        }

        public IEnumerable<Brand> GetBrands()
        {
            return _context.Brands.ToList();
        }

        public IEnumerable<Section> GetSections()
        {
            return _context.Sections.ToList();
        }

        public IEnumerable<Product> GetProducts(ProductFilter filter)
        {
            var products = _context.Products.Include(c => c.Brand).Include(c => c.Section).AsQueryable();
            if (filter != null)
            {
                if (filter.SectionId.HasValue)
                    products = products.Where(p => p.SectionId.Equals(filter.SectionId.Value));
                if (filter.BrandId.HasValue)
                    products = products.Where(p => p.BrandId.HasValue && p.BrandId.Equals(filter.BrandId.Value));
            }
            return products.ToList();
        }

        public int GetBrandProductsCount(int brandId)
        {
            return _context.Products.Count(p => p.BrandId == brandId);
        }

        public Product GetProductById(int productId)
        {
            return _context.Products.Include(c => c.Brand).Include(c => c.Section).FirstOrDefault(c => c.Id.Equals(productId));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureAspNetCore.Domain.Entities;
using AzureAspNetCore.Models;
using AzureAspNetCore.Models.Cart;

namespace AzureAspNetCore.Infrastructure.Interfaces
{
    public interface IProductData
    {
        IEnumerable<Brand> GetBrands();

        IEnumerable<Section> GetSections();

        IEnumerable<Product> GetProducts(ProductFilter filter);

        int GetBrandProductsCount(int brandId);

        Product GetProductById(int brandId);

        public void CreateProduct(Product product);

        public void SaveDB();

        void CreateOrder(Order order);
    }
}

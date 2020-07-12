using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureAspNetCore.Models.Cart
{
    public class CartView
    {
        public Dictionary<ProductView, int> Items { get; set; }

        public int ItemsCount
        {
            get
            {
                return Items?.Sum(x => x.Value) ?? 0;
            }
        }
    }
}

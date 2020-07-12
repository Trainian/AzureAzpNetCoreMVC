using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureAspNetCore.Models.Cart
{
    public class Cart
    {
        public List<CartItem> CartItems { get; set; }

        public int ItemsCount
        {
            get
            {
                return CartItems?.Sum(x => x.Quantity) ?? 0;
            }
        }
    }
}

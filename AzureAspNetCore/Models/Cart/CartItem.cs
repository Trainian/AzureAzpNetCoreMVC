using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureAspNetCore.Models.Cart
{
    public class CartItem
    {
        /// <summary>
        /// Продукт
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Кол-во в заказе
        /// </summary>
        public int Quantity { get; set; }
    }
}

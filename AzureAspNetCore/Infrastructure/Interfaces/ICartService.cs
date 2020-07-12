using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureAspNetCore.Models.Cart;

namespace AzureAspNetCore.Infrastructure.Interfaces
{
    public interface ICartService
    {
        void DecrementFromCart(int id);

        void RemoveFromCart(int id);

        void RemoveAll();

        void AddToCart(int id);

        CartView TransformCart();
    }
}

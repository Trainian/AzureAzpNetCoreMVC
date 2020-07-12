using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureAspNetCore.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AzureAspNetCore.ViewComponents
{
    public class CartViewComponent : ViewComponent
    {
        private readonly ICartService _cart;

        public CartViewComponent(ICartService cart)
        {
            _cart = cart;
        }
        public IViewComponentResult Invoke()
        {
            var items = _cart.TransformCart().ItemsCount;
            return View(items);
        }
    }
}

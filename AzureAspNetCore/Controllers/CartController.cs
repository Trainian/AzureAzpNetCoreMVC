using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureAspNetCore.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AzureAspNetCore.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        public IActionResult Cart()
        {
            var cart = _cartService.TransformCart();
            return View(cart);
        }

        public IActionResult Checkout()
        {
            var cart = _cartService.TransformCart();
            return View(cart);
        }

        public IActionResult DecrementItem(int id)
        {
            _cartService.DecrementFromCart(id);
            return RedirectToAction("Cart", "Cart");
        }

        public IActionResult AddItem(int id, string redirectUrl)
        {
            _cartService.AddToCart(id);
            if (Url.IsLocalUrl(redirectUrl))
                return Redirect(redirectUrl);
            return RedirectToAction("Cart", "Cart");
        }

        public IActionResult RemoveItem(int id)
        {
            _cartService.RemoveFromCart(id);
            return RedirectToAction("Cart", "Cart");
        }
    }
}

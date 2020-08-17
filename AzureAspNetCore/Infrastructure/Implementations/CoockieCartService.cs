using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureAspNetCore.Infrastructure.Interfaces;
using AzureAspNetCore.Models;
using AzureAspNetCore.Models.Cart;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace AzureAspNetCore.Infrastructure.Implementations
{
    public class CoockieCartService : ICartService
    {
        private readonly IProductData _productData;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly string _cartName;

        private Cart Cart
        {
            get
            {
                var coockie = _httpContextAccessor.HttpContext.Request.Cookies[_cartName];

                string json = String.Empty;
                Cart cart = null;

                if (coockie == null)
                {
                    cart = new Cart{CartItems = new List<CartItem>()};
                    json = JsonConvert.SerializeObject(cart);

                    _httpContextAccessor.HttpContext.Response.Cookies.Append(_cartName, json, new CookieOptions(){Expires = DateTime.Now.AddDays(1)});
                    return cart;
                }

                json = coockie;
                cart = JsonConvert.DeserializeObject<Cart>(json);

                _httpContextAccessor.HttpContext.Response.Cookies.Delete(_cartName);
                _httpContextAccessor.HttpContext.Response.Cookies.Append(_cartName, json, new CookieOptions(){Expires = DateTime.Now.AddDays(1)});

                return cart;
            }
            set
            {
                var json = JsonConvert.SerializeObject(value);

                _httpContextAccessor.HttpContext.Response.Cookies.Delete(_cartName);
                _httpContextAccessor.HttpContext.Response.Cookies.Append(_cartName, json, new CookieOptions(){Expires = DateTime.Now.AddDays(1)});
                return;
            }
        }

        public CoockieCartService(IProductData productData, IHttpContextAccessor httpContextAccessor)
        {
            _productData = productData;
            _httpContextAccessor = httpContextAccessor;
            _cartName = "cart" + (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated
                ? _httpContextAccessor.HttpContext.User.Identity.Name
                : "");
        }

        public void DecrementFromCart(int id)
        {
            var cart = Cart;
            var item = cart.CartItems.FirstOrDefault(x => x.ProductId == id);
            if (item != null)
            {
                if (item.Quantity > 0)
                    item.Quantity--;
                if (item.Quantity == 0)
                    cart.CartItems.Remove(item);
            }

            Cart = cart;
        }

        public void RemoveFromCart(int id)
        {
            var cart = Cart;
            var item = cart.CartItems.FirstOrDefault(x => x.ProductId == id);
            if (item != null)
                cart.CartItems.Remove(item);
            Cart = cart;
        }

        public void RemoveAll()
        {
            Cart.CartItems.Clear();
        }

        public void AddToCart(int id)
        {
            var cart = Cart;
            var item = cart.CartItems.FirstOrDefault(x => x.ProductId == id);
            if (item != null)
                item.Quantity++;
            else
                cart.CartItems.Add(new CartItem(){ProductId = id, Quantity = 1});
            Cart = cart;

        }

        public CartView TransformCart()
        {
            var products = _productData.GetProducts(new ProductFilter()
            {
                Ids = Cart.CartItems.Select(i => i.ProductId).ToList()
            }).Select(p => new ProductView()
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Order = p.Order,
                ImageUrl = p.ImageUrl
            }).ToList();

            var r = new CartView()
            {
                Items = Cart.CartItems.ToDictionary(x => products.First(y => y.Id == x.ProductId), x => x.Quantity)
            };

            return r;
        }

    }
}

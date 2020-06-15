using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AzureAspNetCore.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Products()
        {
            return View();
        }

        public IActionResult Product_Details()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
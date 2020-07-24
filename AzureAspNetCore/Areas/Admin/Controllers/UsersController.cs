using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureAspNetCore.Areas.Admin.Infrastructure.Implementations;
using AzureAspNetCore.Areas.Admin.Infrastructure.Interfaces;
using AzureAspNetCore.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AzureAspNetCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class UsersController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IUserService _userService;

        public UsersController(UserManager<User> userManager, RoleManager<Role> roleManager, IUserService userService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var users = _userService.GetAll();
            return View(users);
        }
    }
}

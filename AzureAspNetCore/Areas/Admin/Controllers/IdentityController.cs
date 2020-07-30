using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureAspNetCore.Areas.Admin.Infrastructure.Implementations;
using AzureAspNetCore.Areas.Admin.Infrastructure.Interfaces;
using AzureAspNetCore.Areas.Admin.Models;
using AzureAspNetCore.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NUglify.Helpers;

namespace AzureAspNetCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class IdentityController : Controller
    {
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;

        public IdentityController(IUserService userService, IRoleService roleService)
        {
            _userService = userService;
            _roleService = roleService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var users = _userService.GetAll();
            return View(users);
        }

        [HttpGet]
        public async Task<IActionResult> User(string id)
        {
            var user = new UserView();

            if (!id.IsNullOrWhiteSpace())
            {
                user = _userService.GetById(id);
            }            
            
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> User(UserView user, string password)
        {            
            if (ModelState.IsValid)
            {
                _userService.UpdateUser(user);
                _userService.UpdateRoles(user);
                return RedirectToAction("Index");
            }
            else
            {
                return View(user);
            }
        }
    }
}

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
            user.Roles = (List<RoleView>)_roleService.GetAll();

            if (!id.IsNullOrWhiteSpace())
            {
                user = _userService.GetById(id);
            }            
            
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> User(UserView user, string password)
        {            
            if(user.Id == null && string.IsNullOrEmpty(password))
            {
                ModelState.AddModelError("Password", "Пароль не может быть пустым");
            }
            if (ModelState.IsValid)
            {
                if(user.Id != null)
                {
                    _userService.UpdateUser(user);
                    await _userService.UpdateRoles(user);
                    return RedirectToAction("Index");
                }
                else
                {
                    _userService.CreateNew(user, password);
                    await _userService.UpdateRoles(user);
                    return RedirectToAction("Index");
                }
            }
            else
            {
                return View(user);
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUser(string id, string redirectUrl)
        {
            _userService.Delete(id);
            if (Url.IsLocalUrl(redirectUrl))
                return Redirect(redirectUrl);
            else
                return RedirectToAction("Index", "Admin");
        }
    }
}

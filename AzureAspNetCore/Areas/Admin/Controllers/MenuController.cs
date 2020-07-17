using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureAspNetCore.Domain.Entities;
using AzureAspNetCore.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AzureAspNetCore.Areas.Admin.Controllers
{
    public class MenuController : Controller
    {
        private readonly IEmployeesData employeesData;
        private readonly UserManager<User> userManager;

        public MenuController(IEmployeesData employeesData, UserManager<User> userManager)
        {
            this.employeesData = employeesData;
            this.userManager = userManager;
        }

        [Area("Admin")]
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            ViewBag.Title = "Панель";
            return View();
        }

        public IActionResult Employees()
        {
            ViewBag.Title = "Cущьности";
            var employees = employeesData.GetAll();
            return View(employees);
        }
    }
}

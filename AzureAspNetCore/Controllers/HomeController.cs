using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureAspNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace AzureAspNetCore.Controllers
{
    public class HomeController : Controller
    {
        private List<EmployeeViews> employees = new List<EmployeeViews>()
        {
            new EmployeeViews("Дмитрий","Горбовский",29),
            new EmployeeViews("Алина","Горбовская",25),
            new EmployeeViews("Иван","Иванович",45)
        };

        public IActionResult Index()
        {
            return View();
        }
    }
}
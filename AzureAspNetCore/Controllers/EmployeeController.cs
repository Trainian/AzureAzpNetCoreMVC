using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureAspNetCore.Infrastructure.Interfaces;
using AzureAspNetCore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AzureAspNetCore.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        private readonly IEmployeesData _employeesData;

        public EmployeeController (IEmployeesData employeesData)
        {
            _employeesData = employeesData;
        }

        public IActionResult Index()
        {
            var employees = _employeesData.GetAll();
            return View(employees);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult EmployeeView(int id)
        {
            var employee = _employeesData.GetByID(id);
            if (id == 0 || employee == null)
                employee = new EmployeeViews(0, null, null, 0);
            return View(employee);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult EmployeeView(EmployeeViews employee)
        {
            if (ModelState.IsValid)
            {
                if (employee.Id == 0)
                {
                    employee.Id = _employeesData.GetAll().Max(e => e.Id) + 1;
                    _employeesData.AddNew(employee);
                }
                else
                {
                    var empl = _employeesData.GetByID(employee.Id);
                    empl.FirstName = employee.FirstName;
                    empl.LastName = employee.LastName;
                    empl.Age = employee.Age;
                }
                return RedirectToAction("Index");
            }
            else
            {
                return View(employee);
            }
        }

        [Authorize(Roles = "Admin")]
        public IActionResult EmployeeDelete(int id)
        {
            _employeesData.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
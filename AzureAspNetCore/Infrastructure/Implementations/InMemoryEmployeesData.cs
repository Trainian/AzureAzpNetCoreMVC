using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureAspNetCore.Infrastructure.Interfaces;
using AzureAspNetCore.Models;

namespace AzureAspNetCore.Infrastructure.Implementations
{
    public class InMemoryEmployeesData : IEmployeesData
    {
        private readonly List<EmployeeViews> _employees;

        public InMemoryEmployeesData()
        {
            _employees = new List<EmployeeViews>()
            {
                new EmployeeViews(1,"Дмитрий", "Горбовский", 29),
                new EmployeeViews(2,"Алина", "Котар", 25),
                new EmployeeViews(3,"Василий", "Пупкин", 30)
            };
        }
        
        public IEnumerable<EmployeeViews> GetAll()
        {
            return _employees;
        }

        public EmployeeViews GetByID(int id)
        {
            EmployeeViews employee = _employees.FirstOrDefault(e => e.Id == id);
            return employee;
        }

        public void AddNew(EmployeeViews employee)
        {
            employee.Id = _employees.Max(e => e.Id) + 1;
            _employees.Add(employee);
        }

        public void Delete(int id)
        {
            var employee = _employees.FirstOrDefault(e => e.Id == id);
            if (employee != null)
                _employees.Remove(employee);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureAspNetCore.Models;

namespace AzureAspNetCore.Infrastructure.Interfaces
{
    public interface IEmployeesData
    {
        /// <summary>
        /// Получить список сотрудников
        /// </summary>
        /// <returns></returns>
        IEnumerable<EmployeeViews> GetAll();

        /// <summary>
        /// Найти сотрудника по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        EmployeeViews GetByID(int id);
        
        /// <summary>
        /// Добавить нового сотрудника
        /// </summary>
        /// <param name="employee"></param> 
        void AddNew(EmployeeViews employee);

        /// <summary>
        /// Удалить сотрудника по id
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);
    }
}

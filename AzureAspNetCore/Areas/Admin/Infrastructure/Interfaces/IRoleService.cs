using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureAspNetCore.Areas.Admin.Models;
using Microsoft.AspNetCore.Identity;

namespace AzureAspNetCore.Areas.Admin.Infrastructure.Interfaces
{
    public interface IRoleService
    {
        /// <summary>
        /// Получить все Роли
        /// </summary>
        /// <returns></returns>
        IEnumerable<RoleView> GetAll();

        /// <summary>
        /// Получить Роль по Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        RoleView GetById(string id);

        /// <summary>
        /// Создать новую Роль
        /// </summary>
        /// <param name=""></param>
        void NewRole(RoleView roleView);

        /// <summary>
        /// Удалить роль по Id
        /// </summary>
        /// <param name="id"></param>
        void Delete(string id);

        /// <summary>
        /// Обновить роли, подключить или отключить
        /// </summary>
        /// <param name="roles"></param>
        void UpdateRoles(List<string> roles);
    }
}

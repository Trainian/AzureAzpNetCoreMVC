using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureAspNetCore.Areas.Admin.Models;

namespace AzureAspNetCore.Areas.Admin.Infrastructure.Interfaces
{
    public interface IUserService
    {
        /// <summary>
        /// Вернуть список пользователей
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<UserView>> GetAll();

        /// <summary>
        /// Вывести пользователя по Id
        /// </summary>
        /// <returns></returns>
        Task<UserView> GetById(string id);

        /// <summary>
        /// Обновить данные пользователя
        /// </summary>
        /// <param name="user"></param>
        Task UpdateUser(UserView user);

        /// <summary>
        /// Создать нового пользователя
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        Task CreateNew(UserView user, string password);

        /// <summary>
        /// Удалить пользователя
        /// </summary>
        /// <param name="userView"></param>
        Task Delete(string id);

        /// <summary>
        /// Обновить роли пользователя
        /// </summary>
        /// <param name="userView"></param>
        Task UpdateRoles(UserView userView);
    }
}

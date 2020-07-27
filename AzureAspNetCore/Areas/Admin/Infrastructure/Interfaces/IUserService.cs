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
        IEnumerable<UserView> GetAll();

        /// <summary>
        /// Вывести пользователя по Id
        /// </summary>
        /// <returns></returns>
        UserView GetById(string id);

        /// <summary>
        /// Обновить данные пользователя
        /// </summary>
        /// <param name="user"></param>
        void UpdateUser(UserView user);

        /// <summary>
        /// Создать нового пользователя
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        void CreateNew(UserView user, string password);

        /// <summary>
        /// Удалить пользователя
        /// </summary>
        /// <param name="id"></param>
        void Delete(string id);
    }
}

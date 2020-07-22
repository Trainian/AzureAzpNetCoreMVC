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
        public IEnumerable<UserView> GetAll();

        /// <summary>
        /// Вывести пользователя по Id
        /// </summary>
        /// <returns></returns>
        public UserView GetById();

        /// <summary>
        /// Создать нового пользователя
        /// </summary>
        /// <param name="user"></param>
        public void CreateNew(UserView user);

        /// <summary>
        /// Удалить пользователя
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AzureAspNetCore.Areas.Admin.Infrastructure.Interfaces;
using AzureAspNetCore.Areas.Admin.Models;
using AzureAspNetCore.DAL.Context;
using AzureAspNetCore.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AzureAspNetCore.Areas.Admin.Infrastructure.Implementations
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly IRoleService _roleService;
        private readonly AzureAspNetCoreContext _context;

        public UserService(UserManager<User> userManager, IRoleService roleService, AzureAspNetCoreContext context)
        {
            _userManager = userManager;
            _roleService = roleService;
            _context = context;
        }

        public IEnumerable<UserView> GetAll()
        {
            var usersView = new List<UserView>();
            var usersDB = _userManager.Users.ToList();
            
            foreach (var user in usersDB)
            {
                usersView.Add(new UserView()
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
                    Roles = GetEnabledRoles(user).Result
            });
            }
            return usersView;
        }

        public UserView GetById(string id)
        {
            var userDB = GetUserById(id);
            var userView = new UserView()
            {
                Id = userDB.Id,
                UserName = userDB.UserName,
                Email = userDB.Email,
                PhoneNumber = userDB.PhoneNumber,
                Roles = GetEnabledRoles(userDB).Result
            };
            return userView;
        }

        public void UpdateUser(UserView userView)
        {
            var userDB = UserViewToUser(userView);
            userDB.UserName = userView.UserName;
            userDB.Email = userView.Email;
            userDB.PhoneNumber = userView.PhoneNumber;
        }

        public async Task CreateNew(UserView userView, string password)
        {
            var userDB = new User()
            {
                UserName = userView.UserName,
                Email = userView.Email,
                PhoneNumber = userView.PhoneNumber
            };
            await _userManager.CreateAsync(userDB, password);
        }

        public void Delete(string id)
        {
            var user = GetUserById(id);
            _userManager.DeleteAsync(user);
        }

        public async Task UpdateRoles(UserView userView)
        {
            var user = UserViewToUser(userView);
            var rolesAllDB = _roleService.GetAll();
            var rolesAll = new List<string>();
            var rolesEnabled = new List<string>();

            foreach(var role in rolesAllDB) // Все роли в БД
            {
                rolesAll.Add(role.Name);
            }

            foreach(var role in userView.Roles) // Все роли используемые пользователем
            {
                if (role.IsEnable)
                    rolesEnabled.Add(role.Name);
            }

            await _userManager.RemoveFromRolesAsync(user, rolesAll); // Очищаем Роли
            await _userManager.AddToRolesAsync(user, rolesEnabled); // Добавляем актуальные Роли
        }

        private User UserViewToUser (UserView userView)
        {
            return _userManager.Users.FirstOrDefault(x => x.Id == userView.Id);
        }

        private User GetUserById (string id)
        {
            return _userManager.Users.FirstOrDefault(x => x.Id == id);
        }

        private async Task<List<RoleView>> GetEnabledRoles (User userDB)
        {
            var enabledRoles = await _userManager.GetRolesAsync(userDB);
            
            var allRoles = _roleService.GetAll();
            foreach(var role in allRoles)
            {
                foreach(var roleEnable in enabledRoles)
                {
                    if (role.Name == roleEnable)
                        role.IsEnable = true;
                }
            }
            return allRoles.ToList();
        }
    }
}

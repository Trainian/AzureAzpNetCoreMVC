using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureAspNetCore.Areas.Admin.Infrastructure.Interfaces;
using AzureAspNetCore.Areas.Admin.Models;
using AzureAspNetCore.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AzureAspNetCore.Areas.Admin.Infrastructure.Implementations
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public UserService(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IEnumerable<UserView> GetAll()
        {
            var usersView = new List<UserView>();
            var usersDB = _userManager.Users.ToList();
            
            foreach (var user in usersDB)
            {
                usersView.Add(new UserView()
                {
                    Id = int.Parse(user.Id),
                    UserName = user.UserName,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
                });
            }
            return usersView;
        }

        public UserView GetById()
        {
            throw new NotImplementedException();
        }

        public void CreateNew(UserView user)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}

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
        private readonly AzureAspNetCoreContext _context;

        public UserService(UserManager<User> userManager, AzureAspNetCoreContext context)
        {
            _userManager = userManager;
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
                    Role = (List<string>)_userManager.GetRolesAsync(user).Result
            });
            }
            return usersView;
        }

        public UserView GetById(string id)
        {
            var userDB = _userManager.Users.FirstOrDefault(x => x.Id == id);
            var userView = new UserView()
            {
                Id = userDB.Id,
                UserName = userDB.UserName,
                Email = userDB.Email,
                PhoneNumber = userDB.PhoneNumber,
                Role = (List<string>)_userManager.GetRolesAsync(userDB).Result
            };
            return userView;
        }

        public void UpdateUser(UserView user)
        {
            var userDB = _userManager.Users.First(x => x.Id == user.Id);
            userDB.UserName = user.UserName;
            userDB.Email = user.Email;
            userDB.PhoneNumber = user.PhoneNumber;
            _context.SaveChanges();
        }

        public void CreateNew(UserView user, string password)
        {
            var userDB = new User()
            {
                UserName = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber
            };
            _userManager.CreateAsync(userDB, password);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            _userManager.DeleteAsync(user);
            _context.SaveChanges();
        }

    }
}

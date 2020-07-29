using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureAspNetCore.Areas.Admin.Infrastructure.Interfaces;
using AzureAspNetCore.Areas.Admin.Models;
using AzureAspNetCore.DAL.Context;
using Microsoft.AspNetCore.Identity;

namespace AzureAspNetCore.Areas.Admin.Infrastructure.Implementations
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly AzureAspNetCoreContext _context;

        public RoleService(RoleManager<IdentityRole> roleManager, AzureAspNetCoreContext context)
        {
            _roleManager = roleManager;
            _context = context;
        }
        public IEnumerable<RoleView> GetAll()
        {
            var rolesView = new List<RoleView>();
            var rolesDB = _roleManager.Roles.ToList();
            foreach (var role in rolesDB)
            {
                rolesView.Add(new RoleView()
                {
                    Id = role.Id,
                    Name = role.Name
                });
                _context.SaveChanges();
            }

            return rolesView;
        }

        public RoleView GetById(string id)
        {
            var roleDB = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            RoleView roleView = new RoleView()
            {
                Id = roleDB.Id,
                Name = roleDB.Name
            };
            return roleView;
        }

        public void NewRole(RoleView roleView)
        {
            var roleDB = new IdentityRole(roleView.Name);
            _roleManager.CreateAsync(roleDB);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            var roleDB = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            _roleManager.DeleteAsync(roleDB);
            _context.SaveChanges();
        }
    }
}

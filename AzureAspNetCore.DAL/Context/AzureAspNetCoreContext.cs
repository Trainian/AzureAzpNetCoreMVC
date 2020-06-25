using System;
using System.Collections.Generic;
using System.Text;
using AzureAspNetCore.Domain.Entities;
using AzureAspNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace AzureAspNetCore.DAL.Context
{
    public class AzureAspNetCoreContext : DbContext
    {
        public AzureAspNetCoreContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Section> Sections { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}

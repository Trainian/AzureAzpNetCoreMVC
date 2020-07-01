using System;
using System.Collections.Generic;
using System.Text;
using AzureAspNetCore.Domain.Entities;
using AzureAspNetCore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AzureAspNetCore.DAL.Context
{
    public sealed class AzureAspNetCoreContext : IdentityDbContext<User>
    {
        public AzureAspNetCoreContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Section> Sections { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Brand>().HasData(
            #region Brands
                new Brand()
                {
                    Id = 1,
                    Name = "ACME",
                    Order = 0
                },
                new Brand()
                {
                    Id = 2,
                    Name = "Grüne Erde",
                    Order = 1
                },
                new Brand()
                {
                    Id = 3,
                    Name = "Albiro",
                    Order = 2
                },
                new Brand()
                {
                    Id = 4,
                    Name = "Ronhill",
                    Order = 3
                },
                new Brand()
                {
                    Id = 5,
                    Name = "Oddmolly",
                    Order = 4
                },
                new Brand()
                {
                    Id = 6,
                    Name = "Boudestijn",
                    Order = 5
                },
                new Brand()
                {
                    Id = 7,
                    Name = "Rösch creative culture",
                    Order = 6
                }
                #endregion
            );
            modelBuilder.Entity<Section>().HasData(
            #region Sections
                new Section()
                {
                    Id = 1,
                    Name = "Sportswear",
                    ParentId = null,
                    Order = 0
                },
                new Section()
                {
                    Id = 2,
                    Name = "Nike",
                    ParentId = 1,
                    Order = 0
                },
                new Section()
                {
                    Id = 3,
                    Name = "Under Armour",
                    ParentId = 1,
                    Order = 1
                },
                new Section()
                {
                    Id = 4,
                    Name = "Adidas",
                    ParentId = 1,
                    Order = 2
                },
                new Section()
                {
                    Id = 5,
                    Name = "Puma",
                    ParentId = 1,
                    Order = 3
                },
                new Section()
                {
                    Id = 6,
                    Name = "ASICS",
                    ParentId = 1,
                    Order = 4
                },
                new Section()
                {
                    Id = 7,
                    Name = "Mens",
                    ParentId = null,
                    Order = 1
                },
                new Section()
                {
                    Id = 8,
                    Name = "Fendi",
                    ParentId = 7,
                    Order = 0
                },
                new Section()
                {
                    Id = 9,
                    Name = "Guess",
                    ParentId = 7,
                    Order = 1
                },
                new Section()
                {
                    Id = 10,
                    Name = "Valentino",
                    ParentId = 7,
                    Order = 2
                },
                new Section()
                {
                    Id = 11,
                    Name = "Dior",
                    ParentId = 7,
                    Order = 3
                },
                new Section()
                {
                    Id = 12,
                    Name = "Versace",
                    ParentId = 7,
                    Order = 4
                },
                new Section()
                {
                    Id = 13,
                    Name = "Armani",
                    ParentId = 7,
                    Order = 5
                },
                new Section()
                {
                    Id = 14,
                    Name = "Prada",
                    ParentId = 7,
                    Order = 6
                },
                new Section()
                {
                    Id = 15,
                    Name = "Dolce and Gabbana",
                    ParentId = 7,
                    Order = 7
                },
                new Section()
                {
                    Id = 16,
                    Name = "Chanel",
                    ParentId = 7,
                    Order = 8
                },
                new Section()
                {
                    Id = 17,
                    Name = "Gucci",
                    ParentId = 7,
                    Order = 9
                },
                new Section()
                {
                    Id = 18,
                    Name = "Womens",
                    ParentId = null,
                    Order = 2
                },
                new Section()
                {
                    Id = 19,
                    Name = "Fendi",
                    ParentId = 18,
                    Order = 0
                },
                new Section()
                {
                    Id = 20,
                    Name = "Guess",
                    ParentId = 18,
                    Order = 1
                },
                new Section()
                {
                    Id = 21,
                    Name = "Valentino",
                    ParentId = 18,
                    Order = 2
                },
                new Section()
                {
                    Id = 22,
                    Name = "Dior",
                    ParentId = 18,
                    Order = 3
                },
                new Section()
                {
                    Id = 23,
                    Name = "Versace",
                    ParentId = 18,
                    Order = 4
                },
                new Section()
                {
                    Id = 24,
                    Name = "Kids",
                    ParentId = null,
                    Order = 3
                },
                new Section()
                {
                    Id = 25,
                    Name = "Fashion",
                    ParentId = null,
                    Order = 4
                },
                new Section()
                {
                    Id = 26,
                    Name = "Households",
                    ParentId = null,
                    Order = 5
                },
                new Section()
                {
                    Id = 27,
                    Name = "Interiors",
                    ParentId = null,
                    Order = 6
                },
                new Section()
                {
                    Id = 28,
                    Name = "Clothing",
                    ParentId = null,
                    Order = 7
                },
                new Section()
                {
                    Id = 29,
                    Name = "Bags",
                    ParentId = null,
                    Order = 8
                },
                new Section()
                {
                    Id = 30,
                    Name = "Shoes",
                    ParentId = null,
                    Order = 9
                }
                #endregion
            );
            modelBuilder.Entity<Product>().HasData(
            #region Products
                new Product()
                {
                    Id = 1,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product1.jpg",
                    Order = 0,
                    SectionId = 2,
                    BrandId = 1
                },
                new Product()
                {
                    Id = 2,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product2.jpg",
                    Order = 1,
                    SectionId = 2,
                    BrandId = 1
                },
                new Product()
                {
                    Id = 3,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product3.jpg",
                    Order = 2,
                    SectionId = 2,
                    BrandId = 1
                },
                new Product()
                {
                    Id = 4,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product4.jpg",
                    Order = 3,
                    SectionId = 2,
                    BrandId = 1
                },
                new Product()
                {
                    Id = 5,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product5.jpg",
                    Order = 4,
                    SectionId = 2,
                    BrandId = 2
                },
                new Product()
                {
                    Id = 6,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product6.jpg",
                    Order = 5,
                    SectionId = 2,
                    BrandId = 2
                },
                new Product()
                {
                    Id = 7,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product7.jpg",
                    Order = 6,
                    SectionId = 2,
                    BrandId = 2
                },
                new Product()
                {
                    Id = 8,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product8.jpg",
                    Order = 7,
                    SectionId = 25,
                    BrandId = 2
                },
                new Product()
                {
                    Id = 9,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product9.jpg",
                    Order = 8,
                    SectionId = 25,
                    BrandId = 2
                },
                new Product()
                {
                    Id = 10,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product10.jpg",
                    Order = 9,
                    SectionId = 25,
                    BrandId = 3
                },
                new Product()
                {
                    Id = 11,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product11.jpg",
                    Order = 10,
                    SectionId = 25,
                    BrandId = 3
                },
                new Product()
                {
                    Id = 12,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product12.jpg",
                    Order = 11,
                    SectionId = 25,
                    BrandId = 3
                }
                #endregion
            );

            //User - Admin
            modelBuilder.Entity<Role>().HasData(
                    new Role() {Id = "0", Name = "Admin", NormalizedName = "Admin"}
            );

            //Role - Admin
            var hash = new PasswordHasher<User>();
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = "0",
                    UserName = "Admin",
                    NormalizedUserName = "Admin",
                    PasswordHash = hash.HashPassword(null, "Admin")
                }
            );

            //UserRole - Admin
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "0",
                    UserId = "0"
                }
            );
        }
    }
}

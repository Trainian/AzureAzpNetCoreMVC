﻿// <auto-generated />
using System;
using AzureAspNetCore.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AzureAspNetCore.DAL.Migrations
{
    [DbContext(typeof(AzureAspNetCoreContext))]
    [Migration("20200627075128_InitializeNew")]
    partial class InitializeNew
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AzureAspNetCore.Domain.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "ACME",
                            Order = 0
                        },
                        new
                        {
                            Id = 2,
                            Name = "Grüne Erde",
                            Order = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Albiro",
                            Order = 2
                        },
                        new
                        {
                            Id = 4,
                            Name = "Ronhill",
                            Order = 3
                        },
                        new
                        {
                            Id = 5,
                            Name = "Oddmolly",
                            Order = 4
                        },
                        new
                        {
                            Id = 6,
                            Name = "Boudestijn",
                            Order = 5
                        },
                        new
                        {
                            Id = 7,
                            Name = "Rösch creative culture",
                            Order = 6
                        });
                });

            modelBuilder.Entity("AzureAspNetCore.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("SectionId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            ImageUrl = "product1.jpg",
                            Name = "Easy Polo Black Edition",
                            Order = 0,
                            Price = 1025m,
                            SectionId = 2
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 1,
                            ImageUrl = "product2.jpg",
                            Name = "Easy Polo Black Edition",
                            Order = 1,
                            Price = 1025m,
                            SectionId = 2
                        },
                        new
                        {
                            Id = 3,
                            BrandId = 1,
                            ImageUrl = "product3.jpg",
                            Name = "Easy Polo Black Edition",
                            Order = 2,
                            Price = 1025m,
                            SectionId = 2
                        },
                        new
                        {
                            Id = 4,
                            BrandId = 1,
                            ImageUrl = "product4.jpg",
                            Name = "Easy Polo Black Edition",
                            Order = 3,
                            Price = 1025m,
                            SectionId = 2
                        },
                        new
                        {
                            Id = 5,
                            BrandId = 2,
                            ImageUrl = "product5.jpg",
                            Name = "Easy Polo Black Edition",
                            Order = 4,
                            Price = 1025m,
                            SectionId = 2
                        },
                        new
                        {
                            Id = 6,
                            BrandId = 2,
                            ImageUrl = "product6.jpg",
                            Name = "Easy Polo Black Edition",
                            Order = 5,
                            Price = 1025m,
                            SectionId = 2
                        },
                        new
                        {
                            Id = 7,
                            BrandId = 2,
                            ImageUrl = "product7.jpg",
                            Name = "Easy Polo Black Edition",
                            Order = 6,
                            Price = 1025m,
                            SectionId = 2
                        },
                        new
                        {
                            Id = 8,
                            BrandId = 2,
                            ImageUrl = "product8.jpg",
                            Name = "Easy Polo Black Edition",
                            Order = 7,
                            Price = 1025m,
                            SectionId = 25
                        },
                        new
                        {
                            Id = 9,
                            BrandId = 2,
                            ImageUrl = "product9.jpg",
                            Name = "Easy Polo Black Edition",
                            Order = 8,
                            Price = 1025m,
                            SectionId = 25
                        },
                        new
                        {
                            Id = 10,
                            BrandId = 3,
                            ImageUrl = "product10.jpg",
                            Name = "Easy Polo Black Edition",
                            Order = 9,
                            Price = 1025m,
                            SectionId = 25
                        },
                        new
                        {
                            Id = 11,
                            BrandId = 3,
                            ImageUrl = "product11.jpg",
                            Name = "Easy Polo Black Edition",
                            Order = 10,
                            Price = 1025m,
                            SectionId = 25
                        },
                        new
                        {
                            Id = 12,
                            BrandId = 3,
                            ImageUrl = "product12.jpg",
                            Name = "Easy Polo Black Edition",
                            Order = 11,
                            Price = 1025m,
                            SectionId = 25
                        });
                });

            modelBuilder.Entity("AzureAspNetCore.Domain.Entities.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Sections");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Sportswear",
                            Order = 0
                        },
                        new
                        {
                            Id = 2,
                            Name = "Nike",
                            Order = 0,
                            ParentId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Under Armour",
                            Order = 1,
                            ParentId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "Adidas",
                            Order = 2,
                            ParentId = 1
                        },
                        new
                        {
                            Id = 5,
                            Name = "Puma",
                            Order = 3,
                            ParentId = 1
                        },
                        new
                        {
                            Id = 6,
                            Name = "ASICS",
                            Order = 4,
                            ParentId = 1
                        },
                        new
                        {
                            Id = 7,
                            Name = "Mens",
                            Order = 1
                        },
                        new
                        {
                            Id = 8,
                            Name = "Fendi",
                            Order = 0,
                            ParentId = 6
                        },
                        new
                        {
                            Id = 9,
                            Name = "Guess",
                            Order = 1,
                            ParentId = 6
                        },
                        new
                        {
                            Id = 10,
                            Name = "Valentino",
                            Order = 2,
                            ParentId = 6
                        },
                        new
                        {
                            Id = 11,
                            Name = "Dior",
                            Order = 3,
                            ParentId = 6
                        },
                        new
                        {
                            Id = 12,
                            Name = "Versace",
                            Order = 4,
                            ParentId = 6
                        },
                        new
                        {
                            Id = 13,
                            Name = "Armani",
                            Order = 5,
                            ParentId = 6
                        },
                        new
                        {
                            Id = 14,
                            Name = "Prada",
                            Order = 6,
                            ParentId = 6
                        },
                        new
                        {
                            Id = 15,
                            Name = "Dolce and Gabbana",
                            Order = 7,
                            ParentId = 6
                        },
                        new
                        {
                            Id = 16,
                            Name = "Chanel",
                            Order = 8,
                            ParentId = 6
                        },
                        new
                        {
                            Id = 17,
                            Name = "Gucci",
                            Order = 9,
                            ParentId = 6
                        },
                        new
                        {
                            Id = 18,
                            Name = "Womens",
                            Order = 2
                        },
                        new
                        {
                            Id = 19,
                            Name = "Fendi",
                            Order = 0,
                            ParentId = 17
                        },
                        new
                        {
                            Id = 20,
                            Name = "Guess",
                            Order = 1,
                            ParentId = 17
                        },
                        new
                        {
                            Id = 21,
                            Name = "Valentino",
                            Order = 2,
                            ParentId = 17
                        },
                        new
                        {
                            Id = 22,
                            Name = "Dior",
                            Order = 3,
                            ParentId = 17
                        },
                        new
                        {
                            Id = 23,
                            Name = "Versace",
                            Order = 4,
                            ParentId = 17
                        },
                        new
                        {
                            Id = 24,
                            Name = "Kids",
                            Order = 3
                        },
                        new
                        {
                            Id = 25,
                            Name = "Fashion",
                            Order = 4
                        },
                        new
                        {
                            Id = 26,
                            Name = "Households",
                            Order = 5
                        },
                        new
                        {
                            Id = 27,
                            Name = "Interiors",
                            Order = 6
                        },
                        new
                        {
                            Id = 28,
                            Name = "Clothing",
                            Order = 7
                        },
                        new
                        {
                            Id = 29,
                            Name = "Bags",
                            Order = 8
                        },
                        new
                        {
                            Id = 30,
                            Name = "Shoes",
                            Order = 9
                        });
                });

            modelBuilder.Entity("AzureAspNetCore.Domain.Entities.Product", b =>
                {
                    b.HasOne("AzureAspNetCore.Domain.Entities.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId");

                    b.HasOne("AzureAspNetCore.Domain.Entities.Section", "Section")
                        .WithMany("Products")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AzureAspNetCore.Domain.Entities.Section", b =>
                {
                    b.HasOne("AzureAspNetCore.Domain.Entities.Section", "ParentSection")
                        .WithMany()
                        .HasForeignKey("ParentId");
                });
#pragma warning restore 612, 618
        }
    }
}

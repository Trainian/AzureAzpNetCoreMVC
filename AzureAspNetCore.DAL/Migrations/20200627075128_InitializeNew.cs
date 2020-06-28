using Microsoft.EntityFrameworkCore.Migrations;

namespace AzureAspNetCore.DAL.Migrations
{
    public partial class InitializeNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { 1, "ACME", 0 },
                    { 2, "Grüne Erde", 1 },
                    { 3, "Albiro", 2 },
                    { 4, "Ronhill", 3 },
                    { 5, "Oddmolly", 4 },
                    { 6, "Boudestijn", 5 },
                    { 7, "Rösch creative culture", 6 }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name", "Order", "ParentId" },
                values: new object[,]
                {
                    { 28, "Clothing", 7, null },
                    { 27, "Interiors", 6, null },
                    { 26, "Households", 5, null },
                    { 25, "Fashion", 4, null },
                    { 7, "Mens", 1, null },
                    { 18, "Womens", 2, null },
                    { 29, "Bags", 8, null },
                    { 1, "Sportswear", 0, null },
                    { 24, "Kids", 3, null },
                    { 30, "Shoes", 9, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "ImageUrl", "Name", "Order", "Price", "SectionId" },
                values: new object[,]
                {
                    { 8, 2, "product8.jpg", "Easy Polo Black Edition", 7, 1025m, 25 },
                    { 9, 2, "product9.jpg", "Easy Polo Black Edition", 8, 1025m, 25 },
                    { 10, 3, "product10.jpg", "Easy Polo Black Edition", 9, 1025m, 25 },
                    { 11, 3, "product11.jpg", "Easy Polo Black Edition", 10, 1025m, 25 },
                    { 12, 3, "product12.jpg", "Easy Polo Black Edition", 11, 1025m, 25 }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name", "Order", "ParentId" },
                values: new object[,]
                {
                    { 2, "Nike", 0, 1 },
                    { 3, "Under Armour", 1, 1 },
                    { 4, "Adidas", 2, 1 },
                    { 5, "Puma", 3, 1 },
                    { 6, "ASICS", 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "ImageUrl", "Name", "Order", "Price", "SectionId" },
                values: new object[,]
                {
                    { 1, 1, "product1.jpg", "Easy Polo Black Edition", 0, 1025m, 2 },
                    { 2, 1, "product2.jpg", "Easy Polo Black Edition", 1, 1025m, 2 },
                    { 3, 1, "product3.jpg", "Easy Polo Black Edition", 2, 1025m, 2 },
                    { 4, 1, "product4.jpg", "Easy Polo Black Edition", 3, 1025m, 2 },
                    { 5, 2, "product5.jpg", "Easy Polo Black Edition", 4, 1025m, 2 },
                    { 6, 2, "product6.jpg", "Easy Polo Black Edition", 5, 1025m, 2 },
                    { 7, 2, "product7.jpg", "Easy Polo Black Edition", 6, 1025m, 2 }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name", "Order", "ParentId" },
                values: new object[,]
                {
                    { 15, "Dolce and Gabbana", 7, 6 },
                    { 14, "Prada", 6, 6 },
                    { 13, "Armani", 5, 6 },
                    { 12, "Versace", 4, 6 },
                    { 9, "Guess", 1, 6 },
                    { 10, "Valentino", 2, 6 },
                    { 16, "Chanel", 8, 6 },
                    { 8, "Fendi", 0, 6 },
                    { 11, "Dior", 3, 6 },
                    { 17, "Gucci", 9, 6 }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name", "Order", "ParentId" },
                values: new object[,]
                {
                    { 19, "Fendi", 0, 17 },
                    { 20, "Guess", 1, 17 },
                    { 21, "Valentino", 2, 17 },
                    { 22, "Dior", 3, 17 },
                    { 23, "Versace", 4, 17 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}

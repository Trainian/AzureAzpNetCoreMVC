using Microsoft.EntityFrameworkCore.Migrations;

namespace AzureAspNetCore.DAL.Migrations
{
    public partial class NewRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetRoles");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0",
                column: "ConcurrencyStamp",
                value: "8db9376d-73c9-4432-8c40-42ffe5528fc7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25f1cdf9-43bd-4b62-8925-401b2f0f5805", "AQAAAAEAACcQAAAAEIUaRyefzWCQq9uw8cmdyh0C2lgF/im6XRIW8aGx8Uw3FS9UOWCbTLWS1ynGgUwfVg==", "0f8b82e4-5091-4aed-90be-c97f3729468a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "Discriminator" },
                values: new object[] { "dc233d77-1fc3-40fd-b1f4-3c3e030f354c", "Role" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b00013d-8f1e-4408-be52-6652d4b48b2f", "AQAAAAEAACcQAAAAEEyBDr+XC7F6LoAk47BUeFfLgqPvl/eofCWXzMFgawNvvq0HiDhJeaKdwHqWyOTMRQ==", "8daad9f8-ae4b-465f-9845-ec01898a0a91" });
        }
    }
}

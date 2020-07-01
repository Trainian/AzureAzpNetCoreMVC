using Microsoft.EntityFrameworkCore.Migrations;

namespace AzureAspNetCore.DAL.Migrations
{
    public partial class CorrectParentIdOnSections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0",
                column: "ConcurrencyStamp",
                value: "dc233d77-1fc3-40fd-b1f4-3c3e030f354c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b00013d-8f1e-4408-be52-6652d4b48b2f", "AQAAAAEAACcQAAAAEEyBDr+XC7F6LoAk47BUeFfLgqPvl/eofCWXzMFgawNvvq0HiDhJeaKdwHqWyOTMRQ==", "8daad9f8-ae4b-465f-9845-ec01898a0a91" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8,
                column: "ParentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9,
                column: "ParentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10,
                column: "ParentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11,
                column: "ParentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12,
                column: "ParentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13,
                column: "ParentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14,
                column: "ParentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15,
                column: "ParentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16,
                column: "ParentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17,
                column: "ParentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19,
                column: "ParentId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20,
                column: "ParentId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21,
                column: "ParentId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22,
                column: "ParentId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23,
                column: "ParentId",
                value: 18);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0",
                column: "ConcurrencyStamp",
                value: "5996a061-f93e-4b4d-9fa6-89b9d2aff8fc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d266b6ff-9d72-4d0f-862d-fc4fff45dd49", "AQAAAAEAACcQAAAAEAWur3DpcJHyL+IYdBINMB/qmiR1ItaFibZwZcgmx89i5IF5Ajxwg/zGVC6aYPBQBg==", "771442bf-ba4c-41ae-bd77-aa22dd0d852b" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8,
                column: "ParentId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9,
                column: "ParentId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10,
                column: "ParentId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11,
                column: "ParentId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12,
                column: "ParentId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13,
                column: "ParentId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14,
                column: "ParentId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15,
                column: "ParentId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16,
                column: "ParentId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17,
                column: "ParentId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19,
                column: "ParentId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20,
                column: "ParentId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21,
                column: "ParentId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22,
                column: "ParentId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23,
                column: "ParentId",
                value: 17);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCCorePractice.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b31f9c27-4c2d-4f82-9aa8-a5a10382ca98", "1", "Admin", "Admin" },
                    { "fa6f6c49-37f8-4447-a6bd-1c0a2a1353dc", "2", "User", "User" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "634a60ec-96bc-4f37-937f-27ba52f58d41", 0, "c0358f28-e82e-48c7-8058-94971417e10f", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEGHU4ygsoWLMO+bL1RfvR9z6UGWmRNCb5vGXJnBTA9Q2klqo8BonnKAZYfsouMmKrw==", null, false, "29f73196-2c83-4859-99d0-37b99d303431", false, "admin@gmail.com" },
                    { "c80d49e8-a97c-45e6-babf-0760a6b86814", 0, "30a87d8b-b450-463c-b62d-ba0d8677a4a4", "rishav@gmail.com", false, false, null, "RISHAV@GMAIL.COM", "RISHAV@GMAIL.COM", "AQAAAAEAACcQAAAAENDnpQtQb4UgUaD+6wKzM56KdZDTUNI+A5tBcV7rGmBfCxX9o+QR45L4XeYA5zFS0A==", null, false, "31f4bfcb-370e-43e0-ba5b-29d037f7cd86", false, "Rishav@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b31f9c27-4c2d-4f82-9aa8-a5a10382ca98", "634a60ec-96bc-4f37-937f-27ba52f58d41" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fa6f6c49-37f8-4447-a6bd-1c0a2a1353dc", "c80d49e8-a97c-45e6-babf-0760a6b86814" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b31f9c27-4c2d-4f82-9aa8-a5a10382ca98", "634a60ec-96bc-4f37-937f-27ba52f58d41" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fa6f6c49-37f8-4447-a6bd-1c0a2a1353dc", "c80d49e8-a97c-45e6-babf-0760a6b86814" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b31f9c27-4c2d-4f82-9aa8-a5a10382ca98");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa6f6c49-37f8-4447-a6bd-1c0a2a1353dc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "634a60ec-96bc-4f37-937f-27ba52f58d41");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c80d49e8-a97c-45e6-babf-0760a6b86814");
        }
    }
}

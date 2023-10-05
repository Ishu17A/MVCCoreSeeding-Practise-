using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCCorePractice.Migrations
{
    public partial class abhi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "634a60ec-96bc-4f37-937f-27ba52f58d41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ac131bc-dbed-4f37-9cfe-f9e524dec7ac", "AQAAAAEAACcQAAAAENJP+pNOUCwJKlye3Nv0Em6Kd78gN/roWpiVpaEcQwvPhUGwV7pigqOOkqvFVtjwwg==", "7be8441b-aeff-481b-b6ef-a00f0589236a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c80d49e8-a97c-45e6-babf-0760a6b86814",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05673dc4-8ef3-4877-86a1-25c3366f3584", "AQAAAAEAACcQAAAAEC7Ws9DnFT8dZT4swaCy2B6DlQbb2JtG2gZqG4N4OXx6LdFwiO2L9L1hCxgWNcgnaw==", "b68f19f0-9114-4a67-9ad2-c6da28b711ea" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "634a60ec-96bc-4f37-937f-27ba52f58d41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0358f28-e82e-48c7-8058-94971417e10f", "AQAAAAEAACcQAAAAEGHU4ygsoWLMO+bL1RfvR9z6UGWmRNCb5vGXJnBTA9Q2klqo8BonnKAZYfsouMmKrw==", "29f73196-2c83-4859-99d0-37b99d303431" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c80d49e8-a97c-45e6-babf-0760a6b86814",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30a87d8b-b450-463c-b62d-ba0d8677a4a4", "AQAAAAEAACcQAAAAENDnpQtQb4UgUaD+6wKzM56KdZDTUNI+A5tBcV7rGmBfCxX9o+QR45L4XeYA5zFS0A==", "31f4bfcb-370e-43e0-ba5b-29d037f7cd86" });
        }
    }
}

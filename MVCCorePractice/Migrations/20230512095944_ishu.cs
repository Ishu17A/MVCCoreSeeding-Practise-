using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCCorePractice.Migrations
{
    public partial class ishu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "634a60ec-96bc-4f37-937f-27ba52f58d41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "433ea997-5d45-4cc6-840a-15602d684ac2", "AQAAAAEAACcQAAAAEO2Q+WuuQ2tPhnHMy9mLzGg3DujHytOwhJ8abC8Lwjgsx0EkthyDkVxsKHsK089Jrw==", "0d770431-be3e-4fcb-b52b-0520bd8e4271" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c80d49e8-a97c-45e6-babf-0760a6b86814",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d12e2ff6-33b2-49c1-9942-8ada088d2b06", "AQAAAAEAACcQAAAAEIynkznF/9IiXMHhmAePD1xkHcx4krSBd+dieW2u7VgkUr22ArMkbydbPtQA7sdkdQ==", "8e39816c-08c2-46cc-b4db-237c4363d2d1" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Title", "Url" },
                values: new object[] { 1, "Not Released", "John Wick Chapter-4", "Action", "Keanu Reeves" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}

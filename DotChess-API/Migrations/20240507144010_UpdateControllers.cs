using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DotChess_API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateControllers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b95128ed-b7d0-4b54-907b-9a8aac329f72");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7b87f4a-f755-443d-bc3f-9a00fccd7013");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "56581e44-9f40-42c6-9db4-7d52445e44d2", null, "User", "USER" },
                    { "d7eea25d-7f80-4f03-a0d8-9afe6259a8b0", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56581e44-9f40-42c6-9db4-7d52445e44d2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7eea25d-7f80-4f03-a0d8-9afe6259a8b0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b95128ed-b7d0-4b54-907b-9a8aac329f72", null, "Admin", "ADMIN" },
                    { "d7b87f4a-f755-443d-bc3f-9a00fccd7013", null, "User", "USER" }
                });
        }
    }
}

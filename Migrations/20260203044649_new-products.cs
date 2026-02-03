using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnet_e_commerce.Migrations
{
    /// <inheritdoc />
    public partial class newproducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "HomePage", "IsActiv", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1, true, true, 499.99000000000001, "Apple Watch 10" },
                    { 2, true, true, 899.99000000000001, "Apple Watch 11" },
                    { 3, false, true, 349.99000000000001, "Apple Watch 12" },
                    { 4, false, true, 1199.99, "Apple Watch 13" },
                    { 5, true, true, 349.99000000000001, "Apple Watch 14" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}

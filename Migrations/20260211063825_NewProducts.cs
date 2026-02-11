using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnet_e_commerce.Migrations
{
    /// <inheritdoc />
    public partial class NewProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "HomePage", "Image", "IsActiv", "Price", "ProductName" },
                values: new object[,]
                {
                    { 6, "Apple Watch 15 is the latest smartwatch from Apple, featuring a sleek design, advanced health tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 15 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.", true, "6.jpeg", true, 349.99000000000001, "Apple Watch 15" },
                    { 7, "Apple Watch 16 is the latest smartwatch from Apple, featuring a sleek design, advanced health tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 16 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.", true, "7.jpeg", true, 349.99000000000001, "Apple Watch 16" },
                    { 8, "Apple Watch 17 is the latest smartwatch from Apple, featuring a sleek design, advanced health tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 17 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.", true, "8.jpeg", true, 349.99000000000001, "Apple Watch 17" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}

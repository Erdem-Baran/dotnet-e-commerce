using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnet_e_commerce.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductName = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    HomePage = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "HomePage", "Image", "IsActive", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1, "Apple Watch 10 is the latest smartwatch from Apple, featuring a sleek design, advanced health tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 10 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.", true, "1.jpeg", true, 499.99000000000001, "Apple Watch 10" },
                    { 2, "Apple Watch 11 is the latest smartwatch from Apple, featuring a sleek design, advanced health tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 11 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.", true, "2.jpeg", true, 899.99000000000001, "Apple Watch 11" },
                    { 3, "Apple Watch 12 is the latest smartwatch from Apple, featuring a sleek design, advanced health tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 12 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.", false, "3.jpeg", true, 349.99000000000001, "Apple Watch 12" },
                    { 4, "Apple Watch 13 is the latest smartwatch from Apple, featuring a sleek design, advanced health tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 13 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.", false, "4.jpeg", true, 1199.99, "Apple Watch 13" },
                    { 5, "Apple Watch 14 is the latest smartwatch from Apple, featuring a sleek design, advanced health tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 14 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.", true, "5.jpeg", true, 349.99000000000001, "Apple Watch 14" },
                    { 6, "Apple Watch 15 is the latest smartwatch from Apple, featuring a sleek design, advanced health tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 15 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.", true, "6.jpeg", true, 349.99000000000001, "Apple Watch 15" },
                    { 7, "Apple Watch 16 is the latest smartwatch from Apple, featuring a sleek design, advanced healt tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 16 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.", true, "7.jpeg", true, 349.99000000000001, "Apple Watch 16" },
                    { 8, "Apple Watch 17 is the latest smartwatch from Apple, featuring a sleek design, advanced health tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 17 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.", true, "8.jpeg", true, 349.99000000000001, "Apple Watch 17" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}

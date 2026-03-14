using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnet_e_commerce.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    Index = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });

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
                    HomePage = table.Column<bool>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "Url" },
                values: new object[,]
                {
                    { 1, "Smart Watches", "smart-watches" },
                    { 2, "Laptops", "laptops" },
                    { 3, "Telephone", "telephone" },
                    { 4, "Headphones", "headphones" },
                    { 5, "Electronics", "electronics" },
                    { 6, "computers", "computers" },
                    { 7, "category-1", "category-1" },
                    { 8, "category-2", "category-2" },
                    { 9, "category-3", "category-3" },
                    { 10, "category-4", "category-4" }
                });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "Description", "ImageUrl", "Index", "IsActive", "Title" },
                values: new object[,]
                {
                    { 1, "Explore our wide range of cutting-edge technology products, from smartwatches to laptops, and stay ahead in the digital world.", "slider-1.jpeg", 1, true, "Discover the Latest Tech Trends" },
                    { 2, "Transform your daily routine with our selection of smart devices, designed to enhance convenience and connectivity in your life.", "slider-2.jpeg", 2, true, "Upgrade Your Lifestyle with Smart Devices" },
                    { 3, "Discover the future of technology with our innovative products that combine style, functionality, and performance for an unparalleled user experience.", "slider-3.jpeg", 3, true, "Experience Innovation at Your Fingertips" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "HomePage", "Image", "IsActive", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1, 1, "Apple Watch 10 is the latest smartwatch from Apple, featuring a sleek design, advanced health tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 10 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.", true, "1.jpeg", true, 499.99000000000001, "Apple Watch 10" },
                    { 2, 1, "Apple Watch 11 is the latest smartwatch from Apple, featuring a sleek design, advanced health tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 11 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.", true, "2.jpeg", false, 899.99000000000001, "Apple Watch 11" },
                    { 3, 1, "Apple Watch 12 is the latest smartwatch from Apple, featuring a sleek design, advanced health tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 12 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.", false, "3.jpeg", true, 349.99000000000001, "Apple Watch 12" },
                    { 4, 5, "Apple Watch 13 is the latest smartwatch from Apple, featuring a sleek design, advanced health tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 13 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.", false, "4.jpeg", true, 1199.99, "Apple Watch 13" },
                    { 5, 5, "Apple Watch 14 is the latest smartwatch from Apple, featuring a sleek design, advanced health tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 14 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.", true, "5.jpeg", true, 349.99000000000001, "Apple Watch 14" },
                    { 6, 5, "Apple Watch 15 is the latest smartwatch from Apple, featuring a sleek design, advanced health tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 15 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.", true, "6.jpeg", false, 349.99000000000001, "Apple Watch 15" },
                    { 7, 1, "Apple Watch 16 is the latest smartwatch from Apple, featuring a sleek design, advanced healt tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 16 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.", true, "7.jpeg", true, 349.99000000000001, "Apple Watch 16" },
                    { 8, 1, "Apple Watch 17 is the latest smartwatch from Apple, featuring a sleek design, advanced health tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 17 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.", true, "8.jpeg", false, 349.99000000000001, "Apple Watch 17" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

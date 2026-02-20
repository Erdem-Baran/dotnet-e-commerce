using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnet_e_commerce.Migrations
{
    /// <inheritdoc />
    public partial class SliderCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Slider",
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
                    table.PrimaryKey("PK_Slider", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Slider",
                columns: new[] { "Id", "Description", "ImageUrl", "Index", "IsActive", "Title" },
                values: new object[,]
                {
                    { 1, "Explore our wide range of cutting-edge technology products, from smartwatches to laptops, and stay ahead in the digital world.", "slider-1.jpeg", 1, true, "Discover the Latest Tech Trends" },
                    { 2, "Transform your daily routine with our selection of smart devices, designed to enhance convenience and connectivity in your life.", "slider-2.jpeg", 2, true, "Upgrade Your Lifestyle with Smart Devices" },
                    { 3, "Discover the future of technology with our innovative products that combine style, functionality, and performance for an unparalleled user experience.", "slider-3.jpeg", 3, true, "Experience Innovation at Your Fingertips" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Slider");
        }
    }
}

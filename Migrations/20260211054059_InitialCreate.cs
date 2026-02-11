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
                    IsActiv = table.Column<bool>(type: "INTEGER", nullable: false),
                    HomePage = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "HomePage", "Image", "IsActiv", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1, true, "1.jpeg", true, 499.99000000000001, "Apple Watch 10" },
                    { 2, true, "2.jpeg", true, 899.99000000000001, "Apple Watch 11" },
                    { 3, false, "3.jpeg", true, 349.99000000000001, "Apple Watch 12" },
                    { 4, false, "4.jpeg", true, 1199.99, "Apple Watch 13" },
                    { 5, true, "5.jpeg", true, 349.99000000000001, "Apple Watch 14" }
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

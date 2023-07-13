using Microsoft.EntityFrameworkCore.Migrations;

namespace Machine_test.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryMaster",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryMaster", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "ProductMaster",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMaster", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "CategoryMaster",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Sports", null },
                    { 26, " shopping", null },
                    { 25, "Sports", null },
                    { 24, "Business", null },
                    { 23, " shopping", null },
                    { 22, "Sports", null },
                    { 21, "Business", null },
                    { 20, " shopping", null },
                    { 19, "Sports", null },
                    { 18, "Business", null },
                    { 17, " shopping", null },
                    { 16, "Sports", null },
                    { 15, "Business", null },
                    { 27, "Business", null },
                    { 13, "Sports", null },
                    { 2, " shopping", null },
                    { 3, "Business", null },
                    { 4, "Electronic", null },
                    { 14, " shopping", null },
                    { 6, "Books", null },
                    { 5, " Footware", null },
                    { 8, " Cometics", null },
                    { 9, "Medicical", null },
                    { 10, "MobileAccesories", null },
                    { 11, " shopping", null },
                    { 12, "Business", null },
                    { 7, "Clothing", null }
                });

            migrationBuilder.InsertData(
                table: "ProductMaster",
                columns: new[] { "ProductId", "CategoryId", "Description", "Price", "ProductName" },
                values: new object[,]
                {
                    { 16, 16, null, 0L, "Sports" },
                    { 17, 17, null, 0L, "Sports" },
                    { 18, 18, null, 0L, "Sports" },
                    { 19, 19, null, 0L, "Sports" },
                    { 25, 25, null, 0L, "Sports" },
                    { 21, 21, null, 0L, "Sports" },
                    { 22, 22, null, 0L, "Sports" },
                    { 23, 23, null, 0L, "Sports" },
                    { 24, 24, null, 0L, "Sports" },
                    { 15, 15, null, 0L, "Sports" },
                    { 20, 20, null, 0L, "Sports" },
                    { 14, 14, null, 0L, "Sports" },
                    { 7, 7, null, 0L, "Sports" },
                    { 12, 12, null, 0L, "Sports" },
                    { 11, 11, null, 0L, "Sports" },
                    { 10, 10, null, 0L, "MobileAccesories" },
                    { 9, 9, null, 0L, "Medicical" },
                    { 8, 8, null, 0L, "Cometics" },
                    { 6, 6, null, 0L, "Online" },
                    { 5, 5, null, 0L, "Online" },
                    { 4, 4, null, 0L, "Electronic" },
                    { 3, 3, null, 0L, "Business" },
                    { 2, 2, null, 0L, "shopping" },
                    { 1, 1, null, 0L, "Sports" },
                    { 26, 26, null, 0L, "Sports" },
                    { 13, 13, null, 0L, "Sports" },
                    { 27, 27, null, 0L, "Sports" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryMaster");

            migrationBuilder.DropTable(
                name: "ProductMaster");
        }
    }
}

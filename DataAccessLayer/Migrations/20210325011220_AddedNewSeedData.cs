using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class AddedNewSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "Name", "Percentage" },
                values: new object[,]
                {
                    { 1, "Hot Deals", 25 },
                    { 2, "Mad Sale", 50 },
                    { 3, "Bargin For More", 10 }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "ProductId", "Value" },
                values: new object[,]
                {
                    { 1, 1, 5 },
                    { 2, 2, 10 },
                    { 3, 3, 50 }
                });

            migrationBuilder.InsertData(
                table: "Taxes",
                columns: new[] { "Id", "Name", "Percentage" },
                values: new object[] { 1, "vat", 15 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Taxes",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}

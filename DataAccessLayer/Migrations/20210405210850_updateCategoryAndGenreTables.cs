using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class updateCategoryAndGenreTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a2956f3-aaea-4b1c-ad71-989d7287eef8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "06bdc312-e235-4a39-9707-d8df79bbb947", "8bdd7d75-7071-4425-ac45-e9c81c713a1b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a2956f3-aaea-4b1c-ad71-989d7287eef8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dd79515c-b1a8-4a9c-8bf4-eeef2760bad2", "08418325-8ed4-40fd-9355-95431bbd17cc" });
        }
    }
}

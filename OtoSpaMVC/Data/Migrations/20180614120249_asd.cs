using Microsoft.EntityFrameworkCore.Migrations;

namespace OtoSpaMVC.Data.Migrations
{
    public partial class asd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ContactUs",
                columns: new[] { "ID", "ContactHeader", "Content", "Responded" },
                values: new object[] { 123, "Hi", "How Is Business Going?", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactUs",
                keyColumn: "ID",
                keyValue: 123);
        }
    }
}

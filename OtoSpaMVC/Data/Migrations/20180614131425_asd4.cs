using Microsoft.EntityFrameworkCore.Migrations;

namespace OtoSpaMVC.Data.Migrations
{
    public partial class asd4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_ID_123456789",
                column: "ConcurrencyStamp",
                value: "8500cc7e-6a09-40c4-a174-1f65a70fd1b1");

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "ID", "CategoryID", "ProductID" },
                values: new object[] { 17, 7, 222 });

            migrationBuilder.InsertData(
                table: "ProductSupplier",
                columns: new[] { "ID", "ProductID", "SupplierID" },
                values: new object[] { 18, 111, 11 });

            migrationBuilder.InsertData(
                table: "Purchase",
                columns: new[] { "ID", "CartID", "CreditDetails", "UserID" },
                values: new object[] { 15, 13, "YOOOLLLLOOOO", "admin_ID_123456789" });

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "ProductID", "UserID", "ID", "ProductRating" },
                values: new object[] { 111, "admin_ID_123456789", 16, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductSupplier",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumns: new[] { "ProductID", "UserID" },
                keyValues: new object[] { 111, "admin_ID_123456789" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_ID_123456789",
                column: "ConcurrencyStamp",
                value: "e47090bd-6306-402b-8188-6eb9916b4864");
        }
    }
}

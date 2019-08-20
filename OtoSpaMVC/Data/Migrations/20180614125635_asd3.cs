using Microsoft.EntityFrameworkCore.Migrations;

namespace OtoSpaMVC.Data.Migrations
{
    public partial class asd3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "admin_ID_123456789", 0, "e47090bd-6306-402b-8188-6eb9916b4864", "admin@oto.spa", false, false, null, null, null, "AQAAAAEAACcQAAAAEB23HVSQVaFxEzU6schsf6DT/7pLW8+oCvc33zXP927ZZjb+exuYoNZeM5tSt4O6IQ==", null, false, null, false, "admin" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 111,
                column: "ProductName",
                value: "Car Tree");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 222,
                column: "ProductName",
                value: "Clean Service");

            migrationBuilder.InsertData(
                table: "Cart",
                columns: new[] { "ID", "Editable", "Total", "UserID" },
                values: new object[] { 13, true, 2, "admin_ID_123456789" });

            migrationBuilder.InsertData(
                table: "CartItem",
                columns: new[] { "ID", "Amount", "CartID", "ProductID" },
                values: new object[] { 14, 1, 13, 111 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CartItem",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cart",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "admin_ID_123456789", "e47090bd-6306-402b-8188-6eb9916b4864" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 111,
                column: "ProductName",
                value: "Drug");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 222,
                column: "ProductName",
                value: "Gil");
        }
    }
}

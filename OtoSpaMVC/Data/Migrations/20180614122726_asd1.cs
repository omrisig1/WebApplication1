using Microsoft.EntityFrameworkCore.Migrations;

namespace OtoSpaMVC.Data.Migrations
{
    public partial class asd1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 7, "Car Accessories" },
                    { 8, "Cleaning Products" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CategoryID", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 111, null, "Drug", 99.0 },
                    { 222, null, "Gil", 10.0 }
                });

            migrationBuilder.InsertData(
                table: "Supplier",
                columns: new[] { "ID", "Address", "Contact", "Email", "Name", "Phone", "Website" },
                values: new object[,]
                {
                    { 11, "lilach 99", "gil", "gil@ziv.com", "Guro", "054-9999999", "www.anshubi.com" },
                    { 12, "Aviv 99", "Zil", "Ziv@Giv.com", "Theuro", "054-9999199", "www.tuna.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Supplier",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Supplier",
                keyColumn: "ID",
                keyValue: 12);
        }
    }
}

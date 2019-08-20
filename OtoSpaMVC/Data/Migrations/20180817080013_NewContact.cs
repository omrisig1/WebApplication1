using Microsoft.EntityFrameworkCore.Migrations;

namespace OtoSpaMVC.Data.Migrations
{
    public partial class NewContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContactName",
                table: "ContactUs",
                maxLength: 15,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_ID_123456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "84e53113-8d99-4dac-9252-474866b9322b", "AQAAAAEAACcQAAAAEAa+0vq9wMdOtBkg9Af+LlrUAgrdcnlWht6ziE3Rkpt0tYOBjZE4FZaVno0VTZoXYg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7000",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a125e1c2-c1c7-45fb-bdf2-b706045bf8ee", "AQAAAAEAACcQAAAAEC2dfNTBAkfTvo1zAbXQIcieKCOym6SJU8AoUlBEAromAGnqOfDAO/mzveMsh9yr9A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "251702e3-c630-4bfd-b9c2-de522f33de34", "AQAAAAEAACcQAAAAEOmEms6ULsmSspMcjXgInl+1b5qNywoiZyJNhuRoO4eHejpwaMTDsrMcFP73Bb7u4g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ad845428-cf7a-42ed-9eac-566993a051eb", "AQAAAAEAACcQAAAAEBfK9i1PdnRKM6O0gxxNjVsdphiFH95BhdBSqH3vYwK4P8zn/eWEuElQJLrhy+FcyA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "41cc5a7b-d650-4486-8657-94a774de5d36", "AQAAAAEAACcQAAAAEBO0HI7u2TfkXzLZNpuLoijitRt2x0HAi6PXUWMc8qISD+DqIgrzQuNIq3MzvCywcw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "57471096-4a8a-4c47-a38b-2f4a4a37b660", "AQAAAAEAACcQAAAAEMwS6QHts9BMF2keTeQroiAHbAj9hPQPKwELR6pRJI2Sg9wuoznd4vI3vYNPf2QxSg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c467ea94-303f-4638-b6a7-24662ec6dfc6", "AQAAAAEAACcQAAAAEGz6nWMdnzZ0I6B/V+4U5ibrf7luj1yngv8P0kFc+bMmIMEaCpk32j5V2Pka1MO9QQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7006",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3e5bdd2a-d5a6-4b85-bbb4-500e54735a98", "AQAAAAEAACcQAAAAEOJjZjBiVQB18obINb1b9sUWT8dcDqfbSPKpR2eHnDm4yXo/zCDANaL0f5cJ/5Dc/w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5b5d613f-7478-4b57-b3a8-edfdd1cd0746", "AQAAAAEAACcQAAAAEHJIHwn3FTBH7aE835GxkLrvgkOgHqZxmLKOxKT1Rzomiu2vogVEmuH+WTI6uEI0Hw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cf95ad4c-6775-4269-b430-9912afe99795", "AQAAAAEAACcQAAAAECiIP27XYT4IiRzOBNyVc2HD+LSp1ckhQDAVc46IRjukDoHGz4omQL3qQTkzF9hemw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7009",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4030ac07-66b0-4780-b269-fd147d8dbd10", "AQAAAAEAACcQAAAAELudcUImeYCH1wSC+UH3nkOPZdLHnJUOK4L76rIKCHjk2QEie6dJS0W/F6mqWgqp2A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7010",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fd9b86d8-f998-4140-9599-3c2272c8ecc1", "AQAAAAEAACcQAAAAEDrsmKvIbVl0h9BYdqBPpGb26+4BVwax8kvyei535IuvKDEooBqLhl56j7HfVOuAuw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "71bc419a-dbc7-4471-8dbb-7819d63e2023", "AQAAAAEAACcQAAAAEGdVUeUygtvYY7Jf73qOUGpFhwtkw/qHER7oqcc+MvRRQEDq2qkP/coFxyq23QR2IA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8cdfadd1-8f63-4717-8001-e4f452da07b9", "AQAAAAEAACcQAAAAEH8a1jr5l+93nPioLLydLITU8wBaogdmx78MIbCbRyY/T+metKuld6CwXaa4z0FA+Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7013",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e56aa30e-6309-46ec-bdb2-47607f54641f", "AQAAAAEAACcQAAAAEAmdOoxtswIY8XDYxnk/fQKE8zkgnGgwrgV7Puz+u3IrOdw/Pi5u5T8nM9IB73e94A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7014",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5ac01583-c33f-48b4-b310-4b5c0123be82", "AQAAAAEAACcQAAAAEGgydPojFktOkNy/7MugZRJzXAOvAUyn1biA27Cxq+Hv9bF8Cn4iXex6iT5DlJCjwA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "adad52e6-8a2d-4a33-bb2c-72adcfc2475a", "AQAAAAEAACcQAAAAEPVx3urQOa4oDvyZ4OA4PLWTPzOb1ghQfx37B8fyzlgZmUaYFbvGOpql0e7AzKJF5g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7016",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b8979014-3881-4644-943e-b3a4bff032aa", "AQAAAAEAACcQAAAAEMa1CE0nQ2lUuyx5Nfa/CG4Mql4FJsKashQTae58Cw1nje23CVCUJOM8e3TV4vjUfQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "54e629ee-1d95-4fff-b710-d4a3e90a3c86", "AQAAAAEAACcQAAAAEPXu9Ar3oBX/XLOEYsOT1fWGiEiLJn/TQi/1yf+AitCdIimsXvI7kYLCX7jrRdv5IA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7018",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "91820e70-07dd-4dda-8a88-10ba3d809ceb", "AQAAAAEAACcQAAAAEMXu4YDXWQqwJEb8jrpbLgpQ+ipBR2jJg7VOt/7On7gvxkGBuIMH7+V6wUX/3JrSSQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7019",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ef1139c-6e45-4b2f-bb3d-7ed711d352c0", "AQAAAAEAACcQAAAAELxmGZSDzWLGunQMRD+ujNbwFCCHufFdV/T8Sy1reV+Cnc1WxM3f7cbCA9+mcxV4vA==" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1000,
                column: "ProductPrice",
                value: 388.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1001,
                column: "ProductPrice",
                value: 194.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1002,
                column: "ProductPrice",
                value: 21.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1003,
                column: "ProductPrice",
                value: 29.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1004,
                column: "ProductPrice",
                value: 93.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1005,
                column: "ProductPrice",
                value: 164.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1006,
                column: "ProductPrice",
                value: 140.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1007,
                column: "ProductPrice",
                value: 467.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1008,
                column: "ProductPrice",
                value: 275.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1009,
                column: "ProductPrice",
                value: 181.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1010,
                column: "ProductPrice",
                value: 121.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1011,
                column: "ProductPrice",
                value: 435.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1012,
                column: "ProductPrice",
                value: 477.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1013,
                column: "ProductPrice",
                value: 118.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1014,
                column: "ProductPrice",
                value: 132.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1015,
                column: "ProductPrice",
                value: 267.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1016,
                column: "ProductPrice",
                value: 444.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1017,
                column: "ProductPrice",
                value: 96.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1018,
                column: "ProductPrice",
                value: 354.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1019,
                column: "ProductPrice",
                value: 309.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1020,
                column: "ProductPrice",
                value: 271.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1021,
                column: "ProductPrice",
                value: 451.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1022,
                column: "ProductPrice",
                value: 357.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1023,
                column: "ProductPrice",
                value: 145.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1024,
                column: "ProductPrice",
                value: 452.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1025,
                column: "ProductPrice",
                value: 388.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1026,
                column: "ProductPrice",
                value: 445.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1027,
                column: "ProductPrice",
                value: 56.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1028,
                column: "ProductPrice",
                value: 261.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1029,
                column: "ProductPrice",
                value: 287.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1030,
                column: "ProductPrice",
                value: 10.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1031,
                column: "ProductPrice",
                value: 22.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1032,
                column: "ProductPrice",
                value: 198.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1033,
                column: "ProductPrice",
                value: 438.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1034,
                column: "ProductPrice",
                value: 403.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1035,
                column: "ProductPrice",
                value: 373.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1036,
                column: "ProductPrice",
                value: 128.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1037,
                column: "ProductPrice",
                value: 23.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1038,
                column: "ProductPrice",
                value: 385.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1039,
                column: "ProductPrice",
                value: 273.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1040,
                column: "ProductPrice",
                value: 308.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1041,
                column: "ProductPrice",
                value: 268.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1042,
                column: "ProductPrice",
                value: 341.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1043,
                column: "ProductPrice",
                value: 217.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1044,
                column: "ProductPrice",
                value: 187.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1045,
                column: "ProductPrice",
                value: 203.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1046,
                column: "ProductPrice",
                value: 267.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1047,
                column: "ProductPrice",
                value: 116.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1048,
                column: "ProductPrice",
                value: 494.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1049,
                column: "ProductPrice",
                value: 11.0);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90000,
                column: "ProductID",
                value: 1039);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90001,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1029 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90002,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1043 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90010,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1033 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90011,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1006 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90012,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1021 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90020,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1020 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90021,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1017 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90022,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1024 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90030,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1020 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90031,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1014 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90032,
                column: "Amount",
                value: 2);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90040,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1000 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90041,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1011 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90042,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1045 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90050,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1012 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90051,
                column: "ProductID",
                value: 1005);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90052,
                column: "ProductID",
                value: 1039);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90060,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1022 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90061,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1000 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90062,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1003 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90070,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1044 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90071,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1005 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90072,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1005 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90080,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1003 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90081,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1045 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90082,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1039 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90090,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1035 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90091,
                column: "Amount",
                value: 4);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90092,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1006 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90100,
                column: "ProductID",
                value: 1032);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90101,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1041 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90102,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1007 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90110,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1003 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90111,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1009 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90112,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1037 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90120,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1003 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90121,
                column: "ProductID",
                value: 1021);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90122,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1048 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90130,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1002 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90131,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1045 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90132,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1010 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90140,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1029 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90141,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1043 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90142,
                column: "Amount",
                value: 8);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90150,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1040 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90151,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1006 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90152,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1014 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90160,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1033 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90161,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1010 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90162,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1018 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90170,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1025 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90171,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1019 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90172,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1018 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90180,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1002 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90181,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1047 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90182,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1018 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90190,
                column: "ProductID",
                value: 1047);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90191,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1008 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90192,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1001 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactName",
                table: "ContactUs");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_ID_123456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1fdc46bc-dd02-4fa1-8843-b2f72715a95f", "AQAAAAEAACcQAAAAELQeLX7wJ+XxGyvvZ4mca8+Ag6BYjbdaTtXAIU80wKckkEliWYrN0eHuYJGIpY9HuA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7000",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "43957831-b408-4c52-b3ae-b808e6959285", "AQAAAAEAACcQAAAAELIPyXvRTbxeYY5lah5nrIrXwHtYoYMgfSh2DsqBmZ1NXQPjA5qFBoL9XH0sj58J2A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "688e1efc-9e6d-4c8a-9e3e-68be631de2c9", "AQAAAAEAACcQAAAAEKiF3k+gxJ27p5b3Yp91r8K1IQTcECNg/0HVMZZ3mcS1pwEsz7GTw/c6ReMzGmuVYg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4bb199ed-cb0a-43c3-9c65-5c8dded9a627", "AQAAAAEAACcQAAAAEJKX842Vy7vUewmCII3wW3TDFIlsjJE97j6So9W+1MRrV9LB3fgJ0xkdIM09gf09pQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "96819a5c-6fa5-4e0d-847f-4e704d55da20", "AQAAAAEAACcQAAAAENJ3ky/KlFKpxNKJPNnH8Q9cRdIlhmTlA3VYaBGFR208b8ot37yOrbanV97mv8TrvA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "490b5916-a881-4487-9fb7-707824d4cf76", "AQAAAAEAACcQAAAAEHy5JbVogifpaNGhDY6tKp1Nn8l9jpjQ2SHMIbme+/2Lghc9UUnMGBn4tmR+IHZTVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "38d61f7b-2300-4527-9e76-1604cdd56e41", "AQAAAAEAACcQAAAAEBLAvh7kFBdEQanNIHYZs6XXaJVSHiWUJ1Ek2ubNkezvrm/K+/SOORajWpkoahuQug==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7006",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "32aa75f4-1e3b-4993-911b-ced6c1296188", "AQAAAAEAACcQAAAAEF5KdV0mZ/FD0CRGO+mskXwznWHf+LQUws/j814/oao3z5q//xAicJYhVE7d9B8Kig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4614f226-10b5-4a47-9ae6-a8e43fe358b0", "AQAAAAEAACcQAAAAEP3lQ1vOE69A30W0MvH6uum/y9SxaYn+TpuNZYvXVUy28pCrbqzTMuPx5qmtHwWU9w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f8642f3f-8aab-4383-8fef-16425b39079a", "AQAAAAEAACcQAAAAEM/djiey8L833KYwnLhpdXIWSNioypsAItyLDQP9pLpgKGiEU4MLQXiXaMx2iQzyYQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7009",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "92c68b1d-97b1-4e47-872a-f7cf1435b545", "AQAAAAEAACcQAAAAEEjSVHJnC5FIZoE0RFbaov9Hbnu+2Tz1iIKCp6AxDtN/q6wNaT02EbbS6GyJuYF0tA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7010",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a9a7dca3-8b0c-4bc7-9026-897fd10d2cd4", "AQAAAAEAACcQAAAAEIkR08Yur975MerqxxjMRo5c9SQpq+kIhMZQ6RPOGsPZq8PhXyjT6B46WUtjfrSNRg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3d1c15c8-c0b6-4040-ba63-f3988353798c", "AQAAAAEAACcQAAAAEC+HpJFZ5Fcz9RvToi6Nm03hpuFaBPBD+JkEJo8zJghLBkR+wL7lkoQD2cicnnHXeQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d3767e51-f0bf-4412-8b3b-3337a0195d37", "AQAAAAEAACcQAAAAEFWHqWNFeKeCNpaIUOLZOZUpqiiQ8wASdxxE/SSgEeA8cL/+i8R9dI/eaGrELHPlYw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7013",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bbc51adb-93ad-477d-89f4-76db24fc9789", "AQAAAAEAACcQAAAAEIAVjAvb9ZKJpuLEQ70i0Oj76R+010bfcfxnfX5dGgimbMo2EqJ6EbhCNxXHB4Zh2A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7014",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1373f5f4-ba69-4016-97e5-414f7e4916e4", "AQAAAAEAACcQAAAAELUsA++RqWBMh41ooCCWnI3tG3ZDI0bUXQlbZlaIvkLSSLem1w+FtnsIujDj81LDXg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fc24b23d-33e3-42b0-8ded-6bb5d5cbafc6", "AQAAAAEAACcQAAAAEB5dyUtIhn9WZpjpnWjDGhAyB3+6fW8i/NH/c1gEtgOUvT1B7ub8nVGc7/nF/7pFzQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7016",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bcc00b26-e786-4144-be19-b4b28cc7c147", "AQAAAAEAACcQAAAAED/ig55XwVoJuV7VKT/8aVetLEhj6OW+YhQlfpUgIYCP4D37KvCYx2/xQPYq4oU/Fw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7dea74fd-4714-42a6-a4ec-ad5573aaedba", "AQAAAAEAACcQAAAAEFzXDk4jBvSkBB0mSmcmRjnsmusGjXl/rvvNo/gtECoMScRCA9qBRaY5zE4ImiUhow==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7018",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5c416f39-af5c-4662-8b6a-2983a771badb", "AQAAAAEAACcQAAAAENOUMkdsE4tip5G5/0Pod0mDhJEhQpjhK2DnQeQUM6IRpE7L4viyQeoWIlmbXmY0uw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7019",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cf88db87-100d-44ad-b858-e733fac8405d", "AQAAAAEAACcQAAAAEI9RoKMMbrQGXn2Ljk2D0Gtk4sjdiheyZd8EzqomnLYdv3gtE1sR2Z29IN1ug8wYcw==" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1000,
                column: "ProductPrice",
                value: 340.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1001,
                column: "ProductPrice",
                value: 212.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1002,
                column: "ProductPrice",
                value: 110.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1003,
                column: "ProductPrice",
                value: 261.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1004,
                column: "ProductPrice",
                value: 349.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1005,
                column: "ProductPrice",
                value: 391.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1006,
                column: "ProductPrice",
                value: 201.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1007,
                column: "ProductPrice",
                value: 278.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1008,
                column: "ProductPrice",
                value: 373.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1009,
                column: "ProductPrice",
                value: 306.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1010,
                column: "ProductPrice",
                value: 368.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1011,
                column: "ProductPrice",
                value: 429.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1012,
                column: "ProductPrice",
                value: 467.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1013,
                column: "ProductPrice",
                value: 40.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1014,
                column: "ProductPrice",
                value: 111.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1015,
                column: "ProductPrice",
                value: 438.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1016,
                column: "ProductPrice",
                value: 391.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1017,
                column: "ProductPrice",
                value: 212.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1018,
                column: "ProductPrice",
                value: 362.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1019,
                column: "ProductPrice",
                value: 200.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1020,
                column: "ProductPrice",
                value: 383.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1021,
                column: "ProductPrice",
                value: 309.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1022,
                column: "ProductPrice",
                value: 252.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1023,
                column: "ProductPrice",
                value: 460.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1024,
                column: "ProductPrice",
                value: 236.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1025,
                column: "ProductPrice",
                value: 116.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1026,
                column: "ProductPrice",
                value: 135.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1027,
                column: "ProductPrice",
                value: 230.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1028,
                column: "ProductPrice",
                value: 493.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1029,
                column: "ProductPrice",
                value: 39.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1030,
                column: "ProductPrice",
                value: 15.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1031,
                column: "ProductPrice",
                value: 363.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1032,
                column: "ProductPrice",
                value: 57.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1033,
                column: "ProductPrice",
                value: 377.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1034,
                column: "ProductPrice",
                value: 243.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1035,
                column: "ProductPrice",
                value: 188.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1036,
                column: "ProductPrice",
                value: 77.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1037,
                column: "ProductPrice",
                value: 163.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1038,
                column: "ProductPrice",
                value: 16.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1039,
                column: "ProductPrice",
                value: 362.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1040,
                column: "ProductPrice",
                value: 315.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1041,
                column: "ProductPrice",
                value: 251.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1042,
                column: "ProductPrice",
                value: 177.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1043,
                column: "ProductPrice",
                value: 475.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1044,
                column: "ProductPrice",
                value: 131.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1045,
                column: "ProductPrice",
                value: 347.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1046,
                column: "ProductPrice",
                value: 247.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1047,
                column: "ProductPrice",
                value: 464.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1048,
                column: "ProductPrice",
                value: 365.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1049,
                column: "ProductPrice",
                value: 236.0);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90000,
                column: "ProductID",
                value: 1045);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90001,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1044 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90002,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1042 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90010,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1045 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90011,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1002 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90012,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1026 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90020,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1028 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90021,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1029 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90022,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1037 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90030,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1029 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90031,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1036 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90032,
                column: "Amount",
                value: 9);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90040,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1038 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90041,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1013 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90042,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1033 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90050,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1036 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90051,
                column: "ProductID",
                value: 1036);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90052,
                column: "ProductID",
                value: 1007);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90060,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1041 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90061,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1045 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90062,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1022 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90070,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1013 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90071,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1009 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90072,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1046 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90080,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1017 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90081,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1046 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90082,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1017 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90090,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1036 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90091,
                column: "Amount",
                value: 9);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90092,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1017 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90100,
                column: "ProductID",
                value: 1039);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90101,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1030 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90102,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1037 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90110,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1010 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90111,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1026 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90112,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1009 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90120,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1013 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90121,
                column: "ProductID",
                value: 1019);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90122,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1010 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90130,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1040 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90131,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1016 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90132,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1009 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90140,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1042 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90141,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1049 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90142,
                column: "Amount",
                value: 7);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90150,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1041 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90151,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1032 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90152,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1030 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90160,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1011 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90161,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1039 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90162,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1023 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90170,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1006 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90171,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1002 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90172,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1001 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90180,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1024 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90181,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1011 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90182,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1004 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90190,
                column: "ProductID",
                value: 1011);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90191,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1009 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90192,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1021 });
        }
    }
}

using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OtoSpaMVC.Data.Migrations
{
    public partial class Apriori : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AprioriClassifier",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AprioriClassifier", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_ID_123456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2497fb48-7dcd-49d0-b966-14384781569f", "AQAAAAEAACcQAAAAEDyCL2axKSW5ioFszt2GZGArRLMCxmtgbJcMw9ZNkfnezF7L18UgRV3EnLa1He/laQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7000",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "676a92b1-e3e5-458f-ab6b-e2f87efb8d96", "AQAAAAEAACcQAAAAEItqdmQPnUwEPu1AJ4YPabwZUIITvbxJwJaxNxgAKqbzD4VNh8daQFYkHiyUaeCPrA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a2491ea6-7228-4286-895c-01da0d2749ac", "AQAAAAEAACcQAAAAENBI4SEPSglSYu85aIFpTdl/EepVywVjjC6N/pZtjg1/zFTkYnYtGM/RMUSEgo1I1A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8ce88b05-7539-475b-b978-cd4145bc3278", "AQAAAAEAACcQAAAAEBm/sj5DBUdgw1DxVt8Uum4OGtUhOPAu7wpQzl3lhn5CxXOWNTfxjfa140ED3Nou3A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a6c25127-fbe4-461f-88bf-517baee30663", "AQAAAAEAACcQAAAAEPojAsRbZJAo4/pkjZT9iOLZ1nezEyzV/0/A0l/jCrDptVzu3A1N4NvUsFAyzEEw1g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "17297903-0ac7-4bed-a37f-1a7aa874e649", "AQAAAAEAACcQAAAAEDHmNj8M6n2RNCeNjUA33TyUTngnpup/pGv3+YAA1XkqX5gNNht5M9qBYT08PLSz0A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "11d6979a-9437-4549-a5ca-7c30bcffb31d", "AQAAAAEAACcQAAAAEJ9PnJXpckI3Mk6l65GTBsK8SpEyMMWCnjAQEXRDLMTj4wgVFaM9DBZY+R+40GhjGg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7006",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0a35b6dc-9db0-47e2-b33d-07c7ba16255a", "AQAAAAEAACcQAAAAEHNQ10tOLaw3c3vO/nbXWfkCdpvyoa1dYesZC+q6VFPfWll8nHgLfhdrtBdgcL+lGA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fbf2574f-bb6a-4ed8-be05-49bba150bebc", "AQAAAAEAACcQAAAAEOgapU2ar21CaIUZsSAKlpn3xQhKBDffxutqHUy+U2J34dK3EtWEu2wkURhP8L6ytw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "487f6c75-71e5-41e9-8c41-549e54ef4f32", "AQAAAAEAACcQAAAAEAmxPmhvubuvQ+2PcqkXZZ0OCKiUFwacj0sHlu5lw3YSnL+AylOzU3Zhu1AXQIkYmQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7009",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "16c0da19-89bd-4bcf-91c3-49b430df092b", "AQAAAAEAACcQAAAAEOArm2ZGS6j9HgF0mVrMZn6vvZtyFw+C/+D/MGow3wwu+0EKyiAQbxDZeyvPNqDUzQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7010",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "65e9207c-03b3-4d0f-b818-50c2dd8b4194", "AQAAAAEAACcQAAAAEMWUTA7qFAdQqgq/ZxWVe7ZrMAgNv4kNplg1S1mMFTGX3eemrKzzHlQ0Uuk8Nd5FMQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c42571db-e370-4bc6-8636-f397eb4035a0", "AQAAAAEAACcQAAAAELv/wriasbl6FQHmWEuq4JNQtKFKsa0n56Uz/6qGPTzJjcXYdFIzhridDjsVjENrfw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e8b9d064-1326-43dc-88d8-3fc3a4a50a89", "AQAAAAEAACcQAAAAEAmxs06GtJY8DEcyV+ctfqvRl4+LLR/u/u09NIIJgXZz8vhKYm8x7wBQYRG0+DLhBw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7013",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5a992183-0321-4067-89c3-826993736004", "AQAAAAEAACcQAAAAEBvPeec2Ro9PK73LYKWRSiEl6Jr9fj1WpSaZgtszKJVx4MIWSngGLTxik/st/9i5cQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7014",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1e7b65e7-68ed-4903-8c20-a1a8f0c3f1ad", "AQAAAAEAACcQAAAAEDzzYCiQ3Ao5SEFGA/0LiatRz/2nhwgcvndxmurmkoVyf8SekOtN6tvywBoYRr7VYw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "91f10982-e450-41f4-991a-404c730e32b4", "AQAAAAEAACcQAAAAELCnov8cRogFPk7wTasSH1xxmUpWU7yoDHCVcfpzc96RosMEJtBAC+6mKu6GAfsJwA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7016",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a24fed86-d0b3-4315-b00a-23f2e09db813", "AQAAAAEAACcQAAAAEJcG+B8KK8f9lq6wmM1wkX04oUjkQJ+t74kGyN7Bd+8XK/aF+F+ey+PaoLpfgkgDNg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9926bbe5-277c-4de4-a3fc-286338c6087e", "AQAAAAEAACcQAAAAENtjxDl76oCIUDrNTIz7zDZzTzQwG1PyleEDNGIbxE3uB03isB4sA4eJYgprhsZrng==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7018",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "04e754f5-6fb6-424e-8b79-7b9cebafae7a", "AQAAAAEAACcQAAAAEIwDVrnNcojXcEj9p9BaQDTaxSzIXqaZ2A+Ktx+STSGsig+lkCaqooly4KzJvv6j0w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7019",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "58332677-083d-4d0b-ac2d-d520c1f076cf", "AQAAAAEAACcQAAAAEOshlRcCH6eOz2aV9jzJgaUhy6nHqap27ahDtJCgUgdsqKvVPK1P7y5fW5CbqmAMBQ==" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1000,
                column: "ProductPrice",
                value: 169.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1001,
                column: "ProductPrice",
                value: 110.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1002,
                column: "ProductPrice",
                value: 67.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1003,
                column: "ProductPrice",
                value: 403.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1004,
                column: "ProductPrice",
                value: 11.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1005,
                column: "ProductPrice",
                value: 438.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1006,
                column: "ProductPrice",
                value: 439.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1007,
                column: "ProductPrice",
                value: 225.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1008,
                column: "ProductPrice",
                value: 120.0);

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
                value: 108.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1011,
                column: "ProductPrice",
                value: 145.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1012,
                column: "ProductPrice",
                value: 221.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1013,
                column: "ProductPrice",
                value: 231.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1014,
                column: "ProductPrice",
                value: 29.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1015,
                column: "ProductPrice",
                value: 197.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1016,
                column: "ProductPrice",
                value: 339.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1017,
                column: "ProductPrice",
                value: 263.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1018,
                column: "ProductPrice",
                value: 261.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1019,
                column: "ProductPrice",
                value: 310.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1020,
                column: "ProductPrice",
                value: 294.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1021,
                column: "ProductPrice",
                value: 343.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1022,
                column: "ProductPrice",
                value: 68.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1024,
                column: "ProductPrice",
                value: 427.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1025,
                column: "ProductPrice",
                value: 257.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1026,
                column: "ProductPrice",
                value: 231.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1027,
                column: "ProductPrice",
                value: 118.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1028,
                column: "ProductPrice",
                value: 171.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1029,
                column: "ProductPrice",
                value: 37.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1030,
                column: "ProductPrice",
                value: 371.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1031,
                column: "ProductPrice",
                value: 494.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1032,
                column: "ProductPrice",
                value: 462.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1033,
                column: "ProductPrice",
                value: 149.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1034,
                column: "ProductPrice",
                value: 228.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1035,
                column: "ProductPrice",
                value: 157.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1036,
                column: "ProductPrice",
                value: 449.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1037,
                column: "ProductPrice",
                value: 250.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1038,
                column: "ProductPrice",
                value: 67.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1039,
                column: "ProductPrice",
                value: 299.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1040,
                column: "ProductPrice",
                value: 224.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1041,
                column: "ProductPrice",
                value: 286.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1042,
                column: "ProductPrice",
                value: 497.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1043,
                column: "ProductPrice",
                value: 129.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1044,
                column: "ProductPrice",
                value: 422.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1045,
                column: "ProductPrice",
                value: 114.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1046,
                column: "ProductPrice",
                value: 464.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1047,
                column: "ProductPrice",
                value: 21.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1048,
                column: "ProductPrice",
                value: 364.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1049,
                column: "ProductPrice",
                value: 146.0);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90000,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1006 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90001,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1034 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90002,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1016 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90010,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1004 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90011,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1047 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90012,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1021 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90020,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1005 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90021,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1043 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90022,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1017 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90030,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1000 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90031,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1024 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90032,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1020 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90040,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1008 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90041,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1034 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90042,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1013 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90050,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1028 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90051,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1024 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90052,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1046 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90060,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1015 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90061,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1047 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90062,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1010 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90070,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1027 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90071,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1008 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90072,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1022 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90080,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1018 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90081,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1043 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90082,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1000 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90090,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1039 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90091,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1008 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90092,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1048 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90100,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1047 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90101,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1036 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90102,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1046 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90110,
                column: "ProductID",
                value: 1007);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90111,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1011 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90112,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1045 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90120,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1009 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90121,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1026 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90122,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1031 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90130,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1037 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90131,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1028 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90132,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1024 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90140,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1038 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90141,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1020 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90142,
                column: "ProductID",
                value: 1012);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90150,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1000 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90151,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1040 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90152,
                column: "ProductID",
                value: 1042);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90160,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1008 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90161,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1034 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90162,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1031 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90170,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1029 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90171,
                column: "ProductID",
                value: 1036);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90172,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1029 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90180,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1023 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90181,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1015 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90182,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1000 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90190,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1037 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90191,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1035 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90192,
                column: "ProductID",
                value: 1026);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AprioriClassifier");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_ID_123456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "46f642f6-c33a-4580-9cfd-e1bdf45041cf", "AQAAAAEAACcQAAAAEDnGllF4Q0Q7Aw4ZFL0Rw5H4PftGEIF/ClF7bmBQXJUAeu7u/ZaRSQGewM2Gny3RFw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7000",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "df6d0ee9-576c-4703-9ef0-8bebb2035214", "AQAAAAEAACcQAAAAECCvu0NGEFAbpyEqEM+haxm1KDsFAmJY5P1nG655fRog/CLmmCAAnpfI4Q5GMqvrLw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fb660471-503d-4040-8bad-94eb70363c8c", "AQAAAAEAACcQAAAAEDbaWs/I/xJkeQFSyFcmblwGAJJeJ48Me6dOwZM2zhVN4pzvIAbd4t2WkNFhFxB5Kg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4898cfb0-23f2-4162-b9cf-619a54b3ce86", "AQAAAAEAACcQAAAAEL5FTFSP+k63iJMigPEr/DfSHy0L85G+TTS9x0ET/wvAbnzcbViOn5In16AetgtB0w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bb48f88b-c252-48bf-bf70-6b2dc44a2a52", "AQAAAAEAACcQAAAAED8ClCGyKUWqo4ambFcbw15T7kukr4LSaWGCPOQ1laWF4EdoMeG4RzeTyir9VrBinQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fa7b261d-2a7e-49c1-a5fc-434cd476850a", "AQAAAAEAACcQAAAAENdjPsZsbL601GSyxVQw9bNrkrO6yPrl4RNX0UnerARuifmiaM6S82WYlXKU2ewBxQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5a5ed630-503e-44f5-a845-fd2d25f465ec", "AQAAAAEAACcQAAAAEKC/gbw5FGgs/6I5QrFlGpJdXZIj9qEPYjcVk0g4jlu/VodfefuCNUUnM19Vx33scg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7006",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "da82ba03-a00e-438a-ae4f-1cc0494f9523", "AQAAAAEAACcQAAAAEJmW2CwZahXBxXaotFbKxr4DM5j27zkRHkTrv5B1ZfKgRl94EVpWHseUof6IW/59PA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d224f9d8-aba0-4020-83c4-6224cacb0fed", "AQAAAAEAACcQAAAAEOqkn0N0wH4EdUrmDJpYwNOkpNlepNBXpHj7Idvez/kXPziFoCk4kxinxBs7vzyEbw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3d226ebc-011b-4e3a-828a-f237ede440fc", "AQAAAAEAACcQAAAAEGMXomKN3RVLiIOXqRlAQ26AvPiACT3G8mFv8jZfGueOUnRiWmF9NnhYma1BqZz+Lg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7009",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eba823f2-c6c8-4fba-bf78-0ede2be16e69", "AQAAAAEAACcQAAAAEJRhj8GPuPzMS3btAQ2JBWD5QZ9ygcfpsdGywktemRhZ7PvBhZG/FBKjPa1yP44ZHg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7010",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7692e0e8-f202-4e17-975c-ff6c7d60dd93", "AQAAAAEAACcQAAAAEHcjgxNOpXr+eRukqhfUiObwJ3U4o25XkRkV/wGYynK7ON93loQoSSJ6LXV8Y+j42w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "50355190-d073-4519-af9f-5e2dbeecfe92", "AQAAAAEAACcQAAAAEBB1Cj0EMjFN+C1Akq4KJywCBV7ZNeCyUqMuuy6dMR4irJTitA7nmNqPs/Oc/rfplA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c431ab72-7cc0-4abf-b495-a618a7908ab1", "AQAAAAEAACcQAAAAEHFaZR6Kqrj+EQgKCq+jNNOiE2AFcQzVeBb6iXMuEQ3itZrC4oWhvMWqBWoeF9JGzg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7013",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "34e2814a-b77d-4fb1-a22e-02a6ccf6644a", "AQAAAAEAACcQAAAAEAoE8/ofp7AI7WZ0RVaToBPpmoVEz//1KLcuiMBU6OV5U7kOeIpcbuK6DIGcAXgv5g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7014",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d3d9c4d8-88ae-4710-9a71-5ca082a29778", "AQAAAAEAACcQAAAAEJvnP9vl1YY0qfn/w/xHuxc5hTROEnV+WfsJFCLPgTqaKUjZkk6FHBvlvuSlgq22cw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8a5b8c6a-e987-4ce4-bd80-08f68c00eb2e", "AQAAAAEAACcQAAAAEOSEa45/ebe+VsLitKy4pKLtKRiByaDGVda0/83G1PaMyUR77IPSNi6puOgaKpunBQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7016",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0ba35fce-9f52-4c7c-ade3-eef76b795e07", "AQAAAAEAACcQAAAAEIb0w+O6y+xdtLvnTnB5gk/gLi1B6V7jPvIAWmjKMq25LVFkHQ8XGnFVqOz9FAYOyA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6ece151b-75af-458d-97be-ca5aaea87ef4", "AQAAAAEAACcQAAAAEFmrAtE4YDgpy3B9FbSWvJ04d7USUAXSxDpF4bZ3pnOeMd1XRpHANkHGuTtEpJOSUg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7018",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bb9e7fa3-04ac-4505-92f8-9099624705e1", "AQAAAAEAACcQAAAAEIkSSUcVOjlNOT4Wmzi8BHxgUtO7S/V2VZYeKyb8NUoxEeg7aaEqnHz5/+/RxmFBNw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7019",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8745be27-f53f-4a09-9aeb-9e0db5332641", "AQAAAAEAACcQAAAAEMfTBXOnGX9Qk1M7DFlTTE+rB3MQJBviOhliUJJD1E+9AcRAHTX/bhsK2ix6DFF/mQ==" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1000,
                column: "ProductPrice",
                value: 239.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1001,
                column: "ProductPrice",
                value: 17.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1002,
                column: "ProductPrice",
                value: 262.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1003,
                column: "ProductPrice",
                value: 355.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1004,
                column: "ProductPrice",
                value: 13.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1005,
                column: "ProductPrice",
                value: 23.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1006,
                column: "ProductPrice",
                value: 231.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1007,
                column: "ProductPrice",
                value: 416.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1008,
                column: "ProductPrice",
                value: 285.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1009,
                column: "ProductPrice",
                value: 202.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1010,
                column: "ProductPrice",
                value: 73.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1011,
                column: "ProductPrice",
                value: 227.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1012,
                column: "ProductPrice",
                value: 243.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1013,
                column: "ProductPrice",
                value: 323.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1014,
                column: "ProductPrice",
                value: 474.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1015,
                column: "ProductPrice",
                value: 104.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1016,
                column: "ProductPrice",
                value: 121.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1017,
                column: "ProductPrice",
                value: 364.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1018,
                column: "ProductPrice",
                value: 339.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1019,
                column: "ProductPrice",
                value: 228.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1020,
                column: "ProductPrice",
                value: 73.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1021,
                column: "ProductPrice",
                value: 227.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1022,
                column: "ProductPrice",
                value: 245.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1024,
                column: "ProductPrice",
                value: 222.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1025,
                column: "ProductPrice",
                value: 409.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1026,
                column: "ProductPrice",
                value: 31.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1027,
                column: "ProductPrice",
                value: 82.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1028,
                column: "ProductPrice",
                value: 76.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1029,
                column: "ProductPrice",
                value: 122.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1030,
                column: "ProductPrice",
                value: 27.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1031,
                column: "ProductPrice",
                value: 416.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1032,
                column: "ProductPrice",
                value: 183.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1033,
                column: "ProductPrice",
                value: 257.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1034,
                column: "ProductPrice",
                value: 195.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1035,
                column: "ProductPrice",
                value: 199.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1036,
                column: "ProductPrice",
                value: 315.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1037,
                column: "ProductPrice",
                value: 12.0);

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
                value: 297.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1040,
                column: "ProductPrice",
                value: 167.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1041,
                column: "ProductPrice",
                value: 186.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1042,
                column: "ProductPrice",
                value: 450.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1043,
                column: "ProductPrice",
                value: 373.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1044,
                column: "ProductPrice",
                value: 129.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1045,
                column: "ProductPrice",
                value: 161.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1046,
                column: "ProductPrice",
                value: 102.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1047,
                column: "ProductPrice",
                value: 283.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1048,
                column: "ProductPrice",
                value: 16.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1049,
                column: "ProductPrice",
                value: 261.0);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90000,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1037 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90001,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1016 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90002,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1044 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90010,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1026 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90011,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1013 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90012,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1049 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90020,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1034 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90021,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1017 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90022,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1004 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90030,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1013 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90031,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1028 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90032,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1035 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90040,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1006 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90041,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1027 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90042,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1043 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90050,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1031 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90051,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1006 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90052,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1024 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90060,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1024 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90061,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1030 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90062,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1042 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90070,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1036 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90071,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1030 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90072,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1033 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90080,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1019 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90081,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1010 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90082,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1014 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90090,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1047 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90091,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1049 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90092,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1006 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90100,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1023 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90101,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1026 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90102,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1028 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90110,
                column: "ProductID",
                value: 1008);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90111,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1042 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90112,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1040 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90120,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1017 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90121,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1035 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90122,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1024 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90130,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1024 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90131,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1005 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90132,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1017 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90140,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1045 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90141,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1009 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90142,
                column: "ProductID",
                value: 1033);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90150,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1017 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90151,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1049 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90152,
                column: "ProductID",
                value: 1043);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90160,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1034 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90161,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1012 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90162,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1042 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90170,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1035 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90171,
                column: "ProductID",
                value: 1006);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90172,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1043 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90180,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1037 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90181,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1001 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90182,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1038 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90190,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1000 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90191,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1021 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90192,
                column: "ProductID",
                value: 1011);
        }
    }
}

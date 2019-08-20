using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OtoSpaMVC.Data.Migrations
{
    public partial class googleMaps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GoogleMap",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    langi = table.Column<double>(nullable: false),
                    longi = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoogleMap", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_ID_123456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d522109f-6fc3-4ba2-acf1-cf7c619524b0", "AQAAAAEAACcQAAAAECNqWbXH2p2tV92u4UVqa5J8qJH9ZjnZbcg8XgnEQUqlkE8C03pnyvlHHbIQsPX4wg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7000",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "86373aa1-156e-49a4-8be4-d81f56d0f6d4", "AQAAAAEAACcQAAAAECjszbaqJJpvVBmRDe1hvE19VMgxNPLU3zBEVp/gjmWc25wMba6ou2CWydxdqkpyuw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e75d3059-81a8-4a66-9eaa-5837254bd570", "AQAAAAEAACcQAAAAEHcXnsldoEed+bfCUcxBKIKzJb0l22ySm9CJSVe98VnMxgB7bwHKLAfzh1swAKgmZg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c49e2418-7a9c-4592-b701-f7e75abf1dfd", "AQAAAAEAACcQAAAAEJagzqnT0Ytk9aSPEIq7NkLLBpgxeatse0hSxpfn2R75yH+VgKF1WIdteXL2qV/2qA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e25d146f-4021-4b14-8640-30186d2be562", "AQAAAAEAACcQAAAAEBaaa1rPbeLagoQZ/V6UJO3SB0UvKgXVwrgngpu9bizDY8MgfJRcj1G/DloWCwwjiA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ff20ed74-09cc-464b-ae2a-b281685d95d8", "AQAAAAEAACcQAAAAEE4z2XzS3pGZ3OeLQCq/pR1Nwa4t4UYU/K0yhatC26svZkjAfybipgWiikGLMjeNcw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c3b10fd7-8159-45a9-9d72-7ea50b66b108", "AQAAAAEAACcQAAAAEO4DBjupLAuJK9xykJMquPbFka/qKL1BIbaHhhj1OtJZ7tm5VWKPWNapyzqfE24BFA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7006",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bb08426d-2c9c-470f-b189-2e13b88bff7d", "AQAAAAEAACcQAAAAEMoDMMbVgNIxhaz0T9iWLJMTm7qxePsuuYCfW63Xzscw7tv1C252hlXPZs6r/Y50lg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ca7f135-7f51-4df3-9174-39dfa1f8830f", "AQAAAAEAACcQAAAAEGmjl+2x8ffOTSe5o0aMCy5spaBpEFjCMWovxpXiQOkcHw74pu24aMZqaCzcpzU7EA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "406d360b-9c6f-4ea0-81d3-7bbc5f220fba", "AQAAAAEAACcQAAAAEGXaO2tbkzrDCxR8p+rR1Y5ge2Tm0XyIS2WX+72sxIf4CLuySbQYTx2pCgGRo55cUw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7009",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "04ddadcb-ee0c-461c-8e79-0c85d74e3034", "AQAAAAEAACcQAAAAEEuZGLgAcuyL4wz8/1jD7A97VDqm7Y/wPK3Z1lK3AvA27JTo/UQmNkYU+2+ktpBZPw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7010",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6b48c77c-4106-4708-ae8f-2d1aaa5b0a6d", "AQAAAAEAACcQAAAAEHi9Cfauuaa5IxDxf4hrnsnykPOT2NzyQ6pQNwWmCONN7zKaAUT2sK9MWVFcBB7AKg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "04033d18-9bf5-4ae0-aa17-21940df510b0", "AQAAAAEAACcQAAAAEI0xOTZ3ez2zVktVuWNbSX0e67DY4+DcKs3Y3zeeqyYBR3Vxbnh5QcVNw5wxcxn5Hg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c3aa95cd-ffc4-40f6-9495-102336e9697b", "AQAAAAEAACcQAAAAEF0oo7I+IpkHUziB9aZdTPqDIkGZ5VLr61+OvKWBV9NMiXgEv82lQIdq60QejXBk1w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7013",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9d475cb5-f134-4ce4-9219-e997077bf41e", "AQAAAAEAACcQAAAAEEHg2Jh/h/wgOwR1ot4Kblb75lTDeQECnF+AV4TD45jHYhAutUn9Dxnr8gmQHK4/qg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7014",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0dbae53d-1458-40c4-a439-fec5349a07ef", "AQAAAAEAACcQAAAAEHB5wFlLw8mx3uQJrBxQsnH6LqGKK+CFRvScRjBMfzaRsU+q6Usg1s8vEOTe5L6UHQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b274874d-b20a-4433-a820-9b90e30f6a17", "AQAAAAEAACcQAAAAEDg9qx6FdhgFKRkYxlndnJpc4WhRNTOFQqD1iMzNdRia9yM3q0Ta/BFMgyDvwIZgBQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7016",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7a128de6-e0ce-4851-987a-6438907e1e39", "AQAAAAEAACcQAAAAEOb5M9y9P7DoJkvRwg4mEZdKIEo9JwE6I5j7Tpk/DrQ3+euqOA/sZ+U272dYkPpjtA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3b405c99-7a8f-4d63-a937-d0059c38ac3f", "AQAAAAEAACcQAAAAEPxnSqdDXCxnI7/DTU6jRKZLcYmXj70u1AtBN4vOnW4f6s0yrXJk54g0msbfI2FMlw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7018",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "06d5f331-629d-4e40-8fa9-c8d7ac82dc8a", "AQAAAAEAACcQAAAAEJLCUU4zUKHk2GvwIhLDiUVIQzXTp/NauDqhsRiqAwTEzCmmAWCWOoFZTDwL4CCK0w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7019",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "83ae9a4d-f67c-4db8-94fe-7fa193d1063d", "AQAAAAEAACcQAAAAEHiCQCC0uIm2Qn4IdGfQYYELIHiFX4QXa3f+k8q6eNdHNirhNCe/7yoIu8rR4mhHNg==" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1000,
                column: "ProductPrice",
                value: 183.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1001,
                column: "ProductPrice",
                value: 126.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1002,
                column: "ProductPrice",
                value: 37.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1003,
                column: "ProductPrice",
                value: 171.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1004,
                column: "ProductPrice",
                value: 171.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1005,
                column: "ProductPrice",
                value: 415.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1006,
                column: "ProductPrice",
                value: 78.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1007,
                column: "ProductPrice",
                value: 419.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1008,
                column: "ProductPrice",
                value: 276.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1009,
                column: "ProductPrice",
                value: 318.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1010,
                column: "ProductPrice",
                value: 417.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1011,
                column: "ProductPrice",
                value: 253.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1012,
                column: "ProductPrice",
                value: 479.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1013,
                column: "ProductPrice",
                value: 226.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1014,
                column: "ProductPrice",
                value: 310.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1015,
                column: "ProductPrice",
                value: 275.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1016,
                column: "ProductPrice",
                value: 410.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1017,
                column: "ProductPrice",
                value: 16.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1018,
                column: "ProductPrice",
                value: 487.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1019,
                column: "ProductPrice",
                value: 337.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1020,
                column: "ProductPrice",
                value: 24.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1021,
                column: "ProductPrice",
                value: 184.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1022,
                column: "ProductPrice",
                value: 343.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1023,
                column: "ProductPrice",
                value: 405.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1024,
                column: "ProductPrice",
                value: 446.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1025,
                column: "ProductPrice",
                value: 435.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1026,
                column: "ProductPrice",
                value: 114.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1027,
                column: "ProductPrice",
                value: 42.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1028,
                column: "ProductPrice",
                value: 66.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1029,
                column: "ProductPrice",
                value: 408.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1030,
                column: "ProductPrice",
                value: 154.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1031,
                column: "ProductPrice",
                value: 298.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1032,
                column: "ProductPrice",
                value: 69.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1033,
                column: "ProductPrice",
                value: 320.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1034,
                column: "ProductPrice",
                value: 445.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1035,
                column: "ProductPrice",
                value: 244.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1036,
                column: "ProductPrice",
                value: 253.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1037,
                column: "ProductPrice",
                value: 75.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1038,
                column: "ProductPrice",
                value: 64.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1039,
                column: "ProductPrice",
                value: 266.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1040,
                column: "ProductPrice",
                value: 382.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1041,
                column: "ProductPrice",
                value: 481.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1042,
                column: "ProductPrice",
                value: 373.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1043,
                column: "ProductPrice",
                value: 299.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1044,
                column: "ProductPrice",
                value: 111.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1045,
                column: "ProductPrice",
                value: 386.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1046,
                column: "ProductPrice",
                value: 460.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1047,
                column: "ProductPrice",
                value: 34.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1048,
                column: "ProductPrice",
                value: 447.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1049,
                column: "ProductPrice",
                value: 118.0);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90000,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1023 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90001,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1017 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90002,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1023 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90010,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1027 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90011,
                column: "Amount",
                value: 5);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90012,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1030 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90020,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1036 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90021,
                column: "ProductID",
                value: 1016);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90022,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1018 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90030,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1027 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90031,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1002 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90032,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1045 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90040,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1045 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90041,
                column: "ProductID",
                value: 1030);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90042,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1029 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90050,
                column: "ProductID",
                value: 1047);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90051,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1008 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90052,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1017 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90060,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1012 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90061,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1007 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90062,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1046 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90070,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1034 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90071,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1045 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90072,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1012 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90080,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1012 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90081,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1019 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90082,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1024 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90090,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1008 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90091,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1013 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90092,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1006 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90100,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1019 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90101,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1032 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90102,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1025 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90110,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1044 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90111,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1019 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90112,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1049 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90120,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1008 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90121,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1010 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90122,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1049 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90130,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1027 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90131,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1041 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90132,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1041 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90140,
                column: "ProductID",
                value: 1036);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90141,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1033 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90142,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1035 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90150,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1043 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90151,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1047 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90152,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1025 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90160,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1029 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90161,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1006 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90162,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1039 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90170,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1031 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90171,
                column: "ProductID",
                value: 1048);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90172,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1021 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90180,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1027 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90181,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1039 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90182,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1017 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90190,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1029 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90191,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1031 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90192,
                column: "ProductID",
                value: 1029);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GoogleMap");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_ID_123456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d08fd4ad-d0ec-4812-a17b-11a0f2a4f77c", "AQAAAAEAACcQAAAAEDVkvcxOR6a+IwcyDIS/yVX0HY88/JT7dfUN0iW5YOwViq7d9oWCp8a1y1K15VKehg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7000",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "97aca2f7-dfc3-4179-8673-9a67a3f3f83d", "AQAAAAEAACcQAAAAECyMiH75YFjLf+JZk+Kqukmg9RzJPkchIUe2PCtOwQkgFD033fZtHd5BLug3K4gcSg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b361697c-23c7-47bb-8c9f-6f44365f7c8a", "AQAAAAEAACcQAAAAEOjBEjZ6zq9gGosCBozad602YoNgZBTjnN2lw7s4LR0svoCojACYjmV5Fp8yj3vWFg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bfca693e-4f35-466b-8c66-17bf03ef7d0f", "AQAAAAEAACcQAAAAECe/QCly1yTp+0rRUtohz8O9CbhzvhAIjO+b6WdmSaBxUGZnSIeIMkoQz20JDdT/jQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ba4db838-55f4-426b-b2fc-27402af65331", "AQAAAAEAACcQAAAAELvuTBfLfAek/GAqhf7mRTide75k1RZYVEj/6o/5DwDEiECBYKm76Xo5OWNnzvu9Kg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "387d0cea-3f98-4a37-ba07-bc9689833935", "AQAAAAEAACcQAAAAEKxfWvUVepD62gF/kRJpKub+/OHetclICnSOzk/7xsJkPEC8nigsVPnCTimGwjgHGA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ca21acaa-3ac3-4085-b39c-c547af3ac7b9", "AQAAAAEAACcQAAAAECIKoaJYT0k1m0ui51iSsD4z5BOHAzULPiNNmokB6vQ1StQ4sFSABG22zZvWK1+qgg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7006",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "96e945b1-ed59-4928-937e-e6e4e13bb396", "AQAAAAEAACcQAAAAEFU/lazC27RTEUuEjsekkii7Dqvp5AUeVVFgquRXzJtyiTmy3hl4byVzys/+s2P22A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e48a19fc-ce50-4384-9fef-bec541c77968", "AQAAAAEAACcQAAAAEOHNKyfVGc/NrxLqflrWhJTOEDI7jvCcue0Gx8k2JZmu8TGr+ZW6JJYV7Psy72gQXg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a7dd9a62-d2c7-463e-8cfa-2917ba61c4e4", "AQAAAAEAACcQAAAAEKOTbEA4w80LMnBPcT9kocQGrlTpdXSRD3+lmT28Bp57QPYH3S7rP7Hq7wAZY8Syzw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7009",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5c3af14f-ca26-482a-8d67-ea221f1379a0", "AQAAAAEAACcQAAAAELl+JQ0aCbVgKK8mBOqPaw4EYOPYOEZyuYv1VnCpReNFlHaO5RtRKfx9Zzkigq790w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7010",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6bd60fd4-ba28-40a4-a7ff-1c6068bade05", "AQAAAAEAACcQAAAAEA3AWBP+jyVeHGda+lm5BPmr6IbWdoGCmfVPkf6a7ZiasnY6htiGGtHgyVSNzibQ0g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ff36ca7b-1383-43de-95b9-95d1ebefa6a2", "AQAAAAEAACcQAAAAEFr9dF3yJfly9hMKc4RXwvvangsA4qMgZq6JkeQag/Rc7a4lvvu5xijjAiNk3VCASQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "88021875-667d-4141-b779-8c51338356ab", "AQAAAAEAACcQAAAAECYyOlZFcb6udIOiYDjwmsOsLQr3k3NyA31SrOPF9Xx8Za7KN/uZDxq5XnQH2nplDA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7013",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c8814d72-18d2-4aad-9863-f11b4de5c683", "AQAAAAEAACcQAAAAEMjgJKrs5orfo1vxCojq0vDf0RssxCaNRJcPfYJVyuJpEnBYMekeKQY47SyDwlAgvw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7014",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f7a4fb76-13a2-4065-b81b-e227da7ed97c", "AQAAAAEAACcQAAAAEGVxBok0Yt8dupDw2EroPSrZifGcaheGg2XUaml7c9TbGFFXSU8o43ASk4IchKwR1w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ab21d712-9feb-4142-a7c7-d30c0d0be317", "AQAAAAEAACcQAAAAEHVnbvP/SJ0aJIPzszdoP/wsNUJAthMZFh3qGUMlwZPWwVBMxd1oR7AHu7UbiKuSjQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7016",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "400bad82-7c17-45b0-a0f5-5c06551b92c7", "AQAAAAEAACcQAAAAEEJqjoopl3FzZXF5imsQJutmwq3oYP58yVD0uyXaWMY48yHlv7DPuy+hGduXHeO6lw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "25dec285-6b07-436c-b7b5-190879f65af5", "AQAAAAEAACcQAAAAEBjTzbH8l/dV8evWJVxVQTUA+HaKkstxusG1i/gBXy/dbCTtFUGApjKCE7rZtX1pZw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7018",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "89fdd403-455e-4412-9423-ae3abf7cd280", "AQAAAAEAACcQAAAAECFnQsCZQYEMbd9QUav8KrKpSYyF6N3+SD6DeA6yeX/a3RCrWMnsOS7+CV+WWfGBiA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7019",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "432cb2f1-8189-49f8-b892-a7d7bb48c058", "AQAAAAEAACcQAAAAEFb+Jv+oVHA4LvPIiLKfMyHG/bHKzWDYDKEbZcopz6LQqR+0yJbarsZ81et7Y1uBCQ==" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1000,
                column: "ProductPrice",
                value: 276.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1001,
                column: "ProductPrice",
                value: 184.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1002,
                column: "ProductPrice",
                value: 357.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1003,
                column: "ProductPrice",
                value: 104.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1004,
                column: "ProductPrice",
                value: 80.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1005,
                column: "ProductPrice",
                value: 344.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1006,
                column: "ProductPrice",
                value: 470.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1007,
                column: "ProductPrice",
                value: 288.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1008,
                column: "ProductPrice",
                value: 340.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1009,
                column: "ProductPrice",
                value: 49.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1010,
                column: "ProductPrice",
                value: 267.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1011,
                column: "ProductPrice",
                value: 138.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1012,
                column: "ProductPrice",
                value: 126.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1013,
                column: "ProductPrice",
                value: 419.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1014,
                column: "ProductPrice",
                value: 302.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1015,
                column: "ProductPrice",
                value: 145.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1016,
                column: "ProductPrice",
                value: 335.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1017,
                column: "ProductPrice",
                value: 48.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1018,
                column: "ProductPrice",
                value: 199.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1019,
                column: "ProductPrice",
                value: 473.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1020,
                column: "ProductPrice",
                value: 40.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1021,
                column: "ProductPrice",
                value: 72.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1022,
                column: "ProductPrice",
                value: 463.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1023,
                column: "ProductPrice",
                value: 173.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1024,
                column: "ProductPrice",
                value: 381.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1025,
                column: "ProductPrice",
                value: 98.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1026,
                column: "ProductPrice",
                value: 389.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1027,
                column: "ProductPrice",
                value: 342.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1028,
                column: "ProductPrice",
                value: 332.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1029,
                column: "ProductPrice",
                value: 59.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1030,
                column: "ProductPrice",
                value: 493.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1031,
                column: "ProductPrice",
                value: 136.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1032,
                column: "ProductPrice",
                value: 26.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1033,
                column: "ProductPrice",
                value: 184.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1034,
                column: "ProductPrice",
                value: 37.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1035,
                column: "ProductPrice",
                value: 473.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1036,
                column: "ProductPrice",
                value: 475.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1037,
                column: "ProductPrice",
                value: 42.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1038,
                column: "ProductPrice",
                value: 217.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1039,
                column: "ProductPrice",
                value: 255.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1040,
                column: "ProductPrice",
                value: 299.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1041,
                column: "ProductPrice",
                value: 369.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1042,
                column: "ProductPrice",
                value: 391.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1043,
                column: "ProductPrice",
                value: 446.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1044,
                column: "ProductPrice",
                value: 224.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1045,
                column: "ProductPrice",
                value: 54.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1046,
                column: "ProductPrice",
                value: 408.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1047,
                column: "ProductPrice",
                value: 300.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1048,
                column: "ProductPrice",
                value: 15.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1049,
                column: "ProductPrice",
                value: 12.0);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90000,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1048 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90001,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1037 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90002,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1002 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90010,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1021 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90011,
                column: "Amount",
                value: 9);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90012,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1045 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90020,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1045 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90021,
                column: "ProductID",
                value: 1004);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90022,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1011 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90030,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1039 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90031,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1016 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90032,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1032 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90040,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1017 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90041,
                column: "ProductID",
                value: 1017);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90042,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1044 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90050,
                column: "ProductID",
                value: 1018);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90051,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1033 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90052,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1006 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90060,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1025 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90061,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1015 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90062,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1025 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90070,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1031 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90071,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1029 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90072,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1041 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90080,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1039 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90081,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1043 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90082,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1040 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90090,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1033 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90091,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1003 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90092,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1014 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90100,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1003 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90101,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1023 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90102,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1029 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90110,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1029 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90111,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1022 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90112,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1038 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90120,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1028 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90121,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1006 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90122,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1048 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90130,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1014 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90131,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1025 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90132,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1011 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90140,
                column: "ProductID",
                value: 1040);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90141,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1018 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90142,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1048 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90150,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1009 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90151,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1004 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90152,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1028 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90160,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1004 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90161,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1043 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90162,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1036 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90170,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1037 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90171,
                column: "ProductID",
                value: 1020);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90172,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1017 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90180,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1011 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90181,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1020 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90182,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1028 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90190,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1010 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90191,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1008 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90192,
                column: "ProductID",
                value: 1048);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace OtoSpaMVC.Data.Migrations
{
    public partial class cartTotalToPurchTotal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Total",
                table: "Purchase",
                nullable: false,
                oldClrType: typeof(int));

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
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 15,
                column: "Total",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9000,
                column: "Total",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9001,
                column: "Total",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9002,
                column: "Total",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9003,
                column: "Total",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9004,
                column: "Total",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9005,
                column: "Total",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9006,
                column: "Total",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9007,
                column: "Total",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9008,
                column: "Total",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9009,
                column: "Total",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9010,
                column: "Total",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9011,
                column: "Total",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9012,
                column: "Total",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9013,
                column: "Total",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9014,
                column: "Total",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9015,
                column: "Total",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9016,
                column: "Total",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9017,
                column: "Total",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9018,
                column: "Total",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9019,
                column: "Total",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90000,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1045 });

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
                column: "ProductID",
                value: 1045);

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
                column: "ProductID",
                value: 1028);

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
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1020 });

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
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1007 });

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
                column: "ProductID",
                value: 1013);

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
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1044 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90092,
                column: "ProductID",
                value: 1017);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90100,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1039 });

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
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1019 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90122,
                column: "ProductID",
                value: 1010);

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
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1039 });

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
                column: "ProductID",
                value: 1032);

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
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1011 });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Total",
                table: "Purchase",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_ID_123456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2a302345-29ee-4b58-8e48-9c7dfe35b2a5", "AQAAAAEAACcQAAAAEJIY1j0dWA3uuwJ7vjbrONTf1X0YFzrSHFRs7797HDbf7j7P1Oc7bLIRGPTaHPSkyA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7000",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2067f8c1-5389-4697-8fde-58b0f44ae346", "AQAAAAEAACcQAAAAEI7fcMwunQjDVi+pfEACpRnqJNx9jxJsLHOzvhvEwQSByxl1VI8v+11WmSpLRUkv0w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "01e5f427-a7ea-4a5f-b696-6d3329ea25d4", "AQAAAAEAACcQAAAAEKR4Y9bAEJFI1Uf1X8w5OmHPuUsPPahJLfXu+0owASK/lYUEDux4We0RHV0StPws1g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1db70031-bc42-4da1-92fb-4ef85bc386c1", "AQAAAAEAACcQAAAAEMW27aOgMUQgtx8KoPMoEwZCedXHUa7aR6uAZwr6i8VSNLJ45PMA5tl34yRGfSuKnA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fe0c777b-6b5e-4cd9-9bd9-76be5f44a36a", "AQAAAAEAACcQAAAAELueYAaSsMwpLwYc8LkVekkgZqdlweMWNHlpf7WRejBhxzjAP9xXwkItx14NpdX1yA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "28b1e60a-0499-4afe-bad3-fff9f406d83e", "AQAAAAEAACcQAAAAEBCEi21Q4l+oSrXNarPHl+NWl/TPIdi6yLIBfXinuaAQ7I831P2HG+wmKHJlisDD+Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3a606c9b-b81e-456e-891c-ab928afdaa22", "AQAAAAEAACcQAAAAEIttJvIV9C9Chy5VXai4FrDiboNAEfyKL1/KD9wKOCYmZkN9v0WvnUB7AXMCjyptNw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7006",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f0490b5c-f49e-4f07-b80d-fd7a2ac9eaff", "AQAAAAEAACcQAAAAEChg33iJ5Wzrm2oyLZ7G3szCK05WgqTfL4Rrx3UNSaPJqDzEMXnFNcOwV3r9EwlvDw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "84d00c2b-d771-46d0-b0bd-894a1b1100ef", "AQAAAAEAACcQAAAAEKU0Xgbn/3A85h6kQz/E4OaqC/CoNKf/qeor8HA3xigp7MbnH2+2T3tGuLrAIam1yQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "61b2cf56-9cc5-4640-ae10-8a473ae96c60", "AQAAAAEAACcQAAAAEDhuUZCljYJ07+uGuGKvO1Nsmznyqk8vrNQZTpHOfJ12gjKy2VNNx8KZI4liA1GrYQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7009",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5e583b41-d0e7-4eb3-806e-c399308ba683", "AQAAAAEAACcQAAAAEDEYBXibmxS25zuNo7j1Egn18Iafg9eHFzF8g1vw6O2fIZzG8iJLLUTvn5vJ/QAKqw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7010",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "04dd0008-a98c-47f0-8f37-7b0df0c0e0c3", "AQAAAAEAACcQAAAAEHR5fwsVpHUhpR5O7SOYYBgydEOT9YzvBiz4ILwJPqOCD4quHD9JTJUyn9ksgZeEKQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6f8bf93b-9de7-407b-b4cb-87bffba910af", "AQAAAAEAACcQAAAAEJyj9rYgFXyYZgxD3wKpIaXsaHJaz+ZHm7mdMwLW55Y6c2Htxx6JE1E26kg/P30DYg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "13a4d0d8-7351-417f-b690-5c709a253248", "AQAAAAEAACcQAAAAEKlbkrNsbuGknSr0GJcPCjoOD/UPEW4UUjzkZFWmg0GqKj2oyRDeJwy6ZlcbpSO2Sw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7013",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9d80142c-1ef6-402d-9bb4-eb9327f84c64", "AQAAAAEAACcQAAAAEGtpWLoDVlvSet2apVq2zh9kIkng7bTNzh0hAbXB6UYyswDmuXaddP3xftWCwQjUng==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7014",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "63b9f0cc-4613-4eca-9066-3a334cecb8d2", "AQAAAAEAACcQAAAAED+M8B4VCEz1Ub95GAxsYOv7XhwDR5/u0LolJoqfsoVG5IYhASLavXarO4rmxdxNfw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e8853ab9-b91c-475d-8920-517b2b7e1e62", "AQAAAAEAACcQAAAAEJ/WdjJ5M7mbmQo331HdZp7cyQ8F2K2SG//s93zqsOZaL2DyIilbTq992x3ob8TuIA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7016",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2889ec0e-f69e-41e3-ae79-7ef4cef9f98c", "AQAAAAEAACcQAAAAEL7wXvJ3myxARs0BfzQUDGd3UxAjHJ9pFoLUbNv7Oy/3DKhIiqhie30E5CCVLFXDGg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9483da50-325e-483b-a189-f6e80d37ac16", "AQAAAAEAACcQAAAAEOzEzTXuxwF6dufUkM4ejbn2APyMNIchttQFXrG5s34r02gm69azXYcHCuhMbHIATw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7018",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7c92bb23-5824-48c6-8446-5da532efa162", "AQAAAAEAACcQAAAAEBxyS1Qiv18D89QTK5bwflLbyze5Qm6DAsEkbVLJC//FY8UvCHgz2Phq2Q+3DSGEIA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7019",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8c5f3d81-5421-4d83-af2d-cb8faf25c178", "AQAAAAEAACcQAAAAENCKxWHPWwMfctzqOx0PRxyT+NqeMh2ZtW72CrLBYjffaUoaXSsBV/twFtTApdmMdg==" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1000,
                column: "ProductPrice",
                value: 64.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1001,
                column: "ProductPrice",
                value: 499.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1002,
                column: "ProductPrice",
                value: 286.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1003,
                column: "ProductPrice",
                value: 280.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1004,
                column: "ProductPrice",
                value: 125.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1005,
                column: "ProductPrice",
                value: 498.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1006,
                column: "ProductPrice",
                value: 126.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1007,
                column: "ProductPrice",
                value: 159.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1008,
                column: "ProductPrice",
                value: 54.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1009,
                column: "ProductPrice",
                value: 142.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1010,
                column: "ProductPrice",
                value: 373.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1011,
                column: "ProductPrice",
                value: 210.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1012,
                column: "ProductPrice",
                value: 174.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1013,
                column: "ProductPrice",
                value: 423.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1014,
                column: "ProductPrice",
                value: 471.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1015,
                column: "ProductPrice",
                value: 46.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1016,
                column: "ProductPrice",
                value: 428.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1017,
                column: "ProductPrice",
                value: 407.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1018,
                column: "ProductPrice",
                value: 177.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1019,
                column: "ProductPrice",
                value: 221.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1020,
                column: "ProductPrice",
                value: 276.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1021,
                column: "ProductPrice",
                value: 378.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1022,
                column: "ProductPrice",
                value: 424.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1023,
                column: "ProductPrice",
                value: 172.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1024,
                column: "ProductPrice",
                value: 46.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1025,
                column: "ProductPrice",
                value: 208.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1026,
                column: "ProductPrice",
                value: 131.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1027,
                column: "ProductPrice",
                value: 401.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1028,
                column: "ProductPrice",
                value: 499.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1029,
                column: "ProductPrice",
                value: 213.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1030,
                column: "ProductPrice",
                value: 388.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1031,
                column: "ProductPrice",
                value: 283.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1032,
                column: "ProductPrice",
                value: 238.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1033,
                column: "ProductPrice",
                value: 391.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1034,
                column: "ProductPrice",
                value: 466.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1035,
                column: "ProductPrice",
                value: 449.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1036,
                column: "ProductPrice",
                value: 204.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1037,
                column: "ProductPrice",
                value: 122.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1038,
                column: "ProductPrice",
                value: 196.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1039,
                column: "ProductPrice",
                value: 38.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1040,
                column: "ProductPrice",
                value: 271.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1041,
                column: "ProductPrice",
                value: 183.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1042,
                column: "ProductPrice",
                value: 312.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1043,
                column: "ProductPrice",
                value: 469.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1044,
                column: "ProductPrice",
                value: 391.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1045,
                column: "ProductPrice",
                value: 336.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1046,
                column: "ProductPrice",
                value: 450.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1047,
                column: "ProductPrice",
                value: 171.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1048,
                column: "ProductPrice",
                value: 148.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1049,
                column: "ProductPrice",
                value: 255.0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 15,
                column: "Total",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9000,
                column: "Total",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9001,
                column: "Total",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9002,
                column: "Total",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9003,
                column: "Total",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9004,
                column: "Total",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9005,
                column: "Total",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9006,
                column: "Total",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9007,
                column: "Total",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9008,
                column: "Total",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9009,
                column: "Total",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9010,
                column: "Total",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9011,
                column: "Total",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9012,
                column: "Total",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9013,
                column: "Total",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9014,
                column: "Total",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9015,
                column: "Total",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9016,
                column: "Total",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9017,
                column: "Total",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9018,
                column: "Total",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9019,
                column: "Total",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90000,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1003 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90001,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1027 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90002,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1040 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90010,
                column: "ProductID",
                value: 1007);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90011,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1023 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90012,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1037 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90020,
                column: "ProductID",
                value: 1015);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90021,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1024 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90022,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1047 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90030,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1045 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90031,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1033 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90032,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1021 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90040,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1044 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90041,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1006 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90042,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1027 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90050,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1025 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90051,
                column: "ProductID",
                value: 1025);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90052,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1017 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90060,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1000 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90061,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1048 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90062,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1037 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90070,
                column: "ProductID",
                value: 1037);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90071,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1015 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90072,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1002 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90080,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1022 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90081,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1036 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90082,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1020 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90090,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1041 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90091,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1026 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90092,
                column: "ProductID",
                value: 1035);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90100,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1011 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90101,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1034 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90102,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1016 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90110,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1046 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90111,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1016 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90112,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1008 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90120,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1029 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90121,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1015 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90122,
                column: "ProductID",
                value: 1043);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90130,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1048 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90131,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1006 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90132,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1023 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90140,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1034 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90141,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1024 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90142,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1033 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90150,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1013 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90151,
                column: "ProductID",
                value: 1006);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90152,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1017 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90160,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1024 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90161,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1011 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90162,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1008 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90170,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1030 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90171,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1021 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90172,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1037 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90180,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1046 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90181,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1028 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90182,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1014 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90190,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1024 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90191,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1038 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90192,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1019 });
        }
    }
}

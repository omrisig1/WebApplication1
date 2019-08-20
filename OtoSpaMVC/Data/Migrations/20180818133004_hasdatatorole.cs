using Microsoft.EntityFrameworkCore.Migrations;

namespace OtoSpaMVC.Data.Migrations
{
    public partial class hasdatatorole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "user", "user", "user" },
                    { "2", "admin", "admin", "admin" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_ID_123456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "faea4071-d077-4bd1-a4c3-ffcf7f294509", "AQAAAAEAACcQAAAAEGJI82Edk26IiwWNSGtFgBCecLBufq0raOO1FEQ1ok98yGtLeZkyw/Ricfov9vLQwg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7000",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5ea20ebc-5d5f-4d27-8597-8a462166b058", "AQAAAAEAACcQAAAAEJReolE6aquuXGAX6cZvr3y/N/xEzV4ffMPbDxVo7hedz3UY6xRcJIrrIpxhX3lscA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ba88f28f-cf81-4dea-89d8-f23a540b8337", "AQAAAAEAACcQAAAAEJtI6lIFsEm9a3i8/BdVYmibuDwG13coixu1VhOlUmKYLB7spahNzXq810J8ghu0uQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "beabca6c-3d0c-48aa-813a-8e2fee6b175b", "AQAAAAEAACcQAAAAECDJ9SA5B5YbeXCldSHqF1eqCLdf2iNxjYcwqMUAjfaBGtC8wI6GCZTYElamH4P6Aw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "782b28ed-5d15-4881-8d42-4f6d7391648e", "AQAAAAEAACcQAAAAEIkp4IQDuaA8mqPXC6jSedVgpH/2KzygRzIfw2RsIXuqN4SxJ3ExQLGorawwCeQMgg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "65916201-f945-49cd-94c2-f5d17469e84d", "AQAAAAEAACcQAAAAELdu01EP/DAcBuRStD5ZpX1CIhG5/O1TqgBAdvw7UCKAF1wcyxleKCe/fOm3euDT7g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0ea81161-732e-43ae-8c99-2b8f0def0e4b", "AQAAAAEAACcQAAAAEHnVpHkvQF0vastlvwST+jAkY0bkzjBSBR++glZrhRoa9NyWl+KPdswZo1q1u/aNrA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7006",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "96fe273a-07fb-4e97-8e52-d65d31fed489", "AQAAAAEAACcQAAAAEEhlNmxkqKYzb1y74Z9i2rPqYFqPu5Dgwy5f3GKBQiYEfgtTEgZRDz8WQuRtBbbyOw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5bec3d87-3303-495f-a0cc-2fb6fd53ad81", "AQAAAAEAACcQAAAAEPd+gUxhn1m3WLaN3UQN4iPkv0JgF69Op+vDQrWNMkrZkafuy4bjFg6F94+oYiLHyg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3b26557d-4a6d-4dec-bd4b-041321858ff3", "AQAAAAEAACcQAAAAEEWfmrewHdG1J/OhsAUB1y65mMcv+pY8fbOce7OfwbrTt8nDcDEOBp2REios4YME3Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7009",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4910a465-1107-42d0-9e85-de3f208248f9", "AQAAAAEAACcQAAAAEKSue6jP2EUgld8DARVGwwAOqT7Tt94nJiigcB31KBn5cSOrcvQDUmZhPwYnij+2bw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7010",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ebedfa88-c064-4e21-a6b8-dff213a4eebf", "AQAAAAEAACcQAAAAEKUwgc+XhdQK9gFsv5IMljO/a0CBaUKzBt7DUTCxp6+Bv8FAoFjUb2e7852AHoMs7A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "980502a9-fe65-4c42-bab1-a9f3691c2d28", "AQAAAAEAACcQAAAAEBE01ja8/sdty/xGyeAHgiGYawV9igtwnrTyYjqgNUVves0fHyUYsIcDJatOlwNzZw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fb67771c-8059-470a-ab17-732a6da3fc15", "AQAAAAEAACcQAAAAEAlUmUgfVYJilLUTFiWahbVgHOtSFQ6S3vDsc49GjLlwJaJU9zxRlYDHED/5Fx7ZYw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7013",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "db5f525b-437f-4e5f-b914-16ba5c5d4015", "AQAAAAEAACcQAAAAEOjFLfdcqynz/c0ypa1lrvUtAl7ezFlzGajMP6r3zofxO1m7/UqFfWbtvR1ueF+J9Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7014",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dc035a76-f2c9-4c2d-8dd9-3b0ab576c353", "AQAAAAEAACcQAAAAEOwKVsGkziiXxT1rkrcZVkGANG3fsRlt4dPbV0KjkLjxLONWJmaxHP7pRLe2kTFY/w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c8c68b50-4c89-4f29-a1f5-e4e425cb084e", "AQAAAAEAACcQAAAAECpYsvbVKiXbDlG1ISPN2X/b3gFRch9HcWx+SDKGaL81zcL6sF5mVVb3wPPfUaHcpQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7016",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ed88278-e40d-4056-a50a-053c10f0e0a5", "AQAAAAEAACcQAAAAEEIXNbH80kEdQFOXf7YZNekuKR1xNSMhYyDkMazV6B7JvI3WOM3wa26OliKjnJNldg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "425c42b0-f141-4571-a95c-bf7679ba8fa7", "AQAAAAEAACcQAAAAEN3V+Pcf4aOrIRxD7WI1uCMI49hFtaph3JG5dZpKGvr1ri08U0xV7G1HPaLoMjEGBg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7018",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fdf15959-6da8-4598-a2d0-ad35f66717e0", "AQAAAAEAACcQAAAAENvoK3Cj49A5hzYGzPqYft3ssKwi1PVMMhNsQSGZLGdeR2UcGvzR4ytMH3t+FshBqA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7019",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b054e9ac-9872-4d0f-ae15-6e135dd08755", "AQAAAAEAACcQAAAAEE3F3mnSIn/V+mAqh6pU20bFhdl3LFvcJG6ddwlGNAFFVZuWKsMbdQHLydHx+OkMLA==" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1000,
                column: "ProductPrice",
                value: 371.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1001,
                column: "ProductPrice",
                value: 276.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1002,
                column: "ProductPrice",
                value: 360.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1003,
                column: "ProductPrice",
                value: 155.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1004,
                column: "ProductPrice",
                value: 145.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1005,
                column: "ProductPrice",
                value: 282.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1006,
                column: "ProductPrice",
                value: 110.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1007,
                column: "ProductPrice",
                value: 468.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1008,
                column: "ProductPrice",
                value: 388.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1009,
                column: "ProductPrice",
                value: 421.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1010,
                column: "ProductPrice",
                value: 111.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1011,
                column: "ProductPrice",
                value: 99.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1012,
                column: "ProductPrice",
                value: 432.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1013,
                column: "ProductPrice",
                value: 422.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1014,
                column: "ProductPrice",
                value: 209.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1015,
                column: "ProductPrice",
                value: 472.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1016,
                column: "ProductPrice",
                value: 114.0);

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
                value: 48.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1019,
                column: "ProductPrice",
                value: 454.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1020,
                column: "ProductPrice",
                value: 272.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1021,
                column: "ProductPrice",
                value: 116.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1022,
                column: "ProductPrice",
                value: 272.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1023,
                column: "ProductPrice",
                value: 349.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1024,
                column: "ProductPrice",
                value: 481.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1025,
                column: "ProductPrice",
                value: 174.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1026,
                column: "ProductPrice",
                value: 148.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1027,
                column: "ProductPrice",
                value: 339.0);

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
                value: 178.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1030,
                column: "ProductPrice",
                value: 120.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1031,
                column: "ProductPrice",
                value: 61.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1032,
                column: "ProductPrice",
                value: 70.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1033,
                column: "ProductPrice",
                value: 55.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1034,
                column: "ProductPrice",
                value: 430.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1035,
                column: "ProductPrice",
                value: 431.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1036,
                column: "ProductPrice",
                value: 51.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1037,
                column: "ProductPrice",
                value: 208.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1038,
                column: "ProductPrice",
                value: 222.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1039,
                column: "ProductPrice",
                value: 172.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1040,
                column: "ProductPrice",
                value: 440.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1041,
                column: "ProductPrice",
                value: 263.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1042,
                column: "ProductPrice",
                value: 124.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1043,
                column: "ProductPrice",
                value: 109.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1044,
                column: "ProductPrice",
                value: 447.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1045,
                column: "ProductPrice",
                value: 162.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1046,
                column: "ProductPrice",
                value: 289.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1047,
                column: "ProductPrice",
                value: 460.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1048,
                column: "ProductPrice",
                value: 217.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1049,
                column: "ProductPrice",
                value: 228.0);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90000,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1029 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90001,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1010 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90002,
                column: "ProductID",
                value: 1019);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90010,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1000 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90011,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1016 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90012,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1013 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90020,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1013 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90021,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1030 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90022,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1002 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90030,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1049 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90031,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1042 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90032,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1037 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90040,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1001 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90041,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1049 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90042,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1040 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90050,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1038 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90051,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1012 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90052,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1037 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90060,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1045 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90061,
                column: "ProductID",
                value: 1035);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90062,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1042 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90070,
                column: "ProductID",
                value: 1003);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90071,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1002 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90072,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1012 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90080,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1029 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90081,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1012 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90082,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1046 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90090,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1029 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90091,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1023 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90092,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1001 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90100,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1026 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90101,
                column: "ProductID",
                value: 1011);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90102,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1008 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90110,
                column: "ProductID",
                value: 1014);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90111,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1034 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90112,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1009 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90120,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1002 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90121,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1034 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90122,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1036 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90130,
                column: "ProductID",
                value: 1034);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90131,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1038 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90132,
                column: "Amount",
                value: 1);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90140,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1019 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90141,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1021 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90142,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1031 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90150,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1026 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90151,
                column: "ProductID",
                value: 1000);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90152,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1039 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90160,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1042 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90161,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1015 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90162,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1003 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90170,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1005 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90171,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1029 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90172,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1037 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90180,
                column: "ProductID",
                value: 1009);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90181,
                column: "Amount",
                value: 3);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90182,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1038 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90190,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1029 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90191,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1046 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90192,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1014 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "1", "user" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "2", "admin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_ID_123456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ba77fd9-d6e9-4ed5-9976-cd3d93a8fd1b", "AQAAAAEAACcQAAAAENA4kuQFqaPQQIcLa0JJBIbQKjJnzWiGKcY+hh9ONSPYyuVYhNcQcoQS6RJU26cmsA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7000",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8976480c-4864-41f5-b5bb-0b4ec8fcd5d5", "AQAAAAEAACcQAAAAEHyGK3Vg1SSpwQ41cCZ8+M/JxpV9H2C+aOK5q7UtxXnAEGIqQydF3oXwV/3eR039uA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a6cac06b-cb39-4d18-94cd-1f0befffd88c", "AQAAAAEAACcQAAAAELZM8VgGOiqxbROpVxbGbtb2cVL5sBx7vNiMo2EuRgd4XAJFiH8XOGuA9STna5pvpw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "46d80552-9f55-4bb2-9a01-87610c89906a", "AQAAAAEAACcQAAAAEObL+s+g7nv0xuXakFZo47uXduw1CoqQBEJ7grAqPFjB6PIpU48QPrGPE01/eTJcuw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f4554918-7459-4aa5-99a0-74885be29903", "AQAAAAEAACcQAAAAEHZ3ftAcaWZyeZ3u/GG73t7ps9IRF+BGAJtSRekfQYxxKemsldFHEKF/5ZEasuv96w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "729a1772-0fd4-4a82-9521-f35af958aca3", "AQAAAAEAACcQAAAAEEBLM0FddvzBwsCajKAlUms//cQd5myJWEED92Dg29voeceOHEvhecyZu4ixufe5Nw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "662b56df-7d0f-4fb6-bfaa-1dba67aa6c65", "AQAAAAEAACcQAAAAEPU2P0OszSWJbLZ2sK8E6ulcAmjhNDdASBoDkdiziB7smcJeEexr3AlDuRrDvonu2A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7006",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "da55a95f-df91-488f-b91b-7c0a42d981dd", "AQAAAAEAACcQAAAAEEzi9NDQKy0fyJhgoVSJKmPLy++0YDqBBYzwHgeMGwwcMc4T/Mftmhj2i9/GkiQJlQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e3d1a4e3-35aa-4cf1-8349-18dc1c1f6a04", "AQAAAAEAACcQAAAAEP+DRA02db/QzFmY3hStKVARxFxX2guVeETvTLzXrIYOKf0i6f7dDDItF4a2hrlhdA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2d40dad5-db50-4396-9f6f-40767cb298f6", "AQAAAAEAACcQAAAAENgRWaK8udL3QIBUqJNz4LmaNSNu4RgwUkzGR8WwXn1N2fSSzA6gNATQSdfPdQf0SQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7009",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "80254584-24c4-47b4-8d70-e5b63145736b", "AQAAAAEAACcQAAAAEFiTtPaZ9b0FEozFaGXsnWFHPkhBFo9E7EAlY26GAOGAkMLWSsMP1DM/Gf2MZodhpA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7010",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "30bcd509-c3e2-4460-b47e-af378f7cab6b", "AQAAAAEAACcQAAAAEO7trZc36q9xpYHabuh/haXWM81fRGTjsmFiSGOMM4vCVZnJLxw8tblnP+yzjZr+Zg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c7a14094-2dc4-447d-9615-52c7b019c55a", "AQAAAAEAACcQAAAAEGqnQnxUyQHohlruyfKUDz6KtANhNWJzU1PH/zDhfUrcPFyczlTf4fineBDDIA7bHA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e4b5c518-ef12-4581-a553-6379fab5c504", "AQAAAAEAACcQAAAAEFr7RKTRMcRaLK5YfipEZCejX+mdNpdzWdw+lM92LeKGo4pNG0Q/M+Y1LYrzwDTp+Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7013",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f409c1df-96a1-4caf-a8c4-c7b84b98bdf6", "AQAAAAEAACcQAAAAENMbX1Ba1i+ltgcJdlxXVmPrle9gTo4dF914W8jNe+hGQclIAFQ2ZgxWnF8MKP/qGg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7014",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7559d9d2-b44c-45b7-b78b-ef5a5ebf280e", "AQAAAAEAACcQAAAAEGt+N53+/AtkzmFtDSIwZitiAOvxrYAQvGY+Lglp2ynesHqiInsQBEnNZ4HrRxRUSw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "25aa232a-a359-44fa-bd4b-f72bdad59aa4", "AQAAAAEAACcQAAAAENb80FAzC4W8+6iJUoA4chIi0zjF85qWc9VAQ5WLmbzxdwyjLEgduhGxYIw+eee52w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7016",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2edf1afb-9c1e-498b-a4a1-fcca16f78ffe", "AQAAAAEAACcQAAAAEM7vcqjC7OTSjCJArUBjXC/mCx5pkXmk2mOXCM08pnsP99+ej2AiM+hzPl9C2f2BnA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e7b34c00-1a94-49ef-9bd2-9e15d6cc06bc", "AQAAAAEAACcQAAAAEOXrwG5A9AXScRas3cfozAUlvEo6Qp1xEnO85iEp5/m2TGWs607r9gHrHscXIrMn8g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7018",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3772f53a-13b7-4385-9ccd-dd8ac849d511", "AQAAAAEAACcQAAAAEE1gSe7UywvlcvybkMJnLS2vDoJsVUsWm+aJxave8EOzAIaCiaViPYX+XEzfbxPzJw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7019",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ab4f6748-2bb7-4c8d-8965-9e8f8e691351", "AQAAAAEAACcQAAAAEN10znC273wv82vKGN8KZreEyvjDfhDj1uJO1TILhkhbUky3+U+W40NTrDEeVpb2YQ==" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1000,
                column: "ProductPrice",
                value: 480.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1001,
                column: "ProductPrice",
                value: 245.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1002,
                column: "ProductPrice",
                value: 363.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1003,
                column: "ProductPrice",
                value: 437.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1004,
                column: "ProductPrice",
                value: 300.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1005,
                column: "ProductPrice",
                value: 107.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1006,
                column: "ProductPrice",
                value: 282.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1007,
                column: "ProductPrice",
                value: 12.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1008,
                column: "ProductPrice",
                value: 411.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1009,
                column: "ProductPrice",
                value: 65.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1010,
                column: "ProductPrice",
                value: 362.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1011,
                column: "ProductPrice",
                value: 292.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1012,
                column: "ProductPrice",
                value: 272.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1013,
                column: "ProductPrice",
                value: 388.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1014,
                column: "ProductPrice",
                value: 252.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1015,
                column: "ProductPrice",
                value: 143.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1016,
                column: "ProductPrice",
                value: 88.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1017,
                column: "ProductPrice",
                value: 220.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1018,
                column: "ProductPrice",
                value: 419.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1019,
                column: "ProductPrice",
                value: 75.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1020,
                column: "ProductPrice",
                value: 469.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1021,
                column: "ProductPrice",
                value: 211.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1022,
                column: "ProductPrice",
                value: 154.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1023,
                column: "ProductPrice",
                value: 154.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1024,
                column: "ProductPrice",
                value: 460.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1025,
                column: "ProductPrice",
                value: 455.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1026,
                column: "ProductPrice",
                value: 432.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1027,
                column: "ProductPrice",
                value: 83.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1028,
                column: "ProductPrice",
                value: 446.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1029,
                column: "ProductPrice",
                value: 293.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1030,
                column: "ProductPrice",
                value: 459.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1031,
                column: "ProductPrice",
                value: 396.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1032,
                column: "ProductPrice",
                value: 369.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1033,
                column: "ProductPrice",
                value: 96.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1034,
                column: "ProductPrice",
                value: 483.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1035,
                column: "ProductPrice",
                value: 152.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1036,
                column: "ProductPrice",
                value: 333.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1037,
                column: "ProductPrice",
                value: 412.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1038,
                column: "ProductPrice",
                value: 81.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1039,
                column: "ProductPrice",
                value: 347.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1040,
                column: "ProductPrice",
                value: 450.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1041,
                column: "ProductPrice",
                value: 223.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1042,
                column: "ProductPrice",
                value: 408.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1043,
                column: "ProductPrice",
                value: 191.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1044,
                column: "ProductPrice",
                value: 162.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1045,
                column: "ProductPrice",
                value: 329.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1046,
                column: "ProductPrice",
                value: 187.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1047,
                column: "ProductPrice",
                value: 444.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1048,
                column: "ProductPrice",
                value: 358.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1049,
                column: "ProductPrice",
                value: 425.0);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90000,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1043 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90001,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1045 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90002,
                column: "ProductID",
                value: 1031);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90010,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1009 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90011,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1047 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90012,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1016 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90020,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1005 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90021,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1009 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90022,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1042 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90030,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1040 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90031,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1030 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90032,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1014 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90040,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1011 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90041,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1029 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90042,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1049 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90050,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1027 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90051,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1021 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90052,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1035 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90060,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1043 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90061,
                column: "ProductID",
                value: 1027);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90062,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1005 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90070,
                column: "ProductID",
                value: 1043);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90071,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1017 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90072,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1016 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90080,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1008 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90081,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1040 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90082,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1004 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90090,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1011 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90091,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1014 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90092,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1047 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90100,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1047 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90101,
                column: "ProductID",
                value: 1022);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90102,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1006 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90110,
                column: "ProductID",
                value: 1048);

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
                values: new object[] { 3, 1002 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90120,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1040 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90121,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 4, 1004 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90122,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1023 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90130,
                column: "ProductID",
                value: 1039);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90131,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 1, 1009 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90132,
                column: "Amount",
                value: 6);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90140,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1022 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90141,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1044 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90142,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1040 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90150,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1001 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90151,
                column: "ProductID",
                value: 1030);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90152,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1023 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90160,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1039 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90161,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1016 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90162,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1026 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90170,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 3, 1002 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90171,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 5, 1016 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90172,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 7, 1009 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90180,
                column: "ProductID",
                value: 1020);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90181,
                column: "Amount",
                value: 5);

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90182,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 2, 1048 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90190,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 9, 1047 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90191,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 8, 1025 });

            migrationBuilder.UpdateData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90192,
                columns: new[] { "Amount", "ProductID" },
                values: new object[] { 6, 1011 });
        }
    }
}

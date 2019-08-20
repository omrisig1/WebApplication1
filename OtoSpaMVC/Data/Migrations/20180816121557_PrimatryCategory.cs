using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OtoSpaMVC.Data.Migrations
{
    public partial class PrimatryCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCategory");

            migrationBuilder.AddColumn<int>(
                name: "PrimaryCategoryID",
                table: "Product",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 504, "PrimeCategory_4" },
                    { 503, "PrimeCategory_3" },
                    { 501, "PrimeCategory_1" },
                    { 500, "PrimeCategory_0" },
                    { 502, "PrimeCategory_2" }
                });

            migrationBuilder.InsertData(
                table: "Purchase",
                columns: new[] { "ID", "CreditDetails", "UserID" },
                values: new object[,]
                {
                    { 9018, "abc", "rt_7018" },
                    { 9017, "abc", "rt_7017" },
                    { 9016, "abc", "rt_7016" },
                    { 9015, "abc", "rt_7015" },
                    { 9014, "abc", "rt_7014" },
                    { 9013, "abc", "rt_7013" },
                    { 9012, "abc", "rt_7012" },
                    { 9011, "abc", "rt_7011" },
                    { 9010, "abc", "rt_7010" },
                    { 9008, "abc", "rt_7008" },
                    { 9007, "abc", "rt_7007" },
                    { 9006, "abc", "rt_7006" },
                    { 9005, "abc", "rt_7005" },
                    { 9004, "abc", "rt_7004" },
                    { 9003, "abc", "rt_7003" },
                    { 9002, "abc", "rt_7002" },
                    { 9001, "abc", "rt_7001" },
                    { 9000, "abc", "rt_7000" },
                    { 9009, "abc", "rt_7009" },
                    { 9019, "abc", "rt_7019" }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1000,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 500, 64.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1001,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 501, 499.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1002,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 502, 286.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1003,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 503, 280.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1004,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 504, 125.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1005,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 500, 498.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1006,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 501, 126.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1007,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 502, 159.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1008,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 503, 54.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1009,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 504, 142.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1010,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 500, 373.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1011,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 501, 210.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1012,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 502, 174.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1013,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 503, 423.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1014,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 504, 471.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1015,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 500, 46.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1016,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 501, 428.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1017,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 502, 407.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1018,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 503, 177.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1019,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 504, 221.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1020,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 500, 276.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1021,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 501, 378.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1022,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 502, 424.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1023,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 503, 172.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1024,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 504, 46.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1025,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 500, 208.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1026,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 501, 131.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1027,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 502, 401.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1028,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 503, 499.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1029,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 504, 213.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1030,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 500, 388.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1031,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 501, 283.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1032,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 502, 238.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1033,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 503, 391.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1034,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 504, 466.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1035,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 500, 449.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1036,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 501, 204.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1037,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 502, 122.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1038,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 503, 196.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1039,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 504, 38.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1040,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 500, 271.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1041,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 501, 183.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1042,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 502, 312.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1043,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 503, 469.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1044,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 504, 391.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1045,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 500, 336.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1046,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 501, 450.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1047,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 502, 171.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1048,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 503, 148.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1049,
                columns: new[] { "PrimaryCategoryID", "ProductPrice" },
                values: new object[] { 504, 255.0 });

            migrationBuilder.InsertData(
                table: "PurchaseItem",
                columns: new[] { "ID", "Amount", "ProductID", "PurchaseID" },
                values: new object[,]
                {
                    { 90101, 1, 1034, 9010 },
                    { 90102, 8, 1016, 9010 },
                    { 90110, 8, 1046, 9011 },
                    { 90111, 7, 1016, 9011 },
                    { 90112, 1, 1008, 9011 },
                    { 90120, 4, 1029, 9012 },
                    { 90121, 5, 1015, 9012 },
                    { 90122, 8, 1043, 9012 },
                    { 90130, 8, 1048, 9013 },
                    { 90131, 2, 1006, 9013 },
                    { 90132, 9, 1023, 9013 },
                    { 90140, 2, 1034, 9014 },
                    { 90141, 3, 1024, 9014 },
                    { 90142, 9, 1033, 9014 },
                    { 90150, 7, 1013, 9015 },
                    { 90151, 4, 1006, 9015 },
                    { 90152, 5, 1017, 9015 },
                    { 90160, 7, 1024, 9016 },
                    { 90161, 5, 1011, 9016 },
                    { 90162, 3, 1008, 9016 },
                    { 90170, 7, 1030, 9017 },
                    { 90171, 6, 1021, 9017 },
                    { 90172, 1, 1037, 9017 },
                    { 90180, 3, 1046, 9018 },
                    { 90181, 6, 1028, 9018 },
                    { 90182, 9, 1014, 9018 },
                    { 90190, 1, 1024, 9019 },
                    { 90100, 3, 1011, 9010 },
                    { 90092, 6, 1035, 9009 },
                    { 90011, 8, 1023, 9001 },
                    { 90090, 5, 1041, 9009 },
                    { 90000, 9, 1003, 9000 },
                    { 90001, 6, 1027, 9000 },
                    { 90002, 4, 1040, 9000 },
                    { 90010, 3, 1007, 9001 },
                    { 90191, 7, 1038, 9019 },
                    { 90012, 4, 1037, 9001 },
                    { 90020, 7, 1015, 9002 },
                    { 90021, 2, 1024, 9002 },
                    { 90022, 6, 1047, 9002 },
                    { 90030, 1, 1045, 9003 },
                    { 90031, 6, 1033, 9003 },
                    { 90032, 3, 1021, 9003 },
                    { 90040, 2, 1044, 9004 },
                    { 90041, 9, 1006, 9004 },
                    { 90042, 4, 1027, 9004 },
                    { 90050, 9, 1025, 9005 },
                    { 90051, 5, 1025, 9005 },
                    { 90052, 8, 1017, 9005 },
                    { 90060, 8, 1000, 9006 },
                    { 90061, 6, 1048, 9006 },
                    { 90062, 2, 1037, 9006 },
                    { 90070, 5, 1037, 9007 },
                    { 90071, 1, 1015, 9007 },
                    { 90072, 9, 1002, 9007 },
                    { 90080, 6, 1022, 9008 },
                    { 90081, 4, 1036, 9008 },
                    { 90082, 3, 1020, 9008 },
                    { 90091, 3, 1026, 9009 },
                    { 90192, 2, 1019, 9019 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_PrimaryCategoryID",
                table: "Product",
                column: "PrimaryCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_PrimaryCategoryID",
                table: "Product",
                column: "PrimaryCategoryID",
                principalTable: "Category",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_PrimaryCategoryID",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_PrimaryCategoryID",
                table: "Product");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90000);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90001);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90002);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90010);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90011);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90012);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90020);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90021);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90022);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90030);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90031);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90032);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90040);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90041);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90042);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90050);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90051);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90052);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90060);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90061);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90062);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90070);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90071);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90072);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90080);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90081);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90082);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90090);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90091);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90092);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90100);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90101);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90102);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90110);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90111);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90112);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90120);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90121);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90122);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90130);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90131);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90132);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90140);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90141);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90142);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90150);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90151);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90152);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90160);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90161);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90162);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90170);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90171);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90172);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90180);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90181);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90182);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90190);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90191);

            migrationBuilder.DeleteData(
                table: "PurchaseItem",
                keyColumn: "ID",
                keyValue: 90192);

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9000);

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9001);

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9002);

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9003);

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9004);

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9005);

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9006);

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9007);

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9008);

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9009);

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9010);

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9011);

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9012);

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9013);

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9014);

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9015);

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9016);

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9017);

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9018);

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 9019);

            migrationBuilder.DropColumn(
                name: "PrimaryCategoryID",
                table: "Product");

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductCategory_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategory_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_ID_123456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e7d59a38-c6c0-481c-ba55-83a32bd59182", "AQAAAAEAACcQAAAAEDmxH647Kw+0aSVVTQWugXuyOc2V2IryQohRgQvx8XLoz4wvWwUcTJaAfv6/8vnTig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7000",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ed7e942a-6670-4a49-96c8-3a6876263e68", "AQAAAAEAACcQAAAAEMjDdYKCzS6rvURQVyICVRR9NGW/G0RxuNgbe5w/NWVo7fedwdfkVz/WeitjGzwZsQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b17d7293-e528-4caf-a7d8-d1295fcb5b2a", "AQAAAAEAACcQAAAAEKgwqwPu+cC//E/x7SsWDkjsPjh7Rb1tltRfu/4fqArv/mg8b2QOSpWwEAU7YIpfmA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "432683dd-a5c7-4a59-ba8e-47e8567b565a", "AQAAAAEAACcQAAAAEEniewXaST/4QNufXlHcA0y4rAOs1YMT0v1pXNXGWYQFiEPVoonTVbVDn24qtsV6tw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "578c0531-af0a-4bc2-a3d4-5055a70ff9d8", "AQAAAAEAACcQAAAAEAiMW/7/wDIGqCtqxECgGTMpGFDGczKioe+kC5Ddp76yUnMs9h7AMto8nRp9oXkoTQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "782cdf9c-ccf1-44cb-a300-32539ef40411", "AQAAAAEAACcQAAAAEGtYnhVnguoNpp7RhA82RkP/gANr1I51IlGN1FaTizUMEaQWV3pUEBAhIXXys2lEfQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f1735f95-179d-4eea-b63c-5fadd7dade03", "AQAAAAEAACcQAAAAEDhjWnDgsjkGPtbwphPsL0itG9MzBeO5Xu8NeUhhL6CY9MXFQiLFVNpxeVeefVfbSg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7006",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ce25570-04cd-4aa9-bbd4-8e5f04ed3750", "AQAAAAEAACcQAAAAECey3SgYfpEC+81JGSx/GOrlpeGv+FsDsiV2qq8N9KaiQgz340RTw4ETUKo4dD0wAQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d0cc8046-c991-4daf-b7e9-bc4f12b34a20", "AQAAAAEAACcQAAAAEKvhSWriX6hZOrQgiqBNxu70FfTQ5CWM1tBvdfzsCExIYGE6uhHeJjVSNz0kWn7XOA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0522f6ff-2848-4376-b44d-f4c2bfc61417", "AQAAAAEAACcQAAAAEJXIJerZQaAW314J/ew2y62/eMh+9aHtBb0xkYNUQAWjdfZu7G2AduYm6xikzamZWQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7009",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bb20c67e-d571-4db3-9cfa-d23acbfc6c38", "AQAAAAEAACcQAAAAEA4Hlb9jX13KRRkqC0hru53FZLToArND5Xe6j4i3zPYb/SsYp6B07NgZZU18hmOJcw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7010",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "29fd55e3-1ce0-4749-83a9-aecc8161f4b3", "AQAAAAEAACcQAAAAEOEBN6gzEa3mwYzOy1Pun82akcQtcdq92OoiEfHl2ZV/mtqnXDkCsqFPqp/imLU/mw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1eb4d30c-1f2c-428c-960a-5b8757e6c2f5", "AQAAAAEAACcQAAAAEDjZk7rEE+SbFp3NynYNae5v0AWeuAK2S6lCCr54ZvbJ9ljyayax1DBaIn6mt7d/bg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "01492168-fc4f-4332-a392-7bfe7fa7e488", "AQAAAAEAACcQAAAAEBErEkv2coait1q02c4dk7vTWAsPfybRDiV1luF/c8EzCE9Lf3LsOU54PhxWWsFkiA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7013",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fb1df0e9-1339-4eb4-9015-a646e9b2da8f", "AQAAAAEAACcQAAAAEODN8XbKDZmohR8QLzBSIluMMqWnlltQLkM2bfUWlv0Zd12idePPTHL+iB5Jx/qSHw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7014",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "43cccf10-a800-48fd-a39d-da2d78093436", "AQAAAAEAACcQAAAAEPeutXRIjcjTFp2DzylDeC+/BLugGEI5MOCRiQPSIgX25k0xRowVIeSqMZzaatfblg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "21468f6e-b3c0-4d78-ada2-7e97da0445c5", "AQAAAAEAACcQAAAAEDph5ErXhqVW3f4jda/0V++cic+FM/4kT2PXERb0/XbLrh351tMbDTgraSYoTk5tXQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7016",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b908219a-113c-479b-b967-5d1f08983357", "AQAAAAEAACcQAAAAEPte9mb14YjI700WSzT17kpaWfAdxSx8gG+3aV8aYm+FQjODw1pKEjbS7sCsgWKLfA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "88bbbc19-eda5-4572-a2e5-ba6d62b45f21", "AQAAAAEAACcQAAAAEKdex/aN3fW1hcDp7yNhTF1m4EFKts19m9b1exIdwzfj4tp+wDkPH7lusdwx7tk2zw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7018",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "92bc1dd2-84f3-414b-ad67-65e88f042e16", "AQAAAAEAACcQAAAAEPCng46Evl3ds9yzoub7FA/6X2lZk7yUDjPnThkwGom/ECU41K6CvrlPpX6PWQDz3A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7019",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b5232f77-d990-4fd5-b377-d25bff7ad044", "AQAAAAEAACcQAAAAEMq432L1T41Vicfy2BUWslnIJcx6o38AqqPLG1mdYxAKxF7FKyKcJTR07EPbftMwpA==" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1000,
                column: "ProductPrice",
                value: 1964900465.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1001,
                column: "ProductPrice",
                value: 1889522237.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1002,
                column: "ProductPrice",
                value: 2078938908.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1003,
                column: "ProductPrice",
                value: 301028484.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1004,
                column: "ProductPrice",
                value: 1736667949.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1005,
                column: "ProductPrice",
                value: 1721375456.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1006,
                column: "ProductPrice",
                value: 12094913.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1007,
                column: "ProductPrice",
                value: 96348987.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1008,
                column: "ProductPrice",
                value: 171062535.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1009,
                column: "ProductPrice",
                value: 569801252.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1010,
                column: "ProductPrice",
                value: 2017591637.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1011,
                column: "ProductPrice",
                value: 740248119.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1012,
                column: "ProductPrice",
                value: 1305987366.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1013,
                column: "ProductPrice",
                value: 1109363994.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1014,
                column: "ProductPrice",
                value: 1905035769.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1015,
                column: "ProductPrice",
                value: 1740248953.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1016,
                column: "ProductPrice",
                value: 532693784.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1017,
                column: "ProductPrice",
                value: 212831768.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1018,
                column: "ProductPrice",
                value: 514739807.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1019,
                column: "ProductPrice",
                value: 1029049916.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1020,
                column: "ProductPrice",
                value: 386291777.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1021,
                column: "ProductPrice",
                value: 700030461.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1022,
                column: "ProductPrice",
                value: 1646226973.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1023,
                column: "ProductPrice",
                value: 1467909140.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1024,
                column: "ProductPrice",
                value: 112050486.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1025,
                column: "ProductPrice",
                value: 1211120421.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1026,
                column: "ProductPrice",
                value: 820136634.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1027,
                column: "ProductPrice",
                value: 605432498.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1028,
                column: "ProductPrice",
                value: 893599325.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1029,
                column: "ProductPrice",
                value: 1840062452.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1030,
                column: "ProductPrice",
                value: 317498254.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1031,
                column: "ProductPrice",
                value: 1162082008.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1032,
                column: "ProductPrice",
                value: 1718243213.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1033,
                column: "ProductPrice",
                value: 28762924.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1034,
                column: "ProductPrice",
                value: 189862961.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1035,
                column: "ProductPrice",
                value: 706842315.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1036,
                column: "ProductPrice",
                value: 2104244671.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1037,
                column: "ProductPrice",
                value: 685849203.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1038,
                column: "ProductPrice",
                value: 243663034.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1039,
                column: "ProductPrice",
                value: 2099352806.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1040,
                column: "ProductPrice",
                value: 1631346005.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1041,
                column: "ProductPrice",
                value: 370990054.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1042,
                column: "ProductPrice",
                value: 1000745235.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1043,
                column: "ProductPrice",
                value: 1411312752.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1044,
                column: "ProductPrice",
                value: 648799881.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1045,
                column: "ProductPrice",
                value: 1860729750.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1046,
                column: "ProductPrice",
                value: 47580891.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1047,
                column: "ProductPrice",
                value: 647800605.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1048,
                column: "ProductPrice",
                value: 1879056978.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1049,
                column: "ProductPrice",
                value: 511259887.0);

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "ID", "CategoryID", "ProductID" },
                values: new object[] { 17, 7, 222 });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategory_CategoryID",
                table: "ProductCategory",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategory_ProductID",
                table: "ProductCategory",
                column: "ProductID");
        }
    }
}

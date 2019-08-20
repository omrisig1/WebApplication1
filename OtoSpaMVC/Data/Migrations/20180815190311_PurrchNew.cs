using Microsoft.EntityFrameworkCore.Migrations;

namespace OtoSpaMVC.Data.Migrations
{
    public partial class PurrchNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Cart_CartID",
                table: "Purchase");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_CartID",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "CartID",
                table: "Purchase");

            migrationBuilder.AddColumn<int>(
                name: "PurchaseID",
                table: "CartItem",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_ID_123456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2dde6e55-368a-4150-99e4-3cdbbc702c86", "AQAAAAEAACcQAAAAEI9/WC57DeaYVQzSPt/hXTKubWGoLCxUTS3DyDyX7T6ZcTHFDrTagnfTlGy61eiZiw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7000",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4b3b2c79-42ac-457e-abd4-07c0b4bfff07", "AQAAAAEAACcQAAAAEKvqD9aQ8qz0/b3GQETbr7WR03+SCc9C0NWu8I7F9IPjUo4/Uav3EvmKFhqW9gStMw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "94c97b9a-3fbe-4343-ab10-5d4215617566", "AQAAAAEAACcQAAAAEJjEjsY5p5FYnsEzXQki56vmGAkNZ3qU2l8ihurlkiZSQp0irkIepi2yXfl4E3Y7Hg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1873d3d9-edff-4142-aef3-ba57e555be36", "AQAAAAEAACcQAAAAED5SvKY/3Tv3EsygSZgMdTtrGwHNAzcJHJDDHNwSVE+ZmlYuCw8YA3J22eAM4HL+CQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ddbdecea-5c48-46c1-aa59-34f0b527b879", "AQAAAAEAACcQAAAAENhI5wpzPEflOD/c1C30/WM/16IBTW9gcH6Yr2BhEwSNNCxR01pL7DJHXj6DbnXxEA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d8197013-98e8-4431-b4f8-00e795a92ff4", "AQAAAAEAACcQAAAAENsZGTLkAm/V3M2EoofDg20wl1K54+74khIIt283AKDkmqVgrtuBA9QBpRj3djtfaQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "93884e9c-ca1d-479b-8cb9-e329a58a6080", "AQAAAAEAACcQAAAAENfot9A8hKSLoVVkQk1yPEXHT7Nw0jTt9x1iHN02xnhmJtoBEscMNbo9AG3bcmsIwA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7006",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1c2bf1b7-91d7-4c7a-9dd4-db0a0b52d287", "AQAAAAEAACcQAAAAEDu39DUSsS1EQCrHqg3FMQjzGJFDMaSmfgGljyVKT2LJEtS4xMYl6JthimN2ar6YHg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fa2a6362-c18d-4be1-a048-5f58ab4e54db", "AQAAAAEAACcQAAAAEOuNeNP8PSq3ruXRHnb5rM07SovsaDgQsqmfY+WvCwN6pY5cfhVCQY3ccPRVMD83AA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d777b7be-a24e-46a4-a114-e49dd15246f9", "AQAAAAEAACcQAAAAEEL1mtNHTbLqlT1xJJDEILim5f5TTkvs6dHlNC+aWH/QHuFIFsR1X5jbguN5lLn/qA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7009",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bd53e3f7-9490-4091-84ee-9d547dc9309c", "AQAAAAEAACcQAAAAEAvp30hjdUEbYiTIJ4tj1M+fPuLFcSg1d2ig/x6k5BrEs4+1GD4dAtAf5CGDXzDWFg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7010",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "77a1d521-023e-413d-8ed5-259429872ee4", "AQAAAAEAACcQAAAAEKeTkWNbJBBdgmmfNGJevOHJWNsNT9idBdaBM/UfoQrNERIlMcE68m4wXdVKUWZzGQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "92bc6af5-d455-4361-b7bc-e6461be464af", "AQAAAAEAACcQAAAAEMD7VLDecGYnYZ0c4z6uoayss5IHRjqGVkTyk9cRm+ko1lmhVog8/+yqpBLFnJwH+w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bae88df8-c1a7-4dff-a63c-6cc86d18feda", "AQAAAAEAACcQAAAAEGI1OG8nwXc4Krru5ZPdglfuqN2AgW7FrCBbaKTU4Glm7HKN6HbJyYpgN7ncO89w3w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7013",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bccd496c-eca0-4bb2-9d52-4b58045678fb", "AQAAAAEAACcQAAAAEDMNg99L9RDbaravAeIZYErSToY00k1YDSmyklc1H/uv/ir86rom2DjK8rjPHtQUkg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7014",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8a8b2b0d-aa00-4320-b20e-4da1d15e00a3", "AQAAAAEAACcQAAAAELMCNNIfv1n4AgNEwhcaBO6PiZihSYyq2jh4bQbxvwHHEhsOw6GupLOXE99r4YPSvw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3f75d000-6396-4901-a3be-a938137b583f", "AQAAAAEAACcQAAAAEEcj8PEdjcxZ+41RwWXrc+KqoSoOd6qbp7PYa8G/zWCj3vUpfVlK7x5LzSitXsryGA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7016",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "74e2f48d-2db9-4ed8-8887-832dd5758317", "AQAAAAEAACcQAAAAEN+AUHqQVncchzj1voebfJ27FDjB3ln4UyVCnsBGpImTDVP+iAO0BLVssuL3usLySQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b4e49ccb-2234-4bbf-b61d-77abfad332b1", "AQAAAAEAACcQAAAAENI2sGhRi1bnT2HKHnOyR+j3/9RoI27QZuH+JlgdezBYp5XyJF00ZTr9cVAKAfnepg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7018",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0551bae5-23c0-4c36-9c19-76dbefecaf20", "AQAAAAEAACcQAAAAEPCpqMvKusJEnj8MMUp7EEv2egFePpLOyoLTHk3ipU4eUSdSWiWZdnWEmn79zCfb7w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7019",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a12dbebf-0482-4aa7-bef6-d6b98ffc7937", "AQAAAAEAACcQAAAAEO1DhOIH0HG90PkZb2auuDIP7w/JlyH6AYOx1Ik0hK4GGUGd8zODk+2NfD6oJgVXeQ==" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1000,
                column: "ProductPrice",
                value: 1681871247.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1001,
                column: "ProductPrice",
                value: 994622763.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1002,
                column: "ProductPrice",
                value: 860387186.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1003,
                column: "ProductPrice",
                value: 1290078741.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1004,
                column: "ProductPrice",
                value: 244539677.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1005,
                column: "ProductPrice",
                value: 1215927990.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1006,
                column: "ProductPrice",
                value: 197726538.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1007,
                column: "ProductPrice",
                value: 840777295.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1008,
                column: "ProductPrice",
                value: 1409000118.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1009,
                column: "ProductPrice",
                value: 1416086402.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1010,
                column: "ProductPrice",
                value: 549203934.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1011,
                column: "ProductPrice",
                value: 710068127.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1012,
                column: "ProductPrice",
                value: 469388816.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1013,
                column: "ProductPrice",
                value: 334762990.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1014,
                column: "ProductPrice",
                value: 1409785365.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1015,
                column: "ProductPrice",
                value: 1103088458.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1016,
                column: "ProductPrice",
                value: 1963077632.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1017,
                column: "ProductPrice",
                value: 68137939.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1018,
                column: "ProductPrice",
                value: 1752946831.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1019,
                column: "ProductPrice",
                value: 1818254798.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1020,
                column: "ProductPrice",
                value: 487728225.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1021,
                column: "ProductPrice",
                value: 1521487593.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1022,
                column: "ProductPrice",
                value: 1905445542.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1023,
                column: "ProductPrice",
                value: 652588935.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1024,
                column: "ProductPrice",
                value: 1269683261.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1025,
                column: "ProductPrice",
                value: 1506133160.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1026,
                column: "ProductPrice",
                value: 846583646.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1027,
                column: "ProductPrice",
                value: 475129518.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1028,
                column: "ProductPrice",
                value: 1200696017.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1029,
                column: "ProductPrice",
                value: 1478372896.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1030,
                column: "ProductPrice",
                value: 286520762.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1031,
                column: "ProductPrice",
                value: 787799709.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1032,
                column: "ProductPrice",
                value: 2032231694.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1033,
                column: "ProductPrice",
                value: 1911942399.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1034,
                column: "ProductPrice",
                value: 658685765.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1035,
                column: "ProductPrice",
                value: 1134259668.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1036,
                column: "ProductPrice",
                value: 343911892.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1037,
                column: "ProductPrice",
                value: 1607543901.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1038,
                column: "ProductPrice",
                value: 494934972.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1039,
                column: "ProductPrice",
                value: 837238147.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1040,
                column: "ProductPrice",
                value: 340399123.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1041,
                column: "ProductPrice",
                value: 1358422449.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1042,
                column: "ProductPrice",
                value: 1350125602.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1043,
                column: "ProductPrice",
                value: 1659060070.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1044,
                column: "ProductPrice",
                value: 1138198794.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1045,
                column: "ProductPrice",
                value: 1935883443.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1046,
                column: "ProductPrice",
                value: 1433842274.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1047,
                column: "ProductPrice",
                value: 1723128004.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1048,
                column: "ProductPrice",
                value: 1963886821.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1049,
                column: "ProductPrice",
                value: 1574844151.0);

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_PurchaseID",
                table: "CartItem",
                column: "PurchaseID");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Purchase_PurchaseID",
                table: "CartItem",
                column: "PurchaseID",
                principalTable: "Purchase",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_Purchase_PurchaseID",
                table: "CartItem");

            migrationBuilder.DropIndex(
                name: "IX_CartItem_PurchaseID",
                table: "CartItem");

            migrationBuilder.DropColumn(
                name: "PurchaseID",
                table: "CartItem");

            migrationBuilder.AddColumn<int>(
                name: "CartID",
                table: "Purchase",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_ID_123456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "223e2976-11ce-4f29-8c64-8db9ca765d26", "AQAAAAEAACcQAAAAEC7Usgt8bOypNyP/Uz669CaHKJDSiqGotea0gF+LeNDVnd5Pn3Lm4e6d7TXAgMK5LQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7000",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "246f0d55-70ce-4c63-ba96-9af937f5eeb7", "AQAAAAEAACcQAAAAEOvANMUSj6qBUPNq0k3j+ZtBxS6qrOPOJJy+cXVnzdwgeVEXdcg2gAJesU6LMt7gKQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "51cd722b-9145-4802-8942-4f13095ce4d6", "AQAAAAEAACcQAAAAEKzfxePZHlX+xZIMBPMDsXmhLIpLRqTdBs8GO8bU5vsZjN7TBC9VLmlrSRRp9PX+jg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "880c0899-f4b3-46f0-9710-05959780638d", "AQAAAAEAACcQAAAAEGJ4uNrHyta1USuFlGZEYpyWQJtbCbCzZ2v6NWF72H1iqBgXd7C1GBBfJ2bFQXgDlQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6d713fbd-6b45-4d6f-9c32-c9df9d5326e3", "AQAAAAEAACcQAAAAEPLWIb76YBDUk9EN03OL/4VLXwQftdq/pbatPyRhEidXSocFtCdQ53OZIQRicNgbdQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "747c73b7-8980-4a47-a4cb-680c879cab91", "AQAAAAEAACcQAAAAECouQkHORxYBR/FehUSZFVFOLsNYGtVyx/DttzsFK1nP4OeP5h1yjuubGHjHT7rejA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4efe1093-368b-4890-975e-b306e087d648", "AQAAAAEAACcQAAAAEMwoEZP26mIkXPsdhwBgYvqgR04lB4i3x/EP3Yjf5+6TM5NQZVxSISVdY9fFSwyL9Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7006",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "658f0d98-e847-44ec-b46b-927f75ec86af", "AQAAAAEAACcQAAAAEElICzmQCTZftcs8ZuO4JQoL4ntaCkEeqkfCxyOwSrfpoY4KQPV02s1vTRClZiwEig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1594bc74-84d3-4caa-b8cd-e2d6db742ec3", "AQAAAAEAACcQAAAAEKsVjPmK75oJycpBpgSce/j4Rbc7yBgh9Gl2hPSlSF6OSBKKlTYvtviQCmCDAMphPQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "240b0821-6a3b-43b5-9a57-6a03e85cde6e", "AQAAAAEAACcQAAAAEAoVHX5/dCb7oATOWVBpbK9nB1nUtuysu6feeaEPJl/4sCvnecMGQ7gilaWgYIXvPg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7009",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "95c45c8e-8d1b-44eb-aaa8-4e49179e4e0b", "AQAAAAEAACcQAAAAEOcdxcG16mevfizQgQtCqUXa31f3ScHfEK78dMw0lNWe4zOSYW/jyZV8tJu3ReIQnA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7010",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ac2044ab-82c8-4fb5-a883-d70ab4deffea", "AQAAAAEAACcQAAAAEBMWforxYF+GkQ/TdhuZoHifPCcr2zxwLM8Rhi2rAfjgQ2I2aEg72fX4yJ3L/B9vHA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "be2b3a92-52e7-430e-9538-d6309de2ff7d", "AQAAAAEAACcQAAAAECpoTAclVSMPYvlTQWI7wHzrNytb+NtMlbn1/dZ9OkR3H+GR4innGTpo1kOmbb+RtA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c7c224bc-fc1d-4ac7-88fe-cb18c932436b", "AQAAAAEAACcQAAAAEPGOojMpwormHgwaLWK+WjnSLZ2SYmXymL8Z6ar0JEpACN4agSNjLRnw8yWeRzaCVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7013",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9bd82016-1229-4fa7-bed6-eebd29a1ea79", "AQAAAAEAACcQAAAAEOiIFUhrUpXTkR6DY8Fo0Ow/zUCsDs/oaj97+jogLTk95CFxTZZHThQCDFKgh1zB9w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7014",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "35cb3260-13a5-4e02-a150-b1c9c220e543", "AQAAAAEAACcQAAAAEHuPtw+KvO+nGCQzdpXB995r8o+0Qiht0fIx9UpcLsHlVOW2qwjGLG+lZ/AcqWUYaw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1b465475-7534-4030-988d-fe60c95e8ea0", "AQAAAAEAACcQAAAAEJ2WkhCBY/uMvaC6rv2Ude+kkuNxUJZ2Es8HtawUiFTxLTM4cr5NysSxmASp0rfRVg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7016",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c94e0f2d-8980-4747-807b-2d67bf2a5761", "AQAAAAEAACcQAAAAENaJRR+h3H2YhoUz/dhpEvArOiZtBl+BVef/ejPNT2qQxmwMHuDu9A0P3S6RzHIaOw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6cc067f9-cf7c-4311-afa4-34055f0b4735", "AQAAAAEAACcQAAAAEKU9BzOts0qOf+GO0oEkX4brICUyzE5ebkLH2ak71zVO8IddtP5jKGQugKyDCcT5Gw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7018",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "33ce1abb-8b81-4ab5-92bd-a8bb7aeb94f6", "AQAAAAEAACcQAAAAECW2wlYYC1Ow02cOGjxm6/wjlLxI2a3rPy85CwaBd5H6qdg0hLQc8mGAdRyn2Ru1mA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7019",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e6d984cb-c911-485a-ae08-4fddccd3df00", "AQAAAAEAACcQAAAAEPPFG8YYU7yX3IRz2nIyXBw72jhQj7+KcgOT/Lr+ksfEkB7zOwup/bqj87XMvMuAzg==" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1000,
                column: "ProductPrice",
                value: 1081624743.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1001,
                column: "ProductPrice",
                value: 2032332745.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1002,
                column: "ProductPrice",
                value: 317369019.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1003,
                column: "ProductPrice",
                value: 856306849.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1004,
                column: "ProductPrice",
                value: 706859692.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1005,
                column: "ProductPrice",
                value: 1049885294.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1006,
                column: "ProductPrice",
                value: 258755297.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1007,
                column: "ProductPrice",
                value: 764177265.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1008,
                column: "ProductPrice",
                value: 290283375.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1009,
                column: "ProductPrice",
                value: 2041461062.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1010,
                column: "ProductPrice",
                value: 1607894116.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1011,
                column: "ProductPrice",
                value: 92664442.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1012,
                column: "ProductPrice",
                value: 821503192.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1013,
                column: "ProductPrice",
                value: 1448963099.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1014,
                column: "ProductPrice",
                value: 480715005.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1015,
                column: "ProductPrice",
                value: 1500693401.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1016,
                column: "ProductPrice",
                value: 507327281.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1017,
                column: "ProductPrice",
                value: 1213174665.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1018,
                column: "ProductPrice",
                value: 1408591821.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1019,
                column: "ProductPrice",
                value: 919124892.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1020,
                column: "ProductPrice",
                value: 1844974644.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1021,
                column: "ProductPrice",
                value: 441617661.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1022,
                column: "ProductPrice",
                value: 1884804385.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1023,
                column: "ProductPrice",
                value: 561929545.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1024,
                column: "ProductPrice",
                value: 1950778916.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1025,
                column: "ProductPrice",
                value: 1109330078.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1026,
                column: "ProductPrice",
                value: 329114104.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1027,
                column: "ProductPrice",
                value: 1537738978.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1028,
                column: "ProductPrice",
                value: 204084271.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1029,
                column: "ProductPrice",
                value: 761120724.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1030,
                column: "ProductPrice",
                value: 803604893.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1031,
                column: "ProductPrice",
                value: 22823925.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1032,
                column: "ProductPrice",
                value: 1983474675.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1033,
                column: "ProductPrice",
                value: 581649007.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1034,
                column: "ProductPrice",
                value: 965391719.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1035,
                column: "ProductPrice",
                value: 1207735070.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1036,
                column: "ProductPrice",
                value: 22249297.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1037,
                column: "ProductPrice",
                value: 1631634623.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1038,
                column: "ProductPrice",
                value: 260538987.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1039,
                column: "ProductPrice",
                value: 8937375.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1040,
                column: "ProductPrice",
                value: 1332525540.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1041,
                column: "ProductPrice",
                value: 632507896.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1042,
                column: "ProductPrice",
                value: 943146959.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1043,
                column: "ProductPrice",
                value: 426549017.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1044,
                column: "ProductPrice",
                value: 456785741.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1045,
                column: "ProductPrice",
                value: 928671474.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1046,
                column: "ProductPrice",
                value: 56677110.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1047,
                column: "ProductPrice",
                value: 287605787.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1048,
                column: "ProductPrice",
                value: 247971079.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1049,
                column: "ProductPrice",
                value: 1947830982.0);

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "ID",
                keyValue: 15,
                column: "CartID",
                value: 13);

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_CartID",
                table: "Purchase",
                column: "CartID");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Cart_CartID",
                table: "Purchase",
                column: "CartID",
                principalTable: "Cart",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

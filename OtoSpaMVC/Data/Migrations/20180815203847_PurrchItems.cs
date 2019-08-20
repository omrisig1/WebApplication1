using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OtoSpaMVC.Data.Migrations
{
    public partial class PurrchItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "PurchaseItem",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductID = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    PurchaseID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseItem", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PurchaseItem_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseItem_Purchase_PurchaseID",
                        column: x => x.PurchaseID,
                        principalTable: "Purchase",
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

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseItem_ProductID",
                table: "PurchaseItem",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseItem_PurchaseID",
                table: "PurchaseItem",
                column: "PurchaseID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PurchaseItem");

            migrationBuilder.AddColumn<int>(
                name: "PurchaseID",
                table: "CartItem",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_ID_123456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2ee20510-253e-4d19-910b-a9ee3be381a2", "AQAAAAEAACcQAAAAEAMe4pD+2ol2euFK6b+XqOe6nTyPZMm5adZUfM0RReXKBMhA9ywRqoxMlPy2dZlWHQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7000",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "056d8724-24e7-4049-85c2-17b0e9476680", "AQAAAAEAACcQAAAAEFoB/r4Rcp66suzpFIM0nwOlFr5CzrazYV+lET3e1jeOymykPcmysNtGtuLwOgHDgw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "581acdee-7a8c-4e6e-bae5-f9b44a9f7d44", "AQAAAAEAACcQAAAAEHySoSzU28jbFQvFu9BM8V+LSh6z51VkqOgj0PtleEDM0HtO6K7F7Y5TCiObmtASAw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "20660f10-f0b0-45d1-91a2-701884e65f83", "AQAAAAEAACcQAAAAEJ647eS1YaAlrog8di3U6qLJkCSq8eFsu3Tr3rIbNQGcNyfy9zI47P11BcXP1QJVuQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d9d6440d-2048-4959-b8fc-2123bacefb9f", "AQAAAAEAACcQAAAAECcu/bV8H+zj3eSyjsxMVlpJwwv1fIx3SLP8okGr8FBRq+jdi/+KI9FWkSJPnMEyZw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eee33838-6531-4065-83ef-25f80999b817", "AQAAAAEAACcQAAAAEOkvhRiYN7Em2gsrQX5F4AxuBbMD95ukp9CQqepgGuyqk3WJhZxMOH36qTJmoyHlIg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6e297e5c-8da2-4e9e-93a5-2bf082be1a78", "AQAAAAEAACcQAAAAEAke87Rx0GC2OIPBp6Q2ikh6LjOa0pnFIhQAdxavexhCVilUBxFJNUp8qkeLHDqGLw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7006",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8033cf2a-9c24-4a28-a810-57f1b771d0b8", "AQAAAAEAACcQAAAAEM56yb1C4jYKlhd4RPinWAlhZ46u0AepO276Sq4Yto2nxnofx9rRa8VeNOaXhCRwjA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "43601907-055c-4e0a-bb9b-d24991f1eb5c", "AQAAAAEAACcQAAAAEDIFIR8pDaYRJrpvdnYLKCMrEYhUKrGknhK0JZyDOV5mEFjXdZLFPeCgnPzaur/6nw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c9fa661f-eae2-4c5d-8b33-0f008de87860", "AQAAAAEAACcQAAAAEM0Ek+rUlTBfNXQTuYuUUgOxsF1xk+5K5Tm8ihIwRhir3HP16nZyQH/ZEjacLDmQ3g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7009",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c162a46b-f292-4a37-9a20-e78de70fd5fb", "AQAAAAEAACcQAAAAENwRs4p9m6CftreVvb+Fxg/F5ntqBaaWPQbAs+aO4Prz+Pssm+Kw+8/o2Jb48Ni1EA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7010",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9491ef51-7532-4f57-aad0-eb4c3da330c7", "AQAAAAEAACcQAAAAEMcDMNa1EC8H8hwziVOjgQ7h7HZeqrVwSpzdSuZmk8BmivPWTO8/8ZKiT0Ac72UpjA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "385463fd-96e8-456a-bf4b-fa6565e9cec3", "AQAAAAEAACcQAAAAEKPqon3M8b3+d77qyQJWwvduO5U+xbTflH/WnpRQAA6xSPNb5UFPLdt8Qr+6Wnph6A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e2d74fa0-0c19-4d24-9a99-211e87c3085f", "AQAAAAEAACcQAAAAEFPiAes02m/xGx6gXrZZgDU6YEvfXO29cwZhOpm3iywE8vjE6IpQNwyCNo7NNvhCJw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7013",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e1200c18-022d-407d-b2a8-e34712ac3160", "AQAAAAEAACcQAAAAEIvOYPxLeE2Il4G/k01b+rX7Bms2IJNJsD0LF9g9jkN0clOy4dT/qXP8mMY2FQHTQg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7014",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b43ef0c1-3c38-4777-895e-5f8fde87d82e", "AQAAAAEAACcQAAAAELMf4XibBxQib5q8uDIzR/AQcXAEXC1uPBCpKCgz16z9nX8wHhiqfbDYoTTF1t9tXA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5d5570db-824c-447f-8e4f-aefad89c6250", "AQAAAAEAACcQAAAAELVGORqpjdk+LGae9/U5SxESg9H0Bk9rXn7XuMYGCujInjFTGLLIFKBnGHUhdCTjTQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7016",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8f8b1d05-dfa7-4a15-a6f7-137aac0cd28b", "AQAAAAEAACcQAAAAEEksdknd1ZPzMz+vCI3YXnYPrj7Aa8lSBpcva3IQybeOgIgInF2TS5e/UWaIbI5DgQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "baccab73-db6b-47a5-a4c7-bc075b553e0b", "AQAAAAEAACcQAAAAEOmGrA5PYmEnbTZkhozRDwhZ+haFXXYqQENub9jk4ChY81MGvCDahNI+eyfpqrfgbg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7018",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "73b0a5d4-ff2e-4b16-b7a8-ffc452a29f20", "AQAAAAEAACcQAAAAEJa2q0rsGClsBj6+uuAuSIMch9x4MlvvSTSStRhvUndDT1DIsbGKTRCgC5JdE+gORQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7019",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "58b93d98-d6ee-4232-85f5-2fbcde8df6a6", "AQAAAAEAACcQAAAAEABkRlgfHxWNYEVZrBmeOq5Nv/nHLrFkglAnciAe89DBimcKw7ecCJumlFlNg7PpLQ==" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1000,
                column: "ProductPrice",
                value: 1215414024.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1001,
                column: "ProductPrice",
                value: 111749911.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1002,
                column: "ProductPrice",
                value: 1624495037.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1003,
                column: "ProductPrice",
                value: 67919352.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1004,
                column: "ProductPrice",
                value: 1010628706.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1005,
                column: "ProductPrice",
                value: 1905143936.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1006,
                column: "ProductPrice",
                value: 870984371.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1007,
                column: "ProductPrice",
                value: 1148232627.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1008,
                column: "ProductPrice",
                value: 768837909.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1009,
                column: "ProductPrice",
                value: 4814566.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1010,
                column: "ProductPrice",
                value: 789916577.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1011,
                column: "ProductPrice",
                value: 1567519889.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1012,
                column: "ProductPrice",
                value: 806660093.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1013,
                column: "ProductPrice",
                value: 1175045353.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1014,
                column: "ProductPrice",
                value: 1189570702.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1015,
                column: "ProductPrice",
                value: 676812698.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1016,
                column: "ProductPrice",
                value: 1483680365.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1017,
                column: "ProductPrice",
                value: 1304213498.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1018,
                column: "ProductPrice",
                value: 2017789626.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1019,
                column: "ProductPrice",
                value: 309705985.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1020,
                column: "ProductPrice",
                value: 1754547735.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1021,
                column: "ProductPrice",
                value: 1380902479.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1022,
                column: "ProductPrice",
                value: 1530747396.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1023,
                column: "ProductPrice",
                value: 1480724440.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1024,
                column: "ProductPrice",
                value: 1761962685.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1025,
                column: "ProductPrice",
                value: 1630811322.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1026,
                column: "ProductPrice",
                value: 135486375.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1027,
                column: "ProductPrice",
                value: 619260798.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1028,
                column: "ProductPrice",
                value: 844236686.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1029,
                column: "ProductPrice",
                value: 1964203434.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1030,
                column: "ProductPrice",
                value: 823281771.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1031,
                column: "ProductPrice",
                value: 524876997.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1032,
                column: "ProductPrice",
                value: 1059580206.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1033,
                column: "ProductPrice",
                value: 771812765.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1034,
                column: "ProductPrice",
                value: 1404671909.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1035,
                column: "ProductPrice",
                value: 1671873123.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1036,
                column: "ProductPrice",
                value: 742769493.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1037,
                column: "ProductPrice",
                value: 1909651340.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1038,
                column: "ProductPrice",
                value: 1880956664.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1039,
                column: "ProductPrice",
                value: 743213030.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1040,
                column: "ProductPrice",
                value: 1595826472.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1041,
                column: "ProductPrice",
                value: 1980623962.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1042,
                column: "ProductPrice",
                value: 472849609.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1043,
                column: "ProductPrice",
                value: 1400947379.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1044,
                column: "ProductPrice",
                value: 1028756229.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1045,
                column: "ProductPrice",
                value: 317598246.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1046,
                column: "ProductPrice",
                value: 726891516.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1047,
                column: "ProductPrice",
                value: 1106423073.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1048,
                column: "ProductPrice",
                value: 49988840.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1049,
                column: "ProductPrice",
                value: 264745885.0);

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
    }
}

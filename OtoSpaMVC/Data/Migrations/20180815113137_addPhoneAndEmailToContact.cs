using Microsoft.EntityFrameworkCore.Migrations;

namespace OtoSpaMVC.Data.Migrations
{
    public partial class addPhoneAndEmailToContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "ContactUs",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "ContactUs",
                maxLength: 15,
                nullable: true);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "ContactUs");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_ID_123456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "06d81eaf-24bf-4ada-8340-78a555972556", "AQAAAAEAACcQAAAAEDBRyN0AESlmRnTNaGW4RNMQuFZCGqWrSX7wlADZ5voRT139xx3Bv9I3lmf80TV6fg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7000",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8db8d6eb-40d4-440c-a8f3-5c9008a90b42", "AQAAAAEAACcQAAAAENhknWZNVxf1te/tKNQUJp7Z7pA1bLdW0EFVh7kSJRZCQxqiuAXeHJamHWbTu1oQ3Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3bc23c14-9dee-465e-9b9a-0653dbdd0d30", "AQAAAAEAACcQAAAAEFByj+gy0SS6hPWjucOACaBt4fjLVoM+10q9EJuej9iA84aLE87Id4Ad4aEy2RMjsg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "61548210-ebdc-499d-99eb-605e8d301858", "AQAAAAEAACcQAAAAEKivN+Zu/dOSjqupZ7QnxcimsfF3VOVIwRBTAsb4lVrvtfyTzbJWNnj9u/YkmHiWMA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a05f6121-be36-4856-967d-56a393d005b7", "AQAAAAEAACcQAAAAECPIeDcYPosBQn88X7U9iX8vA1cD0gD5V2U4mMTvudYbPXY+xB9N6onZTfcSBnI8bA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8fa3ea57-8248-41fc-bc80-e4806ff839fa", "AQAAAAEAACcQAAAAEMnX6oX9TvrzNldD/S+FN1yQF5G9zqkvbvg+PHXc9MwMX7tSettnIwxGd7/rfthyVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eed1f34b-4b59-473f-a9fd-de852e907fac", "AQAAAAEAACcQAAAAEPzr5exHVZuRK6rTAGeNzIrOOLoc38Y/H7izinJayivc0X/aNy6eutu5bCwue7tp1g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7006",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ae591c68-6b69-4bba-bc2b-d6555cf552b6", "AQAAAAEAACcQAAAAEHxy74DpsJyO9oMqCAhh/j12QZ0uegP8bzHNtQJgbLmmqm/ty/efnDe9weQXlPnzRA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "08e24c67-49ee-4094-9998-4b63c215859b", "AQAAAAEAACcQAAAAEFxCAASaRjLTdsX7NsCGpghxMDmkjydnMOAJfJhVXsfUc0xI276nksS6cFT27+FRNg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8e01e355-2c43-4fb6-a420-1ea70c38fc5f", "AQAAAAEAACcQAAAAELsg4nMHNDp8/lgT0Ejgck2NAdKjxjtHMKeY3LqXlxQvFR/wWZJRUKqU9byr9Hc0Qw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7009",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "959b17d3-8b6c-41c5-92f2-a3c8b692ba45", "AQAAAAEAACcQAAAAEEXZAYkHcIIU5S5goBbLoCzX426vWRGKg8BLqQkPRrxcSba1KC5LjSYoA2Exflz2sw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7010",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bcf17b1d-8c3e-4d9c-b519-48fcd75925bf", "AQAAAAEAACcQAAAAEDFGOOAOeaMmHdJSNsdw8UqZxM49nXq5E84eCTanE6ssphKNFEk5mZbdOgOIN9fLNw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8d1030cd-fbd9-4be1-8ed2-03af72ada6dd", "AQAAAAEAACcQAAAAEBWm0aO4GQgo8mxemt1ftKzt2PsT6RHdUj4EVR+u4zoI41W2VNVADOSdqADvz7661Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "280ea693-5fca-4dcc-b95c-80ce4e708fe3", "AQAAAAEAACcQAAAAEFrfutnM8JxsYSatmHVloPcOK0ZubPQ1p1Q3Y4745Du3DsXDFxWWB1fNA6M3aoEHlw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7013",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9c4ba4ac-250c-4a01-a2c7-77c872c498b2", "AQAAAAEAACcQAAAAELlix22apKAhknjiPw2imsH4FBr3DAnpCys24XCLeIoNXm1+LPIRpyJcMXsFS39ulg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7014",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c5e9c0f8-da70-455e-ac70-be85a2f3cec9", "AQAAAAEAACcQAAAAEOD0BuT3vRf6GWUae9XTFDAwHgXlYzBgXci2wJfxyGXdpSjO3m6k4t2jSVCdgzDmcg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "836aac32-eb51-4483-8c32-ed6afaa4600a", "AQAAAAEAACcQAAAAEKrFjHfeXmOi7d/ddf3odddG3nWy206YkN/26m2geZ/8GSSa2PZa4JndFXuqULkzCQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7016",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1428290e-b1af-4111-9b78-197991703573", "AQAAAAEAACcQAAAAEMafueysl4VXOjLucCAz/3AikI8+eupPSZR9w+Pp8iQrVE7U/CDQYYrOF+nNu+Y2lA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "84ebafbd-c0dd-4b7f-9182-3acd2a4032e1", "AQAAAAEAACcQAAAAEPGMc8s6/d3yAdU0GFLKNQ0pW1ymDPkenWluq49UWJk8QOTPoIb9zJIDvvrP78DzLQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7018",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aca0714e-30dc-4f14-b6de-d04eb14d293a", "AQAAAAEAACcQAAAAEKXUaHkS6AHmeutlKZnRsR0lgeo7H0sq4SDe7mzrbzlsoG2RR9uSMeV2qu++WMuaHw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rt_7019",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "57f073ee-020f-4a0b-9b9d-96bd04dea904", "AQAAAAEAACcQAAAAEGlcJV76GhoFyO0ww3wPk6ocKp3SAn6pGnddUlKBGwunIfOLIShlg7oIOww68rEe7A==" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1000,
                column: "ProductPrice",
                value: 1362331870.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1001,
                column: "ProductPrice",
                value: 1346053930.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1002,
                column: "ProductPrice",
                value: 1042495228.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1003,
                column: "ProductPrice",
                value: 501392236.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1004,
                column: "ProductPrice",
                value: 397248229.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1005,
                column: "ProductPrice",
                value: 1886948185.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1006,
                column: "ProductPrice",
                value: 50323255.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1007,
                column: "ProductPrice",
                value: 1722951193.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1008,
                column: "ProductPrice",
                value: 1318729345.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1009,
                column: "ProductPrice",
                value: 1098509751.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1010,
                column: "ProductPrice",
                value: 38171895.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1011,
                column: "ProductPrice",
                value: 954348773.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1012,
                column: "ProductPrice",
                value: 1521493038.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1013,
                column: "ProductPrice",
                value: 1372618347.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1014,
                column: "ProductPrice",
                value: 1868298066.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1015,
                column: "ProductPrice",
                value: 2057298028.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1016,
                column: "ProductPrice",
                value: 367780924.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1017,
                column: "ProductPrice",
                value: 348554343.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1018,
                column: "ProductPrice",
                value: 1423873251.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1019,
                column: "ProductPrice",
                value: 1241233352.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1020,
                column: "ProductPrice",
                value: 260659227.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1021,
                column: "ProductPrice",
                value: 427812521.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1022,
                column: "ProductPrice",
                value: 514136237.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1023,
                column: "ProductPrice",
                value: 20817004.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1024,
                column: "ProductPrice",
                value: 160106445.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1025,
                column: "ProductPrice",
                value: 389438319.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1026,
                column: "ProductPrice",
                value: 1739010656.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1027,
                column: "ProductPrice",
                value: 1186191962.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1028,
                column: "ProductPrice",
                value: 413733967.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1029,
                column: "ProductPrice",
                value: 270755508.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1030,
                column: "ProductPrice",
                value: 861730057.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1031,
                column: "ProductPrice",
                value: 331525343.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1032,
                column: "ProductPrice",
                value: 1373775320.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1033,
                column: "ProductPrice",
                value: 911098389.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1034,
                column: "ProductPrice",
                value: 605273405.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1035,
                column: "ProductPrice",
                value: 1757178408.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1036,
                column: "ProductPrice",
                value: 1271748072.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1037,
                column: "ProductPrice",
                value: 1796587102.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1038,
                column: "ProductPrice",
                value: 2052891399.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1039,
                column: "ProductPrice",
                value: 701738718.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1040,
                column: "ProductPrice",
                value: 1997222964.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1041,
                column: "ProductPrice",
                value: 682621669.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1042,
                column: "ProductPrice",
                value: 540964473.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1043,
                column: "ProductPrice",
                value: 1149420092.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1044,
                column: "ProductPrice",
                value: 1620435138.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1045,
                column: "ProductPrice",
                value: 1800513138.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1046,
                column: "ProductPrice",
                value: 1220575832.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1047,
                column: "ProductPrice",
                value: 1406991350.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1048,
                column: "ProductPrice",
                value: 878481542.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1049,
                column: "ProductPrice",
                value: 1985301552.0);
        }
    }
}

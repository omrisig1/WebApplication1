using Microsoft.EntityFrameworkCore.Migrations;

namespace OtoSpaMVC.Data.Migrations
{
    public partial class ManyUsers2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_ID_123456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bbd93990-6263-455a-9ca2-bdaa44a2ea4f", "AQAAAAEAACcQAAAAEOjiNj31gOaUi9RYWHcOhu7vnM4QtCoFsyLACUdcaro701qmgSE+mM/XKBvyvip9jg==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "rt_7072", 0, "691c3faf-a096-48fd-bd1c-69e28c718aab", "rt_7072@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEIZzkuT3Ec0ya+Ki2r5l+7ICYSp4sh4+Zpy6HciDDXqNUKHtJxqClbD3dDrTjlUSDQ==", null, false, null, false, "RaringsTest_rt_7072" },
                    { "rt_7071", 0, "a5f5fdad-017c-4e3f-bd9f-2538f3ea0776", "rt_7071@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEDrudq+QNAiAf9tIxBXBz3P7upil9DCii9Uzfe6YrQNfvTpnoq4FrgE7mUefHL+g3w==", null, false, null, false, "RaringsTest_rt_7071" },
                    { "rt_7070", 0, "187a0f6e-8371-4815-a703-8038b5e1630e", "rt_7070@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEGVvKp1MYqmj541zy17W7CZ9jFSobcvngAlck/2H4lzVjvRCGI40XzTcx80gUb+DDg==", null, false, null, false, "RaringsTest_rt_7070" },
                    { "rt_7069", 0, "d1c2deac-14a2-42a4-9a37-ca27de18b1c2", "rt_7069@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEBBYnkFrqptLzGLTWbTOKjqA0beTKnl/+iFPXzzJ5pLlOsP/gSOpy9khoJsyMooIcA==", null, false, null, false, "RaringsTest_rt_7069" },
                    { "rt_7068", 0, "66798b03-d2a3-46f1-801c-a30395fa09e6", "rt_7068@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEEGRkkZRyRzs1Pv/REUiEgc1KyKmwHRhO6gdHVmH0sBRz2c0azCEJVQ8ioqgKB+pGA==", null, false, null, false, "RaringsTest_rt_7068" },
                    { "rt_7067", 0, "330eab35-1857-4036-ab51-0c8503e594a1", "rt_7067@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEIDTNrHB2qOo7YvCgHDz4DEEq9KtNhmvSl5dzFd0hwnMGQo6+mLAqyQucmd3978ysw==", null, false, null, false, "RaringsTest_rt_7067" },
                    { "rt_7066", 0, "73d6f9bc-6733-42a1-81ea-13333f34f959", "rt_7066@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEFoGJ+kjtMtn1U9MTaVO0hlXbOwxGr4nODd536j/st1UigmSp8iMklemhLS1liDHeA==", null, false, null, false, "RaringsTest_rt_7066" },
                    { "rt_7065", 0, "263a02bd-d9c2-4cc4-99f5-3aa730385854", "rt_7065@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEF5frVXg2ZoxgYalTlLjPcSlB5ARfPL4ttlu9CGmcgIj69uZZ9tQqP33RsLpXGEWWw==", null, false, null, false, "RaringsTest_rt_7065" },
                    { "rt_7064", 0, "0eb68c4c-5ef5-4645-9df1-51a8f45395c7", "rt_7064@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAECAOpDhQKjNp0wYKiz/PBzIJRdwnVo3UOevIW53mno9iyfp6W8c/7FCS/iyfUeoBCg==", null, false, null, false, "RaringsTest_rt_7064" },
                    { "rt_7063", 0, "07ff3f76-67fa-4099-9428-724948224bbc", "rt_7063@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEHJ5yBtj/CnA3QJKmLslJWc4JemLvN0dV10pGdcTEgHR38H656TYlqQ8IXq3ZbVG3A==", null, false, null, false, "RaringsTest_rt_7063" },
                    { "rt_7062", 0, "c929eb05-2536-4837-900e-261caf532e03", "rt_7062@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEGXGlEad5Gn+8W91F5V6r3KCqgHsM2LFG4r/9xT+3V5XPf0t5dw2n9ZYT7TXtML18A==", null, false, null, false, "RaringsTest_rt_7062" },
                    { "rt_7061", 0, "6c605e66-78c3-49b8-9693-45f387309f5d", "rt_7061@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEPrtSIu7eGRVDq8SOaoaqeNom5YkQACVJySYocNx5A/IGvHVYtG6WcYNscV8t9Ngvg==", null, false, null, false, "RaringsTest_rt_7061" },
                    { "rt_7060", 0, "2a3fe2c1-ad2d-44db-9425-aecf05667afa", "rt_7060@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEOBEQNtlxfnvDN9sx5ONzq/53n8WBXBSnYQUhj6L3189ICXTa4YpqKIaNtDfqT3yRA==", null, false, null, false, "RaringsTest_rt_7060" },
                    { "rt_7059", 0, "00d2b907-7e4c-4b3e-a994-817f2395bae1", "rt_7059@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEGZPW6PZaNri736U/DhbtNBKL8A6fcAsiEuqFAuwIHLg9z+w1tVGygDYY79l5MMEFg==", null, false, null, false, "RaringsTest_rt_7059" },
                    { "rt_7058", 0, "53e505b1-db5e-4cf2-922a-bf882fcb6bf1", "rt_7058@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEK9XP1N76uhdtvmBqMWVGJD/tPlUPI6bf40bUfA589v/Ap5cM7SLGSHH7LOBJo7aAw==", null, false, null, false, "RaringsTest_rt_7058" },
                    { "rt_7057", 0, "968ec63c-c35e-426b-8665-63961c73e993", "rt_7057@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEHj0N/vouQrTEtvK9xE3uwA+YGZqmQiHUQgdz13iaqAQWH85/0TBl6cVeDxaqWj5Xw==", null, false, null, false, "RaringsTest_rt_7057" },
                    { "rt_7056", 0, "655f1f7e-23b3-4b91-9ed1-96ab096e38b9", "rt_7056@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAECl6hLNGvGccvei9oe2E8Gza3ZD95c4vcvFmrpQCvKiIKa1B63JpzW6ycgpHbnpsgg==", null, false, null, false, "RaringsTest_rt_7056" },
                    { "rt_7055", 0, "d3fe1992-a3fb-4ce9-abcf-28d65ebf2a88", "rt_7055@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEHfPED6pOOjvZXRdC8sFSrCpnjIwfvFvxIC2LYRN2MDUSHV57mCnm+NFcMdprJVJ7g==", null, false, null, false, "RaringsTest_rt_7055" },
                    { "rt_7054", 0, "3b73c791-f9ef-4bf0-a924-22f47b9143a5", "rt_7054@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEJx2U71JqmECHGNP05Xjy3sBuSKCoSZqyxfRDP3+LfYkgBtSwBHsEULfPz4vynHJjQ==", null, false, null, false, "RaringsTest_rt_7054" },
                    { "rt_7053", 0, "07735bd0-cd58-4782-ac8c-8d4475f69dfb", "rt_7053@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEL75MT7UByiV9lzK1bhHhCR4Ef4Y6Lw3zb2F8pq7gcj3ATovG5ey2t1NCjLFQD14mQ==", null, false, null, false, "RaringsTest_rt_7053" },
                    { "rt_7052", 0, "0dfd4d6d-21b0-452f-a634-96849649993f", "rt_7052@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEFbxuzULvRNcvTkfW0WJgKBRNnocAIriN5YIE/EJ9e5zTEqEvyIrJWvWtu7IgpBWlQ==", null, false, null, false, "RaringsTest_rt_7052" },
                    { "rt_7074", 0, "51bbf59f-3fdb-4836-afc5-f437438d25ab", "rt_7074@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEKqXy4c3CDQUex/ayQIQ6nt2WhVVmBuZaMFI2KhBP3FNqPyHUJtaFi653yVAP3IoUQ==", null, false, null, false, "RaringsTest_rt_7074" },
                    { "rt_7075", 0, "c1998466-a33d-4ea7-b9cb-a774f1c7070e", "rt_7075@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEOvDPzqtcv8IBhzhhAXGZ/vAW+/npgAUpjsa2+4EhGaeqRAWSzsT3eX31TObb7krag==", null, false, null, false, "RaringsTest_rt_7075" },
                    { "rt_7076", 0, "6e57e572-5a64-4109-b7e7-542e452c6b8e", "rt_7076@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEF9Rzj1HaS2vUgzDTze71YA1i0R2Bu2ySEQdYh9S17uA6SOcFSNGr9aXsE/SFoeSmQ==", null, false, null, false, "RaringsTest_rt_7076" },
                    { "rt_7077", 0, "a135c9e4-bb01-4479-a003-ef4233efd24c", "rt_7077@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEO5AqZVjr54CnAJxEkI38S8bdrT+9+jQ6M8pmnmMxLLF4+JayUvelaXJHgJrakpPGA==", null, false, null, false, "RaringsTest_rt_7077" },
                    { "rt_7099", 0, "3dcb061b-ca7f-45be-8ea2-003e8332c108", "rt_7099@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEOmZOi9ny/WepEjSXP6pduiwobCdt+GV9Gpr+Hgy/qJO8/MKP0sQWZPpy/Q2g5Y1oA==", null, false, null, false, "RaringsTest_rt_7099" },
                    { "rt_7098", 0, "8ea2b3b6-9db8-4525-a023-a553d4cd29b1", "rt_7098@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEFG8MdMA9VWO063WD2kYGAcYti0SF1Decyr9L6Y73UJ50uDt2lmh+ullJ4FnhioKRQ==", null, false, null, false, "RaringsTest_rt_7098" },
                    { "rt_7097", 0, "c3133e18-c183-4e04-b6a3-738442866d75", "rt_7097@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEHmkcZQMW4hy96KBZs3+DIZRFNryFqHsAN8vkDILnvpyZhFVp9i1fZoF0Q6BmV/Diw==", null, false, null, false, "RaringsTest_rt_7097" },
                    { "rt_7096", 0, "40f86d7a-ba4e-4461-bd7d-9c3d7201e3b8", "rt_7096@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEMpwcuCiWOmF/BV1YQ3lUh/Nmi6+NhwULM5m6DEAUYAZDht6Rc/3EyQXKzqaQun/2A==", null, false, null, false, "RaringsTest_rt_7096" },
                    { "rt_7095", 0, "80e96de4-894d-483d-af1b-6e6bfb631dab", "rt_7095@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEEYoaGKYxABrB/gRvcwj7QSBhG6wIVG+bkSqy5ZUi62G8XqdBJVrTaf8UouXjO1rLw==", null, false, null, false, "RaringsTest_rt_7095" },
                    { "rt_7094", 0, "a161c452-be49-4d9c-a44b-5bf409ccc8c9", "rt_7094@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEGEbabXaZ/lmBZ3f6RB/KfUuPNnII/ZNcrRNC2yyLOI+ZvZxRSI5a1sSOHOT7iqN9w==", null, false, null, false, "RaringsTest_rt_7094" },
                    { "rt_7093", 0, "62a31d0c-e7aa-47c1-9d44-1af41fc148f9", "rt_7093@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEJBFqCIqS581GExoTwHU2HsP/0LJp0Sg7yPha7csPeGAFfZ1TQ4U5PF6gProAAsgMg==", null, false, null, false, "RaringsTest_rt_7093" },
                    { "rt_7092", 0, "ef1c5acf-ba20-4059-8f3a-9d773c253cda", "rt_7092@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEP4BbVIlkoOdVkVi75M1yRPFUC8JeazFrrP9Qo6l4DCqvdDEb/moCrE6a1X+y4NBCw==", null, false, null, false, "RaringsTest_rt_7092" },
                    { "rt_7091", 0, "d81a5aee-ae71-4d76-89cb-bebb01605087", "rt_7091@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAELESL1zVlwr6wwZB5CWYoSlJhWrtcTSqygnQPfLSi5z6dxAjHDzmxkZLG5LgGPhHsg==", null, false, null, false, "RaringsTest_rt_7091" },
                    { "rt_7090", 0, "aaf84146-8c7f-4832-9b6a-b2e0bc7c573c", "rt_7090@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAELo00PgsTZzb5ZSd+nOw4eJg5Vim6Kfqymy72F9F2ONjZ5J9f3wxYU3g9xgs8AsN2g==", null, false, null, false, "RaringsTest_rt_7090" },
                    { "rt_7051", 0, "18acc04c-0434-4fd3-af42-56d74e905835", "rt_7051@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAED4mH7Q0vzHgVGo6jxPEEsY70kqFskHHq3vcODMY4tiUokj8W/0CqD6MB9Uix4hN0w==", null, false, null, false, "RaringsTest_rt_7051" },
                    { "rt_7089", 0, "1031b0ad-59c0-4631-9ee1-47ccb2941520", "rt_7089@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEA8sqUylW8OYzuEdTRuP+JVwqRIlosCp1a+LxX0+bro/Ld08FLBV7oCuhha1rTP7Tg==", null, false, null, false, "RaringsTest_rt_7089" },
                    { "rt_7087", 0, "77611baf-0f91-4ce1-8b33-e3864280e075", "rt_7087@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEJfx4bC+Jy24H1m3zGPXdE5ZGhogBb31USyYRh44abUIwZxPgfs79THh4nZkL5YoyA==", null, false, null, false, "RaringsTest_rt_7087" },
                    { "rt_7086", 0, "53ac91cf-bb1c-4cc3-8848-b3c00c6991a7", "rt_7086@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEENoPL9dajHFQ+8p7JLkcoifiQrIvLLWxe6eaexQ8IXq8ydhslU6rZAIGJAeFdQ4wQ==", null, false, null, false, "RaringsTest_rt_7086" },
                    { "rt_7085", 0, "825d9ed3-6717-438e-a3a8-fd5a1ef1271d", "rt_7085@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEJhmGLYOfXRTuLOkBs8CzvqRhEfQyLEHol+ATkQjfhPnc3FJi2ZVlKM5GuBJ7f/3DQ==", null, false, null, false, "RaringsTest_rt_7085" },
                    { "rt_7084", 0, "be565d38-4735-4ab2-bd65-060d8b20ceaa", "rt_7084@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEEwjEqWoOhXZt7tGQk0m7IPNlOgVsb/WC+xNaoEZWyijk+F8Mnoayyrzc/kMnG2VRQ==", null, false, null, false, "RaringsTest_rt_7084" },
                    { "rt_7083", 0, "e18995a1-4d6e-4795-9818-c8433a5375cb", "rt_7083@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAELV9Fo1X+qCArL/MdgtI8vm1u/O1mwmRbHNK0E50AgyIjjqcQpzPdanvG68zF6MWmA==", null, false, null, false, "RaringsTest_rt_7083" },
                    { "rt_7082", 0, "17583b2d-6495-4fdf-bf19-f10f0f3ebc78", "rt_7082@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAELD5BDajsqKd7MTfbqWcQCOzl7uXEOgAoZtnDT1VFN6cmYVT56YdYEKdFDVHFT/IHQ==", null, false, null, false, "RaringsTest_rt_7082" },
                    { "rt_7081", 0, "57530b80-b1cb-4d5c-ba9d-b42e54b96bb3", "rt_7081@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEFpDFnN+rQGoscYVVyfSrs+ykGPCiN6nelSxCMoo3fHcNhfHHaiPz3y+KNPe+rwtpg==", null, false, null, false, "RaringsTest_rt_7081" },
                    { "rt_7080", 0, "9bf9e11e-4ed3-4e68-b171-b6e94bb6c5cb", "rt_7080@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEM9YimIh65ZERJEIPK1Ay5R3jF5qRwYFQ/qaUoLBuX4qO7WTv6HvuQzRic6qEUZPnw==", null, false, null, false, "RaringsTest_rt_7080" },
                    { "rt_7079", 0, "cc0be3ce-772c-43dd-a5be-40a16d4ee784", "rt_7079@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEB+AHtarygGYqloXyjfHQ/n+GelPKp/DR9U9v/3bFfCjVWwiG5kacVfx9tBo0UOMJA==", null, false, null, false, "RaringsTest_rt_7079" },
                    { "rt_7078", 0, "45550a06-e4dc-4610-9c87-7bb5a840756a", "rt_7078@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEEqGmVJJH8v5F2rZf1Bap2CrxRs+1sdX2B3S4l2bg16NG127IgZT+W5euqJ//1IfrA==", null, false, null, false, "RaringsTest_rt_7078" },
                    { "rt_7088", 0, "dcec6f95-ef27-4624-b471-163fc3a0c065", "rt_7088@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEGxVuK9IU3DjQNs1RZQddSE8/QbAGFwWXloJmizgiP6g5EeDaVEtLGz85CbBN4aS7w==", null, false, null, false, "RaringsTest_rt_7088" },
                    { "rt_7050", 0, "d5102bed-a4d6-4147-badf-0e659e4c1de6", "rt_7050@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAECXHsBIuO5VICWFbb6UGDaPhuZTXLAtCp6gZg3ytoUV5DdsIHqW1H952p8MNQSPGOA==", null, false, null, false, "RaringsTest_rt_7050" },
                    { "rt_7073", 0, "5b788ed6-5389-4733-8c88-bcb358077955", "rt_7073@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEK7aSszGNGSHPWZzRFw95Z6vxG/YVd2+oic7x2aswROQG2gN7PWgNGcUY7d6zTJOcA==", null, false, null, false, "RaringsTest_rt_7073" },
                    { "rt_7048", 0, "299e0372-0de4-40ca-be20-9d01a718dfaa", "rt_7048@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEJSHlPjUIZbSBaNAtT5ptvm9Ako3eOSkDv08WcMx6j+pPDMyIvRZRz/7UN0htib97Q==", null, false, null, false, "RaringsTest_rt_7048" },
                    { "rt_7021", 0, "cb142e79-7db2-4a8f-954e-d48d63cd154c", "rt_7021@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEHs/0+KAsEHl0OEJyqSUxyMSdJMRSx+YE0c3GD7bpxN3fz0qBoGPgn+htltN+qf40Q==", null, false, null, false, "RaringsTest_rt_7021" },
                    { "rt_7020", 0, "5cffce42-04ce-4367-abbf-0191b0bf1a24", "rt_7020@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEFLFB/grI6XGefYD7OuISpD0gA0fviWuyBdYevhhCJORw6xbP8oSnwerv8Tts2kBZw==", null, false, null, false, "RaringsTest_rt_7020" },
                    { "rt_7019", 0, "1e65111e-db9a-4dff-9810-8d38b8d2a110", "rt_7019@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEHlve733Uy6HwDf9mXaesXlLvnMXazL1VqzRvJLi8vEUWFtvIoOls8L9mKYKYTceQQ==", null, false, null, false, "RaringsTest_rt_7019" },
                    { "rt_7018", 0, "07377778-970e-436c-9ff2-f469459a2bfc", "rt_7018@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAENCDf3VoZTC+pVbgjmTe1XNc5+7PT15Ywzfvai3YUYImk0mrMSXnQXGpiyKoG6xxyQ==", null, false, null, false, "RaringsTest_rt_7018" },
                    { "rt_7017", 0, "476fa726-7c2f-48d5-84e3-26a53b52e4f1", "rt_7017@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEHWDRifi3CneTpHS4gDzqqPpJ/uwO5LceQ1uAmr/QBGjwaPzEzcnsgjEUIthNbNrXg==", null, false, null, false, "RaringsTest_rt_7017" },
                    { "rt_7016", 0, "4a891216-207b-46b2-a660-7090570e3ca0", "rt_7016@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEO350lJ01d0VM3aW5/pBcqBmWWJU/r/YzFC54JHJzmBblF3HLc09tQhG43PTAMZ96Q==", null, false, null, false, "RaringsTest_rt_7016" },
                    { "rt_7015", 0, "6d133c86-63b2-40e9-bfca-b526551226ee", "rt_7015@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEC1dP9ZXw1hWHi8gyD+sR7cOIXgsigrkNeMfKbFeYKv5iwianGhyui5u5vRuuwLwIw==", null, false, null, false, "RaringsTest_rt_7015" },
                    { "rt_7014", 0, "f5d6070e-11e5-4798-a565-79ccf73b6f80", "rt_7014@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAECiswd5q3PavHkbIX3DKW1hIRN0+w/N9+jV6M4S4eZvxoJKXc2yt7xptWNbiHnnO4w==", null, false, null, false, "RaringsTest_rt_7014" },
                    { "rt_7013", 0, "d8400394-0626-4a2e-84e7-13865aa9b285", "rt_7013@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEANdGoMds5Z6P4/DZEQZHLtkiAkGpj39vyNzNKrZUKEC2AxojZfmlXjp1XAViImQBw==", null, false, null, false, "RaringsTest_rt_7013" },
                    { "rt_7012", 0, "90779506-525c-4b22-8426-4d299d47e969", "rt_7012@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEAulDT4qCOxkVpS8tuq3LGWy6gh7ZZ3SwKfzQper0Jpir8W1NaRmwVnlX2Ufp0l8VA==", null, false, null, false, "RaringsTest_rt_7012" },
                    { "rt_7022", 0, "a47043ea-eea6-46a3-98f7-074fc3d4eaa0", "rt_7022@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEPu75Tl8QM630kUx2zc21txuwUeCCzJfqJxmp+uSSwbfRLYvzlPE6LQmx4KOLnshPg==", null, false, null, false, "RaringsTest_rt_7022" },
                    { "rt_7011", 0, "4c5c81cd-4481-43ef-ae31-35b771d0b1e1", "rt_7011@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEH/1n0qqVBt+/96z/dr9kel/rZHUOUFmM5WID0iaCS5edKKJdSpJWMIXK4nQYA9LoA==", null, false, null, false, "RaringsTest_rt_7011" },
                    { "rt_7009", 0, "abf9df03-6452-4fb7-8f6c-65fc2645c55c", "rt_7009@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEKxEbn9l/4VVtWensDcNMocOYaPDOK0KmcLsp8EBPXSJ7DwnNWZIOqKh1Bbdu8+J7A==", null, false, null, false, "RaringsTest_rt_7009" },
                    { "rt_7008", 0, "0cffd6ed-a6b2-4a81-a63b-b96692e7adb2", "rt_7008@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEMK6UggiHRHBJoQrvy9jz8FMif3Jvbk/WcxRW6rconeX6Sk0nRY7lUr8jdkqucVVeg==", null, false, null, false, "RaringsTest_rt_7008" },
                    { "rt_7007", 0, "1a6dba63-2682-4985-bcc3-263da4238396", "rt_7007@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEN1R8WWEAVoxkCb7Z0fUXimv4pGC1YOMvVy59a9+TR+YZUPeScE7hMhW1rQiXQ6OIQ==", null, false, null, false, "RaringsTest_rt_7007" },
                    { "rt_7006", 0, "822cf7ee-1fc6-48b4-8688-7d0e4dcb023f", "rt_7006@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEFZbjMlwJetxv5HbbadIjqcL+d5EujIcSgdIAFGmOZWIYFwTMBz/jPueDoJXAI8Tmg==", null, false, null, false, "RaringsTest_rt_7006" },
                    { "rt_7005", 0, "6a585ada-5e35-472d-a35b-e5a931e1af09", "rt_7005@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEMbZ3AZuurBe9ZV15D3as3GeQ/Ff/7M/Ia1M3PHZdloW7y2Povqe1so+xNLgri8cuw==", null, false, null, false, "RaringsTest_rt_7005" },
                    { "rt_7004", 0, "7587f47f-1a4b-4e6a-965b-253f39e2e0fb", "rt_7004@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEBAXlBh605LfJ1xCsLMeXv3X3H06gWovtfEZWdtcba+j7G22fPudxV8u9flBGsdpSg==", null, false, null, false, "RaringsTest_rt_7004" },
                    { "rt_7003", 0, "59407377-eff6-45c7-b05e-012ea4420f7a", "rt_7003@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEPybCOdrKxRzM53trEE6vPYeV4XalB/bw5/AbJcD8cnKTGA/m1KUwjtHIBUefVIjRg==", null, false, null, false, "RaringsTest_rt_7003" },
                    { "rt_7002", 0, "909b2aa8-18bf-49a7-a721-9a7ffe60e982", "rt_7002@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEPYSoIbiyT/msNvyAmyQkF9DrYyrhA/qNS7GxjzWb+4R6XMClSdxq9shGbAaBFTU2A==", null, false, null, false, "RaringsTest_rt_7002" },
                    { "rt_7049", 0, "0560ee93-66c9-4e9b-89b5-d7f4c903a605", "rt_7049@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEPP6TnV24IOTU0Tim6E9tAqevnBYN1v77bVF+432hBN6hlHqPbbzzHrdjackU27aMg==", null, false, null, false, "RaringsTest_rt_7049" },
                    { "rt_7000", 0, "9600c795-d054-4658-bfd7-d2b2a7d74a11", "rt_7000@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAELy7LSAKmlupZ/Vb2+EryCYfD/AtycIE4CngZbG4bT+FEZg2WVYf/P/Ks1r1FVGWkw==", null, false, null, false, "RaringsTest_rt_7000" },
                    { "rt_7010", 0, "e3902169-6c44-4795-b151-a281fad0983d", "rt_7010@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEALBFYIx4saLwbJ7NjvvId8QtY9wdsRchf13vmcuWxdElnscdzp4tCGpKcSOROfkkA==", null, false, null, false, "RaringsTest_rt_7010" },
                    { "rt_7023", 0, "bba6f005-3ced-46f5-8b37-7a48b36fdc14", "rt_7023@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEFgP+YpnkEid89J2KcupsNWGn+WdmCpirVduw5gaQnUKSzJKmt5BMYKwRaHbv9mnlQ==", null, false, null, false, "RaringsTest_rt_7023" },
                    { "rt_7001", 0, "366b2e3d-8754-4be9-a581-e1709ee1df5b", "rt_7001@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAELgOz0iwPRdBN0QtIsDWkcUcceDnW1cG3Ag7hrytoKU/Hzpjb7ZDbtwPEpGXpYnkVw==", null, false, null, false, "RaringsTest_rt_7001" },
                    { "rt_7025", 0, "ea02ad7e-4e85-42d1-b079-deb9ceeab732", "rt_7025@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEJ6hRG3/L/qMbePlhpw7B6ZTQssdsVA1gpClMwUvmmXFnweVbqWW25s9gc4lMcBkrQ==", null, false, null, false, "RaringsTest_rt_7025" },
                    { "rt_7047", 0, "90800da3-92fc-4b1e-a163-ab7f77a81ca6", "rt_7047@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAELRVaKy2dITYw5sIjOabq4zrX+azSKkXUrEWikqo+FHwgUY+fIv/CkF4RBkoqN8gMA==", null, false, null, false, "RaringsTest_rt_7047" },
                    { "rt_7046", 0, "dd062857-02ca-4c57-9f65-d41c9b797cef", "rt_7046@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEDBv6p4+J6WBDF/4i8Pyd5ZfK7ZkRYEW2fPs2nbYrZrsR1Te8d1FsmLsqzNt1lBt5A==", null, false, null, false, "RaringsTest_rt_7046" },
                    { "rt_7045", 0, "ef2a7bc0-1805-4736-8826-7aa5eef764ee", "rt_7045@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAENP9KRkcnO8mpYlWZYuC0kX5NCXy/LEYiSmrr0Bkoy0BYmajMrqpkJLjzJHfX9TqZA==", null, false, null, false, "RaringsTest_rt_7045" },
                    { "rt_7044", 0, "d257225b-76df-473e-81de-78987bbaa273", "rt_7044@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAENijYUHZ3HYrFEFKkw1uC/BaYZkFAlzLRGsfQRsaNl3IvfjNcceDe7aMJi0AhO5yKg==", null, false, null, false, "RaringsTest_rt_7044" },
                    { "rt_7043", 0, "382803e4-55d8-4c11-9954-25a7eb0e00e4", "rt_7043@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEMnq5Bf5jkeRfYDKwaJe2sqW/v0IBWXY5CnVP3c2Ci8WZGhHBtnwrYCPaCd6+iTfdA==", null, false, null, false, "RaringsTest_rt_7043" },
                    { "rt_7042", 0, "357d0d65-0be6-4677-842c-b00d4abdba6b", "rt_7042@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEDGz8afTRIG720rGML+6qSaECwyzk8csW+u0sRu+CUMAdEwkL0xCXJbdYVi9gNcGVQ==", null, false, null, false, "RaringsTest_rt_7042" },
                    { "rt_7040", 0, "ca0986fa-6c33-4d43-957c-a3947920e7c3", "rt_7040@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEN8HabCL6yVH7SNc+5xuchxChfNIIPmIgbYM9chpzGlnxCvywaf9aTiN0S4xN2bY1Q==", null, false, null, false, "RaringsTest_rt_7040" },
                    { "rt_7039", 0, "e88f81c2-7ae3-4c5c-bfd4-888ed7ceaae4", "rt_7039@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEDJNGlOqTvo4nBgCo6PBk1KbZHAghGwhrfZjDwHQAFKSRyo8qBWX7btGRuV+jy/C8Q==", null, false, null, false, "RaringsTest_rt_7039" },
                    { "rt_7038", 0, "c17d69ba-cd2d-42f2-8b61-6069cefc2635", "rt_7038@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAELqu1anksJwlGT/qP7zPVmW7w9S8dh8VEv8exuZ/zBACSUuOUD0i3UnV/gZML///6Q==", null, false, null, false, "RaringsTest_rt_7038" },
                    { "rt_7037", 0, "d0a02d61-3ba2-47bb-92b9-714a72e75306", "rt_7037@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAECHmsZZ1s02WRnhp9m2dkpS3N+j7oQANfjFGtQ0asH7QKUEldzfy8Z59CsAbpWS3NA==", null, false, null, false, "RaringsTest_rt_7037" },
                    { "rt_7036", 0, "4512035e-b196-4159-ab04-0e3e11b07795", "rt_7036@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEEgUVbjU+ekkunIDRkjxPNxgSIog6WLGekUudaVA0ku5kBrd1ROttozLb+8MlTwFGw==", null, false, null, false, "RaringsTest_rt_7036" },
                    { "rt_7041", 0, "ed12ba40-a6c0-433b-9822-cf40c4faa7ed", "rt_7041@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEFjDu6xZZO4Z3qcr2J8gcxVvGJH6SHpF/RBaJlnztjfC9G/jXOPEXzG70yW7+N84Mg==", null, false, null, false, "RaringsTest_rt_7041" },
                    { "rt_7034", 0, "541433e0-7b9f-4668-b1f7-f03bc01e8faf", "rt_7034@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAECknjsh2gczG3wDg6MdB2u7NasqrA9qYnI90BOPrz6nJ6Pp4gfWQl+F2j4fwP+OgYQ==", null, false, null, false, "RaringsTest_rt_7034" },
                    { "rt_7035", 0, "c677e65c-da8d-46b3-a6a8-1cff0e18f1bc", "rt_7035@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEKpBZGeprip9O/w6drgKoq2xGi9OC2mMwP9k2psCTVif9M14DuzG+8j/WcrxQki5KQ==", null, false, null, false, "RaringsTest_rt_7035" },
                    { "rt_7026", 0, "f5080b1f-4153-4929-9b59-495b316697e3", "rt_7026@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEJWSdnyAcLAd6qsvx8KH8V0ce1Qh3OrFgF4rVjcJjt+am+kbsrx4zKLxlr3mBTVUKw==", null, false, null, false, "RaringsTest_rt_7026" },
                    { "rt_7027", 0, "a4f16b77-0a0b-4d2a-b022-2daead47ffbb", "rt_7027@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEGmVxCR65Y4ICzSuhCRxwhubvrg5YJBBmf6bNyWmeA6pmGV+Sefaoi9GMr8ACeb/TQ==", null, false, null, false, "RaringsTest_rt_7027" },
                    { "rt_7028", 0, "76dd37e7-c825-4d82-8e13-18efbab93697", "rt_7028@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEK72Tj0cwWAACUrsF6L8hDF/1r+T4Yl8is0lhGtWMTzQabwyxKLo7m/2NftyYEj7nQ==", null, false, null, false, "RaringsTest_rt_7028" },
                    { "rt_7029", 0, "ef6f0feb-590c-418b-a643-0c05a54b73b5", "rt_7029@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEOz7poQlcWItIgSTQNVjr93Xo0l4fVwx8GyBqB2OlLfElZcJCd6ZRXt90/PUX1+/3Q==", null, false, null, false, "RaringsTest_rt_7029" },
                    { "rt_7024", 0, "16bfb060-d225-492c-a81e-e0b7a41be243", "rt_7024@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEJFlCmxEBudBHNQ/IvpvLkV4PZT+8Sk/z2WOq4OTPiOS6LyeKkgbOl/P3ioVgzPjfg==", null, false, null, false, "RaringsTest_rt_7024" },
                    { "rt_7031", 0, "883f26e1-10ce-4665-a77e-8490f7af9a4e", "rt_7031@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAECzIJ73O76Fi00kjbV++XUWTZ+OXkubBxqq2/W7mnW33QK+ZgHiALoDyiBmJ5IBwxQ==", null, false, null, false, "RaringsTest_rt_7031" },
                    { "rt_7032", 0, "e4af6f00-091d-40f1-8869-08f94c66ad26", "rt_7032@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEBvPwp8lVM8hXk71ej4FCbSJDPSMSal3BXwvQ2T2ylDoVIqKPdQ1LlvnEleZnbhLCA==", null, false, null, false, "RaringsTest_rt_7032" },
                    { "rt_7033", 0, "b6ef09f3-a24e-4d54-9b2a-71e9836b3993", "rt_7033@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEKOcUehsFK3L4w9um2alvkky6eXnl/D9v0Xqxv1BrF0ctgfg8csDsCOXmW6DNFeUCQ==", null, false, null, false, "RaringsTest_rt_7033" },
                    { "rt_7030", 0, "dd68f575-4d24-4d13-9606-2e832a382a90", "rt_7030@RaringsTest.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEGJhXMJDiCuuzGqBUbRDyUeCZCIUWTpKAbSrEUec9xmix/tbg9iszIXX/SLlSXSssQ==", null, false, null, false, "RaringsTest_rt_7030" }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1000,
                column: "ProductPrice",
                value: 1965263138.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1001,
                column: "ProductPrice",
                value: 657748643.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1002,
                column: "ProductPrice",
                value: 747711281.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1003,
                column: "ProductPrice",
                value: 600247066.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1004,
                column: "ProductPrice",
                value: 1134226361.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1005,
                column: "ProductPrice",
                value: 1554980541.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1006,
                column: "ProductPrice",
                value: 518459109.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1007,
                column: "ProductPrice",
                value: 1060936865.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1008,
                column: "ProductPrice",
                value: 493738787.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1009,
                column: "ProductPrice",
                value: 1458241319.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1010,
                column: "ProductPrice",
                value: 1345031516.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1011,
                column: "ProductPrice",
                value: 1494106594.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1012,
                column: "ProductPrice",
                value: 1281882166.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1013,
                column: "ProductPrice",
                value: 12806820.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1014,
                column: "ProductPrice",
                value: 104607192.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1015,
                column: "ProductPrice",
                value: 619782372.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1016,
                column: "ProductPrice",
                value: 17512838.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1017,
                column: "ProductPrice",
                value: 1948346511.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1018,
                column: "ProductPrice",
                value: 1028881727.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1019,
                column: "ProductPrice",
                value: 1899724523.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1020,
                column: "ProductPrice",
                value: 1866281648.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1021,
                column: "ProductPrice",
                value: 761928178.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1022,
                column: "ProductPrice",
                value: 960587213.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1023,
                column: "ProductPrice",
                value: 727019442.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1024,
                column: "ProductPrice",
                value: 576548626.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1025,
                column: "ProductPrice",
                value: 305870722.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1026,
                column: "ProductPrice",
                value: 1023222466.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1027,
                column: "ProductPrice",
                value: 1329290315.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1028,
                column: "ProductPrice",
                value: 1693003542.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1029,
                column: "ProductPrice",
                value: 1791348644.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1030,
                column: "ProductPrice",
                value: 2001229827.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1031,
                column: "ProductPrice",
                value: 1951359043.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1032,
                column: "ProductPrice",
                value: 1862507729.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1033,
                column: "ProductPrice",
                value: 496369887.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1034,
                column: "ProductPrice",
                value: 847098235.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1035,
                column: "ProductPrice",
                value: 378887001.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1036,
                column: "ProductPrice",
                value: 827574118.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1037,
                column: "ProductPrice",
                value: 1321324092.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1038,
                column: "ProductPrice",
                value: 494466434.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1039,
                column: "ProductPrice",
                value: 1403556429.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1040,
                column: "ProductPrice",
                value: 1903875921.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1041,
                column: "ProductPrice",
                value: 365778146.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1042,
                column: "ProductPrice",
                value: 631544974.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1043,
                column: "ProductPrice",
                value: 691408884.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1044,
                column: "ProductPrice",
                value: 207701287.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1045,
                column: "ProductPrice",
                value: 127324209.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1046,
                column: "ProductPrice",
                value: 373131939.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1047,
                column: "ProductPrice",
                value: 1298228473.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1048,
                column: "ProductPrice",
                value: 2143919879.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1049,
                column: "ProductPrice",
                value: 670204444.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1050,
                column: "ProductPrice",
                value: 602631074.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1051,
                column: "ProductPrice",
                value: 909381469.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1052,
                column: "ProductPrice",
                value: 278828508.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1053,
                column: "ProductPrice",
                value: 1602347359.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1054,
                column: "ProductPrice",
                value: 2141332642.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1055,
                column: "ProductPrice",
                value: 615446859.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1056,
                column: "ProductPrice",
                value: 1256756976.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1057,
                column: "ProductPrice",
                value: 1580287385.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1058,
                column: "ProductPrice",
                value: 1583293986.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1059,
                column: "ProductPrice",
                value: 240467538.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1060,
                column: "ProductPrice",
                value: 2091353621.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1061,
                column: "ProductPrice",
                value: 748764340.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1062,
                column: "ProductPrice",
                value: 927528869.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1063,
                column: "ProductPrice",
                value: 261985689.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1064,
                column: "ProductPrice",
                value: 1016607038.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1065,
                column: "ProductPrice",
                value: 953268019.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1066,
                column: "ProductPrice",
                value: 1191194411.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1067,
                column: "ProductPrice",
                value: 197624178.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1068,
                column: "ProductPrice",
                value: 725304131.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1069,
                column: "ProductPrice",
                value: 1285315737.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1070,
                column: "ProductPrice",
                value: 1351803800.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1071,
                column: "ProductPrice",
                value: 255784292.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1072,
                column: "ProductPrice",
                value: 865991976.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1073,
                column: "ProductPrice",
                value: 1184920844.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1074,
                column: "ProductPrice",
                value: 1555444148.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1075,
                column: "ProductPrice",
                value: 912615401.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1076,
                column: "ProductPrice",
                value: 1689978750.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1077,
                column: "ProductPrice",
                value: 1828773875.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1078,
                column: "ProductPrice",
                value: 2078913701.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1079,
                column: "ProductPrice",
                value: 2008819963.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1080,
                column: "ProductPrice",
                value: 1492334329.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1081,
                column: "ProductPrice",
                value: 1284589539.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1082,
                column: "ProductPrice",
                value: 744965982.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1083,
                column: "ProductPrice",
                value: 434910997.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1084,
                column: "ProductPrice",
                value: 600829469.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1085,
                column: "ProductPrice",
                value: 503960257.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1086,
                column: "ProductPrice",
                value: 1084642434.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1087,
                column: "ProductPrice",
                value: 1819755916.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1088,
                column: "ProductPrice",
                value: 2062116438.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1089,
                column: "ProductPrice",
                value: 1791246922.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1090,
                column: "ProductPrice",
                value: 681725571.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1091,
                column: "ProductPrice",
                value: 806882279.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1092,
                column: "ProductPrice",
                value: 1297625652.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1093,
                column: "ProductPrice",
                value: 1813594442.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1094,
                column: "ProductPrice",
                value: 871798354.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1095,
                column: "ProductPrice",
                value: 567223480.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1096,
                column: "ProductPrice",
                value: 997844823.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1097,
                column: "ProductPrice",
                value: 1929154831.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1098,
                column: "ProductPrice",
                value: 1234397392.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1099,
                column: "ProductPrice",
                value: 814028814.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1100,
                column: "ProductPrice",
                value: 495725344.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1101,
                column: "ProductPrice",
                value: 1735103307.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1102,
                column: "ProductPrice",
                value: 2132519888.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1103,
                column: "ProductPrice",
                value: 270716041.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1104,
                column: "ProductPrice",
                value: 877996190.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1105,
                column: "ProductPrice",
                value: 1906442328.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1106,
                column: "ProductPrice",
                value: 1602985039.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1107,
                column: "ProductPrice",
                value: 653503210.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1108,
                column: "ProductPrice",
                value: 1606498757.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1109,
                column: "ProductPrice",
                value: 640829140.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1110,
                column: "ProductPrice",
                value: 485063655.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1111,
                column: "ProductPrice",
                value: 987578647.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1112,
                column: "ProductPrice",
                value: 1060969230.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1113,
                column: "ProductPrice",
                value: 1134069569.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1114,
                column: "ProductPrice",
                value: 307728755.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1115,
                column: "ProductPrice",
                value: 218875981.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1116,
                column: "ProductPrice",
                value: 1563393904.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1117,
                column: "ProductPrice",
                value: 2052213418.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1118,
                column: "ProductPrice",
                value: 1220751766.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1119,
                column: "ProductPrice",
                value: 2072242327.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1120,
                column: "ProductPrice",
                value: 1428221131.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1121,
                column: "ProductPrice",
                value: 931034041.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1122,
                column: "ProductPrice",
                value: 1842586933.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1123,
                column: "ProductPrice",
                value: 493652755.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1124,
                column: "ProductPrice",
                value: 15702065.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1125,
                column: "ProductPrice",
                value: 2104517067.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1126,
                column: "ProductPrice",
                value: 517754186.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1127,
                column: "ProductPrice",
                value: 611993080.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1128,
                column: "ProductPrice",
                value: 1872718036.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1129,
                column: "ProductPrice",
                value: 400332567.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1130,
                column: "ProductPrice",
                value: 1474366124.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1131,
                column: "ProductPrice",
                value: 1320419465.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1132,
                column: "ProductPrice",
                value: 6488382.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1133,
                column: "ProductPrice",
                value: 676996786.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1134,
                column: "ProductPrice",
                value: 925206518.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1135,
                column: "ProductPrice",
                value: 1316826568.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1136,
                column: "ProductPrice",
                value: 711665197.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1137,
                column: "ProductPrice",
                value: 2033845487.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1138,
                column: "ProductPrice",
                value: 1116510353.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1139,
                column: "ProductPrice",
                value: 253982687.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1140,
                column: "ProductPrice",
                value: 460570764.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1141,
                column: "ProductPrice",
                value: 1990734770.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1142,
                column: "ProductPrice",
                value: 1772852705.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1143,
                column: "ProductPrice",
                value: 833399197.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1144,
                column: "ProductPrice",
                value: 718295166.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1145,
                column: "ProductPrice",
                value: 1253742470.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1146,
                column: "ProductPrice",
                value: 1305508595.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1147,
                column: "ProductPrice",
                value: 1723151629.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1148,
                column: "ProductPrice",
                value: 917977586.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1149,
                column: "ProductPrice",
                value: 65034272.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1150,
                column: "ProductPrice",
                value: 563425122.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1151,
                column: "ProductPrice",
                value: 505226951.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1152,
                column: "ProductPrice",
                value: 120514964.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1153,
                column: "ProductPrice",
                value: 721750611.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1154,
                column: "ProductPrice",
                value: 945403229.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1155,
                column: "ProductPrice",
                value: 1124286849.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1156,
                column: "ProductPrice",
                value: 1452111920.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1157,
                column: "ProductPrice",
                value: 1050979032.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1158,
                column: "ProductPrice",
                value: 1814609522.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1159,
                column: "ProductPrice",
                value: 333074669.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1160,
                column: "ProductPrice",
                value: 800800041.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1161,
                column: "ProductPrice",
                value: 403103858.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1162,
                column: "ProductPrice",
                value: 340380720.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1163,
                column: "ProductPrice",
                value: 618278089.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1164,
                column: "ProductPrice",
                value: 726058562.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1165,
                column: "ProductPrice",
                value: 724239736.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1166,
                column: "ProductPrice",
                value: 393202164.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1167,
                column: "ProductPrice",
                value: 1943567990.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1168,
                column: "ProductPrice",
                value: 1768458597.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1169,
                column: "ProductPrice",
                value: 550497733.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1170,
                column: "ProductPrice",
                value: 1066806330.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1171,
                column: "ProductPrice",
                value: 1089143963.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1172,
                column: "ProductPrice",
                value: 347814964.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1173,
                column: "ProductPrice",
                value: 378880978.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1174,
                column: "ProductPrice",
                value: 1023783462.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1175,
                column: "ProductPrice",
                value: 997081907.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1176,
                column: "ProductPrice",
                value: 717776882.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1177,
                column: "ProductPrice",
                value: 421299635.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1178,
                column: "ProductPrice",
                value: 1334953135.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1179,
                column: "ProductPrice",
                value: 321555141.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1180,
                column: "ProductPrice",
                value: 211120371.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1181,
                column: "ProductPrice",
                value: 354198103.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1182,
                column: "ProductPrice",
                value: 1253611040.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1183,
                column: "ProductPrice",
                value: 1219795663.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1184,
                column: "ProductPrice",
                value: 1396502991.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1185,
                column: "ProductPrice",
                value: 381251072.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1186,
                column: "ProductPrice",
                value: 612016400.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1187,
                column: "ProductPrice",
                value: 844333317.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1188,
                column: "ProductPrice",
                value: 1291189103.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1189,
                column: "ProductPrice",
                value: 1360515215.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1190,
                column: "ProductPrice",
                value: 1424310194.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1191,
                column: "ProductPrice",
                value: 1220281711.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1192,
                column: "ProductPrice",
                value: 1778831511.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1193,
                column: "ProductPrice",
                value: 195547583.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1194,
                column: "ProductPrice",
                value: 1012778192.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1195,
                column: "ProductPrice",
                value: 1617062452.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1196,
                column: "ProductPrice",
                value: 1062465949.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1197,
                column: "ProductPrice",
                value: 566686515.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1198,
                column: "ProductPrice",
                value: 1666936181.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1199,
                column: "ProductPrice",
                value: 1553650976.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1200,
                column: "ProductPrice",
                value: 272652205.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1201,
                column: "ProductPrice",
                value: 921536151.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1202,
                column: "ProductPrice",
                value: 1514288578.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1203,
                column: "ProductPrice",
                value: 1927075399.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1204,
                column: "ProductPrice",
                value: 557823488.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1205,
                column: "ProductPrice",
                value: 1033876705.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1206,
                column: "ProductPrice",
                value: 1717007533.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1207,
                column: "ProductPrice",
                value: 1301229532.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1208,
                column: "ProductPrice",
                value: 1257562695.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1209,
                column: "ProductPrice",
                value: 1507916868.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1210,
                column: "ProductPrice",
                value: 1966105513.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1211,
                column: "ProductPrice",
                value: 442924184.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1212,
                column: "ProductPrice",
                value: 1275621443.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1213,
                column: "ProductPrice",
                value: 905166280.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1214,
                column: "ProductPrice",
                value: 1681549844.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1215,
                column: "ProductPrice",
                value: 2006197484.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1216,
                column: "ProductPrice",
                value: 709088364.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1217,
                column: "ProductPrice",
                value: 680180603.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1218,
                column: "ProductPrice",
                value: 781370644.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1219,
                column: "ProductPrice",
                value: 1904403036.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1220,
                column: "ProductPrice",
                value: 1671818882.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1221,
                column: "ProductPrice",
                value: 1108464393.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1222,
                column: "ProductPrice",
                value: 64490786.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1223,
                column: "ProductPrice",
                value: 1967538928.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1224,
                column: "ProductPrice",
                value: 685783085.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1225,
                column: "ProductPrice",
                value: 1406120165.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1226,
                column: "ProductPrice",
                value: 869907998.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1227,
                column: "ProductPrice",
                value: 1711862927.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1228,
                column: "ProductPrice",
                value: 925698332.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1229,
                column: "ProductPrice",
                value: 966316556.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1230,
                column: "ProductPrice",
                value: 1494211504.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1231,
                column: "ProductPrice",
                value: 1710685913.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1232,
                column: "ProductPrice",
                value: 313959000.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1233,
                column: "ProductPrice",
                value: 1340897705.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1234,
                column: "ProductPrice",
                value: 1608498482.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1235,
                column: "ProductPrice",
                value: 849179766.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1236,
                column: "ProductPrice",
                value: 399505071.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1237,
                column: "ProductPrice",
                value: 886131187.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1238,
                column: "ProductPrice",
                value: 74084074.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1239,
                column: "ProductPrice",
                value: 1922221832.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1240,
                column: "ProductPrice",
                value: 223839085.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1241,
                column: "ProductPrice",
                value: 870382414.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1242,
                column: "ProductPrice",
                value: 1146366168.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1243,
                column: "ProductPrice",
                value: 1342867781.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1244,
                column: "ProductPrice",
                value: 954005248.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1245,
                column: "ProductPrice",
                value: 393497909.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1246,
                column: "ProductPrice",
                value: 1504255814.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1247,
                column: "ProductPrice",
                value: 285777130.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1248,
                column: "ProductPrice",
                value: 73593285.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1249,
                column: "ProductPrice",
                value: 566176254.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1250,
                column: "ProductPrice",
                value: 320085987.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1251,
                column: "ProductPrice",
                value: 1941880892.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1252,
                column: "ProductPrice",
                value: 1344911417.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1253,
                column: "ProductPrice",
                value: 1322128691.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1254,
                column: "ProductPrice",
                value: 1441427640.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1255,
                column: "ProductPrice",
                value: 723783358.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1256,
                column: "ProductPrice",
                value: 269157264.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1257,
                column: "ProductPrice",
                value: 1106345196.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1258,
                column: "ProductPrice",
                value: 653404213.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1259,
                column: "ProductPrice",
                value: 711298869.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1260,
                column: "ProductPrice",
                value: 1723564253.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1261,
                column: "ProductPrice",
                value: 1564740152.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1262,
                column: "ProductPrice",
                value: 1935126746.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1263,
                column: "ProductPrice",
                value: 1850841685.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1264,
                column: "ProductPrice",
                value: 1573300910.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1265,
                column: "ProductPrice",
                value: 1815015146.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1266,
                column: "ProductPrice",
                value: 1688560730.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1267,
                column: "ProductPrice",
                value: 1494319284.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1268,
                column: "ProductPrice",
                value: 856263344.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1269,
                column: "ProductPrice",
                value: 244481977.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1270,
                column: "ProductPrice",
                value: 1018804312.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1271,
                column: "ProductPrice",
                value: 1382552723.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1272,
                column: "ProductPrice",
                value: 18208428.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1273,
                column: "ProductPrice",
                value: 418744358.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1274,
                column: "ProductPrice",
                value: 1092675850.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1275,
                column: "ProductPrice",
                value: 213548367.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1276,
                column: "ProductPrice",
                value: 1521693771.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1277,
                column: "ProductPrice",
                value: 281218551.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1278,
                column: "ProductPrice",
                value: 425645579.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1279,
                column: "ProductPrice",
                value: 1851880722.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1280,
                column: "ProductPrice",
                value: 1461459897.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1281,
                column: "ProductPrice",
                value: 2143726414.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1282,
                column: "ProductPrice",
                value: 1050381541.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1283,
                column: "ProductPrice",
                value: 1919117624.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1284,
                column: "ProductPrice",
                value: 58342468.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1285,
                column: "ProductPrice",
                value: 1111926158.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1286,
                column: "ProductPrice",
                value: 1925370042.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1287,
                column: "ProductPrice",
                value: 551425855.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1288,
                column: "ProductPrice",
                value: 1459065611.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1289,
                column: "ProductPrice",
                value: 296827023.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1290,
                column: "ProductPrice",
                value: 2139618048.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1291,
                column: "ProductPrice",
                value: 852755421.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1292,
                column: "ProductPrice",
                value: 1792322520.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1293,
                column: "ProductPrice",
                value: 922380751.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1294,
                column: "ProductPrice",
                value: 1758253125.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1295,
                column: "ProductPrice",
                value: 218694479.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1296,
                column: "ProductPrice",
                value: 494851214.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1297,
                column: "ProductPrice",
                value: 855120029.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1298,
                column: "ProductPrice",
                value: 1329162417.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1299,
                column: "ProductPrice",
                value: 698585648.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1300,
                column: "ProductPrice",
                value: 264532725.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1301,
                column: "ProductPrice",
                value: 1569532076.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1302,
                column: "ProductPrice",
                value: 989109332.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1303,
                column: "ProductPrice",
                value: 1388706854.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1304,
                column: "ProductPrice",
                value: 1106967488.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1305,
                column: "ProductPrice",
                value: 497128810.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1306,
                column: "ProductPrice",
                value: 1335784363.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1307,
                column: "ProductPrice",
                value: 338278958.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1308,
                column: "ProductPrice",
                value: 1789048387.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1309,
                column: "ProductPrice",
                value: 639991172.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1310,
                column: "ProductPrice",
                value: 761685133.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1311,
                column: "ProductPrice",
                value: 1547534259.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1312,
                column: "ProductPrice",
                value: 92811516.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1313,
                column: "ProductPrice",
                value: 361119037.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1314,
                column: "ProductPrice",
                value: 809434518.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1315,
                column: "ProductPrice",
                value: 1139433385.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1316,
                column: "ProductPrice",
                value: 2073954157.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1317,
                column: "ProductPrice",
                value: 1575604668.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1318,
                column: "ProductPrice",
                value: 1204611116.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1319,
                column: "ProductPrice",
                value: 2020970298.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1320,
                column: "ProductPrice",
                value: 1449240650.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1321,
                column: "ProductPrice",
                value: 549246774.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1322,
                column: "ProductPrice",
                value: 1594849219.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1323,
                column: "ProductPrice",
                value: 2119031867.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1324,
                column: "ProductPrice",
                value: 1811943122.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1325,
                column: "ProductPrice",
                value: 1725644437.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1326,
                column: "ProductPrice",
                value: 1149825749.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1327,
                column: "ProductPrice",
                value: 655423223.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1328,
                column: "ProductPrice",
                value: 220086779.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1329,
                column: "ProductPrice",
                value: 286093270.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1330,
                column: "ProductPrice",
                value: 1278292699.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1331,
                column: "ProductPrice",
                value: 78685641.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1332,
                column: "ProductPrice",
                value: 511651680.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1333,
                column: "ProductPrice",
                value: 1286655477.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1334,
                column: "ProductPrice",
                value: 999459896.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1335,
                column: "ProductPrice",
                value: 1451523367.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1336,
                column: "ProductPrice",
                value: 566728981.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1337,
                column: "ProductPrice",
                value: 1221270233.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1338,
                column: "ProductPrice",
                value: 224262035.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1339,
                column: "ProductPrice",
                value: 1120809204.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1340,
                column: "ProductPrice",
                value: 1335737341.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1341,
                column: "ProductPrice",
                value: 999202983.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1342,
                column: "ProductPrice",
                value: 321973014.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1343,
                column: "ProductPrice",
                value: 231186338.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1344,
                column: "ProductPrice",
                value: 1094737436.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1345,
                column: "ProductPrice",
                value: 4195688.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1346,
                column: "ProductPrice",
                value: 172055804.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1347,
                column: "ProductPrice",
                value: 843315382.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1348,
                column: "ProductPrice",
                value: 1672541779.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1349,
                column: "ProductPrice",
                value: 30931639.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1350,
                column: "ProductPrice",
                value: 1851819515.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1351,
                column: "ProductPrice",
                value: 478842092.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1352,
                column: "ProductPrice",
                value: 1210104459.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1353,
                column: "ProductPrice",
                value: 867787665.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1354,
                column: "ProductPrice",
                value: 808940544.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1355,
                column: "ProductPrice",
                value: 1274881497.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1356,
                column: "ProductPrice",
                value: 1534278403.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1357,
                column: "ProductPrice",
                value: 429673011.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1358,
                column: "ProductPrice",
                value: 1136359278.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1359,
                column: "ProductPrice",
                value: 940918597.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1360,
                column: "ProductPrice",
                value: 906898607.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1361,
                column: "ProductPrice",
                value: 92473039.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1362,
                column: "ProductPrice",
                value: 1677787725.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1363,
                column: "ProductPrice",
                value: 915067016.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1364,
                column: "ProductPrice",
                value: 921294019.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1365,
                column: "ProductPrice",
                value: 95111391.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1366,
                column: "ProductPrice",
                value: 447994478.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1367,
                column: "ProductPrice",
                value: 365751585.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1368,
                column: "ProductPrice",
                value: 921254687.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1369,
                column: "ProductPrice",
                value: 917506697.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1370,
                column: "ProductPrice",
                value: 2132299950.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1371,
                column: "ProductPrice",
                value: 264795823.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1372,
                column: "ProductPrice",
                value: 763454532.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1373,
                column: "ProductPrice",
                value: 1643397458.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1374,
                column: "ProductPrice",
                value: 97344856.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1375,
                column: "ProductPrice",
                value: 2009633213.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1376,
                column: "ProductPrice",
                value: 1786869306.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1377,
                column: "ProductPrice",
                value: 775774780.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1378,
                column: "ProductPrice",
                value: 436406330.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1379,
                column: "ProductPrice",
                value: 1219859333.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1380,
                column: "ProductPrice",
                value: 965700532.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1381,
                column: "ProductPrice",
                value: 1866105913.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1382,
                column: "ProductPrice",
                value: 542476990.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1383,
                column: "ProductPrice",
                value: 1748750686.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1384,
                column: "ProductPrice",
                value: 2141352948.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1385,
                column: "ProductPrice",
                value: 211562506.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1386,
                column: "ProductPrice",
                value: 428176728.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1387,
                column: "ProductPrice",
                value: 1203459561.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1388,
                column: "ProductPrice",
                value: 2037310479.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1389,
                column: "ProductPrice",
                value: 1284173945.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1390,
                column: "ProductPrice",
                value: 1476840510.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1391,
                column: "ProductPrice",
                value: 1696651516.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1392,
                column: "ProductPrice",
                value: 1644506501.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1393,
                column: "ProductPrice",
                value: 842938984.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1394,
                column: "ProductPrice",
                value: 1773506143.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1395,
                column: "ProductPrice",
                value: 655376201.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1396,
                column: "ProductPrice",
                value: 881010804.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1397,
                column: "ProductPrice",
                value: 966501544.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1398,
                column: "ProductPrice",
                value: 869487865.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1399,
                column: "ProductPrice",
                value: 411737944.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1400,
                column: "ProductPrice",
                value: 1115796756.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1401,
                column: "ProductPrice",
                value: 1365899765.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1402,
                column: "ProductPrice",
                value: 1481656241.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1403,
                column: "ProductPrice",
                value: 167146981.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1404,
                column: "ProductPrice",
                value: 1605710882.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1405,
                column: "ProductPrice",
                value: 999135591.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1406,
                column: "ProductPrice",
                value: 1274983106.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1407,
                column: "ProductPrice",
                value: 1126302547.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1408,
                column: "ProductPrice",
                value: 182554708.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1409,
                column: "ProductPrice",
                value: 358902877.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1410,
                column: "ProductPrice",
                value: 1047607737.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1411,
                column: "ProductPrice",
                value: 170615522.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1412,
                column: "ProductPrice",
                value: 1552862227.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1413,
                column: "ProductPrice",
                value: 1476095491.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1414,
                column: "ProductPrice",
                value: 1534813611.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1415,
                column: "ProductPrice",
                value: 600388240.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1416,
                column: "ProductPrice",
                value: 1109591595.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1417,
                column: "ProductPrice",
                value: 1488632585.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1418,
                column: "ProductPrice",
                value: 333309614.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1419,
                column: "ProductPrice",
                value: 121843412.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1420,
                column: "ProductPrice",
                value: 1226530209.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1421,
                column: "ProductPrice",
                value: 804130463.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1422,
                column: "ProductPrice",
                value: 2035520299.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1423,
                column: "ProductPrice",
                value: 1196676288.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1424,
                column: "ProductPrice",
                value: 1000261733.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1425,
                column: "ProductPrice",
                value: 1995243980.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1426,
                column: "ProductPrice",
                value: 179884868.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1427,
                column: "ProductPrice",
                value: 1480111094.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1428,
                column: "ProductPrice",
                value: 1429486861.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1429,
                column: "ProductPrice",
                value: 1001564201.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1430,
                column: "ProductPrice",
                value: 540734308.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1431,
                column: "ProductPrice",
                value: 232479661.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1432,
                column: "ProductPrice",
                value: 1465882461.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1433,
                column: "ProductPrice",
                value: 1584263932.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1434,
                column: "ProductPrice",
                value: 1663658123.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1435,
                column: "ProductPrice",
                value: 1159396313.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1436,
                column: "ProductPrice",
                value: 1944045218.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1437,
                column: "ProductPrice",
                value: 1934925555.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1438,
                column: "ProductPrice",
                value: 1702635350.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1439,
                column: "ProductPrice",
                value: 554329256.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1440,
                column: "ProductPrice",
                value: 496174946.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1441,
                column: "ProductPrice",
                value: 861469727.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1442,
                column: "ProductPrice",
                value: 433016752.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1443,
                column: "ProductPrice",
                value: 1090519501.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1444,
                column: "ProductPrice",
                value: 1796161754.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1445,
                column: "ProductPrice",
                value: 718336887.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1446,
                column: "ProductPrice",
                value: 1703384835.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1447,
                column: "ProductPrice",
                value: 1728006556.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1448,
                column: "ProductPrice",
                value: 867720919.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1449,
                column: "ProductPrice",
                value: 585229802.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1450,
                column: "ProductPrice",
                value: 1105380152.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1451,
                column: "ProductPrice",
                value: 951973765.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1452,
                column: "ProductPrice",
                value: 45303829.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1453,
                column: "ProductPrice",
                value: 159756352.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1454,
                column: "ProductPrice",
                value: 744803281.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1455,
                column: "ProductPrice",
                value: 1871261839.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1456,
                column: "ProductPrice",
                value: 889975012.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1457,
                column: "ProductPrice",
                value: 1844575499.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1458,
                column: "ProductPrice",
                value: 726480794.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1459,
                column: "ProductPrice",
                value: 1170062448.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1460,
                column: "ProductPrice",
                value: 231362622.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1461,
                column: "ProductPrice",
                value: 1354467558.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1462,
                column: "ProductPrice",
                value: 1256411232.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1463,
                column: "ProductPrice",
                value: 740586053.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1464,
                column: "ProductPrice",
                value: 1377764115.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1465,
                column: "ProductPrice",
                value: 227239975.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1466,
                column: "ProductPrice",
                value: 264328607.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1467,
                column: "ProductPrice",
                value: 1528193841.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1468,
                column: "ProductPrice",
                value: 1372032914.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1469,
                column: "ProductPrice",
                value: 1935012844.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1470,
                column: "ProductPrice",
                value: 215938568.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1471,
                column: "ProductPrice",
                value: 734261586.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1472,
                column: "ProductPrice",
                value: 1345592781.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1473,
                column: "ProductPrice",
                value: 1338575904.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1474,
                column: "ProductPrice",
                value: 1185264012.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1475,
                column: "ProductPrice",
                value: 1924656028.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1476,
                column: "ProductPrice",
                value: 1930709257.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1477,
                column: "ProductPrice",
                value: 357112697.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1478,
                column: "ProductPrice",
                value: 960110080.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1479,
                column: "ProductPrice",
                value: 1841520392.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1480,
                column: "ProductPrice",
                value: 1851454691.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1481,
                column: "ProductPrice",
                value: 11473858.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1482,
                column: "ProductPrice",
                value: 24502074.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1483,
                column: "ProductPrice",
                value: 256368958.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1484,
                column: "ProductPrice",
                value: 1455779595.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1485,
                column: "ProductPrice",
                value: 1148356089.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1486,
                column: "ProductPrice",
                value: 1746771378.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1487,
                column: "ProductPrice",
                value: 718238008.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1488,
                column: "ProductPrice",
                value: 251572550.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1489,
                column: "ProductPrice",
                value: 1351991830.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1490,
                column: "ProductPrice",
                value: 1829016847.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1491,
                column: "ProductPrice",
                value: 1659065265.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1492,
                column: "ProductPrice",
                value: 620556660.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1493,
                column: "ProductPrice",
                value: 2092168448.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1494,
                column: "ProductPrice",
                value: 1882562180.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1495,
                column: "ProductPrice",
                value: 701302934.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1496,
                column: "ProductPrice",
                value: 1164654041.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1497,
                column: "ProductPrice",
                value: 1252026245.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1498,
                column: "ProductPrice",
                value: 1272350932.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1499,
                column: "ProductPrice",
                value: 981033678.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7000", "9600c795-d054-4658-bfd7-d2b2a7d74a11" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7001", "366b2e3d-8754-4be9-a581-e1709ee1df5b" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7002", "909b2aa8-18bf-49a7-a721-9a7ffe60e982" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7003", "59407377-eff6-45c7-b05e-012ea4420f7a" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7004", "7587f47f-1a4b-4e6a-965b-253f39e2e0fb" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7005", "6a585ada-5e35-472d-a35b-e5a931e1af09" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7006", "822cf7ee-1fc6-48b4-8688-7d0e4dcb023f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7007", "1a6dba63-2682-4985-bcc3-263da4238396" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7008", "0cffd6ed-a6b2-4a81-a63b-b96692e7adb2" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7009", "abf9df03-6452-4fb7-8f6c-65fc2645c55c" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7010", "e3902169-6c44-4795-b151-a281fad0983d" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7011", "4c5c81cd-4481-43ef-ae31-35b771d0b1e1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7012", "90779506-525c-4b22-8426-4d299d47e969" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7013", "d8400394-0626-4a2e-84e7-13865aa9b285" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7014", "f5d6070e-11e5-4798-a565-79ccf73b6f80" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7015", "6d133c86-63b2-40e9-bfca-b526551226ee" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7016", "4a891216-207b-46b2-a660-7090570e3ca0" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7017", "476fa726-7c2f-48d5-84e3-26a53b52e4f1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7018", "07377778-970e-436c-9ff2-f469459a2bfc" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7019", "1e65111e-db9a-4dff-9810-8d38b8d2a110" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7020", "5cffce42-04ce-4367-abbf-0191b0bf1a24" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7021", "cb142e79-7db2-4a8f-954e-d48d63cd154c" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7022", "a47043ea-eea6-46a3-98f7-074fc3d4eaa0" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7023", "bba6f005-3ced-46f5-8b37-7a48b36fdc14" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7024", "16bfb060-d225-492c-a81e-e0b7a41be243" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7025", "ea02ad7e-4e85-42d1-b079-deb9ceeab732" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7026", "f5080b1f-4153-4929-9b59-495b316697e3" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7027", "a4f16b77-0a0b-4d2a-b022-2daead47ffbb" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7028", "76dd37e7-c825-4d82-8e13-18efbab93697" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7029", "ef6f0feb-590c-418b-a643-0c05a54b73b5" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7030", "dd68f575-4d24-4d13-9606-2e832a382a90" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7031", "883f26e1-10ce-4665-a77e-8490f7af9a4e" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7032", "e4af6f00-091d-40f1-8869-08f94c66ad26" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7033", "b6ef09f3-a24e-4d54-9b2a-71e9836b3993" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7034", "541433e0-7b9f-4668-b1f7-f03bc01e8faf" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7035", "c677e65c-da8d-46b3-a6a8-1cff0e18f1bc" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7036", "4512035e-b196-4159-ab04-0e3e11b07795" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7037", "d0a02d61-3ba2-47bb-92b9-714a72e75306" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7038", "c17d69ba-cd2d-42f2-8b61-6069cefc2635" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7039", "e88f81c2-7ae3-4c5c-bfd4-888ed7ceaae4" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7040", "ca0986fa-6c33-4d43-957c-a3947920e7c3" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7041", "ed12ba40-a6c0-433b-9822-cf40c4faa7ed" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7042", "357d0d65-0be6-4677-842c-b00d4abdba6b" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7043", "382803e4-55d8-4c11-9954-25a7eb0e00e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7044", "d257225b-76df-473e-81de-78987bbaa273" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7045", "ef2a7bc0-1805-4736-8826-7aa5eef764ee" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7046", "dd062857-02ca-4c57-9f65-d41c9b797cef" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7047", "90800da3-92fc-4b1e-a163-ab7f77a81ca6" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7048", "299e0372-0de4-40ca-be20-9d01a718dfaa" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7049", "0560ee93-66c9-4e9b-89b5-d7f4c903a605" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7050", "d5102bed-a4d6-4147-badf-0e659e4c1de6" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7051", "18acc04c-0434-4fd3-af42-56d74e905835" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7052", "0dfd4d6d-21b0-452f-a634-96849649993f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7053", "07735bd0-cd58-4782-ac8c-8d4475f69dfb" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7054", "3b73c791-f9ef-4bf0-a924-22f47b9143a5" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7055", "d3fe1992-a3fb-4ce9-abcf-28d65ebf2a88" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7056", "655f1f7e-23b3-4b91-9ed1-96ab096e38b9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7057", "968ec63c-c35e-426b-8665-63961c73e993" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7058", "53e505b1-db5e-4cf2-922a-bf882fcb6bf1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7059", "00d2b907-7e4c-4b3e-a994-817f2395bae1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7060", "2a3fe2c1-ad2d-44db-9425-aecf05667afa" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7061", "6c605e66-78c3-49b8-9693-45f387309f5d" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7062", "c929eb05-2536-4837-900e-261caf532e03" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7063", "07ff3f76-67fa-4099-9428-724948224bbc" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7064", "0eb68c4c-5ef5-4645-9df1-51a8f45395c7" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7065", "263a02bd-d9c2-4cc4-99f5-3aa730385854" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7066", "73d6f9bc-6733-42a1-81ea-13333f34f959" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7067", "330eab35-1857-4036-ab51-0c8503e594a1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7068", "66798b03-d2a3-46f1-801c-a30395fa09e6" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7069", "d1c2deac-14a2-42a4-9a37-ca27de18b1c2" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7070", "187a0f6e-8371-4815-a703-8038b5e1630e" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7071", "a5f5fdad-017c-4e3f-bd9f-2538f3ea0776" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7072", "691c3faf-a096-48fd-bd1c-69e28c718aab" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7073", "5b788ed6-5389-4733-8c88-bcb358077955" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7074", "51bbf59f-3fdb-4836-afc5-f437438d25ab" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7075", "c1998466-a33d-4ea7-b9cb-a774f1c7070e" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7076", "6e57e572-5a64-4109-b7e7-542e452c6b8e" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7077", "a135c9e4-bb01-4479-a003-ef4233efd24c" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7078", "45550a06-e4dc-4610-9c87-7bb5a840756a" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7079", "cc0be3ce-772c-43dd-a5be-40a16d4ee784" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7080", "9bf9e11e-4ed3-4e68-b171-b6e94bb6c5cb" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7081", "57530b80-b1cb-4d5c-ba9d-b42e54b96bb3" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7082", "17583b2d-6495-4fdf-bf19-f10f0f3ebc78" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7083", "e18995a1-4d6e-4795-9818-c8433a5375cb" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7084", "be565d38-4735-4ab2-bd65-060d8b20ceaa" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7085", "825d9ed3-6717-438e-a3a8-fd5a1ef1271d" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7086", "53ac91cf-bb1c-4cc3-8848-b3c00c6991a7" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7087", "77611baf-0f91-4ce1-8b33-e3864280e075" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7088", "dcec6f95-ef27-4624-b471-163fc3a0c065" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7089", "1031b0ad-59c0-4631-9ee1-47ccb2941520" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7090", "aaf84146-8c7f-4832-9b6a-b2e0bc7c573c" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7091", "d81a5aee-ae71-4d76-89cb-bebb01605087" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7092", "ef1c5acf-ba20-4059-8f3a-9d773c253cda" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7093", "62a31d0c-e7aa-47c1-9d44-1af41fc148f9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7094", "a161c452-be49-4d9c-a44b-5bf409ccc8c9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7095", "80e96de4-894d-483d-af1b-6e6bfb631dab" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7096", "40f86d7a-ba4e-4461-bd7d-9c3d7201e3b8" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7097", "c3133e18-c183-4e04-b6a3-738442866d75" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7098", "8ea2b3b6-9db8-4525-a023-a553d4cd29b1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7099", "3dcb061b-ca7f-45be-8ea2-003e8332c108" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_ID_123456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5a35960e-6402-4197-aa89-c75d6d1a161d", "AQAAAAEAACcQAAAAELwE7EV9gebLj4XN4uMnQxGTPimkv3Me9hU1MvfGCvSJstUXhJdMHNqHSLfiJv9R2Q==" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1000,
                column: "ProductPrice",
                value: 40482469.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1001,
                column: "ProductPrice",
                value: 138529631.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1002,
                column: "ProductPrice",
                value: 1425744914.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1003,
                column: "ProductPrice",
                value: 1096540113.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1004,
                column: "ProductPrice",
                value: 334869480.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1005,
                column: "ProductPrice",
                value: 1238624214.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1006,
                column: "ProductPrice",
                value: 1191703057.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1007,
                column: "ProductPrice",
                value: 2135376010.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1008,
                column: "ProductPrice",
                value: 1560131111.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1009,
                column: "ProductPrice",
                value: 561192084.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1010,
                column: "ProductPrice",
                value: 668672716.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1011,
                column: "ProductPrice",
                value: 1084829105.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1012,
                column: "ProductPrice",
                value: 1089556997.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1013,
                column: "ProductPrice",
                value: 311359140.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1014,
                column: "ProductPrice",
                value: 361341107.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1015,
                column: "ProductPrice",
                value: 930079981.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1016,
                column: "ProductPrice",
                value: 1750324715.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1017,
                column: "ProductPrice",
                value: 223811444.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1018,
                column: "ProductPrice",
                value: 483690787.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1019,
                column: "ProductPrice",
                value: 1566243559.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1020,
                column: "ProductPrice",
                value: 7824975.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1021,
                column: "ProductPrice",
                value: 441193677.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1022,
                column: "ProductPrice",
                value: 404983353.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1023,
                column: "ProductPrice",
                value: 384134101.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1024,
                column: "ProductPrice",
                value: 906951334.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1025,
                column: "ProductPrice",
                value: 1101017892.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1026,
                column: "ProductPrice",
                value: 1633276955.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1027,
                column: "ProductPrice",
                value: 974148078.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1028,
                column: "ProductPrice",
                value: 1189196742.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1029,
                column: "ProductPrice",
                value: 868404801.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1030,
                column: "ProductPrice",
                value: 1081744811.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1031,
                column: "ProductPrice",
                value: 273309575.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1032,
                column: "ProductPrice",
                value: 1127180086.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1033,
                column: "ProductPrice",
                value: 311692619.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1034,
                column: "ProductPrice",
                value: 731491632.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1035,
                column: "ProductPrice",
                value: 2055475856.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1036,
                column: "ProductPrice",
                value: 2014731808.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1037,
                column: "ProductPrice",
                value: 649921621.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1038,
                column: "ProductPrice",
                value: 1518906553.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1039,
                column: "ProductPrice",
                value: 2028299290.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1040,
                column: "ProductPrice",
                value: 51879952.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1041,
                column: "ProductPrice",
                value: 576199145.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1042,
                column: "ProductPrice",
                value: 1330246429.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1043,
                column: "ProductPrice",
                value: 784043249.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1044,
                column: "ProductPrice",
                value: 1773561559.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1045,
                column: "ProductPrice",
                value: 687332145.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1046,
                column: "ProductPrice",
                value: 1307222540.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1047,
                column: "ProductPrice",
                value: 680923046.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1048,
                column: "ProductPrice",
                value: 1880065049.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1049,
                column: "ProductPrice",
                value: 609820001.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1050,
                column: "ProductPrice",
                value: 903971180.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1051,
                column: "ProductPrice",
                value: 1150299668.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1052,
                column: "ProductPrice",
                value: 1263192468.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1053,
                column: "ProductPrice",
                value: 78984563.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1054,
                column: "ProductPrice",
                value: 1564596911.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1055,
                column: "ProductPrice",
                value: 1158884338.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1056,
                column: "ProductPrice",
                value: 1293141824.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1057,
                column: "ProductPrice",
                value: 453722712.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1058,
                column: "ProductPrice",
                value: 1749184325.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1059,
                column: "ProductPrice",
                value: 793447134.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1060,
                column: "ProductPrice",
                value: 1164942805.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1061,
                column: "ProductPrice",
                value: 1777150525.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1062,
                column: "ProductPrice",
                value: 358291167.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1063,
                column: "ProductPrice",
                value: 103838209.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1064,
                column: "ProductPrice",
                value: 1039042819.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1065,
                column: "ProductPrice",
                value: 1954958687.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1066,
                column: "ProductPrice",
                value: 1517244565.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1067,
                column: "ProductPrice",
                value: 189976277.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1068,
                column: "ProductPrice",
                value: 1139463054.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1069,
                column: "ProductPrice",
                value: 2012944444.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1070,
                column: "ProductPrice",
                value: 474943719.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1071,
                column: "ProductPrice",
                value: 512514993.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1072,
                column: "ProductPrice",
                value: 264500437.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1073,
                column: "ProductPrice",
                value: 14987043.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1074,
                column: "ProductPrice",
                value: 926475506.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1075,
                column: "ProductPrice",
                value: 991221376.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1076,
                column: "ProductPrice",
                value: 670542794.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1077,
                column: "ProductPrice",
                value: 1180535650.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1078,
                column: "ProductPrice",
                value: 170168088.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1079,
                column: "ProductPrice",
                value: 1779214735.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1080,
                column: "ProductPrice",
                value: 1353390898.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1081,
                column: "ProductPrice",
                value: 364465808.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1082,
                column: "ProductPrice",
                value: 653678575.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1083,
                column: "ProductPrice",
                value: 2138972287.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1084,
                column: "ProductPrice",
                value: 1524029167.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1085,
                column: "ProductPrice",
                value: 1491040689.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1086,
                column: "ProductPrice",
                value: 569712653.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1087,
                column: "ProductPrice",
                value: 460307422.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1088,
                column: "ProductPrice",
                value: 306691254.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1089,
                column: "ProductPrice",
                value: 1132202840.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1090,
                column: "ProductPrice",
                value: 174445931.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1091,
                column: "ProductPrice",
                value: 973120995.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1092,
                column: "ProductPrice",
                value: 460332842.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1093,
                column: "ProductPrice",
                value: 137571318.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1094,
                column: "ProductPrice",
                value: 275468384.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1095,
                column: "ProductPrice",
                value: 1981808620.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1096,
                column: "ProductPrice",
                value: 1777503524.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1097,
                column: "ProductPrice",
                value: 638520119.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1098,
                column: "ProductPrice",
                value: 1304595976.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1099,
                column: "ProductPrice",
                value: 1378198418.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1100,
                column: "ProductPrice",
                value: 729683126.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1101,
                column: "ProductPrice",
                value: 529358162.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1102,
                column: "ProductPrice",
                value: 1101055538.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1103,
                column: "ProductPrice",
                value: 1426716151.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1104,
                column: "ProductPrice",
                value: 1694471828.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1105,
                column: "ProductPrice",
                value: 1951051733.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1106,
                column: "ProductPrice",
                value: 297911130.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1107,
                column: "ProductPrice",
                value: 660317324.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1108,
                column: "ProductPrice",
                value: 712104603.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1109,
                column: "ProductPrice",
                value: 2132971081.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1110,
                column: "ProductPrice",
                value: 2047937090.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1111,
                column: "ProductPrice",
                value: 1672201720.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1112,
                column: "ProductPrice",
                value: 1843150170.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1113,
                column: "ProductPrice",
                value: 1529565136.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1114,
                column: "ProductPrice",
                value: 999651782.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1115,
                column: "ProductPrice",
                value: 212588896.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1116,
                column: "ProductPrice",
                value: 535583849.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1117,
                column: "ProductPrice",
                value: 1926398073.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1118,
                column: "ProductPrice",
                value: 139404588.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1119,
                column: "ProductPrice",
                value: 1107597676.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1120,
                column: "ProductPrice",
                value: 797357933.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1121,
                column: "ProductPrice",
                value: 469049042.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1122,
                column: "ProductPrice",
                value: 1442880569.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1123,
                column: "ProductPrice",
                value: 1566855760.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1124,
                column: "ProductPrice",
                value: 1250610412.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1125,
                column: "ProductPrice",
                value: 1061418270.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1126,
                column: "ProductPrice",
                value: 1611777697.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1127,
                column: "ProductPrice",
                value: 1686524665.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1128,
                column: "ProductPrice",
                value: 1299114205.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1129,
                column: "ProductPrice",
                value: 504262432.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1130,
                column: "ProductPrice",
                value: 773313398.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1131,
                column: "ProductPrice",
                value: 1591618221.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1132,
                column: "ProductPrice",
                value: 1435535220.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1133,
                column: "ProductPrice",
                value: 351565216.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1134,
                column: "ProductPrice",
                value: 461643508.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1135,
                column: "ProductPrice",
                value: 236144635.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1136,
                column: "ProductPrice",
                value: 823005816.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1137,
                column: "ProductPrice",
                value: 786557970.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1138,
                column: "ProductPrice",
                value: 2004096005.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1139,
                column: "ProductPrice",
                value: 1132572980.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1140,
                column: "ProductPrice",
                value: 605241458.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1141,
                column: "ProductPrice",
                value: 1468990875.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1142,
                column: "ProductPrice",
                value: 1307798365.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1143,
                column: "ProductPrice",
                value: 1880799366.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1144,
                column: "ProductPrice",
                value: 643861296.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1145,
                column: "ProductPrice",
                value: 61839757.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1146,
                column: "ProductPrice",
                value: 689566371.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1147,
                column: "ProductPrice",
                value: 490363252.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1148,
                column: "ProductPrice",
                value: 697515082.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1149,
                column: "ProductPrice",
                value: 1622475034.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1150,
                column: "ProductPrice",
                value: 858336670.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1151,
                column: "ProductPrice",
                value: 1410700997.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1152,
                column: "ProductPrice",
                value: 2058711077.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1153,
                column: "ProductPrice",
                value: 1756593846.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1154,
                column: "ProductPrice",
                value: 2140436031.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1155,
                column: "ProductPrice",
                value: 1820229630.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1156,
                column: "ProductPrice",
                value: 646073139.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1157,
                column: "ProductPrice",
                value: 1093795324.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1158,
                column: "ProductPrice",
                value: 1735701285.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1159,
                column: "ProductPrice",
                value: 45165457.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1160,
                column: "ProductPrice",
                value: 1898869582.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1161,
                column: "ProductPrice",
                value: 170982011.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1162,
                column: "ProductPrice",
                value: 920798665.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1163,
                column: "ProductPrice",
                value: 1767437717.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1164,
                column: "ProductPrice",
                value: 771769582.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1165,
                column: "ProductPrice",
                value: 2015914415.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1166,
                column: "ProductPrice",
                value: 1796262046.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1167,
                column: "ProductPrice",
                value: 903696853.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1168,
                column: "ProductPrice",
                value: 480033527.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1169,
                column: "ProductPrice",
                value: 175619046.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1170,
                column: "ProductPrice",
                value: 949178626.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1171,
                column: "ProductPrice",
                value: 1308621425.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1172,
                column: "ProductPrice",
                value: 1481897614.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1173,
                column: "ProductPrice",
                value: 566427154.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1174,
                column: "ProductPrice",
                value: 2061951764.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1175,
                column: "ProductPrice",
                value: 887962604.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1176,
                column: "ProductPrice",
                value: 720846223.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1177,
                column: "ProductPrice",
                value: 1121676749.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1178,
                column: "ProductPrice",
                value: 335106363.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1179,
                column: "ProductPrice",
                value: 600882554.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1180,
                column: "ProductPrice",
                value: 1931447445.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1181,
                column: "ProductPrice",
                value: 533526344.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1182,
                column: "ProductPrice",
                value: 401121482.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1183,
                column: "ProductPrice",
                value: 1236234717.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1184,
                column: "ProductPrice",
                value: 1205521308.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1185,
                column: "ProductPrice",
                value: 922207947.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1186,
                column: "ProductPrice",
                value: 1092502690.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1187,
                column: "ProductPrice",
                value: 1238536920.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1188,
                column: "ProductPrice",
                value: 1918208378.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1189,
                column: "ProductPrice",
                value: 201009424.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1190,
                column: "ProductPrice",
                value: 1149667042.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1191,
                column: "ProductPrice",
                value: 1288806038.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1192,
                column: "ProductPrice",
                value: 610452231.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1193,
                column: "ProductPrice",
                value: 1371042447.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1194,
                column: "ProductPrice",
                value: 793298944.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1195,
                column: "ProductPrice",
                value: 1993854993.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1196,
                column: "ProductPrice",
                value: 2107787756.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1197,
                column: "ProductPrice",
                value: 1099956194.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1198,
                column: "ProductPrice",
                value: 521141683.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1199,
                column: "ProductPrice",
                value: 187542427.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1200,
                column: "ProductPrice",
                value: 1972656904.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1201,
                column: "ProductPrice",
                value: 1345465064.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1202,
                column: "ProductPrice",
                value: 1569925271.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1203,
                column: "ProductPrice",
                value: 2081491582.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1204,
                column: "ProductPrice",
                value: 85408307.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1205,
                column: "ProductPrice",
                value: 1109310791.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1206,
                column: "ProductPrice",
                value: 1488398929.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1207,
                column: "ProductPrice",
                value: 904395822.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1208,
                column: "ProductPrice",
                value: 1254237628.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1209,
                column: "ProductPrice",
                value: 664585326.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1210,
                column: "ProductPrice",
                value: 511495306.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1211,
                column: "ProductPrice",
                value: 1083991936.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1212,
                column: "ProductPrice",
                value: 170800860.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1213,
                column: "ProductPrice",
                value: 546930630.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1214,
                column: "ProductPrice",
                value: 1820797205.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1215,
                column: "ProductPrice",
                value: 777455137.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1216,
                column: "ProductPrice",
                value: 1329456075.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1217,
                column: "ProductPrice",
                value: 1244159494.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1218,
                column: "ProductPrice",
                value: 2121511955.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1219,
                column: "ProductPrice",
                value: 1409157181.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1220,
                column: "ProductPrice",
                value: 335523624.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1221,
                column: "ProductPrice",
                value: 2117320672.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1222,
                column: "ProductPrice",
                value: 545084021.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1223,
                column: "ProductPrice",
                value: 1838619649.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1224,
                column: "ProductPrice",
                value: 585547550.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1225,
                column: "ProductPrice",
                value: 1219968134.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1226,
                column: "ProductPrice",
                value: 110281093.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1227,
                column: "ProductPrice",
                value: 1670450713.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1228,
                column: "ProductPrice",
                value: 1332723756.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1229,
                column: "ProductPrice",
                value: 1627692317.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1230,
                column: "ProductPrice",
                value: 339770394.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1231,
                column: "ProductPrice",
                value: 1180485575.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1232,
                column: "ProductPrice",
                value: 12646965.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1233,
                column: "ProductPrice",
                value: 1707159482.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1234,
                column: "ProductPrice",
                value: 187821196.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1235,
                column: "ProductPrice",
                value: 2145577927.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1236,
                column: "ProductPrice",
                value: 523196619.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1237,
                column: "ProductPrice",
                value: 2026709093.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1238,
                column: "ProductPrice",
                value: 562938309.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1239,
                column: "ProductPrice",
                value: 1655806063.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1240,
                column: "ProductPrice",
                value: 993404564.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1241,
                column: "ProductPrice",
                value: 1747702414.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1242,
                column: "ProductPrice",
                value: 1543894838.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1243,
                column: "ProductPrice",
                value: 665734951.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1244,
                column: "ProductPrice",
                value: 1249109664.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1245,
                column: "ProductPrice",
                value: 1625270652.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1246,
                column: "ProductPrice",
                value: 530117077.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1247,
                column: "ProductPrice",
                value: 1623117147.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1248,
                column: "ProductPrice",
                value: 1109840788.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1249,
                column: "ProductPrice",
                value: 1575439353.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1250,
                column: "ProductPrice",
                value: 76510817.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1251,
                column: "ProductPrice",
                value: 275740161.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1252,
                column: "ProductPrice",
                value: 538039785.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1253,
                column: "ProductPrice",
                value: 671580048.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1254,
                column: "ProductPrice",
                value: 1411614349.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1255,
                column: "ProductPrice",
                value: 1414931778.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1256,
                column: "ProductPrice",
                value: 212492942.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1257,
                column: "ProductPrice",
                value: 1290901168.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1258,
                column: "ProductPrice",
                value: 908055931.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1259,
                column: "ProductPrice",
                value: 425035719.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1260,
                column: "ProductPrice",
                value: 411141597.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1261,
                column: "ProductPrice",
                value: 1377543762.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1262,
                column: "ProductPrice",
                value: 1131267612.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1263,
                column: "ProductPrice",
                value: 1186140857.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1264,
                column: "ProductPrice",
                value: 1884410478.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1265,
                column: "ProductPrice",
                value: 890605277.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1266,
                column: "ProductPrice",
                value: 483456870.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1267,
                column: "ProductPrice",
                value: 23236924.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1268,
                column: "ProductPrice",
                value: 1918704980.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1269,
                column: "ProductPrice",
                value: 1234814824.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1270,
                column: "ProductPrice",
                value: 1813854064.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1271,
                column: "ProductPrice",
                value: 862342528.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1272,
                column: "ProductPrice",
                value: 93333084.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1273,
                column: "ProductPrice",
                value: 2025301438.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1274,
                column: "ProductPrice",
                value: 1975348163.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1275,
                column: "ProductPrice",
                value: 147416756.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1276,
                column: "ProductPrice",
                value: 2133021380.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1277,
                column: "ProductPrice",
                value: 1438944616.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1278,
                column: "ProductPrice",
                value: 1621884.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1279,
                column: "ProductPrice",
                value: 519872444.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1280,
                column: "ProductPrice",
                value: 101962956.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1281,
                column: "ProductPrice",
                value: 46759492.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1282,
                column: "ProductPrice",
                value: 2120205471.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1283,
                column: "ProductPrice",
                value: 1316879949.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1284,
                column: "ProductPrice",
                value: 963293399.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1285,
                column: "ProductPrice",
                value: 1623625779.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1286,
                column: "ProductPrice",
                value: 54557689.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1287,
                column: "ProductPrice",
                value: 900662463.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1288,
                column: "ProductPrice",
                value: 1855140679.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1289,
                column: "ProductPrice",
                value: 332484964.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1290,
                column: "ProductPrice",
                value: 1345196884.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1291,
                column: "ProductPrice",
                value: 791890997.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1292,
                column: "ProductPrice",
                value: 530765061.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1293,
                column: "ProductPrice",
                value: 1697498136.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1294,
                column: "ProductPrice",
                value: 656776365.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1295,
                column: "ProductPrice",
                value: 1175456348.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1296,
                column: "ProductPrice",
                value: 28546701.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1297,
                column: "ProductPrice",
                value: 1917349527.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1298,
                column: "ProductPrice",
                value: 340920019.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1299,
                column: "ProductPrice",
                value: 1918099933.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1300,
                column: "ProductPrice",
                value: 553925681.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1301,
                column: "ProductPrice",
                value: 2066475699.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1302,
                column: "ProductPrice",
                value: 1264007713.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1303,
                column: "ProductPrice",
                value: 1434621510.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1304,
                column: "ProductPrice",
                value: 1321180835.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1305,
                column: "ProductPrice",
                value: 773763835.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1306,
                column: "ProductPrice",
                value: 1742002623.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1307,
                column: "ProductPrice",
                value: 72333893.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1308,
                column: "ProductPrice",
                value: 255827431.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1309,
                column: "ProductPrice",
                value: 676309492.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1310,
                column: "ProductPrice",
                value: 841505944.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1311,
                column: "ProductPrice",
                value: 333143872.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1312,
                column: "ProductPrice",
                value: 701391183.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1313,
                column: "ProductPrice",
                value: 1947779033.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1314,
                column: "ProductPrice",
                value: 1882668309.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1315,
                column: "ProductPrice",
                value: 1923977651.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1316,
                column: "ProductPrice",
                value: 816933837.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1317,
                column: "ProductPrice",
                value: 1373983209.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1318,
                column: "ProductPrice",
                value: 1782443004.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1319,
                column: "ProductPrice",
                value: 1820380245.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1320,
                column: "ProductPrice",
                value: 248159487.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1321,
                column: "ProductPrice",
                value: 1142389953.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1322,
                column: "ProductPrice",
                value: 1875175438.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1323,
                column: "ProductPrice",
                value: 998331915.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1324,
                column: "ProductPrice",
                value: 1449213486.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1325,
                column: "ProductPrice",
                value: 434074966.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1326,
                column: "ProductPrice",
                value: 1891173013.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1327,
                column: "ProductPrice",
                value: 2102914141.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1328,
                column: "ProductPrice",
                value: 780636972.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1329,
                column: "ProductPrice",
                value: 212003714.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1330,
                column: "ProductPrice",
                value: 1678465601.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1331,
                column: "ProductPrice",
                value: 1775267399.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1332,
                column: "ProductPrice",
                value: 510136496.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1333,
                column: "ProductPrice",
                value: 1790601144.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1334,
                column: "ProductPrice",
                value: 1525542309.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1335,
                column: "ProductPrice",
                value: 1742566450.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1336,
                column: "ProductPrice",
                value: 342347325.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1337,
                column: "ProductPrice",
                value: 97695860.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1338,
                column: "ProductPrice",
                value: 1555294660.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1339,
                column: "ProductPrice",
                value: 1749125110.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1340,
                column: "ProductPrice",
                value: 1441218702.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1341,
                column: "ProductPrice",
                value: 1541819342.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1342,
                column: "ProductPrice",
                value: 56946931.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1343,
                column: "ProductPrice",
                value: 590943086.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1344,
                column: "ProductPrice",
                value: 1050574566.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1345,
                column: "ProductPrice",
                value: 424164911.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1346,
                column: "ProductPrice",
                value: 1650095360.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1347,
                column: "ProductPrice",
                value: 142581574.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1348,
                column: "ProductPrice",
                value: 1374425373.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1349,
                column: "ProductPrice",
                value: 292394260.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1350,
                column: "ProductPrice",
                value: 1918118057.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1351,
                column: "ProductPrice",
                value: 214159038.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1352,
                column: "ProductPrice",
                value: 1694502069.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1353,
                column: "ProductPrice",
                value: 80135320.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1354,
                column: "ProductPrice",
                value: 1082052345.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1355,
                column: "ProductPrice",
                value: 971131274.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1356,
                column: "ProductPrice",
                value: 1750895807.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1357,
                column: "ProductPrice",
                value: 1825271344.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1358,
                column: "ProductPrice",
                value: 1545003570.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1359,
                column: "ProductPrice",
                value: 299217768.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1360,
                column: "ProductPrice",
                value: 442186368.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1361,
                column: "ProductPrice",
                value: 1198684028.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1362,
                column: "ProductPrice",
                value: 851292467.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1363,
                column: "ProductPrice",
                value: 1603419263.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1364,
                column: "ProductPrice",
                value: 557439437.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1365,
                column: "ProductPrice",
                value: 625834091.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1366,
                column: "ProductPrice",
                value: 1382602922.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1367,
                column: "ProductPrice",
                value: 470385585.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1368,
                column: "ProductPrice",
                value: 1981832270.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1369,
                column: "ProductPrice",
                value: 1699697405.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1370,
                column: "ProductPrice",
                value: 993742225.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1371,
                column: "ProductPrice",
                value: 131349876.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1372,
                column: "ProductPrice",
                value: 1378284095.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1373,
                column: "ProductPrice",
                value: 1592913440.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1374,
                column: "ProductPrice",
                value: 1938757089.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1375,
                column: "ProductPrice",
                value: 265935691.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1376,
                column: "ProductPrice",
                value: 497554921.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1377,
                column: "ProductPrice",
                value: 696344251.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1378,
                column: "ProductPrice",
                value: 1507352895.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1379,
                column: "ProductPrice",
                value: 437160474.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1380,
                column: "ProductPrice",
                value: 343575152.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1381,
                column: "ProductPrice",
                value: 1160703338.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1382,
                column: "ProductPrice",
                value: 140600667.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1383,
                column: "ProductPrice",
                value: 2047838258.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1384,
                column: "ProductPrice",
                value: 2000964850.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1385,
                column: "ProductPrice",
                value: 876418462.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1386,
                column: "ProductPrice",
                value: 1640360876.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1387,
                column: "ProductPrice",
                value: 1989596722.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1388,
                column: "ProductPrice",
                value: 120660698.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1389,
                column: "ProductPrice",
                value: 2114006581.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1390,
                column: "ProductPrice",
                value: 1551266189.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1391,
                column: "ProductPrice",
                value: 76671527.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1392,
                column: "ProductPrice",
                value: 112287836.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1393,
                column: "ProductPrice",
                value: 668188791.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1394,
                column: "ProductPrice",
                value: 719050641.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1395,
                column: "ProductPrice",
                value: 1802130220.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1396,
                column: "ProductPrice",
                value: 102638774.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1397,
                column: "ProductPrice",
                value: 13123214.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1398,
                column: "ProductPrice",
                value: 1593099195.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1399,
                column: "ProductPrice",
                value: 1984336021.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1400,
                column: "ProductPrice",
                value: 601157535.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1401,
                column: "ProductPrice",
                value: 591821674.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1402,
                column: "ProductPrice",
                value: 1867828497.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1403,
                column: "ProductPrice",
                value: 1234323514.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1404,
                column: "ProductPrice",
                value: 858247581.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1405,
                column: "ProductPrice",
                value: 1198880080.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1406,
                column: "ProductPrice",
                value: 395470489.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1407,
                column: "ProductPrice",
                value: 1661184175.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1408,
                column: "ProductPrice",
                value: 1848457424.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1409,
                column: "ProductPrice",
                value: 228228553.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1410,
                column: "ProductPrice",
                value: 2033171899.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1411,
                column: "ProductPrice",
                value: 466663455.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1412,
                column: "ProductPrice",
                value: 1877513995.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1413,
                column: "ProductPrice",
                value: 519954995.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1414,
                column: "ProductPrice",
                value: 1515238162.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1415,
                column: "ProductPrice",
                value: 841078576.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1416,
                column: "ProductPrice",
                value: 470195260.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1417,
                column: "ProductPrice",
                value: 363049755.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1418,
                column: "ProductPrice",
                value: 1162049959.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1419,
                column: "ProductPrice",
                value: 1240616521.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1420,
                column: "ProductPrice",
                value: 545068761.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1421,
                column: "ProductPrice",
                value: 952601746.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1422,
                column: "ProductPrice",
                value: 1909320433.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1423,
                column: "ProductPrice",
                value: 1427421235.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1424,
                column: "ProductPrice",
                value: 1708026762.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1425,
                column: "ProductPrice",
                value: 329182597.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1426,
                column: "ProductPrice",
                value: 1578657586.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1427,
                column: "ProductPrice",
                value: 122207203.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1428,
                column: "ProductPrice",
                value: 285974698.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1429,
                column: "ProductPrice",
                value: 1696222415.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1430,
                column: "ProductPrice",
                value: 1722892463.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1431,
                column: "ProductPrice",
                value: 2044027253.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1432,
                column: "ProductPrice",
                value: 662840602.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1433,
                column: "ProductPrice",
                value: 1082612420.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1434,
                column: "ProductPrice",
                value: 1395598485.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1435,
                column: "ProductPrice",
                value: 1311349024.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1436,
                column: "ProductPrice",
                value: 852470387.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1437,
                column: "ProductPrice",
                value: 465872699.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1438,
                column: "ProductPrice",
                value: 601702576.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1439,
                column: "ProductPrice",
                value: 214196669.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1440,
                column: "ProductPrice",
                value: 2040543519.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1441,
                column: "ProductPrice",
                value: 1538772247.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1442,
                column: "ProductPrice",
                value: 1700734844.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1443,
                column: "ProductPrice",
                value: 1452027691.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1444,
                column: "ProductPrice",
                value: 1640430228.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1445,
                column: "ProductPrice",
                value: 496714633.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1446,
                column: "ProductPrice",
                value: 1906236725.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1447,
                column: "ProductPrice",
                value: 1151928387.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1448,
                column: "ProductPrice",
                value: 712546175.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1449,
                column: "ProductPrice",
                value: 1437567611.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1450,
                column: "ProductPrice",
                value: 744046859.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1451,
                column: "ProductPrice",
                value: 1299184565.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1452,
                column: "ProductPrice",
                value: 410668801.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1453,
                column: "ProductPrice",
                value: 1912078220.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1454,
                column: "ProductPrice",
                value: 851379159.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1455,
                column: "ProductPrice",
                value: 1208151335.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1456,
                column: "ProductPrice",
                value: 242096787.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1457,
                column: "ProductPrice",
                value: 2000002808.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1458,
                column: "ProductPrice",
                value: 1085892298.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1459,
                column: "ProductPrice",
                value: 2088660530.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1460,
                column: "ProductPrice",
                value: 1179818040.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1461,
                column: "ProductPrice",
                value: 1832858832.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1462,
                column: "ProductPrice",
                value: 787321376.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1463,
                column: "ProductPrice",
                value: 1711830555.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1464,
                column: "ProductPrice",
                value: 64931636.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1465,
                column: "ProductPrice",
                value: 1548740192.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1466,
                column: "ProductPrice",
                value: 1363418399.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1467,
                column: "ProductPrice",
                value: 207013474.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1468,
                column: "ProductPrice",
                value: 683952056.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1469,
                column: "ProductPrice",
                value: 1763484684.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1470,
                column: "ProductPrice",
                value: 1548203735.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1471,
                column: "ProductPrice",
                value: 1563918107.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1472,
                column: "ProductPrice",
                value: 1320942725.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1473,
                column: "ProductPrice",
                value: 359965189.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1474,
                column: "ProductPrice",
                value: 759668548.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1475,
                column: "ProductPrice",
                value: 565892060.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1476,
                column: "ProductPrice",
                value: 811462448.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1477,
                column: "ProductPrice",
                value: 2016888288.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1478,
                column: "ProductPrice",
                value: 1346586553.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1479,
                column: "ProductPrice",
                value: 623424028.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1480,
                column: "ProductPrice",
                value: 2130025065.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1481,
                column: "ProductPrice",
                value: 1986324745.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1482,
                column: "ProductPrice",
                value: 969256574.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1483,
                column: "ProductPrice",
                value: 408002633.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1484,
                column: "ProductPrice",
                value: 364287455.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1485,
                column: "ProductPrice",
                value: 1983303444.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1486,
                column: "ProductPrice",
                value: 1045470351.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1487,
                column: "ProductPrice",
                value: 310357928.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1488,
                column: "ProductPrice",
                value: 1790828807.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1489,
                column: "ProductPrice",
                value: 1747042696.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1490,
                column: "ProductPrice",
                value: 481364136.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1491,
                column: "ProductPrice",
                value: 412063125.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1492,
                column: "ProductPrice",
                value: 939575947.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1493,
                column: "ProductPrice",
                value: 72637592.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1494,
                column: "ProductPrice",
                value: 593974175.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1495,
                column: "ProductPrice",
                value: 1767280233.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1496,
                column: "ProductPrice",
                value: 163562770.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1497,
                column: "ProductPrice",
                value: 1548499835.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1498,
                column: "ProductPrice",
                value: 799207954.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1499,
                column: "ProductPrice",
                value: 1651285582.0);
        }
    }
}

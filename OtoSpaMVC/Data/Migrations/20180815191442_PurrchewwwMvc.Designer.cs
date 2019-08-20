﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OtoSpaMVC.Data;

namespace OtoSpaMVC.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180815191442_PurrchewwwMvc")]
    partial class PurrchewwwMvc
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("OtoSpaMVC.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new { Id = "admin_ID_123456789", AccessFailedCount = 0, ConcurrencyStamp = "2ee20510-253e-4d19-910b-a9ee3be381a2", Email = "admin@oto.spa", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEAMe4pD+2ol2euFK6b+XqOe6nTyPZMm5adZUfM0RReXKBMhA9ywRqoxMlPy2dZlWHQ==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "admin" },
                        new { Id = "rt_7000", AccessFailedCount = 0, ConcurrencyStamp = "056d8724-24e7-4049-85c2-17b0e9476680", Email = "rt_7000@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEFoB/r4Rcp66suzpFIM0nwOlFr5CzrazYV+lET3e1jeOymykPcmysNtGtuLwOgHDgw==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7000" },
                        new { Id = "rt_7001", AccessFailedCount = 0, ConcurrencyStamp = "581acdee-7a8c-4e6e-bae5-f9b44a9f7d44", Email = "rt_7001@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEHySoSzU28jbFQvFu9BM8V+LSh6z51VkqOgj0PtleEDM0HtO6K7F7Y5TCiObmtASAw==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7001" },
                        new { Id = "rt_7002", AccessFailedCount = 0, ConcurrencyStamp = "20660f10-f0b0-45d1-91a2-701884e65f83", Email = "rt_7002@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEJ647eS1YaAlrog8di3U6qLJkCSq8eFsu3Tr3rIbNQGcNyfy9zI47P11BcXP1QJVuQ==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7002" },
                        new { Id = "rt_7003", AccessFailedCount = 0, ConcurrencyStamp = "d9d6440d-2048-4959-b8fc-2123bacefb9f", Email = "rt_7003@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAECcu/bV8H+zj3eSyjsxMVlpJwwv1fIx3SLP8okGr8FBRq+jdi/+KI9FWkSJPnMEyZw==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7003" },
                        new { Id = "rt_7004", AccessFailedCount = 0, ConcurrencyStamp = "eee33838-6531-4065-83ef-25f80999b817", Email = "rt_7004@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEOkvhRiYN7Em2gsrQX5F4AxuBbMD95ukp9CQqepgGuyqk3WJhZxMOH36qTJmoyHlIg==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7004" },
                        new { Id = "rt_7005", AccessFailedCount = 0, ConcurrencyStamp = "6e297e5c-8da2-4e9e-93a5-2bf082be1a78", Email = "rt_7005@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEAke87Rx0GC2OIPBp6Q2ikh6LjOa0pnFIhQAdxavexhCVilUBxFJNUp8qkeLHDqGLw==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7005" },
                        new { Id = "rt_7006", AccessFailedCount = 0, ConcurrencyStamp = "8033cf2a-9c24-4a28-a810-57f1b771d0b8", Email = "rt_7006@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEM56yb1C4jYKlhd4RPinWAlhZ46u0AepO276Sq4Yto2nxnofx9rRa8VeNOaXhCRwjA==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7006" },
                        new { Id = "rt_7007", AccessFailedCount = 0, ConcurrencyStamp = "43601907-055c-4e0a-bb9b-d24991f1eb5c", Email = "rt_7007@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEDIFIR8pDaYRJrpvdnYLKCMrEYhUKrGknhK0JZyDOV5mEFjXdZLFPeCgnPzaur/6nw==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7007" },
                        new { Id = "rt_7008", AccessFailedCount = 0, ConcurrencyStamp = "c9fa661f-eae2-4c5d-8b33-0f008de87860", Email = "rt_7008@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEM0Ek+rUlTBfNXQTuYuUUgOxsF1xk+5K5Tm8ihIwRhir3HP16nZyQH/ZEjacLDmQ3g==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7008" },
                        new { Id = "rt_7009", AccessFailedCount = 0, ConcurrencyStamp = "c162a46b-f292-4a37-9a20-e78de70fd5fb", Email = "rt_7009@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAENwRs4p9m6CftreVvb+Fxg/F5ntqBaaWPQbAs+aO4Prz+Pssm+Kw+8/o2Jb48Ni1EA==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7009" },
                        new { Id = "rt_7010", AccessFailedCount = 0, ConcurrencyStamp = "9491ef51-7532-4f57-aad0-eb4c3da330c7", Email = "rt_7010@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEMcDMNa1EC8H8hwziVOjgQ7h7HZeqrVwSpzdSuZmk8BmivPWTO8/8ZKiT0Ac72UpjA==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7010" },
                        new { Id = "rt_7011", AccessFailedCount = 0, ConcurrencyStamp = "385463fd-96e8-456a-bf4b-fa6565e9cec3", Email = "rt_7011@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEKPqon3M8b3+d77qyQJWwvduO5U+xbTflH/WnpRQAA6xSPNb5UFPLdt8Qr+6Wnph6A==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7011" },
                        new { Id = "rt_7012", AccessFailedCount = 0, ConcurrencyStamp = "e2d74fa0-0c19-4d24-9a99-211e87c3085f", Email = "rt_7012@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEFPiAes02m/xGx6gXrZZgDU6YEvfXO29cwZhOpm3iywE8vjE6IpQNwyCNo7NNvhCJw==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7012" },
                        new { Id = "rt_7013", AccessFailedCount = 0, ConcurrencyStamp = "e1200c18-022d-407d-b2a8-e34712ac3160", Email = "rt_7013@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEIvOYPxLeE2Il4G/k01b+rX7Bms2IJNJsD0LF9g9jkN0clOy4dT/qXP8mMY2FQHTQg==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7013" },
                        new { Id = "rt_7014", AccessFailedCount = 0, ConcurrencyStamp = "b43ef0c1-3c38-4777-895e-5f8fde87d82e", Email = "rt_7014@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAELMf4XibBxQib5q8uDIzR/AQcXAEXC1uPBCpKCgz16z9nX8wHhiqfbDYoTTF1t9tXA==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7014" },
                        new { Id = "rt_7015", AccessFailedCount = 0, ConcurrencyStamp = "5d5570db-824c-447f-8e4f-aefad89c6250", Email = "rt_7015@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAELVGORqpjdk+LGae9/U5SxESg9H0Bk9rXn7XuMYGCujInjFTGLLIFKBnGHUhdCTjTQ==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7015" },
                        new { Id = "rt_7016", AccessFailedCount = 0, ConcurrencyStamp = "8f8b1d05-dfa7-4a15-a6f7-137aac0cd28b", Email = "rt_7016@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEEksdknd1ZPzMz+vCI3YXnYPrj7Aa8lSBpcva3IQybeOgIgInF2TS5e/UWaIbI5DgQ==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7016" },
                        new { Id = "rt_7017", AccessFailedCount = 0, ConcurrencyStamp = "baccab73-db6b-47a5-a4c7-bc075b553e0b", Email = "rt_7017@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEOmGrA5PYmEnbTZkhozRDwhZ+haFXXYqQENub9jk4ChY81MGvCDahNI+eyfpqrfgbg==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7017" },
                        new { Id = "rt_7018", AccessFailedCount = 0, ConcurrencyStamp = "73b0a5d4-ff2e-4b16-b7a8-ffc452a29f20", Email = "rt_7018@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEJa2q0rsGClsBj6+uuAuSIMch9x4MlvvSTSStRhvUndDT1DIsbGKTRCgC5JdE+gORQ==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7018" },
                        new { Id = "rt_7019", AccessFailedCount = 0, ConcurrencyStamp = "58b93d98-d6ee-4232-85f5-2fbcde8df6a6", Email = "rt_7019@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEABkRlgfHxWNYEVZrBmeOq5Nv/nHLrFkglAnciAe89DBimcKw7ecCJumlFlNg7PpLQ==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7019" }
                    );
                });

            modelBuilder.Entity("OtoSpaMVC.Models.Cart", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Editable");

                    b.Property<int>("Total");

                    b.Property<string>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Cart");

                    b.HasData(
                        new { ID = 13, Editable = true, Total = 2, UserID = "admin_ID_123456789" }
                    );
                });

            modelBuilder.Entity("OtoSpaMVC.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Category");

                    b.HasData(
                        new { ID = 7, Name = "Car Accessories" },
                        new { ID = 8, Name = "Cleaning Products" }
                    );
                });

            modelBuilder.Entity("OtoSpaMVC.Models.ContactUs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactHeader")
                        .HasMaxLength(160);

                    b.Property<string>("Content")
                        .HasMaxLength(160);

                    b.Property<string>("Email")
                        .HasMaxLength(20);

                    b.Property<string>("Phone")
                        .HasMaxLength(15);

                    b.Property<bool>("Responded");

                    b.HasKey("ID");

                    b.ToTable("ContactUs");

                    b.HasData(
                        new { ID = 123, ContactHeader = "Hi", Content = "How Is Business Going?", Responded = false }
                    );
                });

            modelBuilder.Entity("OtoSpaMVC.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductName");

                    b.Property<double>("ProductPrice");

                    b.Property<string>("URIImage");

                    b.HasKey("ID");

                    b.ToTable("Product");

                    b.HasData(
                        new { ID = 1000, ProductName = "Prod_0", ProductPrice = 1215414024.0 },
                        new { ID = 1001, ProductName = "Prod_1", ProductPrice = 111749911.0 },
                        new { ID = 1002, ProductName = "Prod_2", ProductPrice = 1624495037.0 },
                        new { ID = 1003, ProductName = "Prod_3", ProductPrice = 67919352.0 },
                        new { ID = 1004, ProductName = "Prod_4", ProductPrice = 1010628706.0 },
                        new { ID = 1005, ProductName = "Prod_5", ProductPrice = 1905143936.0 },
                        new { ID = 1006, ProductName = "Prod_6", ProductPrice = 870984371.0 },
                        new { ID = 1007, ProductName = "Prod_7", ProductPrice = 1148232627.0 },
                        new { ID = 1008, ProductName = "Prod_8", ProductPrice = 768837909.0 },
                        new { ID = 1009, ProductName = "Prod_9", ProductPrice = 4814566.0 },
                        new { ID = 1010, ProductName = "Prod_10", ProductPrice = 789916577.0 },
                        new { ID = 1011, ProductName = "Prod_11", ProductPrice = 1567519889.0 },
                        new { ID = 1012, ProductName = "Prod_12", ProductPrice = 806660093.0 },
                        new { ID = 1013, ProductName = "Prod_13", ProductPrice = 1175045353.0 },
                        new { ID = 1014, ProductName = "Prod_14", ProductPrice = 1189570702.0 },
                        new { ID = 1015, ProductName = "Prod_15", ProductPrice = 676812698.0 },
                        new { ID = 1016, ProductName = "Prod_16", ProductPrice = 1483680365.0 },
                        new { ID = 1017, ProductName = "Prod_17", ProductPrice = 1304213498.0 },
                        new { ID = 1018, ProductName = "Prod_18", ProductPrice = 2017789626.0 },
                        new { ID = 1019, ProductName = "Prod_19", ProductPrice = 309705985.0 },
                        new { ID = 1020, ProductName = "Prod_20", ProductPrice = 1754547735.0 },
                        new { ID = 1021, ProductName = "Prod_21", ProductPrice = 1380902479.0 },
                        new { ID = 1022, ProductName = "Prod_22", ProductPrice = 1530747396.0 },
                        new { ID = 1023, ProductName = "Prod_23", ProductPrice = 1480724440.0 },
                        new { ID = 1024, ProductName = "Prod_24", ProductPrice = 1761962685.0 },
                        new { ID = 1025, ProductName = "Prod_25", ProductPrice = 1630811322.0 },
                        new { ID = 1026, ProductName = "Prod_26", ProductPrice = 135486375.0 },
                        new { ID = 1027, ProductName = "Prod_27", ProductPrice = 619260798.0 },
                        new { ID = 1028, ProductName = "Prod_28", ProductPrice = 844236686.0 },
                        new { ID = 1029, ProductName = "Prod_29", ProductPrice = 1964203434.0 },
                        new { ID = 1030, ProductName = "Prod_30", ProductPrice = 823281771.0 },
                        new { ID = 1031, ProductName = "Prod_31", ProductPrice = 524876997.0 },
                        new { ID = 1032, ProductName = "Prod_32", ProductPrice = 1059580206.0 },
                        new { ID = 1033, ProductName = "Prod_33", ProductPrice = 771812765.0 },
                        new { ID = 1034, ProductName = "Prod_34", ProductPrice = 1404671909.0 },
                        new { ID = 1035, ProductName = "Prod_35", ProductPrice = 1671873123.0 },
                        new { ID = 1036, ProductName = "Prod_36", ProductPrice = 742769493.0 },
                        new { ID = 1037, ProductName = "Prod_37", ProductPrice = 1909651340.0 },
                        new { ID = 1038, ProductName = "Prod_38", ProductPrice = 1880956664.0 },
                        new { ID = 1039, ProductName = "Prod_39", ProductPrice = 743213030.0 },
                        new { ID = 1040, ProductName = "Prod_40", ProductPrice = 1595826472.0 },
                        new { ID = 1041, ProductName = "Prod_41", ProductPrice = 1980623962.0 },
                        new { ID = 1042, ProductName = "Prod_42", ProductPrice = 472849609.0 },
                        new { ID = 1043, ProductName = "Prod_43", ProductPrice = 1400947379.0 },
                        new { ID = 1044, ProductName = "Prod_44", ProductPrice = 1028756229.0 },
                        new { ID = 1045, ProductName = "Prod_45", ProductPrice = 317598246.0 },
                        new { ID = 1046, ProductName = "Prod_46", ProductPrice = 726891516.0 },
                        new { ID = 1047, ProductName = "Prod_47", ProductPrice = 1106423073.0 },
                        new { ID = 1048, ProductName = "Prod_48", ProductPrice = 49988840.0 },
                        new { ID = 1049, ProductName = "Prod_49", ProductPrice = 264745885.0 }
                    );
                });

            modelBuilder.Entity("OtoSpaMVC.Models.Purchase", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreditDetails");

                    b.Property<string>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Purchase");

                    b.HasData(
                        new { ID = 15, CreditDetails = "YOOOLLLLOOOO", UserID = "admin_ID_123456789" }
                    );
                });

            modelBuilder.Entity("OtoSpaMVC.Models.Rating", b =>
                {
                    b.Property<int>("ProductID");

                    b.Property<string>("UserID");

                    b.Property<int>("ID");

                    b.Property<int>("ProductRating");

                    b.HasKey("ProductID", "UserID");

                    b.HasIndex("UserID");

                    b.ToTable("Rating");

                    b.HasData(
                        new { ProductID = 1007, UserID = "rt_7000", ID = 7000, ProductRating = 1 },
                        new { ProductID = 1007, UserID = "rt_7001", ID = 7001, ProductRating = 2 },
                        new { ProductID = 1007, UserID = "rt_7002", ID = 7002, ProductRating = 3 },
                        new { ProductID = 1007, UserID = "rt_7003", ID = 7003, ProductRating = 4 },
                        new { ProductID = 1007, UserID = "rt_7004", ID = 7004, ProductRating = 5 },
                        new { ProductID = 1007, UserID = "rt_7005", ID = 7005, ProductRating = 1 },
                        new { ProductID = 1007, UserID = "rt_7006", ID = 7006, ProductRating = 2 },
                        new { ProductID = 1007, UserID = "rt_7007", ID = 7007, ProductRating = 3 },
                        new { ProductID = 1007, UserID = "rt_7008", ID = 7008, ProductRating = 4 },
                        new { ProductID = 1007, UserID = "rt_7009", ID = 7009, ProductRating = 5 },
                        new { ProductID = 1007, UserID = "rt_7010", ID = 7010, ProductRating = 1 },
                        new { ProductID = 1007, UserID = "rt_7011", ID = 7011, ProductRating = 2 },
                        new { ProductID = 1007, UserID = "rt_7012", ID = 7012, ProductRating = 3 },
                        new { ProductID = 1007, UserID = "rt_7013", ID = 7013, ProductRating = 4 },
                        new { ProductID = 1007, UserID = "rt_7014", ID = 7014, ProductRating = 5 },
                        new { ProductID = 1007, UserID = "rt_7015", ID = 7015, ProductRating = 1 },
                        new { ProductID = 1007, UserID = "rt_7016", ID = 7016, ProductRating = 2 },
                        new { ProductID = 1007, UserID = "rt_7017", ID = 7017, ProductRating = 3 },
                        new { ProductID = 1007, UserID = "rt_7018", ID = 7018, ProductRating = 4 },
                        new { ProductID = 1007, UserID = "rt_7019", ID = 7019, ProductRating = 5 },
                        new { ProductID = 111, UserID = "admin_ID_123456789", ID = 16, ProductRating = 1 }
                    );
                });

            modelBuilder.Entity("OtoSpaMVC.Models.SeconderyModels.CartItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<int>("CartID");

                    b.Property<int>("ProductID");

                    b.Property<int?>("PurchaseID");

                    b.HasKey("ID");

                    b.HasIndex("CartID");

                    b.HasIndex("ProductID");

                    b.HasIndex("PurchaseID");

                    b.ToTable("CartItem");

                    b.HasData(
                        new { ID = 14, Amount = 1, CartID = 13, ProductID = 111 }
                    );
                });

            modelBuilder.Entity("OtoSpaMVC.Models.SeconderyModels.ProductCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID");

                    b.Property<int>("ProductID");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("ProductID");

                    b.ToTable("ProductCategory");

                    b.HasData(
                        new { ID = 17, CategoryID = 7, ProductID = 222 }
                    );
                });

            modelBuilder.Entity("OtoSpaMVC.Models.SeconderyModels.ProductSupplier", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductID");

                    b.Property<int>("SupplierID");

                    b.HasKey("ID");

                    b.HasIndex("ProductID");

                    b.HasIndex("SupplierID");

                    b.ToTable("ProductSupplier");

                    b.HasData(
                        new { ID = 18, ProductID = 111, SupplierID = 11 }
                    );
                });

            modelBuilder.Entity("OtoSpaMVC.Models.Supplier", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Contact");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("Website");

                    b.HasKey("ID");

                    b.ToTable("Supplier");

                    b.HasData(
                        new { ID = 11, Address = "lilach 99", Contact = "gil", Email = "gil@ziv.com", Name = "Guro", Phone = "054-9999999", Website = "www.anshubi.com" },
                        new { ID = 12, Address = "Aviv 99", Contact = "Zil", Email = "Ziv@Giv.com", Name = "Theuro", Phone = "054-9999199", Website = "www.tuna.com" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("OtoSpaMVC.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("OtoSpaMVC.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OtoSpaMVC.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("OtoSpaMVC.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OtoSpaMVC.Models.Cart", b =>
                {
                    b.HasOne("OtoSpaMVC.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("OtoSpaMVC.Models.Purchase", b =>
                {
                    b.HasOne("OtoSpaMVC.Models.ApplicationUser", "User")
                        .WithMany("Purchases")
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("OtoSpaMVC.Models.Rating", b =>
                {
                    b.HasOne("OtoSpaMVC.Models.Product", "Product")
                        .WithMany("ProductRatings")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OtoSpaMVC.Models.ApplicationUser", "User")
                        .WithMany("Ratings")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OtoSpaMVC.Models.SeconderyModels.CartItem", b =>
                {
                    b.HasOne("OtoSpaMVC.Models.Cart", "Cart")
                        .WithMany("Items")
                        .HasForeignKey("CartID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OtoSpaMVC.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OtoSpaMVC.Models.Purchase")
                        .WithMany("Items")
                        .HasForeignKey("PurchaseID");
                });

            modelBuilder.Entity("OtoSpaMVC.Models.SeconderyModels.ProductCategory", b =>
                {
                    b.HasOne("OtoSpaMVC.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OtoSpaMVC.Models.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OtoSpaMVC.Models.SeconderyModels.ProductSupplier", b =>
                {
                    b.HasOne("OtoSpaMVC.Models.Product", "Product")
                        .WithMany("ProductSuppliers")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OtoSpaMVC.Models.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
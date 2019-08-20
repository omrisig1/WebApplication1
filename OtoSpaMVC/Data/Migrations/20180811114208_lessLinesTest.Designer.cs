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
    [Migration("20180811114208_lessLinesTest")]
    partial class lessLinesTest
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
                        new { Id = "admin_ID_123456789", AccessFailedCount = 0, ConcurrencyStamp = "cfb9419e-fe58-4885-be82-a3464b4ad451", Email = "admin@oto.spa", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEGPtF9EPV1k7ed4W+60cdSUVJwTPT4ysBeDWvSLhBJizK2BKaBjHJOZHKwyDDHkGXA==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "admin" },
                        new { Id = "rt_7000", AccessFailedCount = 0, ConcurrencyStamp = "71675ea8-8b9a-44ec-964a-c784006285dc", Email = "rt_7000@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEGxOp1eDpTfGgfq12BhdJgBpy1soS9FTjcXeb2yKyKjSSQrVQ7Gwx4LBwHsiOfNAdw==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7000" },
                        new { Id = "rt_7001", AccessFailedCount = 0, ConcurrencyStamp = "52758073-6c2f-403d-ad47-ae77736aab3a", Email = "rt_7001@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAED08ZC8ViNjKAMJLxo4gKSeA1TvEQwD4eXHyqVw/ctzKrsC2H9MOqM8/mj36lsZcXQ==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7001" },
                        new { Id = "rt_7002", AccessFailedCount = 0, ConcurrencyStamp = "de61b85c-ac54-45f1-8fab-479c7db9d352", Email = "rt_7002@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEEXqYToBehOgR+DT1+nItEaO/RgOb/RVnEuugHYDiAH34jfrMvH4qM70Dqeo3tABAw==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7002" },
                        new { Id = "rt_7003", AccessFailedCount = 0, ConcurrencyStamp = "6bfb067d-42b8-4fbe-9399-928e95ef2256", Email = "rt_7003@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEIb+hNB8jNs08RjT8sTnCNSgn/L00/kdFNtOKcH9EprEN4TbdWWxBW4IM/hzGmFMiA==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7003" },
                        new { Id = "rt_7004", AccessFailedCount = 0, ConcurrencyStamp = "c032756b-fb7e-4c63-8942-33c5552a4bb6", Email = "rt_7004@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEG16vnq/CT6/37kNguODTVX0nfh9FI6sdCyDUFfTu3srHB3fTko/pBUtTnoLpEz6jw==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7004" },
                        new { Id = "rt_7005", AccessFailedCount = 0, ConcurrencyStamp = "624de734-c2da-439b-9491-1dffd1404c6b", Email = "rt_7005@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEN5cO1DKNGmc03GNNORrcN1ldOl/03h1ldjhNmMMFgbe1vjQKYBGp7pbhLP0SzoKbg==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7005" },
                        new { Id = "rt_7006", AccessFailedCount = 0, ConcurrencyStamp = "ea247f02-24c8-4ca6-b62d-49bcb8323e0b", Email = "rt_7006@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAELdF8+9D+ME2n7lkeRJPI3QYKBoKrv4HxfFUELu+0EKTJ09mbyliCl8rNtlXBi48BQ==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7006" },
                        new { Id = "rt_7007", AccessFailedCount = 0, ConcurrencyStamp = "02484455-acc2-4510-90fa-a4767db6aafc", Email = "rt_7007@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEKQX/3g2NY7q61iahZP0jjM7JrCUcJe7hTasYyJdI1KttHASeO4ginO9ooj6JEdMXA==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7007" },
                        new { Id = "rt_7008", AccessFailedCount = 0, ConcurrencyStamp = "b9e93177-5e7c-4859-a5b6-7610f4ee9c5a", Email = "rt_7008@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEM64PEQA8oEk92eYv0Wo1lHO98r8B0jcKlsFLTMvHAW4Qpf815JGogRSxV2ZDrjS+w==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7008" },
                        new { Id = "rt_7009", AccessFailedCount = 0, ConcurrencyStamp = "a3e34a7c-5db3-46ae-8451-cc28472c8c84", Email = "rt_7009@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAENhFN0o3QaRsoedhG34JTrb+lpV2KYznuIiXV4cZ9+PI7UDetvFQ5dHLwRWxkTb9BQ==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7009" },
                        new { Id = "rt_7010", AccessFailedCount = 0, ConcurrencyStamp = "f93bbd3c-86f2-43a2-a79c-94b1976c9aa7", Email = "rt_7010@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEDoqjyuDT0c0P+pnXBwM47uAusG9gP3caPeSou7rl4iQz+iLN8w+KdHTZwxIByWiRw==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7010" },
                        new { Id = "rt_7011", AccessFailedCount = 0, ConcurrencyStamp = "3debb2cc-10ae-4f9e-abfd-b0dd64a82eb0", Email = "rt_7011@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEMXhDPRnO9Ini9VwTsXdDwMfuG9nIKEHipMSuqDDwdzNK8Rd7bKDu33OIkpo4wLxXg==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7011" },
                        new { Id = "rt_7012", AccessFailedCount = 0, ConcurrencyStamp = "8c270857-caeb-4094-86fa-67e5f05239e5", Email = "rt_7012@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEDkoQX4zOegNKoAXdgJQcCyuVqOcPCtm805Fuv7QuYFmx8qCRAL8/uoNHQKFtagT6g==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7012" },
                        new { Id = "rt_7013", AccessFailedCount = 0, ConcurrencyStamp = "c55de216-f197-49d2-8bf3-da8ee24252bb", Email = "rt_7013@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEKXKmguAAQkVid6b8ZP+NBH3XjBIe1oBy71ouqiMP9xk9DilA73jYIvigSzehPc/6g==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7013" },
                        new { Id = "rt_7014", AccessFailedCount = 0, ConcurrencyStamp = "3d5eac26-3fc8-43a5-82e1-9f61eaf78c0a", Email = "rt_7014@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEHisSP1mzrSa9nSZvXJkXxNy313ZHFdy8vH7krv9V5eQ3OPnNjUCJFJFZoPb0TpTVg==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7014" },
                        new { Id = "rt_7015", AccessFailedCount = 0, ConcurrencyStamp = "2b4be601-f6c6-43c2-b8ba-29d93cb263f0", Email = "rt_7015@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEBGnIKB0IQTviHURfcT+D0AqeeivqBvsvSJXDK0ev1/hEXiJCJSFmmMBwl9x7rmCZQ==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7015" },
                        new { Id = "rt_7016", AccessFailedCount = 0, ConcurrencyStamp = "6bec32b7-7095-407b-94e8-34fd3589d7d0", Email = "rt_7016@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEEwpsfEWmwKvhO2UtjKb+KgvOjdv8yU6RgSU3axJulOYylj+0CzpSCv23tT0VeCOUw==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7016" },
                        new { Id = "rt_7017", AccessFailedCount = 0, ConcurrencyStamp = "13e8ae6c-ae64-4edd-99e7-aac2b191f1d0", Email = "rt_7017@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEEMbjg2ip3dJCJeEVb6zI97NoZH4FerCuDu95/9PDDTf0ZDK0JkZKCqsPznluycoWA==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7017" },
                        new { Id = "rt_7018", AccessFailedCount = 0, ConcurrencyStamp = "c02840df-e08d-4479-aea9-865fb467bf1d", Email = "rt_7018@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAED6MNecaG/N7EsE5fEY56yOw39yJyVZnGC2yjg28qUCLrLxZ7Mul1LCOc7AiU6rQIA==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7018" },
                        new { Id = "rt_7019", AccessFailedCount = 0, ConcurrencyStamp = "cde00dbd-6503-46a0-aa65-6d58fddd541d", Email = "rt_7019@RaringsTest.com", EmailConfirmed = false, LockoutEnabled = false, PasswordHash = "AQAAAAEAACcQAAAAEEPK2N4JWbQYCFJ4BbVrJpJu/1/Y1H/Lkq88bqEGM5MHFhvJwx4WjOLBYuV/Du7FuA==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "RaringsTest_rt_7019" }
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
                        new { ID = 1000, ProductName = "Prod_0", ProductPrice = 184713012.0 },
                        new { ID = 1001, ProductName = "Prod_1", ProductPrice = 546940496.0 },
                        new { ID = 1002, ProductName = "Prod_2", ProductPrice = 41509808.0 },
                        new { ID = 1003, ProductName = "Prod_3", ProductPrice = 1664277446.0 },
                        new { ID = 1004, ProductName = "Prod_4", ProductPrice = 647707496.0 },
                        new { ID = 1005, ProductName = "Prod_5", ProductPrice = 203096180.0 },
                        new { ID = 1006, ProductName = "Prod_6", ProductPrice = 54932320.0 },
                        new { ID = 1007, ProductName = "Prod_7", ProductPrice = 311026940.0 },
                        new { ID = 1008, ProductName = "Prod_8", ProductPrice = 313827366.0 },
                        new { ID = 1009, ProductName = "Prod_9", ProductPrice = 1143823372.0 },
                        new { ID = 1010, ProductName = "Prod_10", ProductPrice = 1108686981.0 },
                        new { ID = 1011, ProductName = "Prod_11", ProductPrice = 1437286469.0 },
                        new { ID = 1012, ProductName = "Prod_12", ProductPrice = 735551495.0 },
                        new { ID = 1013, ProductName = "Prod_13", ProductPrice = 413747845.0 },
                        new { ID = 1014, ProductName = "Prod_14", ProductPrice = 254065668.0 },
                        new { ID = 1015, ProductName = "Prod_15", ProductPrice = 1062504676.0 },
                        new { ID = 1016, ProductName = "Prod_16", ProductPrice = 255194849.0 },
                        new { ID = 1017, ProductName = "Prod_17", ProductPrice = 2072954317.0 },
                        new { ID = 1018, ProductName = "Prod_18", ProductPrice = 513057848.0 },
                        new { ID = 1019, ProductName = "Prod_19", ProductPrice = 1362671909.0 },
                        new { ID = 1020, ProductName = "Prod_20", ProductPrice = 2022273349.0 },
                        new { ID = 1021, ProductName = "Prod_21", ProductPrice = 2068466736.0 },
                        new { ID = 1022, ProductName = "Prod_22", ProductPrice = 168745497.0 },
                        new { ID = 1023, ProductName = "Prod_23", ProductPrice = 848859555.0 },
                        new { ID = 1024, ProductName = "Prod_24", ProductPrice = 1549750170.0 },
                        new { ID = 1025, ProductName = "Prod_25", ProductPrice = 2129185532.0 },
                        new { ID = 1026, ProductName = "Prod_26", ProductPrice = 1370245457.0 },
                        new { ID = 1027, ProductName = "Prod_27", ProductPrice = 833925365.0 },
                        new { ID = 1028, ProductName = "Prod_28", ProductPrice = 1248275853.0 },
                        new { ID = 1029, ProductName = "Prod_29", ProductPrice = 140147918.0 },
                        new { ID = 1030, ProductName = "Prod_30", ProductPrice = 792467625.0 },
                        new { ID = 1031, ProductName = "Prod_31", ProductPrice = 619877093.0 },
                        new { ID = 1032, ProductName = "Prod_32", ProductPrice = 1206330001.0 },
                        new { ID = 1033, ProductName = "Prod_33", ProductPrice = 33050980.0 },
                        new { ID = 1034, ProductName = "Prod_34", ProductPrice = 909146820.0 },
                        new { ID = 1035, ProductName = "Prod_35", ProductPrice = 1300782706.0 },
                        new { ID = 1036, ProductName = "Prod_36", ProductPrice = 1565694891.0 },
                        new { ID = 1037, ProductName = "Prod_37", ProductPrice = 1773146260.0 },
                        new { ID = 1038, ProductName = "Prod_38", ProductPrice = 824667553.0 },
                        new { ID = 1039, ProductName = "Prod_39", ProductPrice = 328909558.0 },
                        new { ID = 1040, ProductName = "Prod_40", ProductPrice = 535377346.0 },
                        new { ID = 1041, ProductName = "Prod_41", ProductPrice = 198427111.0 },
                        new { ID = 1042, ProductName = "Prod_42", ProductPrice = 724238766.0 },
                        new { ID = 1043, ProductName = "Prod_43", ProductPrice = 302570932.0 },
                        new { ID = 1044, ProductName = "Prod_44", ProductPrice = 1790450413.0 },
                        new { ID = 1045, ProductName = "Prod_45", ProductPrice = 933091318.0 },
                        new { ID = 1046, ProductName = "Prod_46", ProductPrice = 1612839560.0 },
                        new { ID = 1047, ProductName = "Prod_47", ProductPrice = 2027004358.0 },
                        new { ID = 1048, ProductName = "Prod_48", ProductPrice = 1523917843.0 },
                        new { ID = 1049, ProductName = "Prod_49", ProductPrice = 340870527.0 }
                    );
                });

            modelBuilder.Entity("OtoSpaMVC.Models.Purchase", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CartID");

                    b.Property<string>("CreditDetails");

                    b.Property<string>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("CartID");

                    b.HasIndex("UserID");

                    b.ToTable("Purchase");

                    b.HasData(
                        new { ID = 15, CartID = 13, CreditDetails = "YOOOLLLLOOOO", UserID = "admin_ID_123456789" }
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

                    b.HasKey("ID");

                    b.HasIndex("CartID");

                    b.HasIndex("ProductID");

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
                    b.HasOne("OtoSpaMVC.Models.Cart", "PurchaseCart")
                        .WithMany()
                        .HasForeignKey("CartID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OtoSpaMVC.Models.ApplicationUser", "User")
                        .WithMany()
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

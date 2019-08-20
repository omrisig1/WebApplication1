using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OtoSpaMVC.Models;

namespace OtoSpaMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Rating> Rating { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);


            builder.Entity<Rating>()
                .HasKey(r => new { r.ProductID, r.UserID });

            var pHasher = new PasswordHasher<ApplicationUser>();
            ApplicationUser adminUser = new ApplicationUser
            {
                Id = "admin_ID_123456789",
                Email = "admin@oto.spa",
                UserName = "admin",
                EmailConfirmed = true,
                SecurityStamp = "admin@oto.spa",
                NormalizedEmail = "admin@oto.spa",
                NormalizedUserName = "admin@oto.spa",
                LockoutEnabled = true,

            };
            adminUser.PasswordHash
                = pHasher.HashPassword(adminUser, "OtoSpa123.");

            const int RATINGS_AMNT = 20;

            var users4_testRatings = new ApplicationUser[RATINGS_AMNT];
            for (var i = 0; i < RATINGS_AMNT; i++)
            {
                string userID = "rt_" + (7000 + i);
                string email = userID + "@RaringsTest.com";
                string username = "RaringsTest_" + userID;
                users4_testRatings[i] = new ApplicationUser
                {
                    Id = "" + userID,
                    Email = email + "",
                    UserName = username + "",
                    EmailConfirmed = true,
                    SecurityStamp = email + "",
                    NormalizedEmail = email + "",
                    NormalizedUserName = email + "",
                    LockoutEnabled = true,
                };
                users4_testRatings[i].PasswordHash
                    = pHasher.HashPassword(users4_testRatings[i], "Aa123456!" + userID);
            }
            //users4_testRatings[100] = adminUser;

            builder.Entity<ApplicationUser>().HasData(adminUser);
            builder.Entity<ApplicationUser>().HasData(users4_testRatings);

            /*
                 //builder.Entity<Rating>()
                 // .HasOne(r => r.Product)
                 // .WithMany(p => p.ProductRatings)
                 // .HasForeignKey(r => r.ProductID);

                 //builder.Entity<Rating>()
                 // .HasOne(r => r.User)
                 // .WithMany(u => u.Ratings)
                 // .HasForeignKey(r => r.UserID);

                 //  builder.Entity<ProductSupplier>()
                 //   .HasOne(ps => ps.Product)
                 //   .WithMany(p => p.ProductSuppliers)
                 //   .HasForeignKey(ps => ps.ProductID);

                 //  builder.Entity<ProductSupplier>()
                 //   .HasOne(ps => ps.Supplier)
                 //   .WithMany(s => s.Products)
                 //   .HasForeignKey(ps => ps.SupplierID);

                 //  builder.Entity<ProductCategory>()
                 //   .HasOne(pc => pc.Product)
                 //   .WithMany(p => p.ProductCategories)
                 //   .HasForeignKey(pc => pc.ProductID);

                 //  builder.Entity<ProductCategory>()
                 //   .HasOne(pc => pc.Category)
                 //   .WithMany(c => c.Products)
                 //   .HasForeignKey(pc => pc.CategoryID);

                 //  builder.Entity<CartItem>()
                 //   .HasOne(ci => ci.Cart)
                 //   .WithMany(c => c.Items)
                 //   .HasForeignKey(ci => ci.Cart);

                 //  builder.Entity<CartItem>()
                 //   .HasOne(ci => ci.Product).WithMany()
                 //	  .HasForeignKey(ci => ci.ProductID);   
                 */

            /// All Test Data (needs migration.)

            var rnd = new Random();
            builder.Entity<ContactUs>().HasData(
                new ContactUs { ID = 123, ContactHeader = "Hi", Content = "How Is Business Going?" });

            //builder.Entity<Product>().HasData(
            //    new Product[] {
            //        new Product { ID = 111, ProductName = "Car Tree",       ProductPrice = 99 },
            //        new Product { ID = 222, ProductName = "Clean Service",  ProductPrice = 10 }
            //    });

            var testCategories = new Category[5];
            for (var i = 0; i < 5; i++)
                testCategories[i] = new Category { ID = 500 + i, Name = "PrimeCategory_" + i };
            builder.Entity<Category>().HasData(testCategories);

            var testProducts = new Product[50];
            for (var i = 0; i < 50; i++)
            {
                testProducts[i] = new Product
                {
                    ID = 1000 + i,
                    ProductName = "Prod_" + i.ToString(),
                    ProductPrice = rnd.Next(10, 500),
                    PrimaryCategoryID = testCategories[i % 5].ID
                };
            }
            builder.Entity<Product>().HasData(testProducts);

            var testRatings = new Rating[RATINGS_AMNT];
            for (var i = 0; i < RATINGS_AMNT; i++)
            {
                string userID = "rt_" + (7000 + i);
                testRatings[i] = new Rating { ID = 7000 + i, ProductID = 1007, ProductRating = (i % 5 + 1), UserID = userID };
            }
            builder.Entity<Rating>().HasData(testRatings);

            var testPurchases = new Purchase[RATINGS_AMNT];
            var testPurchaseItems = new LinkedList<PurchaseItem>();
            for (var i = 0; i < RATINGS_AMNT; i++)
            {
                testPurchases[i] = new Purchase
                {
                    ID = (9000 + i),
                    CreditDetails = "abc",
                    UserID = users4_testRatings[i].Id
                };
                for (var j = 0; j < 3; j++)
                    testPurchaseItems.AddLast(new PurchaseItem
                    {
                        ID = (testPurchases[i].ID * 10 + j),
                        PurchaseID = testPurchases[i].ID,
                        ProductID = (1000 + rnd.Next(0, 50)),
                        Amount = rnd.Next(1, 10)
                    });
            }
            builder.Entity<Purchase>().HasData(testPurchases);
            builder.Entity<PurchaseItem>().HasData(testPurchaseItems.ToArray<PurchaseItem>());

            builder.Entity<Category>().HasData(
                new Category[] {
                    new Category { ID = 7, Name = "Car Accessories" },
                    new Category { ID = 8, Name = "Cleaning Products" }
                });

            builder.Entity<Supplier>().HasData(
                new Supplier[] {
                    new Supplier { ID = 11, Address = "lilach 99", Contact = "gil", Email = "gil@ziv.com",Name ="Guro",Website ="www.anshubi.com",Phone = "054-9999999" },
                    new Supplier { ID = 12, Address = "Aviv 99", Contact = "Zil", Email = "Ziv@Giv.com", Name = "Theuro", Website = "www.tuna.com", Phone = "054-9999199" }
                });



            builder.Entity<Cart>().HasData(
                 new Cart[] {
                    new Cart { ID = 13, Editable = true,Total = 2,UserID = "admin_ID_123456789" }
                 });

            builder.Entity<CartItem>().HasData(
                 new CartItem[] {
                    new CartItem { ID= 14,Amount = 1,CartID =13,ProductID = 111 }
                 });

            //builder.Entity<Purchase>().HasData(
            //     new Purchase[] {
            //        new Purchase {ID = 15,CartID = 13,CreditDetails="YOOOLLLLOOOO", UserID ="admin_ID_123456789"}
            //     });
            builder.Entity<Purchase>().HasData(
                 new Purchase[] {
                    new Purchase {ID = 15,CreditDetails="YOOOLLLLOOOO", UserID ="admin_ID_123456789"}
                 });


            builder.Entity<Rating>().HasData(
                 new Rating[] {
                    new Rating {ID = 16, ProductID = 111,UserID ="admin_ID_123456789",ProductRating= 1 }
                 });
            //builder.Entity<ProductCategory>().HasData(
            //     new ProductCategory[] {
            //        new ProductCategory {ID=17,CategoryID=7,ProductID=222}
            //     });
            builder.Entity<ProductSupplier>().HasData(
                 new ProductSupplier[] {
                    new ProductSupplier {ID=18,ProductID=111,SupplierID=11 }
                 });

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = "user",
                    NormalizedName = "user",
                    ConcurrencyStamp = "user",
                    Id = "1"
                });
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = "admin",
                    NormalizedName = "admin",
                    ConcurrencyStamp = "admin",
                    Id = "2"
                });

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2",
                    UserId = "admin_ID_123456789"
                });
            for (var i = 0; i < RATINGS_AMNT; i++)
            {
                string userID = "rt_" + (7000 + i);
                builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "1",
                    UserId = userID+""
                });
            }


            builder.Entity<GoogleMap>().HasData(
                new GoogleMap
                {
                    ID=1,
                    langi= 31.888556,
                    longi= 34.780474,
                });
        }

        public DbSet<OtoSpaMVC.Models.CartItem> CartItem { get; set; }

        //public DbSet<OtoSpaMVC.Models.SeconderyModels.ProductCategory> ProductCategory { get; set; }

        public DbSet<OtoSpaMVC.Models.ProductSupplier> ProductSupplier { get; set; }
        public DbSet<OtoSpaMVC.Models.Cart> Cart { get; set; }

        public DbSet<OtoSpaMVC.Models.Category> Category { get; set; }

        public DbSet<OtoSpaMVC.Models.Purchase> Purchase { get; set; }

        public DbSet<OtoSpaMVC.Models.PurchaseItem> PurchaseItem { get; set; }

        public DbSet<OtoSpaMVC.Models.GoogleMap> GoogleMap { get; set; }

        public DbSet<OtoSpaMVC.Models.OtherHelperModels.hAprioriClassifier> AprioriClassifier { get; set; }


    }
}

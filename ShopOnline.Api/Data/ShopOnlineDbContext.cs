using Microsoft.EntityFrameworkCore;
using ShopOnline.Api.Entities;

namespace ShopOnline.Api.Data
{
    public class ShopOnlineDbContext:DbContext
    {
        public ShopOnlineDbContext(DbContextOptions<ShopOnlineDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			//Products
			//Beauty Category
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 1,
				Name = "Dui ga nuong",
				Description = "Mot mieng ga don vui ve",
				ImageURL = "/Images/Beauty/Beauty1.png",
				Price = 39000,
				Qty = 100,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 2,
				Name = "Com chien hai san",
				Description = "Com tam Viet Nam + Hai san tuoi song",
				ImageURL = "/Images/Beauty/Beauty2.png",
				Price = 50000,
				Qty = 45,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 3,
				Name = "Banh mi",
				Description = "San pham dung top dau the gioi",
				ImageURL = "/Images/Beauty/Beauty3.png",
				Price = 20000,
				Qty = 30,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 4,
				Name = "Piza",
				Description = "Banh kep Viet Nam day du duong chat",
				ImageURL = "/Images/Beauty/Beauty4.png",
				Price = 30000,
				Qty = 60,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 5,
				Name = "Ga vui ve",
				Description = "Mot phan ga voi mot phan khoai tay chien",
				ImageURL = "/Images/Beauty/Beauty5.png",
				Price = 40000,
				Qty = 85,
				CategoryId = 1

			});
			//Electronics Category
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 6,
				Name = "Ga sot cay",
				Description = "Ga sot cay voi ly nuoc bat ky",
				ImageURL = "/Images/Electronic/Electronics1.png",
				Price = 100000,
				Qty = 120,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 7,
				Name = "My y bo bam",
				Description = "My voi ly nuoc bat ky",
				ImageURL = "/Images/Electronic/Electronics2.png",
				Price = 40000,
				Qty = 200,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 8,
				Name = "Ga phomai",
				Description = "Ga phomai voi ly nuoc bat ky",
				ImageURL = "/Images/Electronic/Electronics3.png",
				Price = 40000,
				Qty = 300,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 9,
				Name = "Chicken shoup",
				Description = "Ga sot voi banh mi voi nuoc bat ky",
				ImageURL = "/Images/Electronic/Electronic4.png",
				Price = 600,
				Qty = 20,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 10,
				Name = "Combo",
				Description = "Ga voi khoai tay",
				ImageURL = "/Images/Electronic/Electronic5.png",
				Price = 50000,
				Qty = 15,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 11,
				Name = "Combo",
				Description = "Ga voi my y",
				ImageURL = "/Images/Electronic/technology6.png",
				Price = 100,
				Qty = 60000,
				CategoryId = 3
			});
			//Furniture Category
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 12,
				Name = "Combo",
				Description = "Ga voi Soup",
				ImageURL = "/Images/Furniture/Furniture1.png",
				Price = 70000,
				Qty = 212,
				CategoryId = 2
			});

			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 13,
				Name = "Combo",
				Description = "Ga voi banh mi",
				ImageURL = "/Images/Furniture/Furniture2.png",
				Price = 70000,
				Qty = 112,
				CategoryId = 2
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 14,
				Name = "Mon trang mieng",
				Description = "Kem",
				ImageURL = "/Images/Furniture/Furniture3.png",
				Price = 70,
				Qty = 90,
				CategoryId = 2
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 15,
				Name = "Nuoc uong",
				Description = "coca pesi suoi",
				ImageURL = "/Images/Furniture/Furniture4.png",
				Price = 120,
				Qty = 95,
				CategoryId = 2
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 16,
				Name = "Bo luc lac",
				Description = "Thit bo voi khoai tay",
				ImageURL = "/Images/Furniture/Furniture6.png",
				Price = 15,
				Qty = 100,
				CategoryId = 2
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 17,
                Name = "Dui ga nuong",
                Description = "Mot mieng ga don vui ve",
                ImageURL = "/Images/Beauty/Beauty1.png",
                Price = 20,
				Qty = 73,
				CategoryId = 2
			});
			//Shoes Category
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 18,
                Name = "Dui ga nuong",
                Description = "Mot mieng ga don vui ve",
                ImageURL = "/Images/Beauty/Beauty1.png",
                Price = 100,
				Qty = 50,
				CategoryId = 4
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 19,
                Name = "Dui ga nuong",
                Description = "Mot mieng ga don vui ve",
                ImageURL = "/Images/Beauty/Beauty1.png",
                Price = 150,
				Qty = 60,
				CategoryId = 4
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 20,
                Name = "Dui ga nuong",
                Description = "Mot mieng ga don vui ve",
                ImageURL = "/Images/Beauty/Beauty1.png",
                Price = 200,
				Qty = 70,
				CategoryId = 4
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 21,
                Name = "Combo",
                Description = "Ga voi banh mi",
                ImageURL = "/Images/Furniture/Furniture2.png",
                Price = 70000,
                Qty = 120,
				CategoryId = 4
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 22,
                Name = "Combo",
                Description = "Ga voi banh mi",
                ImageURL = "/Images/Furniture/Furniture2.png",
                Price = 70000,
                Qty = 100,
				CategoryId = 4
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 23,
                Name = "Combo",
                Description = "Ga voi banh mi",
                ImageURL = "/Images/Furniture/Furniture2.png",
                Price = 70000,
                Qty = 150,
				CategoryId = 4
			});

			//Add users
			modelBuilder.Entity<User>().HasData(new User
			{
				Id = 1,
				UserName = "Hieu"

			});
			modelBuilder.Entity<User>().HasData(new User
			{
				Id = 2,
				UserName = "Giang"

			});

			//Create Shopping Cart for Users
			modelBuilder.Entity<Cart>().HasData(new Cart
			{
				Id = 1,
				UserId = 1

			});
			modelBuilder.Entity<Cart>().HasData(new Cart
			{
				Id = 2,
				UserId = 2

			});
			//Add Product Categories
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 1,
				Name = "Beauty",
				IconCSS = "fas fa-spa"
			});
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 2,
				Name = "Furniture",
				IconCSS ="fas fa-couch"
			});
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 3,
				Name = "Electronics",
				IconCSS = "fas fa-headphones"
			});
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 4,
				Name = "Shoes",
				IconCSS = "fas fa-shoe-prints"
			});


		}

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<User> Users { get; set; }

    }
}

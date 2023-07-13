using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Machine_test.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        public DbSet<CategoryMaster> CategoryMaster { get; set; }
        public DbSet<ProductMaster> ProductMaster { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryMaster>().HasData(
                new CategoryMaster() { CategoryId = 1, CategoryName = "Sports" },
                new CategoryMaster() { CategoryId = 2, CategoryName = " shopping" },
                new CategoryMaster() { CategoryId = 3, CategoryName = "Business" },
                new CategoryMaster() { CategoryId = 4, CategoryName = "Electronic" },
                new CategoryMaster() { CategoryId = 5, CategoryName = " Footware" },
                new CategoryMaster() { CategoryId = 6, CategoryName = "Books" },
                new CategoryMaster() { CategoryId = 7, CategoryName = "Clothing" },
                new CategoryMaster() { CategoryId = 8, CategoryName = " Cometics" },
                new CategoryMaster() { CategoryId = 9, CategoryName = "Medicical" },
                new CategoryMaster() { CategoryId = 10, CategoryName = "MobileAccesories" },
                new CategoryMaster() { CategoryId = 11, CategoryName = " shopping" },
                new CategoryMaster() { CategoryId = 12, CategoryName = "Business" },
                new CategoryMaster() { CategoryId = 13, CategoryName = "Sports" },
                new CategoryMaster() { CategoryId = 14, CategoryName = " shopping" },
                new CategoryMaster() { CategoryId = 15, CategoryName = "Business" },
                new CategoryMaster() { CategoryId = 16, CategoryName = "Sports" },
                new CategoryMaster() { CategoryId = 17, CategoryName = " shopping" },
                new CategoryMaster() { CategoryId = 18, CategoryName = "Business" },
                new CategoryMaster() { CategoryId = 19, CategoryName = "Sports" },
                new CategoryMaster() { CategoryId = 20, CategoryName = " shopping" },
                new CategoryMaster() { CategoryId = 21, CategoryName = "Business" },
                new CategoryMaster() { CategoryId = 22, CategoryName = "Sports" },
                new CategoryMaster() { CategoryId = 23, CategoryName = " shopping" },
                new CategoryMaster() { CategoryId = 24, CategoryName = "Business" },
                new CategoryMaster() { CategoryId = 25, CategoryName = "Sports" },
                new CategoryMaster() { CategoryId = 26, CategoryName = " shopping" },
                new CategoryMaster() { CategoryId = 27, CategoryName = "Business" });
            
            modelBuilder.Entity<ProductMaster>().HasData(
                new ProductMaster() { ProductId = 1, ProductName = "Sports", CategoryId = 1 },
                new ProductMaster() { ProductId = 2, ProductName = "shopping", CategoryId = 2 },
                new ProductMaster() { ProductId = 3, ProductName = "Business", CategoryId = 3 },
                new ProductMaster() { ProductId = 4, ProductName = "Electronic", CategoryId = 4 },
                new ProductMaster() { ProductId = 5, ProductName = "Online", CategoryId = 5 },
                new ProductMaster() { ProductId = 6, ProductName = "Online", CategoryId = 6 },
                new ProductMaster() { ProductId = 7, ProductName = "Sports", CategoryId = 7 },
                new ProductMaster() { ProductId = 8, ProductName = "Cometics", CategoryId = 8 },
                new ProductMaster() { ProductId = 9, ProductName = "Medicical", CategoryId = 9 },
                new ProductMaster() { ProductId = 10, ProductName = "MobileAccesories", CategoryId = 10 },
                new ProductMaster() { ProductId = 11, ProductName = "Bike", CategoryId = 11 },
                new ProductMaster() { ProductId = 12, ProductName = "Sports", CategoryId = 12 },
                new ProductMaster() { ProductId = 13, ProductName = "Sports", CategoryId = 13 },
                new ProductMaster() { ProductId = 14, ProductName = "Sports", CategoryId = 14 },
                new ProductMaster() { ProductId = 15, ProductName = "Sports", CategoryId = 15 },
                new ProductMaster() { ProductId = 16, ProductName = "Sports", CategoryId = 16 },
                new ProductMaster() { ProductId = 17, ProductName = "Sports", CategoryId = 17 },
                new ProductMaster() { ProductId = 18, ProductName = "Sports", CategoryId = 18 },
                new ProductMaster() { ProductId = 19, ProductName = "Sports", CategoryId = 19 },
                new ProductMaster() { ProductId = 20, ProductName = "Sports", CategoryId = 20 },
                new ProductMaster() { ProductId = 21, ProductName = "Sports", CategoryId = 21 },
                new ProductMaster() { ProductId = 22, ProductName = "Sports", CategoryId = 22 },
                new ProductMaster() { ProductId = 23, ProductName = "Sports", CategoryId = 23 },
                new ProductMaster() { ProductId = 24, ProductName = "Sports", CategoryId = 24 },
                new ProductMaster() { ProductId = 25, ProductName = "Sports", CategoryId = 25 },
                new ProductMaster() { ProductId = 26, ProductName = "Sports", CategoryId = 26 },
                new ProductMaster() { ProductId = 27, ProductName = "Sports", CategoryId = 27 });
        }

       
    }
}
